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
    public partial class FormReportOrders : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DataTable ordersDataTable;
        public FormReportOrders()
        {
            InitializeComponent();

        }

       

      

        private void FormReportOrders_Load(object sender, EventArgs e)
        {

        }

        private void DataGrid_OrdersInfo_DoubleClick(object sender, EventArgs e)
        {

            
        }



        DateTime dateFrom = new DateTime();
        DateTime dateTo = DateTime.Now;
        private void Btn_Search_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (DateEdit_From.EditValue != null)
            {
                dateFrom = DateEdit_From.DateTime;
            }

            if (DateEdit_To.EditValue != null)
            {
                dateTo = DateEdit_To.DateTime;
            }
            LoadOrders(dateFrom, dateTo);

        }

        private void LoadOrders(DateTime from, DateTime to)
        {
            var orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e=> e.IsDeleted == false && e.IsEnabled && e.AdditionTime.Date >= from.Date && e.AdditionTime.Date <= to.Date);
            DataGridConfiguration();
            OrdersToDataGrid(orders);
        }

        private void OrdersToDataGrid(IEnumerable<Order> orders)
        {
            Decimal totalAmount = 0;
            Decimal paidAmounts = 0;
            Decimal remainPaymentAmounts = 0;
            foreach (var order in orders)
            {
                var orderDataRow = ordersDataTable.NewRow();
                orderDataRow["الرقم التعريفى"] = order.OrderId;
                orderDataRow["العميل"] = order.ClientId != null ? GlobalData.UnitOfWork.Clients.Get(order.ClientId.Value).ClientName : "";
                orderDataRow["الوحدة"] = order.UnitId != null ? GlobalData.UnitOfWork.Units.Get(order.UnitId.Value).UnitName : "";
                orderDataRow["المبلغ الإجمالى"] = order.OrderTotalPrice;
                orderDataRow["المبلغ المدفوع"] = order.OrderPaymentAmount;
                Decimal remainPaymentAmount = Decimal.Parse(order.OrderTotalPrice.ToString()) - Decimal.Parse(order.OrderPaymentAmount.ToString());
                orderDataRow["المبلغ المتبقى"] = remainPaymentAmount;
                orderDataRow["التاريخ"] = order.AdditionTime.ToString("yyyy/MM/dd");
                ordersDataTable.Rows.Add(orderDataRow);
                totalAmount += Decimal.Parse(order.OrderTotalPrice.ToString());
                paidAmounts += Decimal.Parse(order.OrderPaymentAmount.ToString());
                remainPaymentAmounts += Decimal.Parse(order.OrderTotalPrice.ToString()) - Decimal.Parse(order.OrderPaymentAmount.ToString());
            }
            Txt_Total.Text = totalAmount.ToString();
            Txt_PaymentAmount.Text = paidAmounts.ToString();
            Txt_RemainPaymentAmount.Text = remainPaymentAmounts.ToString();
        }

        private void DataGridConfiguration()
        {
            ordersDataTable = new DataTable();
            ordersDataTable.Columns.Add("الرقم التعريفى");
            ordersDataTable.Columns.Add("العميل");
            ordersDataTable.Columns.Add("الوحدة");
            ordersDataTable.Columns.Add("المبلغ الإجمالى");
            ordersDataTable.Columns.Add("المبلغ المدفوع");
            ordersDataTable.Columns.Add("المبلغ المتبقى");
            ordersDataTable.Columns.Add("التاريخ");
            
            DataGrid_OrdersInfo.DataSource = ordersDataTable;
            GridView_Order.PopulateColumns();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            DateEdit_From.EditValue = null;
            DateEdit_To.Text = null;
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid_OrdersInfo_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Btn_PrintReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(dateFrom,dateTo);
        }
        private void Print(DateTime DateFrom,DateTime DateTo)
        {
            //SqlDataSource.AllowCustomSqlQueries = true;
            //SqlDataSource.DisableCustomQueryValidation = true;
            //var report = new Reports.AllOrders.AllOrdersWithDate();
            //report.Parameters["DateFrom"].Value = dateFrom;
            //report.Parameters["DateFrom"].Visible = false;
            //report.Parameters["DateTo"].Value = dateTo;
            //report.Parameters["DateTo"].Visible = false;
            //var printTool = new ReportPrintTool(report);
            //printTool.ShowPreview();
        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_RemainPaymentAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_PaymentAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Searchaaa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}