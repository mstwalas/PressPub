namespace ProductionUI
{
    partial class Form_ShowProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShowProducts));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_AddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_EditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_DeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_SearchData = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_SearchData = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_SearchFilter = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_SearchFilter = new DevExpress.XtraEditors.LabelControl();
            this.DataGrid_ProductsInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProductsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.Btn_AddProduct,
            this.Btn_EditProduct,
            this.barButtonItem4,
            this.Btn_DeleteProduct,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1016, 162);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "حفظ";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // Btn_AddProduct
            // 
            this.Btn_AddProduct.Caption = "إضافة منتج";
            this.Btn_AddProduct.Id = 2;
            this.Btn_AddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_AddProduct.ImageOptions.SvgImage")));
            this.Btn_AddProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_AddProduct.Name = "Btn_AddProduct";
            // 
            // Btn_EditProduct
            // 
            this.Btn_EditProduct.Caption = "تعديل";
            this.Btn_EditProduct.Id = 3;
            this.Btn_EditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_EditProduct.ImageOptions.SvgImage")));
            this.Btn_EditProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditProduct.Name = "Btn_EditProduct";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "إضافة منتج";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Btn_DeleteProduct
            // 
            this.Btn_DeleteProduct.Caption = "حذف";
            this.Btn_DeleteProduct.Id = 5;
            this.Btn_DeleteProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_DeleteProduct.ImageOptions.SvgImage")));
            this.Btn_DeleteProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteProduct.Name = "Btn_DeleteProduct";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 6;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.Name = "Btn_Exit";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "عرض المنتجات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage")));
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_AddProduct);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Btn_EditProduct);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_DeleteProduct);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Exit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DataGrid_ProductsInfo, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 469);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1010, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Txt_SearchData, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_SearchData, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(600, 36);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Txt_SearchData
            // 
            this.Txt_SearchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SearchData.Location = new System.Drawing.Point(3, 3);
            this.Txt_SearchData.MenuManager = this.ribbon;
            this.Txt_SearchData.Name = "Txt_SearchData";
            this.Txt_SearchData.Properties.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Txt_SearchData.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchData.Size = new System.Drawing.Size(432, 32);
            this.Txt_SearchData.TabIndex = 2;
            // 
            // Lbl_SearchData
            // 
            this.Lbl_SearchData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchData.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Lbl_SearchData.Appearance.Options.UseFont = true;
            this.Lbl_SearchData.Location = new System.Drawing.Point(478, 3);
            this.Lbl_SearchData.Name = "Lbl_SearchData";
            this.Lbl_SearchData.Size = new System.Drawing.Size(82, 26);
            this.Lbl_SearchData.TabIndex = 1;
            this.Lbl_SearchData.Text = "بيانات البحث";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Txt_SearchFilter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_SearchFilter, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(609, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 36);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Txt_SearchFilter
            // 
            this.Txt_SearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SearchFilter.Location = new System.Drawing.Point(3, 3);
            this.Txt_SearchFilter.MenuManager = this.ribbon;
            this.Txt_SearchFilter.Name = "Txt_SearchFilter";
            this.Txt_SearchFilter.Properties.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Txt_SearchFilter.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchFilter.Size = new System.Drawing.Size(230, 32);
            this.Txt_SearchFilter.TabIndex = 2;
            // 
            // Lbl_SearchFilter
            // 
            this.Lbl_SearchFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchFilter.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Lbl_SearchFilter.Appearance.Options.UseFont = true;
            this.Lbl_SearchFilter.Location = new System.Drawing.Point(286, 3);
            this.Lbl_SearchFilter.Name = "Lbl_SearchFilter";
            this.Lbl_SearchFilter.Size = new System.Drawing.Size(62, 26);
            this.Lbl_SearchFilter.TabIndex = 1;
            this.Lbl_SearchFilter.Text = "نوع البحث";
            // 
            // DataGrid_ProductsInfo
            // 
            this.DataGrid_ProductsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_ProductsInfo.Location = new System.Drawing.Point(3, 76);
            this.DataGrid_ProductsInfo.MainView = this.gridView1;
            this.DataGrid_ProductsInfo.MenuManager = this.ribbon;
            this.DataGrid_ProductsInfo.Name = "DataGrid_ProductsInfo";
            this.DataGrid_ProductsInfo.Size = new System.Drawing.Size(1010, 365);
            this.DataGrid_ProductsInfo.TabIndex = 1;
            this.DataGrid_ProductsInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DataGrid_ProductsInfo;
            this.gridView1.Name = "gridView1";
            // 
            // Form_ShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "Form_ShowProducts";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المنتجات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProductsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem Btn_AddProduct;
        private DevExpress.XtraBars.BarButtonItem Btn_EditProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem Btn_DeleteProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.GridControl DataGrid_ProductsInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchFilter;
        private DevExpress.XtraEditors.TextEdit Txt_SearchFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.TextEdit Txt_SearchData;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchData;
    }
}