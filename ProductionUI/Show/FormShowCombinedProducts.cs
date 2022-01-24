using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using ProductionUI.Classes;
using System;
using System.Data;

namespace ProductionUI.Show
{
    public partial class FormShowCombinedProducts : RibbonForm
    {
        private DataTable combinedProductsDataTable;

        private DataRow selectedRow;

        public FormShowCombinedProducts()
        {
            InitializeComponent();
            CombinedProductDatatableConfiguration();
            GetAllCombinedProductToGrd();
            BestFitForColumnsGridView(GridView_Products);
        }

        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        private void CombinedProductDatatableConfiguration()
        {
            combinedProductsDataTable = new DataTable();
            combinedProductsDataTable.Columns.Add("الرقم التعريفي");
            combinedProductsDataTable.Columns.Add("اسم المنتج");
            combinedProductsDataTable.Columns.Add("سعر المنتج");
        }


        private void GetAllCombinedProductToGrd()
        {
            var combinedProducts = GlobalData.UnitOfWork.ProductsCombined
                .Find(e => e.IsEnabled && !e.IsDeleted);
            foreach (var combinedProduct in combinedProducts)
            {
                var combinedProductsDataRow = combinedProductsDataTable.NewRow();
                combinedProductsDataRow["الرقم التعريفي"] = combinedProduct.ProductCombinedId;
                combinedProductsDataRow["اسم المنتج"] = combinedProduct.ProductCombinedName;
                if (combinedProduct.IsDetailed)
                    combinedProductsDataRow["سعر المنتج"] = "سعر متغير" + "(منتج مجمع)";
                else
                    combinedProductsDataRow["سعر المنتج"] = combinedProduct.TotalPrice;
                combinedProductsDataTable.Rows.Add(combinedProductsDataRow);
            }

            GrdControl_Product.DataSource = combinedProductsDataTable;
            GridView_Products.PopulateColumns();
        }

        private void Form_ShowCombinedProducts_Load(object sender, EventArgs e)
        {
        }

        private void PassingCombinedProductToShowDetials()
        {
            foreach (var rowSelected in GridView_Products.GetSelectedRows())
            {
                selectedRow = GridView_Products.GetDataRow(rowSelected);
                if (selectedRow[1] != null) CombinedProduct();
            }
        }

        private void CombinedProduct()
        {
            var combinedProductId = Convert.ToInt32(selectedRow[0]);
            var combinedProduct = new FormCombinedProduct(combinedProductId);
            combinedProduct.ShowDialog();
        }

        private void GrdControl_Product_DoubleClick(object sender, EventArgs e)
        {
            PassingCombinedProductToShowDetials();
        }
    }
}