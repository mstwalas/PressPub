using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using ProductionUI.Classes;
using System.Data;

namespace ProductionUI
{
    public partial class FormTrackingOrder : RibbonForm
    {
        private DataTable dataTable;

        public FormTrackingOrder()
        {
            InitializeComponent();
            DataTableColumnsConfigurations();
        }

        private void DataTableColumnsConfigurations()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("رقم المنتج المجمع");
            dataTable.Columns.Add("رقم المنتج");

            dataTable.Columns.Add("اسم المنتج");
            dataTable.Columns.Add("حاله التشغيل");
            GrdControl_Tracking.DataSource = dataTable;
            GrdControl_Tracking.MainView.PopulateColumns();
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close(); 
        }
       
    }
}