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
    public partial class FormUnitReportOrders : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DataTable ordersDataTable;
        public FormUnitReportOrders()
        {
            InitializeComponent();
            LoadUnitsToCmbx();

        }

        private void LoadUnitsToCmbx()
        {
            var units = GlobalData.UnitOfWork.Units.GetAll().Where(e => e.IsDeleted == false && e.IsEnabled == true);
            Combobox_Unit.DataSource = units;
            Combobox_Unit.DisplayMember = "UnitName";

        }

      

        private void FormUnitReportOrders_Load(object sender, EventArgs e)
        {

        }
        DateTime dateFrom = new DateTime();
        DateTime dateTo = DateTime.Now;

        Unit selectedUnit = null;
        private void DataGrid_OrdersInfo_DoubleClick(object sender, EventArgs e)
        {

            int orderId = GetSelectedRow();
            var showOrder = new FormAddOrder(orderId);
            showOrder.Show();
        }

        private void LoadOrders(IEnumerable<Order> orders)
        {
            Decimal totalAmount = 0;
            Decimal paidAmounts = 0;
            Decimal remainPaymentAmounts = 0;
            ordersDataTable = new DataTable();
            ordersDataTable.Columns.Add("الرقم التعريفي");
            //ordersDataTable.Columns.Add("العميل");
            ordersDataTable.Columns.Add("الوحدة");
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

                orderDataRow["الوحدة"] = order.UnitId != null ? GlobalData.UnitOfWork.Units.Get(order.UnitId.Value).UnitName : "";
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
            if (Combobox_Unit.SelectedIndex > -1)
            {
                var selectedUnit = Combobox_Unit.SelectedItem as Unit;
                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false && e.Unit == selectedUnit && e.AdditionTime.Date >= from.Date && e.AdditionTime.Date <= to.Date);
            }

            else
            {

                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false &&e.Unit!=null&& e.AdditionTime.Date >= from.Date && e.AdditionTime.Date <= to.Date);
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
            if (Combobox_Unit.SelectedIndex > -1)
            {
                if (DateEdit_From.EditValue != null)
                {
                    dateFrom = DateEdit_From.DateTime;
                }

                if (DateEdit_To.EditValue != null)
                {
                    dateTo = DateEdit_To.DateTime;
                }
                selectedUnit = Combobox_Unit.SelectedItem as Unit;
                if (selectedUnit != null)
                {
                    var firstAdditionTime = GlobalData.UnitOfWork.Orders.
                        Find(r => r.Unit == selectedUnit && r.IsEnabled && r.IsDeleted == false).First();
                    dateFrom = firstAdditionTime.AdditionTime;
                }
                LoadOrders(SortingOrders(dateFrom, dateTo));
                BestFitForColumnsGridView(GridView_Order);
            }
            else
            {
                MessageBox.Show("برجاء إختيار وحدة");
            }
        }

        private void Combobox_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_Unit.SelectedIndex > -1)
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
            Print(dateFrom, dateTo, selectedUnit);
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void Print(DateTime dateFrom, DateTime dateTo, Unit unit)
        {
            SqlDataSource.AllowCustomSqlQueries = true;
            SqlDataSource.DisableCustomQueryValidation = true;
            var report = new Reports.AllOrders.AllOrdersForUnit();
            report.Parameters["DateFrom"].Value = dateFrom;
            report.Parameters["DateFrom"].Visible = false;
            report.Parameters["DateTo"].Value = dateTo;
            report.Parameters["DateTo"].Visible = false;
            report.Parameters["UnitId"].Value = unit.UnitId;
            report.Parameters["UnitId"].Visible = false;
            var printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}