using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormShowOrder : RibbonForm
    {
        private DataTable dataTable;

        public FormShowOrder()
        {
            InitializeComponent();
            DataTableColumnsConfigurations();
            Txt_BillNUmber.Select();
        }

        private void DataTableColumnsConfigurations()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("رقم المنتج");
            dataTable.Columns.Add("رقم المنتج المجمع");
            dataTable.Columns.Add("اسم الصنف");
            dataTable.Columns.Add("الكمية", typeof(int));
            dataTable.Columns.Add("سعر الوحدة", typeof(decimal));
            dataTable.Columns.Add("السعر الاجمالي", typeof(decimal));
            GridControl_ShowOrder.DataSource = dataTable;
            GridControl_ShowOrder.MainView.PopulateColumns();
        }

        private void LabelControl1_Click(object sender, EventArgs e)
        {
        }

        private void LabelControl3_Click(object sender, EventArgs e)
        {
        }

        public void XtraMassageWithTimer(string massage,int time)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = time;
            args.Caption = "خطأ";
            args.Text = massage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //DataTableColumnsConfigurations();
            
            LoadOrder(int.Parse(Txt_BillNUmber.Text));
        }
        int numOfProducts = 0;
        Order order;
        Order orderWithAllDate;
        private void LoadOrder(int billNumber)
        {

            dataTable.Clear();
            if (chckedit_SpecialBill.Checked)
            {
                var orders = GlobalData.UnitOfWork.Orders.Find(e => e.IsDeleted == false && e.IsEnabled && e.OrderNo == billNumber && e.SpecialOrderNo != null);
                if (orders != null)
                {
                    int orderid = 0;
                    foreach (Order order in orders)
                    {
                        orderid = order.OrderId;
                    }
                    if (orderid != 0)
                    {
                        var order = GlobalData.UnitOfWork.Orders.GetOrderWithAllData(orderid);
                        this.order = null;
                        this.order = order;
                        LoadMainOrderInfo(order);
                        LoadCompinedProduct(order);
                        LoadProducts(order);
                        gridView1.BestFitColumns();
                    }
                    else
                    {
                        ResetControlllers();
                        // order = null;
                    }
                }
            }
            else
            {
                var orders = GlobalData.UnitOfWork.Orders.
                    Find(e => e.OrderNo == billNumber &&  e.SpecialOrderNo == null &&e.IsDeleted == false && e.IsEnabled==true );
                foreach(var order in orders)
                {
                    this.order = order;
                }
                orderWithAllDate = GlobalData.UnitOfWork.Orders.GetOrderWithAllData(order.OrderId);
            
            if (order != null)
            {
                LoadMainOrderInfo(order);
                LoadCompinedProduct(order);
                LoadProducts(order);
                gridView1.BestFitColumns();
            }
            else
            {
                ResetControlllers();
                order = null;
            }
            }
        }
        private void PrintSpecialUnit(int orderId)
        {
            SqlDataSource.AllowCustomSqlQueries = true;
            SqlDataSource.DisableCustomQueryValidation = true;
            var report = new Reports.Order();


            report.Parameters["POrderId"].Value = orderId;
            report.Parameters["POrderId"].Visible = false;
            report.Parameters["UserWithDegreePrinted"].Value =
                $"{GlobalData.LoginUser.Degree1.DegreeName} / {GlobalData.LoginUser.UserDescriptiveName}";
            //report.Parameters["UserWithDegreePrinted"].Value = GlobalData.LoginUser.UserDescriptiveName;
            report.Parameters["UserWithDegreePrinted"].Visible = false;

            var printTool = new ReportPrintTool(report);

            // Invoke the Ribbon Print Preview form  
            // and load the report document into it. 
            //printTool.ShowRibbonPreview();

            // Invoke the Ribbon Print Preview form modally 
            // with the specified look and feel settings. 
            //printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

            // Invoke the Print Preview form  
            // and load the report document into it. 
            printTool.ShowPreview();

            // Invoke the Print Preview form modally 
            // with the specified look and feel settings. 
            //printTool.ShowPreviewDialog(UserLookAndFeel.Default);
        }
        private void Print(int orderId)
        {
            SqlDataSource.AllowCustomSqlQueries = true;
            SqlDataSource.DisableCustomQueryValidation = true;
            var report = new Reports.Order();


            report.Parameters["POrderId"].Value = orderId;
            report.Parameters["POrderId"].Visible = false;
            report.Parameters["UserWithDegreePrinted"].Value =
                $"{GlobalData.LoginUser.Degree1.DegreeName} / {GlobalData.LoginUser.UserDescriptiveName}";
            //report.Parameters["UserWithDegreePrinted"].Value = GlobalData.LoginUser.UserDescriptiveName;
            report.Parameters["UserWithDegreePrinted"].Visible = false;

            var printTool = new ReportPrintTool(report);

            // Invoke the Ribbon Print Preview form  
            // and load the report document into it. 
            //printTool.ShowRibbonPreview();

            // Invoke the Ribbon Print Preview form modally 
            // with the specified look and feel settings. 
            //printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

            // Invoke the Print Preview form  
            // and load the report document into it. 
            printTool.ShowPreview();

            // Invoke the Print Preview form modally 
            // with the specified look and feel settings. 
            //printTool.ShowPreviewDialog(UserLookAndFeel.Default);
        }
        private void ResetControlllers()
        {
            XtraMessageBox.Show("يرجى ادخال رقم مقايسه صحيح");
            Txt_BillNUmber.BackColor = System.Drawing.Color.Red;
            Txt_Unit.Text = "";
            Txt_Client.Text = "";
            Txt_NumOfOrder.Text = "";
            Txt_BillType.Text = "";
            Txt_Date.Text = "";
            Txt_TotalPayment.Text = "";
            Txt_PaidOff.Text = "";
            Txt_RestOfPayment.Text = "";
            Txt_PaymentState.Text = "";
            Txt_PaymentState.BackColor =DefaultBackColor ;
            Txt_Delivary.Text = "";
            Txt_Delivary.BackColor = DefaultBackColor;

        }

        private void LoadProducts(Order order)
        {
            foreach (var orderProduct in order.OrderProduct) 
            { 
                AddOrderProductToGridView(orderProduct);
                numOfProducts++;
            }
        }

        private void AddOrderProductToGridView(OrderProduct orderProduct)
        {
            var orderProductDataRow = dataTable.NewRow();
            orderProductDataRow["رقم المنتج المجمع"] = "";
            orderProductDataRow["رقم المنتج"] = orderProduct.ProductId;

            //GlobalData.unitOfWork.Products.GetProductsWithAllData(orderProduct.ProductId).ProductName
            orderProductDataRow["اسم الصنف"] = GlobalData.UnitOfWork.Products
                .GetProductsWithAllData(orderProduct.ProductId).ProductName;
            orderProductDataRow["الكمية"] = orderProduct.Quantity;
            orderProductDataRow["سعر الوحدة"] = orderProduct.UnitActualSellPrice;
            orderProductDataRow["السعر الاجمالي"] = orderProduct.Quantity * orderProduct.UnitActualSellPrice;
            dataTable.Rows.Add(orderProductDataRow);
        }

        private void LoadCompinedProduct(Order order)
        {
            foreach (var orderProductCombined in order.OrderProductCombined) 
            { 
                if (orderProductCombined.ProductCombined.IsDetailed) 
                { 
                    AddOrderProductCombinedDetialiedToGridView(orderProductCombined);
                }
                else 
                { 
                    AddOrderProductCombinedNotDetialedToGridView(orderProductCombined);
                }
                numOfProducts++;
            }
        }

        private void AddOrderProductCombinedDetialiedToGridView(OrderProductCombined orderProductCombined)
        {
            foreach (var orderProduct in orderProductCombined.OrderProductCombinedDetails)
            {
                //if (orderProduct)
                //{
                var combinedDataRow = dataTable.NewRow();
                combinedDataRow["رقم المنتج المجمع"] = orderProduct.ProductCombinedId;
                combinedDataRow["رقم المنتج"] = orderProduct.ProductId;
                combinedDataRow["اسم الصنف"] = orderProduct.Product.ProductName;
                combinedDataRow["الكمية"] = "1";
                //combinedDataRow["سعر الوحدة"] = orderProduct.IsPaid != false ? orderProduct.Product.ProductSellPrice : 0;
                //combinedDataRow["السعر الاجمالي"] =
                //    orderProduct.IsPaid != false ? orderProduct.Product.ProductSellPrice * 1 : 0;
                dataTable.Rows.Add(combinedDataRow);
                //}
            }
        }

        private void AddOrderProductCombinedNotDetialedToGridView(OrderProductCombined orderProductCombined)
        {
            var combinedProductDataRow = dataTable.NewRow();
            combinedProductDataRow["رقم المنتج المجمع"] = orderProductCombined.ProductCombined.ProductCombinedId;
            combinedProductDataRow["رقم المنتج"] = "";

            combinedProductDataRow["اسم الصنف"] = orderProductCombined.ProductCombined.ProductCombinedName;
            combinedProductDataRow["الكمية"] = "1";
            combinedProductDataRow["سعر الوحدة"] = orderProductCombined.ProductCombined.TotalPrice;
            combinedProductDataRow["السعر الاجمالي"] =
                orderProductCombined.ProductCombined.TotalPrice * 1;
            dataTable.Rows.Add(combinedProductDataRow);
        }


        private void LoadMainOrderInfo(Order order)
        {
            Txt_Unit.Text = order.Unit != null ? order.Unit.UnitName : "";
            Txt_Client.Text = order.Client != null ? order.Client.ClientName : "";
            Txt_NumOfOrder.Text = order.OrderNo.ToString();
            Txt_BillType.Text = order.OrderCategory.OrderCategoryName;
            Txt_Date.Text = order.AdditionTime.ToShortDateString();
            Txt_TotalPayment.Text = order.OrderTotalPrice.ToString();
            Txt_PaidOff.Text = order.OrderPaymentAmount.ToString();
            Txt_RestOfPayment.Text = ((Decimal.Parse(Txt_TotalPayment.Text)) - (Decimal.Parse(Txt_PaidOff.Text))).ToString();
            if (order.IsReceived)
            {
                Txt_Delivary.Text = "تم الاستلام";
                Txt_Delivary.BackColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                Txt_Delivary.Text = "لم يتم الاستلام";
                Txt_Delivary.BackColor = System.Drawing.Color.Red;
            }
            LoadPaymentState(order);
            //Txt_Payment.Text=Order.OrderPayment
            Txt_Notes.Text = order.Notes;
        }

        private void LoadPaymentState(Order order)
        {
            if (Decimal.Parse(Txt_PaidOff.Text) == 0)
            {
                Txt_PaymentState.Text = "غير مسدد";
                Txt_PaymentState.BackColor = System.Drawing.Color.Red;
            }
            else if (Decimal.Parse(Txt_PaidOff.Text)==Decimal.Parse(Txt_TotalPayment.Text))
            {
                Txt_PaymentState.Text = "مسدد بالكامل";
                Txt_PaymentState.BackColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                Txt_PaymentState.Text = "مسدد جزئيا";
                Txt_PaymentState.BackColor = System.Drawing.Color.Yellow;
            }
        }

        

        private void Btn_UnitInfo_Click(object sender, EventArgs e)
        {

        }

        private void Txt_BillNUmber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ProductionUI.Classes.UI_Logic.UIValidation.ValidateNumericTxtEdit(Txt_BillNUmber))
                {
                    LoadOrder(int.Parse(Txt_BillNUmber.Text));
                }
            }
        }

        private void Btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (order != null)
            {
                
                if (order.SpecialOrderNo != null)
                {
                    PrintSpecialUnit(order.OrderId);
                }
                else
                {
                    Print(order.OrderId);
                }
            }
            else
            {
                XtraMassageWithTimer("برجاء ادخال رقم مقايسه صحيح", 2000);
               // XtraMessageBox.Show("برجاء ادخال رقم مقايسه صحيحة");
            }
            
        }

        private void Btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}