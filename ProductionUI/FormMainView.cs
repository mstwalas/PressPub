using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ProductionUI.Add;
using ProductionUI.Add.Productivity;
using ProductionUI.Show;
using System;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormMainView : RibbonForm
    {
        public FormMainView()
        {
            InitializeComponent();
        }

        private void AddOrder_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplachScreenAddOrder();
        }

        private void SplachScreenAddOrder()
        {
            try
            {
                
                var order = new FormAddOrder();
                order.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void ViewProduct_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showProduct = new FormShowMaterial();
            showProduct.Show();
        }

        private void ViewOrder_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showOrders = new FormShowOrders();
            showOrders.Show();
        }

        

        private void AddMaterial_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var material = new FormAddOrEditMaterial { AddFlag = true };
            material.Show();
        }

        private void AddSize_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var size = new FormAddSize();
            size.Show();
        }


        private void ViewMaterial_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showMaterial = new FormShowMaterial();
            showMaterial.Show();
        }

        private void AddCat_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addCategory = new FormAddCategory();
            addCategory.Show();
        }

        private void Btn_AddUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addUser = new FormAddUser();
            addUser.Show();
        }

        private void BtnAddMaterialCat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormAddMaterialCategory();
            form.Show();
        }

        private void Btn_AddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addOrEditProduct = new FormAddOrEditProduct();
            addOrEditProduct.Show();
        }

        private void Btn_ShowProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showProducts = new FormShowProducts();
            showProducts.Show();
        }

        private void Btn_CombinedProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var combinedProduct = new FormCombinedProduct();
            combinedProduct.Show();
        }

        private void Btn_ShowCombinedProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showCombinedProduct = new FormShowCombinedProducts();
            showCombinedProduct.Show();
        }

        private void Btn_AllProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var allProduct = new FormShowAllProduct();
            allProduct.Show();
        }

        private void Btn_AddCombinedProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var combinedProduct = new FormCombinedProduct();
            combinedProduct.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
        }

        private void Form_MainView_Load(object sender, EventArgs e)
        {
        }

        private void Btn_AddMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addMaterial = new FormAddOrEditMaterial();
            addMaterial.Show();
        }

        private void Btn_ShowMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showMaterial = new FormShowMaterial();
            showMaterial.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var combinedProduct = new FormCombinedProduct();
            combinedProduct.Show();
        }

        private void Btn_ShowOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            var showOrder = new FormShowOrder();
            showOrder.Show();

        }

        
        private void Btn_Release_ItemClick(object sender, ItemClickEventArgs e)
        {
            var release = new FormRelease();
            release.Show();
        }

        private void Btn_Tracking_ItemClick(object sender, ItemClickEventArgs e)
        {
            var trackingOrder = new FormTrackingOrder();
            trackingOrder.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addOrEditProduct = new FormAddOrEditProduct();
            addOrEditProduct.Show();
        }

        private void OrdersForUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormUnitReportOrders unitReportOrders = new FormUnitReportOrders();
            unitReportOrders.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormReleasePermissions realeasePremissions = new FormReleasePermissions();
            realeasePremissions.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void Btn_Saver_ItemClick(object sender, ItemClickEventArgs e)
        {
            var FormSaverReport = new FormSaverReport();
            FormSaverReport.Show();
        }

        private void BtnOrdersReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormReportOrders reportOrders = new FormReportOrders();
            reportOrders.Show();
        }

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FormClientReportOrders clientReportOrders = new FormClientReportOrders();
            clientReportOrders.Show();
        }
    }
}