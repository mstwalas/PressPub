using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using ProductionUI.Classes;
using System;
using System.Data;
using System.Linq;
using ProductionUI.Add;
using System.Collections.Generic;
using DevExpress.Data;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes.UI_Logic;
using ProductionUI.Show;
using System.Globalization;
using System.Windows.Forms;
using System.Collections;

namespace ProductionUI
{
    public partial class FormClientReportOrders : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DataTable ordersDataTable;
        public FormClientReportOrders()
        {
            InitializeComponent();
            LoadClientsToCmbx();

        }

        private void LoadClientsToCmbx()
        {
            var clients = GlobalData.UnitOfWork.Clients.GetAll().Where(e => e.IsDeleted == false && e.IsEnabled == true);
            Combobox_Client.DataSource = clients;
            Combobox_Client.DisplayMember = "ClientName";

        }

      

        private void FormClientReportOrders_Load(object sender, EventArgs e)
        {

        }

        private void DataGrid_OrdersInfo_DoubleClick(object sender, EventArgs e)
        {

            int orderId = GetSelectedRow();
            var showOrder = new FormAddOrder(orderId);
            showOrder.Show();
        }
        DateTime dateFrom = new DateTime();
        DateTime dateTo = DateTime.Now;

        Client selectedClient = null;

        private void LoadOrders(IEnumerable<Order> orders)
        {
            Decimal totalAmount = 0;
            Decimal paidAmounts = 0;
            Decimal remainPaymentAmounts = 0;
            ordersDataTable = new DataTable();
            ordersDataTable.Columns.Add("الرقم التعريفي");
            //ordersDataTable.Columns.Add("العميل");
            ordersDataTable.Columns.Add("العميل");
            ordersDataTable.Columns.Add("المبلغ الاجمالى");
            ordersDataTable.Columns.Add("المبلغ المدفوع");
            ordersDataTable.Columns.Add("المبلغ المتبقى");
            ordersDataTable.Columns.Add("التاريخ");
            foreach (var order in orders)
            {
                var orderDataRow = ordersDataTable.NewRow();
                orderDataRow["الرقم التعريفي"] = order.OrderId;
                //orderDataRow["العميل"] = order.ClientId != null
                //    ? GlobalData.UnitOfWork.Clients.Get(order.ClientId.Value).ClientName
                //    : "";

                orderDataRow["العميل"] = order.ClientId != null ? GlobalData.UnitOfWork.Clients.Get(order.ClientId.Value).ClientName : "";
                orderDataRow["المبلغ الاجمالى"] = order.OrderTotalPrice;
                orderDataRow["المبلغ المدفوع"] = order.OrderPaymentAmount;
                Decimal remainPaymentAmount = Decimal.Parse(order.OrderTotalPrice.ToString()) - Decimal.Parse(order.OrderPaymentAmount.ToString());
                orderDataRow["المبلغ المتبقى"] = remainPaymentAmount;
                orderDataRow["التاريخ"] = order.AdditionTime.ToString("yyyy/MM/dd");

                ordersDataTable.Rows.Add(orderDataRow);
                totalAmount += Decimal.Parse(order.OrderTotalPrice.ToString());
                paidAmounts += Decimal.Parse(order.OrderPaymentAmount.ToString());
                remainPaymentAmounts += Decimal.Parse(order.OrderTotalPrice.ToString()) - Decimal.Parse(order.OrderPaymentAmount.ToString());
            }
            DataGrid_OrdersInfo.DataSource = ordersDataTable;
            GridView_Order.PopulateColumns();
            Txt_Total.Text = totalAmount.ToString();
            Txt_PaymentAmount.Text = paidAmounts.ToString();
            Txt_RemainPaymentAmount.Text = remainPaymentAmounts.ToString();
        }
        private IEnumerable<Order> SortingOrders(DateTime from , DateTime to)
        {
            IEnumerable<Order> orders = null;
            if (Combobox_Client.SelectedIndex > -1)
            {
                
                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false && e.Client == selectedClient && e.AdditionTime.Date >= from.Date && e.AdditionTime.Date <= to.Date);
            }

            else
            {

                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false &&e.Client!=null&& e.AdditionTime.Date >= from.Date && e.AdditionTime.Date <= to.Date);
            }
            return orders;

        }
        private int GetSelectedRow()
        {
            int orderId = 0;
            foreach (var row in GridView_Order.GetSelectedRows())
            {
                var selectedRow = GridView_Order.GetDataRow(row);
                orderId = Convert.ToInt32(selectedRow[0]);
            }
            return orderId;
        }
        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }
        
        private void Btn_Search_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Combobox_Client.SelectedIndex > -1)
            {
                if (DateEdit_From.EditValue != null)
                {
                    dateFrom = DateEdit_From.DateTime;
                }

                if (DateEdit_To.EditValue != null)
                {
                    dateTo = DateEdit_To.DateTime;
                }
                selectedClient = Combobox_Client.SelectedItem as Client;
                if (selectedClient != null)
                {
                    var firstAdditionTime = GlobalData.UnitOfWork.Orders.
                        Find(r => r.Client == selectedClient && r.IsEnabled && r.IsDeleted == false).First();
                    dateFrom = firstAdditionTime.AdditionTime;
                }
                LoadOrders(SortingOrders(dateFrom, dateTo));
                BestFitForColumnsGridView(GridView_Order);
                
            }
            else
            {
                MessageBox.Show("برجاء إختيار عميل");
            }
            
            
        }

        private void Combobox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_Client.SelectedIndex > -1)
            {
                DateEdit_From.EditValue =null;
                DateEdit_To.Text = null;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            DateEdit_From.EditValue = null;
            DateEdit_To.Text = null;
        }

        private void Btn_PrintReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(dateFrom, dateTo, selectedClient);
        }

        

        private void BtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void Print(DateTime dateFrom, DateTime dateTo,Client client)
        {
            SqlDataSource.AllowCustomSqlQueries = true;
            SqlDataSource.DisableCustomQueryValidation = true;
            var report = new Reports.AllOrders.AllOrdersForClient();
            report.Parameters["DateFrom"].Value = dateFrom;
            report.Parameters["DateFrom"].Visible = false;
            report.Parameters["DateTo"].Value = dateTo;
            report.Parameters["DateTo"].Visible = false;
            report.Parameters["ClientId"].Value = client.ClientId;
            report.Parameters["ClientId"].Visible = false;
            var printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}