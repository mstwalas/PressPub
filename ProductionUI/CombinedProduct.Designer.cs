namespace ProductionUI
{
    partial class FormCombinedProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCombinedProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Details = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_CombinedProductName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SellPrice = new DevExpress.XtraEditors.LabelControl();
            this.ChckEdt_Details = new DevExpress.XtraEditors.CheckEdit();
            this.Txt_CombinedProductName = new DevExpress.XtraEditors.TextEdit();
            this.Txt_SellPrice = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_AddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_DeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.GrdControl_CombinedProduct = new DevExpress.XtraGrid.GridControl();
            this.GridView_Product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColumn_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Process = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GrdColumn_Paid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_paid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GrdColumn_Release = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Release = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GrdColumn_Size = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ReleaseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_QuantityReleaseForUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChckEdt_Details.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CombinedProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SellPrice.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_CombinedProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_paid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Release)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Save,
            this.barButtonItem2,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(917, 162);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Caption = "حفظ";
            this.Btn_Save.Id = 1;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Save.ImageOptions.SvgImage")));
            this.Btn_Save.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Save_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "مسح";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 3;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Exit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "منتج مجمع";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Btn_Exit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GrdControl_CombinedProduct, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 362);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32454F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.67546F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl_Details, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_CombinedProductName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_SellPrice, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ChckEdt_Details, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Txt_CombinedProductName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Txt_SellPrice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53061F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53061F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53061F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(911, 156);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Lbl_Details
            // 
            this.Lbl_Details.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Details.Appearance.Options.UseFont = true;
            this.Lbl_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Details.Location = new System.Drawing.Point(766, 3);
            this.Lbl_Details.Name = "Lbl_Details";
            this.Lbl_Details.Size = new System.Drawing.Size(142, 25);
            this.Lbl_Details.TabIndex = 0;
            this.Lbl_Details.Text = "السعر مفصل";
            // 
            // Lbl_CombinedProductName
            // 
            this.Lbl_CombinedProductName.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_CombinedProductName.Appearance.Options.UseFont = true;
            this.Lbl_CombinedProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_CombinedProductName.Location = new System.Drawing.Point(766, 34);
            this.Lbl_CombinedProductName.Name = "Lbl_CombinedProductName";
            this.Lbl_CombinedProductName.Size = new System.Drawing.Size(142, 35);
            this.Lbl_CombinedProductName.TabIndex = 0;
            this.Lbl_CombinedProductName.Text = "اسم المنتج المجمع";
            // 
            // Lbl_SellPrice
            // 
            this.Lbl_SellPrice.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_SellPrice.Appearance.Options.UseFont = true;
            this.Lbl_SellPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_SellPrice.Location = new System.Drawing.Point(766, 75);
            this.Lbl_SellPrice.Name = "Lbl_SellPrice";
            this.Lbl_SellPrice.Size = new System.Drawing.Size(142, 35);
            this.Lbl_SellPrice.TabIndex = 0;
            this.Lbl_SellPrice.Text = "سعر البيع";
            // 
            // ChckEdt_Details
            // 
            this.ChckEdt_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChckEdt_Details.Location = new System.Drawing.Point(3, 3);
            this.ChckEdt_Details.MenuManager = this.ribbon;
            this.ChckEdt_Details.Name = "ChckEdt_Details";
            this.ChckEdt_Details.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ChckEdt_Details.Properties.Appearance.Options.UseFont = true;
            this.ChckEdt_Details.Properties.Caption = "";
            this.ChckEdt_Details.Size = new System.Drawing.Size(757, 25);
            this.ChckEdt_Details.TabIndex = 2;
            this.ChckEdt_Details.CheckedChanged += new System.EventHandler(this.ChckEdt_Details_CheckedChanged);
            // 
            // Txt_CombinedProductName
            // 
            this.Txt_CombinedProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_CombinedProductName.Location = new System.Drawing.Point(3, 34);
            this.Txt_CombinedProductName.Name = "Txt_CombinedProductName";
            this.Txt_CombinedProductName.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_CombinedProductName.Properties.Appearance.Options.UseFont = true;
            this.Txt_CombinedProductName.Size = new System.Drawing.Size(757, 30);
            this.Txt_CombinedProductName.TabIndex = 3;
            // 
            // Txt_SellPrice
            // 
            this.Txt_SellPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SellPrice.Location = new System.Drawing.Point(3, 75);
            this.Txt_SellPrice.Name = "Txt_SellPrice";
            this.Txt_SellPrice.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_SellPrice.Properties.Appearance.Options.UseFont = true;
            this.Txt_SellPrice.Size = new System.Drawing.Size(757, 30);
            this.Txt_SellPrice.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_AddProduct, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_DeleteProduct, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 116);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(757, 37);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // Btn_AddProduct
            // 
            this.Btn_AddProduct.Appearance.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_AddProduct.Appearance.Options.UseFont = true;
            this.Btn_AddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddProduct.Location = new System.Drawing.Point(382, 3);
            this.Btn_AddProduct.Name = "Btn_AddProduct";
            this.Btn_AddProduct.Size = new System.Drawing.Size(218, 31);
            this.Btn_AddProduct.TabIndex = 0;
            this.Btn_AddProduct.Text = "اضافة منتج";
            this.Btn_AddProduct.Click += new System.EventHandler(this.Btn_AddProduct_Click);
            // 
            // Btn_DeleteProduct
            // 
            this.Btn_DeleteProduct.Appearance.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteProduct.Appearance.Options.UseFont = true;
            this.Btn_DeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DeleteProduct.Location = new System.Drawing.Point(158, 3);
            this.Btn_DeleteProduct.Name = "Btn_DeleteProduct";
            this.Btn_DeleteProduct.Size = new System.Drawing.Size(218, 31);
            this.Btn_DeleteProduct.TabIndex = 0;
            this.Btn_DeleteProduct.Text = "حذف منتج";
            // 
            // GrdControl_CombinedProduct
            // 
            this.GrdControl_CombinedProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl_CombinedProduct.Location = new System.Drawing.Point(3, 165);
            this.GrdControl_CombinedProduct.MainView = this.GridView_Product;
            this.GrdControl_CombinedProduct.MenuManager = this.ribbon;
            this.GrdControl_CombinedProduct.Name = "GrdControl_CombinedProduct";
            this.GrdControl_CombinedProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit_Process,
            this.repositoryItemCheckEdit_paid,
            this.repositoryItemCheckEdit_Release});
            this.GrdControl_CombinedProduct.Size = new System.Drawing.Size(911, 194);
            this.GrdControl_CombinedProduct.TabIndex = 1;
            this.GrdControl_CombinedProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Product});
            // 
            // GridView_Product
            // 
            this.GridView_Product.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.GridView_Product.Appearance.Row.Options.UseFont = true;
            this.GridView_Product.Appearance.SelectedRow.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.GridView_Product.Appearance.SelectedRow.Options.UseFont = true;
            this.GridView_Product.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColumn_Id,
            this.GrdColumn_ProductName,
            this.GrdColumn_Price,
            this.GrdColumn_ProductProcess,
            this.GrdColumn_Paid,
            this.GrdColumn_Release,
            this.GrdColumn_Size,
            this.GrdColumn_ReleaseName,
            this.GrdColumn_QuantityReleaseForUnit});
            this.GridView_Product.DetailHeight = 303;
            this.GridView_Product.GridControl = this.GrdControl_CombinedProduct;
            this.GridView_Product.Name = "GridView_Product";
            this.GridView_Product.OptionsSelection.MultiSelect = true;
            this.GridView_Product.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.GridView_Product.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.GridView_Product.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            // 
            // GrdColumn_Id
            // 
            this.GrdColumn_Id.Caption = "الرقم التعريفي";
            this.GrdColumn_Id.MinWidth = 17;
            this.GrdColumn_Id.Name = "GrdColumn_Id";
            this.GrdColumn_Id.Visible = true;
            this.GrdColumn_Id.VisibleIndex = 8;
            this.GrdColumn_Id.Width = 64;
            // 
            // GrdColumn_ProductName
            // 
            this.GrdColumn_ProductName.Caption = "اسم المنتج";
            this.GrdColumn_ProductName.MinWidth = 17;
            this.GrdColumn_ProductName.Name = "GrdColumn_ProductName";
            this.GrdColumn_ProductName.OptionsColumn.ReadOnly = true;
            this.GrdColumn_ProductName.Visible = true;
            this.GrdColumn_ProductName.VisibleIndex = 0;
            this.GrdColumn_ProductName.Width = 64;
            // 
            // GrdColumn_Price
            // 
            this.GrdColumn_Price.Caption = "السعر";
            this.GrdColumn_Price.MinWidth = 17;
            this.GrdColumn_Price.Name = "GrdColumn_Price";
            this.GrdColumn_Price.OptionsColumn.ReadOnly = true;
            this.GrdColumn_Price.Visible = true;
            this.GrdColumn_Price.VisibleIndex = 4;
            this.GrdColumn_Price.Width = 64;
            // 
            // GrdColumn_ProductProcess
            // 
            this.GrdColumn_ProductProcess.Caption = "عمليه";
            this.GrdColumn_ProductProcess.ColumnEdit = this.repositoryItemCheckEdit_Process;
            this.GrdColumn_ProductProcess.MinWidth = 17;
            this.GrdColumn_ProductProcess.Name = "GrdColumn_ProductProcess";
            this.GrdColumn_ProductProcess.Visible = true;
            this.GrdColumn_ProductProcess.VisibleIndex = 1;
            this.GrdColumn_ProductProcess.Width = 64;
            // 
            // repositoryItemCheckEdit_Process
            // 
            this.repositoryItemCheckEdit_Process.AutoHeight = false;
            this.repositoryItemCheckEdit_Process.Name = "repositoryItemCheckEdit_Process";
            // 
            // GrdColumn_Paid
            // 
            this.GrdColumn_Paid.Caption = "مدفوعه";
            this.GrdColumn_Paid.ColumnEdit = this.repositoryItemCheckEdit_paid;
            this.GrdColumn_Paid.MinWidth = 17;
            this.GrdColumn_Paid.Name = "GrdColumn_Paid";
            this.GrdColumn_Paid.Visible = true;
            this.GrdColumn_Paid.VisibleIndex = 2;
            this.GrdColumn_Paid.Width = 64;
            // 
            // repositoryItemCheckEdit_paid
            // 
            this.repositoryItemCheckEdit_paid.AutoHeight = false;
            this.repositoryItemCheckEdit_paid.Name = "repositoryItemCheckEdit_paid";
            // 
            // GrdColumn_Release
            // 
            this.GrdColumn_Release.Caption = "تصرف";
            this.GrdColumn_Release.ColumnEdit = this.repositoryItemCheckEdit_Release;
            this.GrdColumn_Release.MinWidth = 17;
            this.GrdColumn_Release.Name = "GrdColumn_Release";
            this.GrdColumn_Release.Visible = true;
            this.GrdColumn_Release.VisibleIndex = 3;
            this.GrdColumn_Release.Width = 64;
            // 
            // repositoryItemCheckEdit_Release
            // 
            this.repositoryItemCheckEdit_Release.AutoHeight = false;
            this.repositoryItemCheckEdit_Release.Name = "repositoryItemCheckEdit_Release";
            // 
            // GrdColumn_Size
            // 
            this.GrdColumn_Size.Caption = "المقاس";
            this.GrdColumn_Size.MinWidth = 17;
            this.GrdColumn_Size.Name = "GrdColumn_Size";
            this.GrdColumn_Size.Visible = true;
            this.GrdColumn_Size.VisibleIndex = 5;
            this.GrdColumn_Size.Width = 64;
            // 
            // GrdColumn_ReleaseName
            // 
            this.GrdColumn_ReleaseName.Caption = "الصرف";
            this.GrdColumn_ReleaseName.MinWidth = 17;
            this.GrdColumn_ReleaseName.Name = "GrdColumn_ReleaseName";
            this.GrdColumn_ReleaseName.Visible = true;
            this.GrdColumn_ReleaseName.VisibleIndex = 6;
            this.GrdColumn_ReleaseName.Width = 64;
            // 
            // GrdColumn_QuantityReleaseForUnit
            // 
            this.GrdColumn_QuantityReleaseForUnit.Caption = "كمية الصرف للوحده";
            this.GrdColumn_QuantityReleaseForUnit.MinWidth = 17;
            this.GrdColumn_QuantityReleaseForUnit.Name = "GrdColumn_QuantityReleaseForUnit";
            this.GrdColumn_QuantityReleaseForUnit.Visible = true;
            this.GrdColumn_QuantityReleaseForUnit.VisibleIndex = 7;
            this.GrdColumn_QuantityReleaseForUnit.Width = 64;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FormCombinedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FormCombinedProduct";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منتج مجمع";
            this.Load += new System.EventHandler(this.Form_CombinedProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChckEdt_Details.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CombinedProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SellPrice.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_CombinedProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_paid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Release)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Save;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl Lbl_Details;
        private DevExpress.XtraEditors.LabelControl Lbl_CombinedProductName;
        private DevExpress.XtraEditors.LabelControl Lbl_SellPrice;
        private DevExpress.XtraGrid.GridControl GrdControl_CombinedProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Product;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductProcess;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Paid;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Release;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Price;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit ChckEdt_Details;
        private DevExpress.XtraEditors.TextEdit Txt_CombinedProductName;
        private DevExpress.XtraEditors.TextEdit Txt_SellPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton Btn_AddProduct;
        private DevExpress.XtraEditors.SimpleButton Btn_DeleteProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Process;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_paid;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Release;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Size;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ReleaseName;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_QuantityReleaseForUnit;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Id;
    }
}