using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionUI.Add;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormProductDetails : RibbonForm
    {
        public FormProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Form_Load(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<FormAddOrderItem>().FirstOrDefault();
            ProductName_Txt.Text = principalForm.productName;
            ProductPrice_Txt.Text = principalForm.ProductPrice;
            ProductQuantity_Txt.Text = "1";
        }

        private void Save_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            //product_Quantity
            var principalForm = Application.OpenForms.OfType<FormAddOrderItem>().FirstOrDefault();
            principalForm.productName = ProductName_Txt.Text;
            principalForm.ProductPrice = ProductPrice_Txt.Text;
            principalForm.ProductQuantity = ProductQuantity_Txt.Text;

            principalForm.Addrow();
            Close();
        }

        private void Exit_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void EarseFields_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductName_Txt.Text = "";
            ProductPrice_Txt.Text = "";
            ProductQuantity_Txt.Text = "";
        }
    }
}