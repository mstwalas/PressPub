using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using ProductionUI.Classes;
using System;
using System.Data;
using System.Linq;
using ProductionUI.Add;
using System.Collections.Generic;
using DevExpress.Data;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes.UI_Logic;
using ProductionUI.Show;
using System.Globalization;
using System.Windows.Forms;
using System.Collections;

namespace ProductionUI.Show
{
    public partial class FormShowOrders : RibbonForm
    {
        private DataTable ordersDataTable;

        public FormShowOrders()
        {
            InitializeComponent();
            LoadOrders(SortingOrders());

            GridViewColumnsConfigurations();
            BestFitForColumnsGridView(GridView_Order);
            FilterSearchCombobx();
        }

        private void FilterSearchCombobx()
        {

            Combobox_SearchFilter.Text = "اختر نوع البحث";
            var ordersCategries = GlobalData.UnitOfWork.OrdersCategories.GetAll();

            var delivaryStates = new List<string> { "الكل", "فاتورة عادية", "فاتورة خاصه" };
            Combobox_SearchFilter.DataSource = ordersCategries;
            Combobox_SearchFilter.DisplayMember = "OrderCategoryName";
        }

        private void GridViewColumnsConfigurations()
        {
            GridView_Order.OptionsBehavior.ReadOnly = true;
            GridView_Order.OptionsBehavior.Editable = false;
        }

        private void BestFitForColumnsGridView(GridView gridView)
        {
            gridView.BestFitColumns();
        }

        private IEnumerable<Order> SortingOrders()
        {
            IEnumerable<Order> orders = null;
            if (Combobox_SearchFilter.SelectedIndex > -1)
            {
                var selectedOrderCategry = Combobox_SearchFilter.SelectedItem as OrderCategory;
                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false && e.OrderCategory == selectedOrderCategry);
            }

            else
            {

                orders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false);
            }
            return orders;

        }
        private void LoadOrders(IEnumerable<Order> orders)
        {

            ordersDataTable = new DataTable();
            ordersDataTable.Columns.Add("رقم الطلب");
            ordersDataTable.Columns.Add("الرقم التعريفي");
            ordersDataTable.Columns.Add("العميل");
            ordersDataTable.Columns.Add("الوحدة");
            ordersDataTable.Columns.Add("المبلغ الاجمالى");
            ordersDataTable.Columns.Add("المبلغ المدفوع");
            ordersDataTable.Columns.Add("المبلغ المتبقى");
            foreach (var order in orders)
            {
                var orderDataRow = ordersDataTable.NewRow();
                orderDataRow["رقم الطلب"] = order.OrderNo;
                orderDataRow["الرقم التعريفي"] = order.OrderId;
                orderDataRow["العميل"] = order.ClientId != null
                    ? GlobalData.UnitOfWork.Clients.Get(order.ClientId.Value).ClientName
                    : "";

                orderDataRow["الوحدة"] = order.UnitId != null ? GlobalData.UnitOfWork.Units.Get(order.UnitId.Value).UnitName : "";
                //orderDataRow["الوحدة"] =
                //    order.Unit != null ? GlobalData.UnitOfWork.Units.Get(order.UnitId.Value).UnitName : "";

                orderDataRow["المبلغ الاجمالى"] = order.OrderTotalPrice;
                orderDataRow["المبلغ المدفوع"] = order.OrderPaymentAmount;
                Decimal remainPaymentAmount = Decimal.Parse(order.OrderTotalPrice.ToString()) - Decimal.Parse(order.OrderPaymentAmount.ToString());
                orderDataRow["المبلغ المتبقى"] = remainPaymentAmount;

                ordersDataTable.Rows.Add(orderDataRow);
            }

            DataGrid_OrdersInfo.DataSource = ordersDataTable;
            GridView_Order.PopulateColumns();
        }

        private void Form_ShowOrder_Load(object sender, EventArgs e)
        {
        }

        private void DataGrid_OrdersInfo_DoubleClick(object sender, EventArgs e)
        {

            int orderId = GetSelectedRow();
            var showOrder = new FormAddOrder(orderId);
            //Form2 yeniform = new Form2();
            showOrder.FormClosing += new FormClosingEventHandler(this.showOrders_FormClosing);
            
            showOrder.Show();
        }
        private void showOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadOrders(SortingOrders());
        }

        private int GetSelectedRow()
        {
            //int orderNo = 0;
            int orderId = 0;
            foreach (var row in GridView_Order.GetSelectedRows())
            {
                var selectedRow = GridView_Order.GetDataRow(row);
                orderId = Convert.ToInt32(selectedRow[1]);
            }
            
            return orderId;
        }

        private void Btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Btn_EditOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int orderId = GetSelectedRow();
            var showOrder = new FormAddOrder(orderId);
            showOrder.Show();
        }

        private void Btn_DeleteOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int orderId = GetSelectedRow();
            var order = GlobalData.UnitOfWork.Orders.Get(orderId).IsDeleted = true;
            GlobalData.UnitOfWork.Complete();
            ClearGridview();
            LoadOrders(SortingOrders());
            GridViewColumnsConfigurations();
            BestFitForColumnsGridView(GridView_Order);
        }

        private void ClearGridview()
        {
            DataGrid_OrdersInfo.DataSource = null;
        }

        private void Combobox_SearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders(SortingOrders());
        }

        

        private void SearchForAllOrders()
        {
            var orders = new List<Order>();

            var allOrders = GlobalData.UnitOfWork.Orders.GetAll().Where(e => e.IsDeleted == false && e.IsEnabled);

            foreach (var order in allOrders)
            {
                  if (order.Client != null)
                {
                    if (order.Client.ClientName.Contains(Txt_SearchData.Text))
                    {
                        orders.Add(order);
                    }
                }
                else if (order.Unit != null)
                {
                    if (order.Client != null)
                    {
                        if (order.Client.ClientName.Contains(Txt_SearchData.Text))
                        {
                            orders.Add(order);
                        }
                    }
                    else if (order.Unit.UnitName.Contains(Txt_SearchData.Text))
                    {
                        orders.Add(order);
                    }
                }

               

            }

            LoadOrders(orders);
           

        }
            

        private void Txt_SearchData_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
            if (Combobox_SearchFilter.SelectedIndex > -1)
            {
                SearchWithFilter();
            }
            else if(Combobox_SearchFilter.SelectedIndex==-1)
            {
                SearchForAllOrders();
            }
        }

        private void SearchWithFilter()
        {
            var searchedOrders = new List<Order>();
            var sortingOrders = SortingOrders();
            LoadOrders(sortingOrders);
            foreach (var order in sortingOrders)
            {
                if (order.Unit != null)
                {
                    if (order.SpecialOrderNo != null)
                    {
                        if (order.Unit.UnitName.Contains(Txt_SearchData.Text))
                        {
                            searchedOrders.Add(order);
                        }
                    }
                    else
                    {
                        if (order.Unit.UnitName.Contains(Txt_SearchData.Text))
                        {
                            searchedOrders.Add(order);
                        }
                        else if (order.Client.ClientName.Contains(Txt_SearchData.Text))
                        {
                            searchedOrders.Add(order);
                        }
                    }
                }
                else if(order.Client!=null)
                {
                    if (order.Client.ClientName.Contains(Txt_SearchData.Text))
                    {
                        searchedOrders.Add(order);
                    }
                }
            }
            LoadOrders(searchedOrders);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}