using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using ProductionLogic.Core.Domain;
using ProductionUI.Add;
using ProductionUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductionUI.Show
{
    public partial class FormShowProducts : RibbonForm
    {
        private readonly FormCombinedProduct parent;
        DataTable productsDataTable = new DataTable();
        public FormShowProducts(FormCombinedProduct parent = null)
        {
            InitializeComponent();
            GridControlProductsColumnsConfigurations();

            LoadProductsToGridControl();

            this.parent = parent;

            if (parent != null)
                SelectionMenuConfiguration();
            else
                EditProductFormConfiguration();

            BestFitForColumnsGridView(GridView_Products);
            SearchConfiguration();
        }

        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        private void EditProductFormConfiguration()
        {
            Btn_Edit.Visibility = BarItemVisibility.Always;
            Btn_CombinedProduct.Visibility = BarItemVisibility.Never;
        }

        private void SelectionMenuConfiguration()
        {
            Btn_Edit.Visibility = BarItemVisibility.Never;
            Btn_CombinedProduct.Visibility = BarItemVisibility.Always;
        }

        private void GridControlProductsColumnsConfigurations()
        {
            productsDataTable.Columns.Add("الرقم التعريفي");
            productsDataTable.Columns.Add("اسم المنتج");
            productsDataTable.Columns.Add("القسم");
            productsDataTable.Columns.Add("العملية");
            productsDataTable.Columns.Add("تصنيف الخامات");
            productsDataTable.Columns.Add("الخامة");
            productsDataTable.Columns.Add("نوع الخامة");
            productsDataTable.Columns.Add("مقاس الخامة");
            productsDataTable.Columns.Add("مقاس الصرف");
            productsDataTable.Columns.Add("نسبة الهدر");

            productsDataTable.Columns.Add("سعر المنتج");
            GrdControl_Product.DataSource = productsDataTable;
            GrdControl_Product.MainView.PopulateColumns();
        }
        private void LoadProductsToGridControl()
        {
            var products = GlobalData.UnitOfWork.Products.GetAllProductsWithAllData().Where(e => e.IsEnabled && !e.IsDeleted);

            productsDataTable.Clear();
            foreach (var product in products)
            {
                var row = productsDataTable.NewRow();
                row["الرقم التعريفي"] = product.ProductId;
                row["اسم المنتج"] = product.ProductName;
                row["القسم"] = product.Department.DepartmentName ?? "";
                row["العملية"] = product.ProductionProcess.ProductionProcessName ?? "";
                //
                row["تصنيف الخامات"] = product.MaterialCategory != null
                    ? product
                        .MaterialCategory.CategoryName
                    : "";
                row["الخامة"] = product.Material != null ? product.Material.MaterialName : "";
                //
                row["نوع الخامة"] = product.MaterialType != null ? product.MaterialType.MaterialTypeName : "";
                row["مقاس الخامة"] = product.MaterialSize != null ? product.MaterialSize.MaterialSizeName : "";
                row["مقاس الصرف"] = product.ReleaseSize != null ? product.ReleaseSize.MaterialSizeName : "";
                row["نسبة الهدر"] = product.MaterialWastRatio;
                row["سعر المنتج"] = product.ProductSellPrice;
                productsDataTable.Rows.Add(row);
            }

            
        }

        private void Form_ShowProducts_Load(object sender, EventArgs e)
        {
            //LoadProductsToGridControl();
        }

        private void Brn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void Btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditProduct();
        }

        private void GrdControl_Product_DoubleClick(object sender, EventArgs e)
        {
            if (parent != null)
            {
                CombinedProduct();
            }
                
            else
            {
                EditProduct();
            }
                
        }

        private void CombinedProduct()
        {
            // GridView_Products.OptionsSelection.MultiSelect = true;
            var product = GetSelectedProduct();
            parent.GetProduct(product);
            Close();
        }

        private void EditProduct()
        {
            var product = GetSelectedProduct();
            if (product != null)
            {
                var frmProduct = new FormAddOrEditProduct(product);
                frmProduct.ShowDialog();
            }
        }

        private Product GetSelectedProduct()
        {
            DataRow selectedRow = null;
            foreach (var rowSelected in GridView_Products.GetSelectedRows())
                selectedRow = GridView_Products.GetDataRow(rowSelected);

            var selectedId = selectedRow != null ? Convert.ToInt32(selectedRow[0]) : 0;

            var product =
                GlobalData.UnitOfWork.Products
                    .GetAllProductsWithAllData().SingleOrDefault(e => e.ProductId == selectedId);
            return product;
        }

        private void Form_ShowProducts_Shown(object sender, EventArgs e)
        {
        }

        private void GrdControl_Product_Load(object sender, EventArgs e)
        {
        }

        private void Form_ShowProducts_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_CombinedProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formAddNewProduct = new FormAddOrEditProduct(this);
            formAddNewProduct.Show();
        }

        public void LoadNewProductToGridView()
        {
            LoadProductsToGridControl();
        }
        public void SearchConfiguration()
        {
            var searchList = new List<string> { "الكل","القسم","اسم المنتج" };
            ComboBox_SearchFilter.DataSource = searchList;
            ComboBox_SearchFilter.Text = "اختر";
        }
    }
}