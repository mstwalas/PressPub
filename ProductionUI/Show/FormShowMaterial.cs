using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using ProductionUI.Classes;
using System;
using System.Data;

namespace ProductionUI
{
    public partial class FormShowMaterial : RibbonForm
    {
        private DataRow selectedRow;

        public FormShowMaterial()
        {
            InitializeComponent();
        }

        private void Form_ShowMaterial_Load(object sender, EventArgs e)
        {
            LoadMaterial();
            BestFitForColumnsGridView(GridView_ShowMaterial);
        }

        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        public void LoadMaterial()
        {
            var materialData = GlobalData.UnitOfWork.Materials.GetAllMaterialsWithCategories();
            var dt = new DataTable();
            dt.Columns.Add("الرقم التعريفي");
            dt.Columns.Add("اسم التصنيف");
            dt.Columns.Add("اسم الخامه");

            foreach (var material in materialData)
            {
                var dr = dt.NewRow();
                dr["الرقم التعريفي"] = material.MaterialId;
                dr["اسم التصنيف"] = material.MaterialCategory.CategoryName;
                dr["اسم الخامه"] = material.MaterialName;

                dt.Rows.Add(dr);
            }

            DataGrid_ProductsInfo.DataSource = dt;
            DataGrid_ProductsInfo.MainView.PopulateColumns();
        }

        private void DataGrid_ProductsInfo_DoubleClick(object sender, EventArgs e)
        {
            SelectedRowInfo();
        }

        public void SelectedRowInfo()
        {
            foreach (var rowSelected in GridView_ShowMaterial.GetSelectedRows())
                selectedRow = GridView_ShowMaterial.GetDataRow(rowSelected);

            var selectedId = Convert.ToInt32(selectedRow[0]);
            var selectedMaterial = GlobalData.UnitOfWork
                .Materials.GetMaterialWithCategoryAndTypesAndSizesAssigned(selectedId);
            var material = new FormAddOrEditMaterial(selectedMaterial) { AddFlag = false };

            material.Show();
            material.LoadMaterialForViewAndEdit(selectedMaterial);
        }

        private void Btn_EditProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedRowInfo();
        }

        private void Btn_AddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var material = new FormAddOrEditMaterial { AddFlag = true };
            material.Show();
        }
    }
}