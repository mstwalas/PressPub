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
    public partial class FormSaverReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable paymentDataTable;
        public FormSaverReport()
        {
            InitializeComponent();
            DataTableConfiguration();
        }

        private void sfDataGrid3_Click(object sender, EventArgs e)
        {

        }
        DateTime dateFrom = new DateTime();
        DateTime dateTo = DateTime.Now;
        private void BtnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (DateEdit_From.EditValue != null)
            {
                dateFrom = DateEdit_From.DateTime;
            }
            if (DateEditTo.EditValue != null)
            {
                dateTo = DateEditTo.DateTime;
            }
            
            LoadPayments(dateFrom, dateTo);
        }
        private void DataTableConfiguration()
        {
            
            paymentDataTable = new DataTable();
            paymentDataTable.Columns.Add("رقم الفاتورة");
            paymentDataTable.Columns.Add("العميل");
            paymentDataTable.Columns.Add("الوحدة");
            paymentDataTable.Columns.Add("المبلغ المدفوع");
            paymentDataTable.Columns.Add("التاريخ");
            DataGridOrders.DataSource = paymentDataTable;
            GridView_Order.PopulateColumns();
            
        }
        private void LoadPayments(DateTime dateFrom, DateTime dateTo)
        {
            var filteredOrderPaymentData = GlobalData.UnitOfWork.OrdersPayments.GetAll().
                Where(e=>e.AdditionTime.Date >= dateFrom.Date && e.AdditionTime.Date <= dateTo.Date && e.IsDeleted == false && e.IsEnabled==true);
            PaymentsToDataTable(filteredOrderPaymentData);//to show data in grideTable
        }

        private void PaymentsToDataTable(IEnumerable<OrderPayment> payments)
        {
            Decimal? totalPayments = 0;
            paymentDataTable.Clear();
            foreach (var payment in payments)
            {
                var orderDataRow = paymentDataTable.NewRow();
                var order = GlobalData.UnitOfWork.Orders.Get(payment.OrderId);
                orderDataRow["رقم الفاتورة"] = order.OrderNo;
                var clinet = order.ClientId != null? GlobalData.UnitOfWork.Clients.Get(order.ClientId.Value).ClientName:"";
                var unit = order.UnitId !=null? GlobalData.UnitOfWork.Units.Get(order.UnitId.Value).UnitName:"";
                orderDataRow["العميل"] = order.ClientId != null ? clinet : "";
                orderDataRow["الوحدة"] = order.UnitId != null ? unit : "";
                orderDataRow["المبلغ المدفوع"] = payment.PaymentAmount;
                orderDataRow["التاريخ"] = payment.AdditionTime;
                paymentDataTable.Rows.Add(orderDataRow);
                totalPayments += payment.PaymentAmount ;
            }
            TxtEdit_Payments.Text = totalPayments.ToString();
            BestFitForColumnsGridView(GridView_Order);
          
        }
        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        private void BtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnPrintReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(dateFrom, dateTo);
        }
        private void Print(DateTime dateFrom,DateTime dateTo)
        {
            SqlDataSource.AllowCustomSqlQueries = true;
            SqlDataSource.DisableCustomQueryValidation = true;
            var report = new Reports.AllOrders.SaverWithDate();
            report.Parameters["DateFrom"].Value = dateFrom;
            report.Parameters["DateFrom"].Visible = false;
            report.Parameters["DateTo"].Value = dateTo;
            report.Parameters["DateTo"].Visible = false;
            var printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}