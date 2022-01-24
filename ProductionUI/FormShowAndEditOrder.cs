using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using System;
using System.Data;

namespace ProductionUI
{
    public partial class FormShowAndEditOrder : RibbonForm
    {
        private DataTable dataTable;

        public FormShowAndEditOrder()
        {
            InitializeComponent();
        }

        public FormShowAndEditOrder(int orderId)
        {
            InitializeComponent();
            DataTableColumnsConfigurations();
            LoadOrder(orderId);
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
            GrdControl_ShowAndEditOrder.DataSource = dataTable;
            GrdControl_ShowAndEditOrder.MainView.PopulateColumns();
        }


        private void LoadOrder(int orderId)
        {
            var order = GlobalData.UnitOfWork.Orders.GetOrderWithAllData(orderId);
            LoadMainOrderInfo(order);
            LoadProduct(order);
            LoadProductCompined(order);
        }

        private void LoadMainOrderInfo(Order order)
        {
            ComboBox_Unit.Text = order.Unit != null ? order.Unit.UnitName : "";
            ComboBox_Client.Text = order.Client.ClientName;
            Txt_OrderNum.Text = order.OrderNo.ToString();
            ComboBox_BillType.Text = order.OrderCategory.OrderCategoryName;
            Txt_Date.Text = order.AdditionTime.ToShortDateString();
            ComboBox_Delivary.Text = order.IsReceived ? "تم الاستلام" : "لم يتم الاستلام";
            //Txt_Payment.Text=Order.OrderPayment
            Txt_Notes.Text = order.Notes;
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

        private void LoadProduct(Order order)
        {
            foreach (var orderProduct in order.OrderProduct) AddOrderProductToGridView(orderProduct);
        }

        private void LoadProductCompined(Order order)
        {
            foreach (var orderProductCombined in order.OrderProductCombined)
                if (orderProductCombined.ProductCombined.IsDetailed)
                    AddOrderProductCombinedDetialiedToGridView(orderProductCombined);
                else
                    AddOrderProductCombinedWithoutDetailsToGridView(orderProductCombined);
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

        private void AddOrderProductCombinedWithoutDetailsToGridView(OrderProductCombined orderProductCombined)
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


        private void Form_ShowAndEditOrder_Load(object sender, EventArgs e)
        {
        }
    }
}