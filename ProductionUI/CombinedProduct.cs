using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using ProductionUI.Classes.UI_Logic;
using ProductionUI.Show;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormCombinedProduct : RibbonForm
    {
        private readonly DataTable dataTable = new DataTable();

        private int combinedProductId;

        private Product product;
        private decimal totalPrice;

        public FormCombinedProduct()
        {
            InitializeComponent();

            DataTableColumnsConfigurations();
            GridControlConfigurations();
        }

        public FormCombinedProduct(int productCombinedId)
        {
            InitializeComponent();
            GridView_Product.OptionsBehavior.ReadOnly = true;
            ShowCombinedProducts(productCombinedId);
            Btn_AddProduct.Visible = false;
            Btn_DeleteProduct.Visible = false;
            Txt_CombinedProductName.Visible = true;
            ChckEdt_Details.ReadOnly = true;
        }

        private void ViewProductCombinedDetails()
        {
            DataTableColumnsConfigurations();

            var productCombined =
                GlobalData.UnitOfWork.ProductsCombined.GetProductCombinedWithAllData(combinedProductId);


            foreach (var productCombinedDetail in productCombined.ProductCombinedDetails)
            {
                var productProductName = productCombinedDetail.Product.ProductName;

                dataTable.Rows.Add(productCombinedDetail.ProcessNo, productCombinedDetail.Product.ProductId,
                    productCombinedDetail.Product.ProductName, productCombinedDetail.Product.ProductSellPrice,
                    productCombinedDetail.Isprocess, productCombinedDetail.IsPaid, productCombinedDetail.IsRelease,
                    productCombinedDetail.Product.MaterialSize != null
                        ? productCombinedDetail.Product.MaterialSize.MaterialSizeName
                        : "", productCombinedDetail.Product.ReleaseSize != null
                        ? productCombinedDetail.Product.ReleaseSize.MaterialSizeName
                        : "", productCombinedDetail.UnitReleaseQuantity);
            }

            GrdControl_CombinedProduct.DataSource = dataTable;
            GrdControl_CombinedProduct.MainView.PopulateColumns();
        }

        private void ShowCombinedProducts(int productCombinedId)
        {
            var combinedProduct = GlobalData.UnitOfWork.ProductsCombined
                .Get(productCombinedId);
            combinedProductId = productCombinedId;
            Txt_CombinedProductName.Text = combinedProduct.ProductCombinedName;
            //Txt_SellPrice.Text = productCombined[3].ToString();
            ViewProductCombinedDetails();
        }

        public void GetProduct(Product product)
        {
            this.product = product;
            if (IsCheckProductExist())
            {
                MessageBox.Show("المنتج موجود مسبقا");
            }
            else
            {
                AddProductToDataSource(product);
                totalPrice = totalPrice + product.ProductSellPrice;
                //Txt_SellPrice.Text = Convert.ToString(totalPrice);
            }
        }

        private bool IsCheckProductExist()
        {
            var contains = dataTable.AsEnumerable()
                .Any(row => product.ProductId == row.Field<int>("الرقم التعريفي"));
            return contains;
        }

        private void Form_CombinedProduct_Load(object sender, EventArgs e)
        {
            ProductDetailedCheckBoxConfiguration();
        }

        private void ProductDetailedCheckBoxConfiguration()
        {
            ChckEdt_Details.Checked = true;
            Txt_SellPrice.Enabled = false;
        }


        private void GridControlConfigurations()
        {
            GrdControl_CombinedProduct.DataSource = dataTable;
            GrdControl_CombinedProduct.MainView.PopulateColumns();

            var gridColumns = GridView_Product.Columns.ToList();
            foreach (var column in gridColumns)
            {
                column.OptionsColumn.ReadOnly = true;
                if (column.FieldName == "السعر" || column.FieldName == "اسم المنتج")
                    column.OptionsColumn.ReadOnly = true;
                else
                    column.OptionsColumn.ReadOnly = false;
            }
        }

        private void DataTableColumnsConfigurations()
        {
            dataTable.Columns.Add("ترتيب العملية", typeof(int));
            dataTable.Columns.Add("الرقم التعريفي", typeof(int));
            dataTable.Columns.Add("اسم المنتج", typeof(string));
            dataTable.Columns.Add("السعر", typeof(string));
            dataTable.Columns.Add("عملية", typeof(bool));
            dataTable.Columns.Add("مدفوعة", typeof(bool));
            dataTable.Columns.Add("تصرف", typeof(bool));
            dataTable.Columns.Add("المقاس", typeof(string));
            dataTable.Columns.Add("الصرف", typeof(string));
            dataTable.Columns.Add("كمية الصرف", typeof(string));
        }

        private void AddProductToDataSource(Product p)
        {
            dataTable.Rows.Add(dataTable.Rows.Count + 1, p.ProductId, p.ProductName, p.ProductSellPrice, false, false,
                false, p.MaterialSize != null ? p.MaterialSize.MaterialSizeName : "",
                p.ReleaseSize != null ? p.ReleaseSize.MaterialSizeName : "", "1");
        }

        private void Btn_AddProduct_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormShowProducts(this);
            frmProduct.ShowDialog();
        }

        private bool ValidateForm()
        {
            var output = true;


            output &= UIValidation.ValidateNumericTxtEdit(Txt_CombinedProductName);
            output &= UIValidation.ValidateNumericTxtEdit(Txt_SellPrice);

            return output;
        }

        private void Btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (!ValidateForm())
            {
                UIValidation.ShowErrorMessage();
            }
            else if (ChckEdt_Details.Checked && !IsOneRowPaid())
            {
                MessageBox.Show("برجاء تحديد منتج واحد على الأقل أنه مدفوع");
            }

            else
            {
                AddCombinedProduct();
                MessageBox.Show("تم الحفظ بنجاح");
            }
        }

        private bool IsOneRowPaid()
        {
            for (var i = 0; i < GridView_Product.RowCount; i++)
                if ((bool)GridView_Product.GetRowCellValue(i, GridView_Product.Columns["مدفوعة"]))
                    return true;

            return false;
        }

        private void IsDetialedValidation()
        {
            if (!ChckEdt_Details.Checked)
                for (var i = 0; i < GridView_Product.RowCount; i++)
                    GridView_Product.SetRowCellValue(i, GridView_Product.Columns["مدفوعة"], false);
        }

        private void AddCombinedProduct()
        {
            decimal.TryParse(Txt_SellPrice.Text, out var price);
            ProductCombined combinedProduct;
            if (price == 0)
                combinedProduct = new ProductCombined
                {
                    ProductCombinedName = Txt_CombinedProductName.Text,

                    User = GlobalData.LoginUser,
                    IsDetailed = ChckEdt_Details.Checked
                };
            else
                combinedProduct = new ProductCombined
                {
                    ProductCombinedName = Txt_CombinedProductName.Text,
                    TotalPrice = price,
                    User = GlobalData.LoginUser,
                    IsDetailed = ChckEdt_Details.Checked
                };

            GlobalData.UnitOfWork.ProductsCombined.Add(combinedProduct);
            //MessageBox.Show(GridView_Product.GetRowCellDisplayText(0, "عملية"));
            //MessageBox.Show(GridView_Product.GetRowCellDisplayText(0, "الرقم التعريفي"));
            //MessageBox.Show((GridView_Product.GetRowCellDisplayText(0, "عملية") == "Checked").ToString());
            //MessageBox.Show((Convert.ToDecimal(GridView_Product.GetRowCellDisplayText(0, "السعر"))).ToString());
            //MessageBox.Show((Convert.ToInt32(GridView_Product.GetRowCellDisplayText(0, "كمية الصرف")).ToString()));
            for (var i = 0; i < GridView_Product.RowCount; i++)
                GlobalData.UnitOfWork.ProductsCombinedDetails.Add(new ProductCombinedDetails
                {
                    ProductId = Convert.ToInt32(GridView_Product.GetRowCellDisplayText(i, "الرقم التعريفي")),
                    ProductCombined = combinedProduct,
                    ProcessNo = Convert.ToInt32(GridView_Product.GetRowCellDisplayText(i, "ترتيب العملية")),
                    Isprocess = GridView_Product.GetRowCellDisplayText(i, "عملية") == "Checked",
                    IsPaid = GridView_Product.GetRowCellDisplayText(i, "مدفوعة") == "Checked",
                    IsRelease = GridView_Product.GetRowCellDisplayText(i, "تصرف") == "Checked",
                    UnitSellPrice = Convert.ToDecimal(GridView_Product.GetRowCellDisplayText(i, "السعر")),
                    User = GlobalData.LoginUser,
                    UnitReleaseQuantity = Convert.ToInt32(GridView_Product.GetRowCellDisplayText(i, "كمية الصرف"))
                });

            GlobalData.UnitOfWork.Complete();
        }

        private void ChckEdt_Details_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckEdt_Details.Checked == false)
            {
                Txt_SellPrice.Enabled = true;
                IsDetialedValidation();
            }
            else
            {
                Txt_SellPrice.Enabled = false;
            }
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
    }
}