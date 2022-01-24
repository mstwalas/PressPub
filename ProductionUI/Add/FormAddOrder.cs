using DevExpress.Data;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using ProductionUI.Classes.UI_Logic;
using ProductionUI.Show;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProductionUI.Add
{
    public partial class FormAddOrder : RibbonForm
    {
        private DataTable dataTable;


        public FormAddOrder()
        {
            InitializeComponent();
            DataTableColumnsConfigurations();
            RadioButton_Unit.Checked = true;
            ControllersConfiguration();
            IsReceivedComboBoxConfiguration();
            PayingOptionsComboBoxConfiguration();
            ResetAllControlers();
            Reload();
        }
        bool editMode = false;
        int openedOrderID;
        public FormAddOrder(int orderId)
        {
            InitializeComponent();
            editMode = true;
            DataTableColumnsConfigurations();
            openedOrderID = orderId;
            LoadOrder(orderId);
        }
        
        
        private void LoadOrder(int orderId)
        {
            var order = GlobalData.UnitOfWork.Orders.GetOrderWithAllData(orderId);
            Reload();
            PayingOptionsComboBoxConfiguration();
            IsReceivedComboBoxConfiguration();
            LoadMainOrderInfo(order);
            //products
            LoadProduct(order);
            LoadProductCompined(order);
            editMode = true;
        }
        private void LoadMainOrderInfo(Order order)
        {
            LoadOrderCategory(order);
            LoadOrderUnitesOrClients( order);
            Txt_OrderNum.Text = order.OrderNo.ToString();
            //ComboBox_OrderCategory.SelectedItem = order.OrderCategory.OrderCategoryName;
            
            Txt_Date.Text = order.AdditionTime.ToShortDateString();
            Txt_TotalPriceAmount.Text = order.OrderTotalPrice.ToString();
            Txt_PaidAmount.Text = order.OrderPaymentAmount.ToString();
            ComboBox_IsReceived.SelectedIndex = order.IsReceived ? 1 : 0;
            //Txt_Payment.Text=Order.OrderPayment
            Txtbx_OrderNotes.Text = order.Notes;
            LoadPaymentState(order);
        }

        private void LoadOrderCategory(Order order)
        {
            ComboBox_OrderCategory.SelectedItem = order.OrderCategory;
        }

        private void LoadPaymentState(Order order)
        {
            if (Decimal.Parse(Txt_PaidAmount.Text) == 0)
            {
                //غير مسدد
                ComboBox_PaymentState.SelectedIndex = 2;
                Txt_PaidAmount.Enabled = false;
            }
            else if ((Decimal.Parse(Txt_PaidAmount.Text)) == (Decimal.Parse(Txt_TotalPriceAmount.Text)))
            {
                //مسدد بالكامل
                ComboBox_PaymentState.SelectedIndex = 0;
                Txt_PaidAmount.Enabled = false;
            }
            else
            {
                //مسدد جزئيا
                ComboBox_PaymentState.SelectedIndex = 1;
                Txt_PaidAmount.Enabled = true;
            }
        }

        private void LoadOrderUnitesOrClients(Order order)
        {
            if (order.SpecialOrderNo != null)
            {
                HideClientPart();
                ComboBox_Unit.SelectedItem = order.Unit;
                RadioButton_Unit.Checked = true;
                RadioButton_Unit.Enabled = true;
            }
            else
            {
                if (order.UnitId == null)
                {
                    RadioButton_Client.Checked = true;
                    ComboBox_Client.Enabled = true;
                    ComboBox_Client.SelectedItem = order.Client;

                }
                else
                {
                    RadioButton_Unit.Checked = true;
                    ComboBox_Unit.SelectedItem = order.Unit;
                    ComboBox_Unit.Enabled = true;
                    ComboBox_Client.SelectedItem = order.Client;
                    ComboBox_Client.Enabled = true;
                }
            }
        }

        private void HideClientPart()
        {
            ComboBox_Client.Hide();
            Lbl_Delegate.Hide();
            Btn_AddClient.Hide();
            Btn_ShowClientInfo.Hide();
            RadioButton_Client.Enabled = false;
        }

        private void LoadProduct(Order order)
        {
            foreach (var orderProduct in order.OrderProduct)
            {
                if (orderProduct.IsDeleted == false)
                {
                    AddOrderProductToGridView(orderProduct);
                }  
            }
        }

        private void LoadProductCompined(Order order)
        {
            foreach (var orderProductCombined in order.OrderProductCombined)
            {
                if(orderProductCombined.IsDeleted == false){
                    if (orderProductCombined.ProductCombined.IsDetailed)
                    {
                        AddOrderProductCombinedDetialiedToGridView(orderProductCombined);
                    }

                    else
                    {
                        AddOrderProductCombinedWithoutDetailsToGridView(orderProductCombined);
                    }
                }
            }
        }
        private void AddOrderProductCombinedDetialiedToGridView(OrderProductCombined orderProductCombined)
        {
            foreach (var orderProduct in orderProductCombined.OrderProductCombinedDetails)
            {
                //if (orderProduct)
                //{
                var combinedproductalldata = GlobalData.UnitOfWork.ProductsCombined.GetProductCombinedWithAllData(orderProduct.ProductCombinedId);
                
                var combinedDataRow = dataTable.NewRow();
                combinedDataRow["رقم المنتج المجمع"] = orderProduct.ProductCombinedId;
                combinedDataRow["رقم المنتج"] = orderProduct.ProductId;
                combinedDataRow["اسم الصنف"] = orderProduct.Product.ProductName;
                combinedDataRow["الكمية"] = orderProduct.Quantity;
                foreach(var product in combinedproductalldata.ProductCombinedDetails)
                {
                    if(product.ProductId==Convert.ToInt32(combinedDataRow["رقم المنتج"].ToString()))
                    {
                        combinedDataRow["سعر الوحدة"] = product.UnitSellPrice;
                    }    
                }
                combinedDataRow["السعر الاجمالي"] =(Convert.ToDecimal(combinedDataRow["سعر الوحدة"].ToString()))*orderProduct.Quantity ;
                dataTable.Rows.Add(combinedDataRow);
                //}
            }
        }
        private void AddOrderProductCombinedWithoutDetailsToGridView(OrderProductCombined orderProductCombined)
        {
            var combinedProductDataRow = dataTable.NewRow();
            combinedProductDataRow["رقم المنتج المجمع"] = orderProductCombined.ProductCombined.ProductCombinedId;
            combinedProductDataRow["رقم المنتج"] = "";

            combinedProductDataRow["اسم الصنف"] = orderProductCombined.ProductCombined.ProductCombinedName;
            combinedProductDataRow["الكمية"] = orderProductCombined.Quantity;
            combinedProductDataRow["سعر الوحدة"] = orderProductCombined.ProductCombined.TotalPrice;
            combinedProductDataRow["السعر الاجمالي"] =
                orderProductCombined.ProductCombined.TotalPrice * (orderProductCombined.Quantity);
            dataTable.Rows.Add(combinedProductDataRow);
        }
        private void LoadOrderInfo(Order order)
        {
            ComboBox_OrderCategory.Text = order.OrderCategory.OrderCategoryName;

            ComboBox_OrderCategory.TextBox.ReadOnly = true;
            if (order.Unit != null)
            {
                ComboBox_Unit.Text = order.Unit.UnitName;
                ComboBox_Unit.TextBox.ReadOnly = true;
                ComboBox_Unit.Visible = true;
                Lbl_Unit.Visible = true;

                RadioButton_Unit.Checked = true;
                //Todo RadioButton ReadOnly
                RadioButton_Client.Checked = false;
            }
            else
            {
                ComboBox_Unit.Visible = false;
                Lbl_Unit.Visible = false;
                RadioButton_Unit.Checked = false;
                //Todo RadioButton ReadOnly
                RadioButton_Client.Checked = true;
            }

            ComboBox_Client.Text = order.Client.ClientName;
            ComboBox_Client.TextBox.ReadOnly = true;
            //TODO: ComboBox_Delivary 
            //ComboBox_Delivery.Text=order.
            //TODO:payment Retrive
            //Txt_TotalPayment.Text=order.OrderPayment
            Txt_OrderNum.Text = order.OrderNo.ToString();

            //
            foreach (var orderProduct in order.OrderProduct) AddOrderProductToGridView(orderProduct);

            foreach (var OrderProductCombined in order.OrderProductCombined)
                AddProductCombinedToGridView(OrderProductCombined.ProductCombined);

            //GrdControl_AddOrder.DataSource = dataTable;
            //GrdControl_AddOrder.MainView.PopulateColumns();


            UpdateCalculatedData();
            //GridView_AddOrder.PopulateColumns();
        }

        //TODO:GRID pROBLEM
        private void AddOrderProductToGridView(OrderProduct orderProduct)
        {
           
                var orderProductDataRow = dataTable.NewRow();
                orderProductDataRow["رقم المنتج المجمع"] = "";
                orderProductDataRow["رقم المنتج"] = orderProduct.ProductId;
                var product = GlobalData.UnitOfWork.Products.Get(orderProduct.ProductId);
                orderProductDataRow["اسم الصنف"] = product.ProductName.ToString();
                orderProductDataRow["الكمية"] = orderProduct.Quantity;
                orderProductDataRow["سعر الوحدة"] = orderProduct.UnitActualSellPrice;
                orderProductDataRow["السعر الاجمالي"] = orderProduct.Quantity * orderProduct.UnitActualSellPrice;

                dataTable.Rows.Add(orderProductDataRow);
                GridView_AddOrder.BestFitColumns();

            //GrdControl_AddOrder.DataSource = dataTable;
            //GrdControl_AddOrder.MainView.PopulateColumns();
        }


        private void PayingOptionsComboBoxConfiguration()
        {
            Txt_PaidAmount.ReadOnly = true;
            ComboBox_PaymentState.Text = "اختر السداد";
            var paymentStates = new List<string> {"مسدد بالكامل", "مسدد جزئيا", "غير مسدد"};
            ComboBox_PaymentState.DataSource = paymentStates;
        }

        private void IsReceivedComboBoxConfiguration()
        {
            ComboBox_IsReceived.Text = "اختر التسليم";
            var delivaryStates = new List<string> {"لم يتم الاستلام", "تم الاستلام"};
            ComboBox_IsReceived.DataSource = delivaryStates;
        }

        private void Form_AddOrder_Load(object sender, EventArgs e)
        {
            

        }

        private void Reload()
        {
            DateLoadToTxt();
            GrdControlConfiguration();
            AddOrderFormConfiguration();
            LoadOrdersCategories();
            LoadUnites();
            LoadDefaultValesForControls();
            UnitComboBoxSelectionValidation();
        }

        private void DateLoadToTxt()
        {
            Txt_Date.Text = DateTime.Now.Date.ToString(CultureInfo.InvariantCulture);
        }

        private void LoadOrdersCategories()
        {
            var ordersCategories =
                GlobalData.UnitOfWork.OrdersCategories.Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_OrderCategory.DataSource = ordersCategories;
            ComboBox_OrderCategory.DisplayMember = "OrderCategoryName";
        }

        private void UnitComboBoxSelectionValidation()
        {
            if (ComboBox_Unit.SelectedIndex == -1)
            {
                //Client Disable
                ComboBox_Client.Enabled = false;
                ComboBox_Client.Text = "";
                Btn_AddClient.Enabled = false;
                Btn_ShowClientInfo.Enabled = false;

                //Unit Disable
                Btn_ShowUnitInfo.Enabled = false;
            }
            else
            {
                //Client Enable
                ComboBox_Client.Enabled = true;
                Btn_AddClient.Enabled = true;

                //Btn_ShowClientInfo.Enabled = true; //this controller used by client validation
                //Unit Enable
                Btn_ShowUnitInfo.Enabled = true;
            }
        }

        private void ClientComboBoxSelectionValidation()
        {
            Btn_ShowClientInfo.Enabled = ComboBox_Client.SelectedIndex != -1;
        }

        private void AddOrderFormConfiguration()
        {
            Txt_TotalPriceAmount.ReadOnly = true;
        }

        private void LoadUnites()
        {
            var units = GlobalData.UnitOfWork.Units.GetAllUnitsWithClients()
                .Where(e => e.IsEnabled && e.IsDeleted == false && e.IsSpecial == false);
            ComboBox_Unit.DataSource = units;
            ComboBox_Unit.DisplayMember = "UnitName";
            ComboBox_Unit.Text = "اختر الوحدة";
        }

        private void LoadDefaultValesForControls()
        {
            //ComboBox_OrderCategory.Text = "فاتورة عادية";
            //ComboBox_Client.Text = "محمود علي";
            //ComboBox_Delivery.Text = "لم يتم التسليم";
            //ComboBox_Repayment.Text = "تم السداد";
            //ComboBox_Unit.Text = "الانقاذ";
            //RadioButton_Client.Checked = true;
        }


        private void ControlsConfigurationData()
        {
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {
        }

        private void Exit_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }


        private void DataTableColumnsConfigurations()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("رقم المنتج المجمع");
            dataTable.Columns.Add("رقم المنتج");

            dataTable.Columns.Add("اسم الصنف");
            dataTable.Columns.Add("الكمية", typeof(int));
            dataTable.Columns.Add("سعر الوحدة", typeof(decimal));
            dataTable.Columns.Add("السعر الاجمالي", typeof(decimal));
            GrdControl_AddOrder.DataSource = dataTable;
            GrdControl_AddOrder.MainView.PopulateColumns();
        }

        private void GrdControlConfiguration()
        {
            var gridColumns = GridView_AddOrder.Columns.ToList();

            foreach (var column in gridColumns)
                //column.OptionsColumn.ReadOnly = true;
                if (column.FieldName == "الكمية" || column.FieldName == "سعر الوحدة")
                    column.OptionsColumn.ReadOnly = false;
                else
                    column.OptionsColumn.ReadOnly = true;
        }

        public void AddProductCombinedToGridView(ProductCombined productCombined)
        {
            if (!IsCombinedProductAlreadyAdded(productCombined.ProductCombinedId))
            {
                if (productCombined.IsDetailed)
                    AddCombinedProductWithDetails(productCombined);
                else
                    AddCombinedProductWithoutDetails(productCombined);

                UpdateCalculatedData();
            }
        }

        private void AddCombinedProductWithoutDetails(ProductCombined productCombined)
        {
            var combinedProductDataRow = dataTable.NewRow();
            combinedProductDataRow["رقم المنتج المجمع"] = productCombined.ProductCombinedId;
            combinedProductDataRow["رقم المنتج"] = "";

            combinedProductDataRow["اسم الصنف"] = productCombined.ProductCombinedName;
            combinedProductDataRow["الكمية"] = "1";
            combinedProductDataRow["سعر الوحدة"] = productCombined.TotalPrice;
            combinedProductDataRow["السعر الاجمالي"] =
                productCombined.TotalPrice * 1;
            dataTable.Rows.Add(combinedProductDataRow);
            GridView_AddOrder.BestFitColumns();
        }

        private bool IsCombinedProductAlreadyAdded(int combinedProductId)
        {
            var isDuplicated = false;
            for (var i = 0; i < GridView_AddOrder.DataRowCount; i++)
                if (GridView_AddOrder.GetRowCellValue(i, "رقم المنتج المجمع").ToString() ==
                    combinedProductId.ToString())
                {
                    isDuplicated = true;
                    break;
                }

            if (isDuplicated)
            {
                MessageBox.Show("تم اضافة المنتج مسبقا");
                return true;
            }

            return false;
        }

        private void AddCombinedProductWithDetails(ProductCombined productCombined)
        {
            //Combinded Data

            foreach (var product in productCombined.ProductCombinedDetails)
                if (product.IsPaid)
                {
                    var combinedDataRow = dataTable.NewRow();
                    combinedDataRow["رقم المنتج المجمع"] = productCombined.ProductCombinedId;
                    combinedDataRow["رقم المنتج"] = product.ProductId;
                    combinedDataRow["اسم الصنف"] = product.Product.ProductName;
                    combinedDataRow["الكمية"] = "1";
                    combinedDataRow["سعر الوحدة"] = product.IsPaid ? product.Product.ProductSellPrice : 0;
                    combinedDataRow["السعر الاجمالي"] =
                        product.IsPaid ? product.Product.ProductSellPrice * 1 : 0;
                    dataTable.Rows.Add(combinedDataRow);
                    GridView_AddOrder.BestFitColumns();
                }
        }

        public void CalcAndViewTotalPrice()
        {
            Txt_TotalPriceAmount.Text = CalcTotalPrice().ToString(CultureInfo.InvariantCulture);
        }

        private decimal CalcTotalPrice()
        {
            decimal total = 0;
            for (var i = 0; i < GridView_AddOrder.DataRowCount; i++)
                if (GridView_AddOrder.GetRowCellValue(i, "السعر الاجمالي").ToString() != "")
                    total += Convert.ToDecimal(GridView_AddOrder.GetRowCellValue(i, "السعر الاجمالي"));

            return total;
        }


        private bool IsProductAlreadyAdded(int productId)
        {
            var isDuplicated = false;
            for (var i = 0; i < GridView_AddOrder.DataRowCount; i++)
                if (GridView_AddOrder.GetRowCellValue(i, "رقم المنتج المجمع").ToString() == "" &&
                    GridView_AddOrder.GetRowCellValue(i, "رقم المنتج").ToString() == productId.ToString())
                {
                    isDuplicated = true;
                    break;
                }

            if (isDuplicated)
            {
                MessageBox.Show("تم اضافة المنتج مسبقا");
                return true;
            }

            return false;
        }

        public void AddProductToGridView(Product product)
        {
            if (!IsProductAlreadyAdded(product.ProductId))
            {
                var productDataRow = dataTable.NewRow();
                productDataRow["رقم المنتج المجمع"] = "";
                productDataRow["رقم المنتج"] = product.ProductId;

                productDataRow["اسم الصنف"] = product.ProductName;
                productDataRow["الكمية"] = "1";
                productDataRow["سعر الوحدة"] = product.ProductSellPrice;
                productDataRow["السعر الاجمالي"] = product.ProductSellPrice * 1;
                dataTable.Rows.Add(productDataRow);

                GridView_AddOrder.BestFitColumns();
                UpdateCalculatedData();
            }
        }


        private void AddClient_Btn_Click(object sender, EventArgs e)
        {
            var addClient = new FormAddClient(this);
            addClient.ShowDialog();
        }

        private void AddOrderItem_Btn_Click(object sender, EventArgs e)
        {
            var allProduct = new FormShowAllProduct(this);
            allProduct.ShowDialog();
        }

        private void AddUnit_Btn_Click(object sender, EventArgs e)
        {
            var addUnit = new FormAddUnit(this);
            addUnit.ShowDialog();
        }

        private void ShowUnitInfo_Btn_Click(object sender, EventArgs e)
        {
            var unitInfo = new FormShowUnitInfo(ComboBox_Unit.SelectedItem as Unit, this);
            unitInfo.ShowDialog();
        }

        private void ShowClientInfo_Btn_Click(object sender, EventArgs e)
        {
            var ClientInfo = new FormShowClientInfo(ComboBox_Client.SelectedItem as Client, this);
            ClientInfo.ShowDialog();
        }


        private void Btn_DelOrderItem_Click(object sender, EventArgs e)
        {
            RemoveProductOrProductCombinedFromGridView();
            
        }


        private void RemoveProductOrProductCombinedFromGridView()
        {
            var rowsToDelete = new List<DataRow>();
            dataTable.AcceptChanges();
            foreach (var selectedRows in GridView_AddOrder.GetSelectedRows())
            {
                //int.TryParse((string) GridView_AddOrder.GetDataRow(selectedRows)[0], out var productCombinedId);
                //int.TryParse((string) GridView_AddOrder.GetDataRow(selectedRows)[1], out var productId);
                string productCombinedId = GridView_AddOrder.GetDataRow(selectedRows)[0].ToString();
                string productId = GridView_AddOrder.GetDataRow(selectedRows)[1].ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    //int.TryParse(row[0].ToString(), out var rowProductCombinedId);
                    //int.TryParse(row[1].ToString(), out var rowProductId);
                    string rowProductCombinedId = row[0].ToString();
                    string rowProductId = row[1].ToString();
                    
                    if ((rowProductCombinedId == productCombinedId &&rowProductCombinedId!="")
                        || productId == rowProductId && rowProductCombinedId.ToString() == "")
                    {
                        rowsToDelete.Add(row);
                    }
                        
                }
            }

            foreach (var row in rowsToDelete) dataTable.Rows.Remove(row);

            UpdateCalculatedData();
        }

        private void UpdateCalculatedData()
        {
            CalcAndViewTotalPrice();
            PaymentStatesValidate();
            CalcAndViewRemainPayment();
        }


        private void GrdControl_AddOrder_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void GridView_AddOrder_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
        }

        private void CalcAndViewRemainPayment()
        {
            if (!string.IsNullOrWhiteSpace(Txt_PaidAmount.Text))
            {
                decimal.TryParse(Txt_TotalPriceAmount.Text, out var totalAmount);
                decimal.TryParse(Txt_PaidAmount.Text, out var paymentAmount);
                if (totalAmount >= paymentAmount)
                {
                    var remainAmount = totalAmount - paymentAmount;
                    Txt_RemainPaymentAmount.Text = Convert.ToString(remainAmount, CultureInfo.InvariantCulture);
                }
                else
                {
                    Txt_PaidAmount.Text = "";
                    Txt_RemainPaymentAmount.Text = Txt_TotalPriceAmount.Text;
                    MessageBox.Show("برجاء ادخال مبلغ اقل من المبلغ الاجمالي");
                }
            }
        }

        private void Btn_SaveAndPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var orderId = Save();

            if (orderId != 0) Print(orderId);
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

        private void RadioButton_Unit_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Client.DataSource = "";
            ControllersConfiguration();
        }

        private void ControllersConfiguration()
        {
            if (RadioButton_Unit.Checked)
            {
                ComboBox_Unit.Enabled = true;
                ComboBox_Unit.Visible = true;
                Btn_AddUnit.Visible = true;
                Lbl_Unit.Visible = true;
                Btn_ShowUnitInfo.Visible = true;
            }
            else
            {
                ComboBox_Unit.Visible = false;
                Btn_AddUnit.Visible = false;
                Lbl_Unit.Visible = false;
                Btn_ShowUnitInfo.Visible = false;
            }
        }

        private void RadioButton_Client_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Client.Checked)
            {
                ComboBox_Unit.Enabled = false;
                LoadAllClients();
            }
        }

        private void LoadAllClients()
        {
            var Clients = GlobalData.UnitOfWork.Clients
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_Client.DataSource = Clients;
            ComboBox_Client.DisplayMember = "ClientNameWithDegree";
            //ComboBox_Client.DisplayMember = "ClientName";
            ComboBox_Client.Text = "اختر العميل";
            ComboBox_Client.Enabled = true;
            Btn_AddClient.Enabled = true;
        }

        private void ComboBox_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClientsByTheirUnit();
            UnitComboBoxSelectionValidation();
        }


        private void LoadClientsByTheirUnit()
        {
            if (ComboBox_Unit.SelectedItem is Unit unit)
            {
                ComboBox_Client.DataSource = null;
                ComboBox_Client.DataSource = unit.Client;
                //ComboBox_Client.DisplayMember = "ClientNameWithDegree";
                ComboBox_Client.DisplayMember = "ClientName";
                ComboBox_Client.Text = "اختر العميل";
            }
        }

        private void Btn_ClearAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  Reload();
            ResetAllControlers();
        }

        private void ResetAllControlers()
        {
            Txt_TotalPriceAmount.Text = "0";
            Txt_PaidAmount.Text = "0";
            Txt_RemainPaymentAmount.Text = "0";

            Txt_NumOfVarieties.Text = "";
            Txt_OrderNum.Text = "";
            Txt_Quantity.Text = "";
            Txtbx_OrderNotes.Text = "";


            ComboBox_Unit.Text = "اختر الوحدة";
            ComboBox_Client.Text = "اختر العميل";
            ComboBox_IsReceived.Text = "اختر التسليم";
            ComboBox_OrderCategory.Text = "اختر نوع الفاتورة";
            ComboBox_PaymentState.Text = "اختر الدفع";
        }

        private void ComboBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientComboBoxSelectionValidation();
        }

        private void GridView_AddOrder_CellValueChanged(object sender,
            CellValueChangedEventArgs e)
        {
            //MessageBox.Show((e.Column.FieldName == "الكمية").ToString());
            //MessageBox.Show("Changed : " + e.Value.ToString());
            if (e.Column.FieldName == "السعر الاجمالي") return;

            var quantity = Convert.ToDecimal(GridView_AddOrder.GetRowCellValue(e.RowHandle, "الكمية"));
            
            var productPrice = Convert.ToDecimal(GridView_AddOrder.GetRowCellValue(e.RowHandle, "سعر الوحدة"));
            var totalPrice = productPrice * quantity;

            GridView_AddOrder.SetRowCellValue(e.RowHandle, "السعر الاجمالي", totalPrice);
            UpdateCalculatedData();
        }

        private void GridView_AddOrder_CellValueChanging(object sender,
            CellValueChangedEventArgs e)
        {
        }

        private void Txt_PaidAmount_TextChanged(object sender, EventArgs e)
        {
            CalcAndViewRemainPayment();
        }

        private bool ValidateForm()
        {
            var output = true;


            output &= UIValidation.ValidateNumericTxtEdit(Txt_PaidAmount);
            output &= UIValidation.ValidateNumericTxtEdit(Txt_OrderNum);
            output &= UIValidation.ValidateNumericTxtEdit(Txt_NumOfVarieties);
            output &= UIValidation.ValidateNumericTxtEdit(Txt_Quantity);


            output &= UIValidation.ValidateSfComboBox(ComboBox_Unit);
            output &= UIValidation.ValidateSfComboBox(ComboBox_IsReceived);
            output &= UIValidation.ValidateSfComboBox(ComboBox_PaymentState);
            output &= UIValidation.ValidateSfComboBox(ComboBox_Client);
            output &= UIValidation.ValidateSfComboBox(ComboBox_OrderCategory);
            
            output &= UIValidation.ValidateDevExpressDataGrid(GridView_AddOrder);
            
            // TxtBx_ItemPrice.Text = "1";

            return output;
        }

        private int Save()
        {
            if (ValidateForm())
            {
                var view = GrdControl_AddOrder.FocusedView as ColumnView;
                string editingValue = null;
                if (view != null && view.IsEditing)
                {
                    editingValue = view.EditingValue.ToString();
                    //MessageBox.Show(view.FocusedValue.ToString());
                    //MessageBox.Show(editingValue);
                    MessageBox.Show("من فضلك قم بتأكيد أخر تعديل للكمية أو للسعر");
                    return 0;
                }
                
                var transaction = GlobalData.UnitOfWork.GetContext().Database.BeginTransaction();
                    try
                    {
                        Order order;
                        if (editMode == true)
                        {
                        // TODO  edit mode
                            int orderId=EditOrder();
                            
                            GlobalData.UnitOfWork.Complete();
                            transaction.Commit();
                            return orderId;
                        //-------END OF EDIT MODE
                        }
                        else
                        {
                            order = CreateOrder();
                            MessageBox.Show("Created Order");
                            AddProductToOrder(order);
                            AddProductCombinedWithAllDetailsToOrder(order);
                            AddMaterialRelease(order);
                            AddOrderPayment(order);
                            AddPaymentAmountToOrder(order);
                            GlobalData.UnitOfWork.Complete();
                            MessageBox.Show("تم اضافة الطلب رقم (" + order.OrderId + ")");
                            transaction.Commit();
                            return order.OrderId;
                        }
                    }
                    catch (Exception ex)
                    {
                    // TODO: Handle failure
                        MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.InnerException.Message+"");
                        transaction.Commit();
                        return 0;
                    }

                //}
                
            }

            return 0;
        }


        private void AddPaymentAmountToOrder(Order order)
        {
            decimal.TryParse(Txt_PaidAmount.Text, out var paymentAmount);
            order.OrderPaymentAmount = paymentAmount;
            GlobalData.UnitOfWork.Complete();
        }

        private void AddOrderPayment(Order order)
        {
            int lastPaymentNo = 0;
            Decimal paidMoneyBefore = order.OrderPaymentAmount;
            Decimal PaidMoneyToday = Convert.ToDecimal(Txt_PaidAmount.Text) - paidMoneyBefore;
            if (PaidMoneyToday != 0)
            {
                OrderPayment lastPaymentOrder;
                try
                {
                    lastPaymentOrder = GlobalData.UnitOfWork.OrdersPayments.GetAll().Where(e => e.Order == order && e.IsDeleted == false && e.IsEnabled).Last();
                    lastPaymentNo = lastPaymentOrder.PaymentNo + 1;
                }
                catch
                {
                    lastPaymentNo = 1;
                }
                MessageBox.Show(lastPaymentNo + "");

                if (ComboBox_PaymentState.SelectedIndex > -1 && ComboBox_PaymentState.SelectedIndex != 2)
                {
                    var orderPayment = new OrderPayment
                    {
                        Order = order,
                        User = GlobalData.LoginUser,
                        PaymentAmount = PaidMoneyToday,
                        PaymentNo = lastPaymentNo,
                        IsDeleted = false,
                        IsEnabled = true,

                    };
                    GlobalData.UnitOfWork.OrdersPayments.Add(orderPayment);
                    GlobalData.UnitOfWork.Complete();
                }
            }
            else
            {
               
            }
        }


        private int EditOrder()
        {
            Order order = GlobalData.UnitOfWork.Orders.Get(openedOrderID);
            var isSpecial = order.SpecialOrderNo;

            DeleteProductsFromOrder(order);
            MessageBox.Show("done deleting Product");
            DeleteCompinedProductFromOrder(order);
            MessageBox.Show("done deleting compined");
            DeleteMaterialReleaseForProduct(order);
            MessageBox.Show("done deleting Material");

            AddProductToOrder(order);
            MessageBox.Show("done New product");
            //AddnewCombinedProduct(order);
            AddProductCombinedWithAllDetailsToOrder(order);
            MessageBox.Show("done New Combined product");
            AddMaterialRelease(order);
            MessageBox.Show("done Material Release");

            if (isSpecial != null)
            {
                //Special Order
                if (ComboBox_OrderCategory.SelectedIndex == 0)
                {
                    //Converting Special Order to Normal Order
                    order.OrderCategory = ComboBox_OrderCategory.SelectedItem as OrderCategory;
                    var maxNormailOrderNumber = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsDeleted == false).Max(e => e.OrderNo);
                    order.OrderNo = maxNormailOrderNumber + 1;
                    if (RadioButton_Unit.Checked)
                    {
                        order.Unit = ComboBox_Unit.SelectedItem as Unit;
                        order.Client = ComboBox_Client.SelectedItem as Client;
                    }
                    else
                    {
                        order.Unit = null;
                        order.Client = ComboBox_Client.SelectedItem as Client;
                    }

                }
                else
                {
                    if (order.Unit != (ComboBox_Unit.SelectedItem as Unit))
                    {
                        var newUnit = ComboBox_Unit.SelectedItem as Unit;
                        var maxSpecialOrderNo = GlobalData.UnitOfWork.Orders.GetAll().
                        Where(e => e.IsDeleted == false && e.IsEnabled && e.UnitId == newUnit.UnitId && e.SpecialOrderNo != null).Max(e => e.SpecialOrderNo);
                        order.SpecialOrderNo = maxSpecialOrderNo + 1;
                    }

                    //Special Order
                    order.OrderCategory = ComboBox_OrderCategory.SelectedItem as OrderCategory;
                    order.Unit = ComboBox_Unit.SelectedItem as Unit;
                }

            }
            //Normal Order
            else
            {
                if (ComboBox_OrderCategory.SelectedIndex != 0)
                {
                    //Converting Normal Order To Special
                    order.Unit = ComboBox_Unit.SelectedItem != null ? ComboBox_Unit.SelectedItem as Unit : null;
                    order.Client = null;

                }
                else
                {
                    if (RadioButton_Unit.Checked)
                    {
                        order.Unit = ComboBox_Unit.SelectedItem != null ? ComboBox_Unit.SelectedItem as Unit : null;
                        order.Client = ComboBox_Client.SelectedItem != null ? ComboBox_Client.SelectedItem as Client : null;
                    }
                    else if (RadioButton_Client.Checked)
                    {
                        order.Unit = null;
                        order.Client = ComboBox_Client.SelectedItem != null ? ComboBox_Client.SelectedItem as Client : null;
                    }
                }
            }

            //order.IsReceived = ComboBox_IsReceived.SelectedIndex != 0 ? false : true;
            //order.OrderTotalPrice = CalcTotalPrice();
            //order.OrderPaymentAmount = Decimal.Parse(Txt_PaidAmount.Text);
            ////TODO Add Product && Add combined Product
            //EditProduct(order);
            //EditCompinedProduct(order);
            //AddNewProduct(order);
            ////AddnewCombinedProduct(order);
            //AddMaterialRelease(order);
            //MessageBox.Show(order.OrderId+ "تم تعديل الطلب رقم");

            AddOrderPayment(order);

            order.IsReceived = ComboBox_IsReceived.SelectedIndex != 0 ? false : true;
            order.OrderTotalPrice = CalcTotalPrice();
            order.OrderPaymentAmount = Decimal.Parse(Txt_PaidAmount.Text);
            //TODO Add Product && Add combined Product
            
            return order.OrderId;
        }

        private void DeleteMaterialReleaseForProduct(Order order)
        {
            var materialsReleases = GlobalData.UnitOfWork.MaterialsReleases.GetAll().
                Where(e => e.OrderId == order.OrderId);
            
            GlobalData.UnitOfWork.MaterialsReleases.RemoveRange(materialsReleases);
            GlobalData.UnitOfWork.Complete();
        }

        private void DeleteCompinedProductFromOrder(Order order)
        {
            try
            {
                GlobalData.UnitOfWork.OrdersProductsCombinedDetails.RemoveRange(order.OrderProductCombinedDetails);
                GlobalData.UnitOfWork.Complete();
                GlobalData.UnitOfWork.OrdersProductsCombined.RemoveRange(order.OrderProductCombined);
                GlobalData.UnitOfWork.Complete();
            }
            catch
            {
            }
        }
        private void DeleteProductsFromOrder(Order order)
        {


            try
            {
                //foreach (var product in order.OrderProduct)
                //{
                    //product.IsEnabled = false;
                    //product.IsDeleted = true;
                    GlobalData.UnitOfWork.OrdersProducts.RemoveRange(order.OrderProduct);
                    GlobalData.UnitOfWork.Complete();
                //}
            }
            catch
            {

            }




            try
            {
                //foreach (var product in order.OrderProduct)
                //{
                    //product.IsEnabled = false;
                    //product.IsDeleted = true;
                    GlobalData.UnitOfWork.OrdersProducts.RemoveRange(order.OrderProduct);
                    GlobalData.UnitOfWork.Complete();
                //}
            }
            catch
            {

            }



        }
        private void AddnewCombinedProduct(Order order)
        {
            int previousRowCombinedId = 0;
            foreach(DataRow dt in dataTable.Rows)
            {
                bool isExist = false;
                foreach(var productCombined in order.OrderProductCombinedDetails)
                {
                    if (productCombined.ProductId != Convert.ToInt32(dt[1].ToString()))
                    {
                        isExist = false;
                    }
                    else
                    {
                        isExist = true;
                    }

                    
                   

                }
                if (isExist == false)
                {
                    if (dt[0].ToString() != "")
                    {
                        int selectedRowCombinedProductId = Convert.ToInt32(dt[0].ToString());
                        int selectedRowProductId = Convert.ToInt32(dt[1].ToString());
                        Decimal productActualPrice = Convert.ToDecimal(dt[4].ToString());
                        int productQuantity = Convert.ToInt32(dt[3].ToString());
                        var productCombined = GlobalData.UnitOfWork.ProductsCombined.Get(selectedRowCombinedProductId);
                        var product = GlobalData.UnitOfWork.Products.Get(selectedRowProductId);
                        if (selectedRowCombinedProductId == previousRowCombinedId)
                        {


                            var orderProductCombinedDetails = new OrderProductCombinedDetails
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                Product = product,
                                UnitSellPriceActual = productActualPrice,
                                UnitSellPriceOriginal = product.ProductSellPrice,
                                Quantity = productQuantity,
                                User = GlobalData.LoginUser,
                            };
                            GlobalData.UnitOfWork.OrdersProductsCombinedDetails.Add(orderProductCombinedDetails);
                        }
                        else
                        {
                            previousRowCombinedId = selectedRowCombinedProductId;
                            var orderCombinedProduct = new OrderProductCombined
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                User = GlobalData.LoginUser,
                                //IsEnabled=true,
                                //IsDeleted=false
                            };
                            GlobalData.UnitOfWork.OrdersProductsCombined.Add(orderCombinedProduct);

                            var orderProductCombinedDetails = new OrderProductCombinedDetails
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                Product = product,
                                UnitSellPriceActual = productActualPrice,
                                UnitSellPriceOriginal = product.ProductSellPrice,
                                Quantity = productQuantity,
                                User = GlobalData.LoginUser,
                            };
                            GlobalData.UnitOfWork.OrdersProductsCombinedDetails.Add(orderProductCombinedDetails);

                        }

                    }
                    GlobalData.UnitOfWork.Complete();
                }
            }
        }


        public void XtraMassageWithTimer(string massage, int time)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = time;
            args.Caption = "خطأ";
            args.Text = massage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }
        private void AddNewProduct(Order order)
        {
            foreach(DataRow dr in dataTable.Rows)
            {
                bool isExits=false ;
                foreach(var product in order.OrderProduct)
                {
                    string productStringId = product.ProductId.ToString();
                    if(dr["رقم المنتج"].ToString() == productStringId)
                    {
                        isExits = true;
                        product.IsDeleted = false;
                        product.IsEnabled = true;
                        break;
                    }
                    else
                    {
                        isExits = false;
                    }
                    GlobalData.UnitOfWork.Complete();
                }
                if (isExits == false)
                {
                   
                    //TODO New product
                    int productId = Convert.ToInt32((dr["رقم المنتج"]).ToString());
                    int productQuantity = Convert.ToInt32((dr["الكمية"]).ToString());
                    Decimal productActualPrice = Convert.ToDecimal(dr["سعر الوحدة"].ToString());
                    
                    if (string.IsNullOrEmpty(dr[0].ToString()))
                    {
                        var product = GlobalData.UnitOfWork.Products.Get(productId);
                        var orderProduct = new OrderProduct
                        {
                            Order = order,
                            Product = product,
                            UnitActualSellPrice = productActualPrice,
                            UnitOriginalSellPrice = product.ProductSellPrice,
                            Quantity = productQuantity,
                            User = GlobalData.LoginUser
                        };
                        GlobalData.UnitOfWork.OrdersProducts.Add(orderProduct);
                        GlobalData.UnitOfWork.Complete();
                    }

                }
            }
        }


        private void EditCompinedProduct(Order order)
        {
            DeleteCombinedProductAndDetails(order);
            AddProductCombinedWithAllDetailsToOrder(order);

        }

        private void DeleteCombinedProductAndDetails(Order order)
        {
            //foreach(Subscriber s in subscribers.Values.ToList())
            foreach (var orderCombinedProductDetails in order.OrderProductCombinedDetails.ToList())
            {
                GlobalData.UnitOfWork.OrdersProductsCombinedDetails.Remove(orderCombinedProductDetails);
                GlobalData.UnitOfWork.Complete();
            }
            foreach (var orderCombinedProduct in order.OrderProductCombined.ToList())
            {
                GlobalData.UnitOfWork.OrdersProductsCombined.Remove(orderCombinedProduct);
                GlobalData.UnitOfWork.Complete();
            }
        }

        private void EditProduct(Order order)
        {

            foreach(var product in order.OrderProduct)
            {
                string productStringId = product.ProductId.ToString();
                bool exist =false;
                foreach (DataRow dr in dataTable.Rows)
                {
                    if(productStringId == dr["رقم المنتج"].ToString())
                    {
                        exist = true;
                        product.Quantity = (Int32)dr["الكمية"];
                    }
                }
                if (exist == false)
                {
                    product.IsDeleted = true;
                }

                GlobalData.UnitOfWork.Complete();
            }   
        }
       

        private void AddMaterialRelease(Order order)
        {
            MaterialReleaseProduct(order);

            MaterialReleaseProductCombined(order);
        }

        private void MaterialReleaseProductCombined(Order order)
        {
            foreach (var orderProductCombined in order.OrderProductCombined)
                if (orderProductCombined.ProductCombined.IsDetailed)
                {
                    MaterialReleaseProductCombinedWithDetails(order, orderProductCombined);
                }

                else 
                {
                    MaterialReleaseProductCombinedWithoutDetails(order, orderProductCombined);
                }
                    
        }

        private void MaterialReleaseProductCombinedWithoutDetails(Order order,
            OrderProductCombined orderProductCombined)
        {
            foreach (var productCombinedDetail in orderProductCombined.ProductCombined.ProductCombinedDetails)
                if (productCombinedDetail.IsRelease
                    && productCombinedDetail.Product.MaterialId != null
                )
                {
                    var noSSizeInBSize =
                        GlobalData.UnitOfWork.MaterialSizeConversion
                            .SingleOrDefault(e =>
                                e.SmallSizeId == productCombinedDetail.Product.MaterialSizeId
                                && e.BigSizeId == productCombinedDetail.Product.ReleaseSizeId)
                            .NoSSizeInBSize;

                    decimal originalQuantity = (decimal) ((decimal)(orderProductCombined.Quantity ?? 0 )*
                        (decimal)productCombinedDetail.UnitReleaseQuantity / (decimal)noSSizeInBSize);
                    decimal wastQuantity = originalQuantity * (productCombinedDetail.Product.MaterialWastRatio ?? 0) / 100;
                    int releaseQuantity = (int) Math.Ceiling(originalQuantity + wastQuantity);
                    var materialRelease = new MaterialRelease
                    {
                        Order = order,
                        Product = productCombinedDetail.Product,
                        ProductCombined = orderProductCombined.ProductCombined,
                        OriginalQuantity = originalQuantity,
                        WastQuantity = wastQuantity,
                        ReleaseQuantity = releaseQuantity,
                        MaterialCategoryId = productCombinedDetail.Product.MaterialCategoryId ?? 0,
                        MaterialId = productCombinedDetail.Product.MaterialId ?? 0,
                        MaterialReleaseSizeId = productCombinedDetail.Product.ReleaseSizeId,
                        MaterialTypeId = productCombinedDetail.Product.MaterialTypeId,
                        DepartmentId = productCombinedDetail.Product.DepartmentId,
                        ReasonId = 1,
                        CreatedUser = GlobalData.LoginUser
                    };
                    GlobalData.UnitOfWork.MaterialsReleases.Add(materialRelease);
                }
        }

        private void MaterialReleaseProductCombinedWithDetails(Order order, OrderProductCombined orderProductCombined)
        {
            foreach (var orderProductCombinedDetails in orderProductCombined.OrderProductCombinedDetails)
            foreach (var productCombinedDetail in orderProductCombined.ProductCombined.ProductCombinedDetails)
                if (productCombinedDetail.IsRelease &&
                    productCombinedDetail.Product.MaterialId != null
                    &&
                    productCombinedDetail.ProductId == orderProductCombinedDetails.ProductId)
                {
                    var noSSizeInBSize =
                        GlobalData.UnitOfWork.MaterialSizeConversion
                            .SingleOrDefault(e =>
                                e.SmallSizeId == productCombinedDetail.Product.MaterialSizeId
                                && e.BigSizeId == productCombinedDetail.Product.ReleaseSizeId)
                            .NoSSizeInBSize;

                    var originalQuantity = (decimal) ((decimal) orderProductCombinedDetails.Quantity *
                                                      (decimal) productCombinedDetail.UnitReleaseQuantity /
                                                      (decimal) noSSizeInBSize);
                    var wastQuantity = originalQuantity * (productCombinedDetail.Product.MaterialWastRatio ?? 0) / 100;
                    var releaseQuantity = (int) Math.Ceiling(originalQuantity + wastQuantity);
                    var materialRelease = new MaterialRelease
                    {
                        Order = order,
                        Product = productCombinedDetail.Product,
                        ProductCombined = orderProductCombined.ProductCombined,
                        OriginalQuantity = originalQuantity,
                        WastQuantity = wastQuantity,
                        ReleaseQuantity = releaseQuantity,
                        MaterialCategoryId = productCombinedDetail.Product.MaterialCategoryId ?? 0,
                        MaterialId = productCombinedDetail.Product.MaterialId ?? 0,
                        MaterialReleaseSizeId = productCombinedDetail.Product.ReleaseSizeId,
                        MaterialTypeId = productCombinedDetail.Product.MaterialTypeId,

                        DepartmentId = productCombinedDetail.Product.DepartmentId,
                        ReasonId = 1,
                        CreatedUser = GlobalData.LoginUser
                    };
                    GlobalData.UnitOfWork.MaterialsReleases.Add(materialRelease);
                }
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
                if (entry.State.ToString() != "Unchanged")
                    Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: {entry.State.ToString()}");
        }

        private void MaterialReleaseProduct(Order order)
        {
            foreach (var orderProduct in order.OrderProduct)
                if (orderProduct.Product.Material != null&&orderProduct.IsDeleted==false)
                {
                    var noSSizeInBSize =
                        GlobalData.UnitOfWork.MaterialSizeConversion
                            .SingleOrDefault(e =>
                                e.SmallSizeId == orderProduct.Product.MaterialSizeId
                                && e.BigSizeId == orderProduct.Product.ReleaseSizeId)
                            .NoSSizeInBSize;

                    var originalQuantity = orderProduct.Quantity / noSSizeInBSize;
                    var wastQuantity = originalQuantity * (orderProduct.Product.MaterialWastRatio ?? 0) / 100;
                    var releaseQuantity = (int) Math.Ceiling(originalQuantity + wastQuantity);
                    var materialRelease = new MaterialRelease
                    {
                        Order = order,
                        Product = orderProduct.Product,
                        MaterialCategory = orderProduct.Product.MaterialCategory,
                        Material = orderProduct.Product.Material,
                        MaterialReleaseSize = orderProduct.Product.ReleaseSize,
                        MaterialType = orderProduct.Product.MaterialType,
                        OriginalQuantity = originalQuantity,
                        WastQuantity = wastQuantity,
                        ReleaseQuantity = releaseQuantity,
                        Department = orderProduct.Product.Department,
                        ReasonId = 1,
                        CreatedUser = GlobalData.LoginUser
                    };

                    GlobalData.UnitOfWork.MaterialsReleases.Add(materialRelease);
                }
        }

        private void AddProductCombinedWithAllDetailsToOrder(Order order)
        {

            var orderProductCombinedDetails = new List<OrderProductCombinedDetails>();
            var previousProductCombinedId = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                int.TryParse(row[0].ToString(), out var combinedProductId);
                int.TryParse(row[1].ToString(), out var productId);
                int.TryParse(row[3].ToString(), out var productQuantity);
                decimal.TryParse(row[4].ToString(), out var productActualPrice);


                // there is a lot of work
                if (combinedProductId != 0)
                {
                    var productCombined = GlobalData.UnitOfWork.ProductsCombined.Get(combinedProductId);
                    var product = GlobalData.UnitOfWork.Products.Get(productId);
                    if (productCombined.IsDetailed)
                    {
                        if (previousProductCombinedId == combinedProductId
                        ) // combined product added but its details row not added
                        {
                            //add row to CombinedProductDetails

                            var productCombinedDetails = new OrderProductCombinedDetails
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                Product = product,
                                UnitSellPriceActual = productActualPrice,
                                UnitSellPriceOriginal = product.ProductSellPrice,
                                Quantity = productQuantity,
                                User = GlobalData.LoginUser
                            };

                            GlobalData.UnitOfWork.OrdersProductsCombinedDetails.Add(productCombinedDetails);
                        }
                        else // add combined product and its details row
                        {
                            //add row to CombinedProduct then to CombinedProductDetails
                            var orderCombinedProduct = new OrderProductCombined
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                User = GlobalData.LoginUser
                            };
                            GlobalData.UnitOfWork.OrdersProductsCombined.Add(orderCombinedProduct);
                            
                            var productCombinedDetails = new OrderProductCombinedDetails
                            {
                                Order = order,
                                ProductCombined = productCombined,
                                Product = product,
                                UnitSellPriceActual = productActualPrice,
                                UnitSellPriceOriginal = product.ProductSellPrice,
                                Quantity = productQuantity,
                                User = GlobalData.LoginUser
                            };

                            GlobalData.UnitOfWork.OrdersProductsCombinedDetails.Add(productCombinedDetails);
                        }
                    }
                    else // add not Detailed Product
                    {
                        var orderCombinedProduct = new OrderProductCombined
                        {
                            Order = order,
                            ProductCombined = productCombined,
                            UnitSellPriceActual = productActualPrice,
                            UnitSellPriceOriginal = productCombined.TotalPrice ?? 0,
                            Quantity = productQuantity,
                            User = GlobalData.LoginUser
                        };
                        GlobalData.UnitOfWork.OrdersProductsCombined.Add(orderCombinedProduct);
                    }
                }

                previousProductCombinedId = combinedProductId;
            }
        }

        private void AddProductToOrder(Order order)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int.TryParse(row[1].ToString(), out var productId);
                int.TryParse(row[3].ToString(), out var productQuantity);
                decimal.TryParse(row[4].ToString(), out var productActualPrice);


                if (string.IsNullOrEmpty(row[0].ToString()))
                {
                    var product = GlobalData.UnitOfWork.Products.Get(productId);
                    var orderProduct = new OrderProduct
                    {
                        Order = order,
                        Product = product,
                        UnitActualSellPrice = productActualPrice,
                        UnitOriginalSellPrice = product.ProductSellPrice,
                        Quantity = productQuantity,
                        User = GlobalData.LoginUser
                    };
                    GlobalData.UnitOfWork.OrdersProducts.Add(orderProduct);
                    GlobalData.UnitOfWork.Complete();
                }
            }
        }

        private Order CreateOrder()
        {
            var unit = ComboBox_Unit.SelectedItem as Unit;
            
            var orderCategory = ComboBox_OrderCategory.SelectedItem as OrderCategory;
            var user = GlobalData.LoginUser;
            // TODO PAID
            
            var isReceived = ComboBox_IsReceived.SelectedIndex == 1;
            //TODO: Change retrieve orderNo method
            var orderNo = (GlobalData.UnitOfWork.Orders
                .Find(e => e.OrderCategory == orderCategory)
                .Max(e => (int?) e.OrderNo) ?? 0) + 1;
            Client client;
            Nullable <int> nextSpecialNumber=null;
            if (orderCategory.IsSpecial)
            {
                var MaxSpecialNumber = GlobalData.UnitOfWork.Orders.GetAll().
                    Where(e => e.SpecialOrderNo != null && e.IsEnabled && e.IsDeleted == false&&e.UnitId==unit.UnitId).Max(e=>e.SpecialOrderNo);
                
                if (MaxSpecialNumber == null|| MaxSpecialNumber==0)
                {
                    nextSpecialNumber = 1;
                }
                else
                {
                    nextSpecialNumber = MaxSpecialNumber + 1;
                    
                }
                client = null;
            }
            else
            {
                 client = ComboBox_Client.SelectedItem as Client;
                nextSpecialNumber = null;
            }

            var order = new Order
            {
                Unit = unit,
                Client = client,
                OrderCategory = orderCategory,
                OrderNo = orderNo,
                OrderTotalPrice = CalcTotalPrice(),
                OrderPaymentAmount=0,
                IsReceived = isReceived,
                SpecialOrderNo=nextSpecialNumber,
                Notes = Txtbx_OrderNotes.Text,
                User = user
            };

            GlobalData.UnitOfWork.Orders.Add(order);

            return order;
        }


        private void ComboBox_Repayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentStatesValidate();
        }

        private void PaymentStatesValidate()
        {
            var selectedIndex = ComboBox_PaymentState.SelectedIndex;
            //"مسدد بالكامل"
            if (selectedIndex == 0 && !string.IsNullOrWhiteSpace(Txt_TotalPriceAmount.Text))
            {
                Txt_PaidAmount.Text = Txt_TotalPriceAmount.Text;
                Txt_PaidAmount.ReadOnly = true;
            }
            //"مسدد جزئيا"
            else if (selectedIndex == 1 )
            {
                Txt_PaidAmount.ReadOnly = false;
                if (editMode == false)
                {
                    Txt_PaidAmount.Text = "0";
                }
                else
                {
                    Txt_PaidAmount.Enabled = true;
                    Txt_PaidAmount.ReadOnly = false;
                }
            }
            //"غير مسدد"
            else if (selectedIndex == 2)
            {
                Txt_PaidAmount.Text = "0";
                Txt_PaidAmount.ReadOnly = true;
            }
        }

        public void UpdateUnits()
        {
            LoadUnites();
        }

        public void UpdateClients()
        {
            if (RadioButton_Client.Checked)
                LoadAllClients();
            else
                LoadClientsByTheirUnit();
        }

        private void ComboBox_Unit_Leave(object sender, EventArgs e)
        {
            if (ComboBox_Unit.Text=="")
            {
                ComboBox_Unit.Text = "اختر الوحدة";
            }
        }

        private void ComboBox_Client_Leave(object sender, EventArgs e)
        {
            if (ComboBox_Client.Text == "")
            {
                ComboBox_Client.Text = "اختر العميل";
            }
        }

        private void ComboBox_OrderCategory_Leave(object sender, EventArgs e)
        {
            if (ComboBox_OrderCategory.Text == "")
            {
                ComboBox_OrderCategory.Text = "اختر نوع الفاتورة";
            }
        }

        private void ComboBox_IsReceived_Leave(object sender, EventArgs e)
        {
            if (ComboBox_IsReceived.Text == "")
            {
                ComboBox_IsReceived.Text = "اختر التسليم";
            }
        }

        private void ComboBox_PaymentState_Leave(object sender, EventArgs e)
        {
            if (ComboBox_PaymentState.Text == "")
            {
                ComboBox_PaymentState.Text = "اختر الدفع";
            }
        }

        private void ComboBox_OrderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = ComboBox_OrderCategory.SelectedItem as OrderCategory;
            if (selectedCategory != null)
            {   
                if (selectedCategory.IsSpecial == true)
                {
                    LoadSpecialOrder();
                    SpecialOrderLayoutConfiguration();
                }
                else
                {
                    ShowClientControllers();
                    Reload();
                    LoadUnites();
                }

            }
        }

        private void ShowClientControllers()
        {
            RadioButton_Unit.Checked = true;
            RadioButton_Client.Enabled = true;
            Lbl_Delegate.Show();
            ComboBox_Client.Show();
            Btn_AddClient.Show();
            Btn_ShowClientInfo.Show();
        }

        private void SpecialOrderLayoutConfiguration()
        {
            RadioButton_Unit.Checked = true;
            RadioButton_Client.Enabled = false;
            Lbl_Delegate.Hide();
            ComboBox_Client.Hide();
            Btn_AddClient.Hide();
            Btn_ShowClientInfo.Hide();
        }

        private void LoadSpecialOrder()
        {
            ComboBox_Unit.DataSource = null;
            var units = GlobalData.UnitOfWork.Units.GetAllUnitsWithClients()
             .Where(e => e.IsEnabled && e.IsDeleted == false&&e.IsSpecial);
            ComboBox_Unit.DataSource = units;
            ComboBox_Unit.DisplayMember = "UnitName";
            ComboBox_Unit.Text = "اختر الوحدة";
        }
    }
}