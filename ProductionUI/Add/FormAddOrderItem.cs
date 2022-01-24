using DevExpress.XtraBars.Ribbon;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductionUI.Add
{
    public partial class FormAddOrderItem : RibbonForm
    {
        public string productName = "";
        public string ProductPrice = "";
        public string ProductQuantity = "";
        private readonly DataTable tableCus = new DataTable();

        public FormAddOrderItem()
        {
            InitializeComponent();
        }

        private void AddOrderItem_Form_Load(object sender, EventArgs e)
        {
            var table = new DataTable();
            //add in tables
            table.Columns.Add("إسم المنتج", typeof(string));
            table.Columns.Add("السعر", typeof(string));

            //add in rows
            table.Rows.Add("طباعة", "200");


            table.Rows.Add("تصوير", "400");
            table.Rows.Add("شهادات", "300");


            table.Rows.Add("بانر", "500");

            Grid_Products.DataSource = table;

            tableCus.Columns.Add("إسم المنتج", typeof(string));
            tableCus.Columns.Add("السعر", typeof(string));
            tableCus.Columns.Add("الكمية", typeof(string));
            tableCus.Columns.Add("السعر الإجمالي", typeof(string));
        }

        public void Addrow()
        {
            /* table_cus.Rows.Add(productName, product_price, product_Quantity);
             Client_Grid.DataSource = table_cus;
             Client_Grid.Refresh();*/
        }

        private void Products_Grid_DoubleClick(object sender, EventArgs e)
        {
            productName = gridView1.GetFocusedRowCellValue("إسم المنتج").ToString();
            ProductPrice = gridView1.GetFocusedRowCellValue("السعر").ToString();
            var priceTotal = double.Parse(ProductPrice) * 1;
            tableCus.Rows.Add(productName, ProductPrice, ProductQuantity);
            tableCus.Rows.Add(productName, ProductPrice, "1", priceTotal);
            Grid_Client.DataSource = tableCus;
            Grid_Client.Refresh();
        }

        private void Products_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                productName = gridView1.GetFocusedRowCellValue("إسم المنتج").ToString();
                ProductPrice = gridView1.GetFocusedRowCellValue("السعر").ToString();

                var priceTotal = double.Parse(ProductPrice) * 1;

                tableCus.Rows.Add(productName, ProductPrice, "1", priceTotal);
                Grid_Client.DataSource = tableCus;
                Grid_Client.Refresh();
            }
            else if (e.KeyData == Keys.Tab)
            {
                Grid_Client.Select();
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                Txt_SearchDetails.Focus();
            }
        }

        private void Client_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
            }
            else if (e.KeyData == Keys.Tab)
            {
                Grid_Products.Select();
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                Txt_SearchDetails.Focus();
            }
        }
    }
}