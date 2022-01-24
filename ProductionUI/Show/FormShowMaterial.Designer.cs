namespace ProductionUI
{
    partial class FormShowMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowMaterial));
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
            this.Lbl_SearchFilter = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_SearchFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.DataGrid_ProductsInfo = new DevExpress.XtraGrid.GridControl();
            this.GridView_ShowMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_SearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProductsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowMaterial)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1068, 162);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "حفظ";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // Btn_AddProduct
            // 
            this.Btn_AddProduct.Caption = "إضافة خامة";
            this.Btn_AddProduct.Id = 2;
            this.Btn_AddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_AddProduct.ImageOptions.SvgImage")));
            this.Btn_AddProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_AddProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_AddProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_AddProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_AddProduct.Name = "Btn_AddProduct";
            this.Btn_AddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_AddProduct_ItemClick);
            // 
            // Btn_EditProduct
            // 
            this.Btn_EditProduct.Caption = "تعديل";
            this.Btn_EditProduct.Id = 3;
            this.Btn_EditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_EditProduct.ImageOptions.SvgImage")));
            this.Btn_EditProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_EditProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_EditProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_EditProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_EditProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_EditProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_EditProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditProduct.Name = "Btn_EditProduct";
            this.Btn_EditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_EditProduct_ItemClick);
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
            this.Btn_DeleteProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteProduct.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteProduct.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteProduct.Name = "Btn_DeleteProduct";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 6;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.Name = "Btn_Exit";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "عرض الخامات";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.73267F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.26733F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Txt_SearchData, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_SearchData, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(666, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Txt_SearchData
            // 
            this.Txt_SearchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SearchData.Location = new System.Drawing.Point(3, 3);
            this.Txt_SearchData.MenuManager = this.ribbon;
            this.Txt_SearchData.Name = "Txt_SearchData";
            this.Txt_SearchData.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_SearchData.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchData.Size = new System.Drawing.Size(541, 30);
            this.Txt_SearchData.TabIndex = 2;
            // 
            // Lbl_SearchData
            // 
            this.Lbl_SearchData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchData.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_SearchData.Appearance.Options.UseFont = true;
            this.Lbl_SearchData.Location = new System.Drawing.Point(559, 3);
            this.Lbl_SearchData.Name = "Lbl_SearchData";
            this.Lbl_SearchData.Size = new System.Drawing.Size(95, 24);
            this.Lbl_SearchData.TabIndex = 1;
            this.Lbl_SearchData.Text = "بيانات البحث";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Lbl_SearchFilter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ComboBox_SearchFilter, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(675, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Lbl_SearchFilter
            // 
            this.Lbl_SearchFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchFilter.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_SearchFilter.Appearance.Options.UseFont = true;
            this.Lbl_SearchFilter.Location = new System.Drawing.Point(295, 3);
            this.Lbl_SearchFilter.Name = "Lbl_SearchFilter";
            this.Lbl_SearchFilter.Size = new System.Drawing.Size(74, 24);
            this.Lbl_SearchFilter.TabIndex = 1;
            this.Lbl_SearchFilter.Text = "نوع البحث";
            // 
            // ComboBox_SearchFilter
            // 
            this.ComboBox_SearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_SearchFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_SearchFilter.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Location = new System.Drawing.Point(3, 3);
            this.ComboBox_SearchFilter.Name = "ComboBox_SearchFilter";
            this.ComboBox_SearchFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_SearchFilter.Size = new System.Drawing.Size(273, 32);
            this.ComboBox_SearchFilter.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_SearchFilter.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.TabIndex = 2;
            // 
            // DataGrid_ProductsInfo
            // 
            this.DataGrid_ProductsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_ProductsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.DataGrid_ProductsInfo.Location = new System.Drawing.Point(3, 62);
            this.DataGrid_ProductsInfo.MainView = this.GridView_ShowMaterial;
            this.DataGrid_ProductsInfo.MenuManager = this.ribbon;
            this.DataGrid_ProductsInfo.Name = "DataGrid_ProductsInfo";
            this.DataGrid_ProductsInfo.Size = new System.Drawing.Size(1062, 344);
            this.DataGrid_ProductsInfo.TabIndex = 1;
            this.DataGrid_ProductsInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_ShowMaterial});
            this.DataGrid_ProductsInfo.DoubleClick += new System.EventHandler(this.DataGrid_ProductsInfo_DoubleClick);
            // 
            // GridView_ShowMaterial
            // 
            this.GridView_ShowMaterial.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_ShowMaterial.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView_ShowMaterial.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_ShowMaterial.Appearance.Row.Options.UseFont = true;
            this.GridView_ShowMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn_ID});
            this.GridView_ShowMaterial.DetailHeight = 397;
            this.GridView_ShowMaterial.GridControl = this.DataGrid_ProductsInfo;
            this.GridView_ShowMaterial.Name = "GridView_ShowMaterial";
            this.GridView_ShowMaterial.OptionsBehavior.Editable = false;
            this.GridView_ShowMaterial.OptionsBehavior.ReadOnly = true;
            this.GridView_ShowMaterial.OptionsCustomization.AllowFilter = false;
            this.GridView_ShowMaterial.OptionsFind.AllowFindPanel = false;
            this.GridView_ShowMaterial.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridView_ShowMaterial.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn_ID
            // 
            this.GridColumn_ID.Caption = "ID";
            this.GridColumn_ID.MinWidth = 26;
            this.GridColumn_ID.Name = "GridColumn_ID";
            this.GridColumn_ID.Visible = true;
            this.GridColumn_ID.VisibleIndex = 0;
            this.GridColumn_ID.Width = 96;
            // 
            // FormShowMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FormShowMaterial";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الخامات";
            this.Load += new System.EventHandler(this.Form_ShowMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_SearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProductsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowMaterial)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_ShowMaterial;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.TextEdit Txt_SearchData;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchData;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_SearchFilter;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn_ID;
    }
}