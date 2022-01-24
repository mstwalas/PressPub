using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using ProductionLogic.Core.Domain;
using ProductionUI.Add;
using ProductionUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductionUI.Show
{
    public partial class FormShowAllProduct : RibbonForm
    {
        private readonly FormAddOrder parent;

        private readonly DataTable dt = new DataTable();
        private List<Product> products;
        private List<ProductCombined> productsCombined;

        private DataRow selectedRow;

        public FormShowAllProduct(FormAddOrder parent = null)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.parent = parent;
                AddOrderConfiguration();
            }
        }


        public FormShowAllProduct()
        {
            InitializeComponent();
        }

        private void AddOrderConfiguration()
        {
        }

        private void Form_ShowAllProduct_Load(object sender, EventArgs e)
        {
            DataTableConfigration();
            GetProductsAndProductsCombined();
            AddProductsToGridView(products);
            AddCombinedProductToGridView(productsCombined);
            Databinding();
            BestFitForColumnsGridView(GridView_Products);
            SearchConfiguration();
        }

        private void GetProductsAndProductsCombined()
        {
            products = GlobalData.UnitOfWork.Products
                .Find(e => e.IsEnabled && e.IsDeleted == false).ToList();
            productsCombined = GlobalData.UnitOfWork.ProductsCombined
                .Find(e => e.IsEnabled && e.IsDeleted == false).ToList();
        }

        private void SearchConfiguration()
        {
            var searchList = new List<string> { "الكل", "المنتجات", "المنتجات المجمعة" };

            ComboBox_SearchFilter.DataSource = searchList;
            ComboBox_SearchFilter.Text = "اختر";
        }


        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        private void Databinding()
        {
            GrdControl_AllProduct.DataSource = dt;
            GrdControl_AllProduct.MainView.PopulateColumns();
        }

        private void AddCombinedProductToGridView(List<ProductCombined> addProductsCombined)
        {
            foreach (var productCombined in addProductsCombined)
            {
                // MessageBox.Show(productCombined.TotalPrice.ToString());
                var row = dt.NewRow();
                row["المنتج"] = "";
                row["المجمع"] = productCombined.ProductCombinedId.ToString();
                row["اسم المنتج"] = productCombined.ProductCombinedName;
                row["سعر المنتج"] = productCombined.TotalPrice.ToString() != ""
                    ? productCombined.TotalPrice.ToString()
                    : "سعر متغير" + "(منتج مجمع)";
                dt.Rows.Add(row);
            }
        }

        private void AddProductsToGridView(List<Product> addProducts)
        {
            foreach (var product in addProducts)
            {
                var row = dt.NewRow();
                row["المنتج"] = product.ProductId;
                row["المجمع"] = "";
                row["اسم المنتج"] = product.ProductName;
                row["سعر المنتج"] = product.ProductSellPrice;
                dt.Rows.Add(row);
            }

            //product.ProductSellPrice !=null?product.ProductSellPrice.ToString():""
        }

        private void DataTableConfigration()
        {
            dt.Columns.Add("المنتج");
            dt.Columns.Add("المجمع");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("سعر المنتج");
        }

        private void GetAndSendSelectedProductOrCombinedProductToAddOrderSCreen()
        {
            foreach (var selectedRow in GridView_Products.GetSelectedRows())
            {
                var productId = GridView_Products.GetDataRow(selectedRow)[0].ToString();

                var combinedProductId = GridView_Products.GetDataRow(selectedRow)[1].ToString();
                if (combinedProductId != "")
                {
                    var productCombined = GlobalData.UnitOfWork.ProductsCombined.GetProductCombinedWithAllData(
                        Convert.ToInt32(combinedProductId));
                    //product = null;
                    //(bool isCombined, int productOrCombinedProductId)
                    //_parent.AddProductOrCombinedProductToGridView(true, productCombined.ProductCombinedId);
                    parent.AddProductCombinedToGridView(productCombined);
                }

                else
                {
                    var product = GlobalData.UnitOfWork.Products.GetProductsWithAllData(Convert.ToInt32(productId));
                    //productCombined = null;

                    parent.AddProductToGridView(product);
                }
            }

            Close();
        }
   


        private void GrdControl_AllProduct_DoubleClick(object sender, EventArgs e)
        {
            if (parent != null)
                // Form_AddOrder addOrder=new Form_AddOrder();
                GetAndSendSelectedProductOrCombinedProductToAddOrderSCreen();
            //EditMode
            else
                PassingCombinedProductOrProductToEditScreen();
        }

        private void CombinedProduct()
        {
            var combinedId = Convert.ToInt32(selectedRow[1]);
            var combinedProduct = new FormCombinedProduct(combinedId);

            combinedProduct.ShowDialog();
        }

        private void Product()
        {
            var productId = Convert.ToInt32(selectedRow[0]);
            var product = GlobalData.UnitOfWork.Products.Get(productId);
            var frmProduct = new FormAddOrEditProduct(product);
            frmProduct.ShowDialog();
        }

        private void PassingCombinedProductOrProductToEditScreen()
        {
            foreach (var rowSelected in GridView_Products.GetSelectedRows())
            {
                selectedRow = GridView_Products.GetDataRow(rowSelected);
                if (string.IsNullOrEmpty(selectedRow[0].ToString()))
                    CombinedProduct();
                else
                    Product();
            }
        }

        private void Btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            PassingCombinedProductOrProductToEditScreen();
        }

        private void Txt_SearchData_EditValueChanging(object sender, ChangingEventArgs e)
        {
            //الكل
            if (ComboBox_SearchFilter.SelectedIndex == 0 || ComboBox_SearchFilter.SelectedIndex == -1)
            {
                Seraching();
            }
            //منتج
            else if (ComboBox_SearchFilter.SelectedIndex == 1)
            {
                dt.Clear();
                SearchingForProduct();
            }
            //مجمع
            else if (ComboBox_SearchFilter.SelectedIndex == 2)
            {
                dt.Clear();
                SearchingForCombinedProduct();
            }

            GridView_Products.BestFitColumns();
        }

        private void Seraching()
        {
            dt.Clear();

            SearchingForProduct();
            SearchingForCombinedProduct();

            Databinding();
        }
        //done
        private void SearchingForCombinedProduct()
        {
            var searchedCombinedProducts = new List<ProductCombined>();
            foreach (var productCombined in productsCombined)
            {
                var searchWords = Txt_SearchData.Text.Split(' ');
                var containsSearchWords = true;
                foreach (var searchWord in searchWords)
                   
                    if (!productCombined.ProductCombinedName.Contains(searchWord))
                    {
                        containsSearchWords = false;
                        break;
                    }

                if (containsSearchWords) searchedCombinedProducts.Add(productCombined);
            }

            AddCombinedProductToGridView(searchedCombinedProducts);
        }

        private void SearchingForProduct()
        {
            var searchedProduct = new List<Product>();
            foreach (var product in products)
            {
                var searchWords = Txt_SearchData.Text.Split(' ');
                var containsSearchWords = true;
                foreach (var searchWord in searchWords)
                    if (!product.ProductName.Contains(searchWord))
                    {
                        containsSearchWords = false;
                        break;
                    }

                if (containsSearchWords) searchedProduct.Add(product);
            }

            AddProductsToGridView(searchedProduct);
        }

        private void ComboBox_SearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //الكل
            if (ComboBox_SearchFilter.SelectedIndex == 0)
            {
                Seraching();
            }
            //منتج
            else if (ComboBox_SearchFilter.SelectedIndex == 1)
            {
                dt.Clear();
                SearchingForProduct();
            }
            //مجمع
            else if (ComboBox_SearchFilter.SelectedIndex == 2)
            {
                dt.Clear();
                SearchingForCombinedProduct();
            }
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}