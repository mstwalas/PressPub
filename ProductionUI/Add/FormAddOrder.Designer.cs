namespace ProductionUI.Add
{
    partial class FormAddOrder
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ProductionUI.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_SaveAndPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_ClearAll = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_OrderNum = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_OrderNum = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_NumOfVarieties = new DevExpress.XtraEditors.LabelControl();
            this.Txt_NumOfVarieties = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Date = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Quantity = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Quantity = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_AddOrderItem = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_DelOrderItem = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.Txtbx_OrderNotes = new System.Windows.Forms.TextBox();
            this.Lbl_Notes = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_BillType = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_OrderCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ClientSortLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_ClientType = new DevExpress.XtraEditors.LabelControl();
            this.RadioButton_Client = new System.Windows.Forms.RadioButton();
            this.RadioButton_Unit = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Repayment = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Delivery = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_IsReceived = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_PaymentState = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_TotoalPayment = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PaidOff = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_RestOfPayment = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PaidAmount = new DevExpress.XtraEditors.TextEdit();
            this.Txt_RemainPaymentAmount = new DevExpress.XtraEditors.TextEdit();
            this.Txt_TotalPriceAmount = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Unit = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Delegate = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_Client = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_Unit = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ShowUnitInfo = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_ShowClientInfo = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_AddClient = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_AddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.GrdControl_AddOrder = new DevExpress.XtraGrid.GridControl();
            this.GridView_AddOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColumn_ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_CombinedId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_UnitSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OrderNum.Properties)).BeginInit();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NumOfVarieties.Properties)).BeginInit();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Date.Properties)).BeginInit();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).BeginInit();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_OrderCategory)).BeginInit();
            this.ClientSortLayout.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_IsReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_PaymentState)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PaidAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RemainPaymentAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalPriceAmount.Properties)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Unit)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_AddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_AddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(135)))), ((int)(((byte)(202)))));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_SaveAndPrint,
            this.barButtonItem2,
            this.Btn_ClearAll,
            this.barButtonItem4,
            this.Btn_Exit,
            this.barEditItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.QuickToolbarItemLinks.Add(this.barEditItem1);
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.ribbon.Size = new System.Drawing.Size(1384, 164);
            // 
            // Btn_SaveAndPrint
            // 
            this.Btn_SaveAndPrint.Caption = "حفظ و طباعة";
            this.Btn_SaveAndPrint.Id = 1;
            this.Btn_SaveAndPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_SaveAndPrint.ImageOptions.SvgImage")));
            this.Btn_SaveAndPrint.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndPrint.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndPrint.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndPrint.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_SaveAndPrint.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_SaveAndPrint.Name = "Btn_SaveAndPrint";
            this.Btn_SaveAndPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_SaveAndPrint_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Btn_ClearAll
            // 
            this.Btn_ClearAll.Caption = "مـسـح";
            this.Btn_ClearAll.Id = 3;
            this.Btn_ClearAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_ClearAll.ImageOptions.SvgImage")));
            this.Btn_ClearAll.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_ClearAll.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_ClearAll.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_ClearAll.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_ClearAll.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_ClearAll.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_ClearAll.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_ClearAll.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_ClearAll.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_ClearAll.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_ClearAll.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_ClearAll.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_ClearAll.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_ClearAll.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_ClearAll.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_ClearAll.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_ClearAll.Name = "Btn_ClearAll";
            this.Btn_ClearAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ClearAll_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 5;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
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
            this.Btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Exit_Btn_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemCalcEdit1;
            this.barEditItem1.Id = 6;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
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
            this.ribbonPage1.Text = "طلب جديد";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_SaveAndPrint);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_ClearAll);
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
            this.tableLayoutPanel1.Controls.Add(this.GrdControl_AddOrder, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 623);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.93895F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06105F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1376, 359);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel22, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79725F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20275F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(558, 347);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(550, 157);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel18, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel19, 0, 2);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(279, 6);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(267, 145);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.Txt_OrderNum, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.Lbl_OrderNum, 0, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(4, 54);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(259, 36);
            this.tableLayoutPanel18.TabIndex = 1;
            // 
            // Txt_OrderNum
            // 
            this.Txt_OrderNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_OrderNum.EditValue = "";
            this.Txt_OrderNum.Location = new System.Drawing.Point(4, 6);
            this.Txt_OrderNum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_OrderNum.Name = "Txt_OrderNum";
            this.Txt_OrderNum.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_OrderNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_OrderNum.Properties.ReadOnly = true;
            this.Txt_OrderNum.Size = new System.Drawing.Size(128, 30);
            this.Txt_OrderNum.TabIndex = 5;
            // 
            // Lbl_OrderNum
            // 
            this.Lbl_OrderNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_OrderNum.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_OrderNum.Appearance.Options.UseFont = true;
            this.Lbl_OrderNum.Location = new System.Drawing.Point(159, 6);
            this.Lbl_OrderNum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_OrderNum.Name = "Lbl_OrderNum";
            this.Lbl_OrderNum.Size = new System.Drawing.Size(77, 24);
            this.Lbl_OrderNum.TabIndex = 0;
            this.Lbl_OrderNum.Text = "رقم الطلب";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Controls.Add(this.Lbl_NumOfVarieties, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.Txt_NumOfVarieties, 1, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(4, 102);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(259, 37);
            this.tableLayoutPanel19.TabIndex = 2;
            // 
            // Lbl_NumOfVarieties
            // 
            this.Lbl_NumOfVarieties.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NumOfVarieties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_NumOfVarieties.Appearance.Options.UseFont = true;
            this.Lbl_NumOfVarieties.Location = new System.Drawing.Point(151, 6);
            this.Lbl_NumOfVarieties.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_NumOfVarieties.Name = "Lbl_NumOfVarieties";
            this.Lbl_NumOfVarieties.Size = new System.Drawing.Size(93, 24);
            this.Lbl_NumOfVarieties.TabIndex = 0;
            this.Lbl_NumOfVarieties.Text = "عدد الأصناف";
            // 
            // Txt_NumOfVarieties
            // 
            this.Txt_NumOfVarieties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_NumOfVarieties.EditValue = "";
            this.Txt_NumOfVarieties.Location = new System.Drawing.Point(4, 6);
            this.Txt_NumOfVarieties.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_NumOfVarieties.Name = "Txt_NumOfVarieties";
            this.Txt_NumOfVarieties.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NumOfVarieties.Properties.Appearance.Options.UseFont = true;
            this.Txt_NumOfVarieties.Properties.ReadOnly = true;
            this.Txt_NumOfVarieties.Size = new System.Drawing.Size(128, 30);
            this.Txt_NumOfVarieties.TabIndex = 4;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel20, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel21, 0, 2);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 3;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(267, 145);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.Txt_Date, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.Lbl_Date, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(4, 54);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(259, 36);
            this.tableLayoutPanel20.TabIndex = 1;
            // 
            // Txt_Date
            // 
            this.Txt_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Date.EditValue = "2021-02-26";
            this.Txt_Date.Location = new System.Drawing.Point(4, 6);
            this.Txt_Date.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_Date.MenuManager = this.ribbon;
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Date.Properties.Appearance.Options.UseFont = true;
            this.Txt_Date.Properties.ReadOnly = true;
            this.Txt_Date.Size = new System.Drawing.Size(103, 30);
            this.Txt_Date.TabIndex = 4;
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(161, 6);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(49, 24);
            this.Lbl_Date.TabIndex = 0;
            this.Lbl_Date.Text = "التاريخ";
            this.Lbl_Date.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.Lbl_Quantity, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.Txt_Quantity, 1, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(4, 102);
            this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(259, 37);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Quantity.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Quantity.Appearance.Options.UseFont = true;
            this.Lbl_Quantity.Location = new System.Drawing.Point(161, 6);
            this.Lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(48, 24);
            this.Lbl_Quantity.TabIndex = 0;
            this.Lbl_Quantity.Text = "الكمية";
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Quantity.EditValue = "";
            this.Txt_Quantity.Location = new System.Drawing.Point(4, 6);
            this.Txt_Quantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Quantity.Properties.Appearance.Options.UseFont = true;
            this.Txt_Quantity.Properties.ReadOnly = true;
            this.Txt_Quantity.Size = new System.Drawing.Size(103, 30);
            this.Txt_Quantity.TabIndex = 4;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel24, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(4, 175);
            this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(550, 166);
            this.tableLayoutPanel22.TabIndex = 1;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Controls.Add(this.Btn_AddOrderItem, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.Btn_DelOrderItem, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(4, 122);
            this.tableLayoutPanel23.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(542, 38);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // Btn_AddOrderItem
            // 
            this.Btn_AddOrderItem.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_AddOrderItem.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_AddOrderItem.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_AddOrderItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_AddOrderItem.Appearance.Options.UseBackColor = true;
            this.Btn_AddOrderItem.Appearance.Options.UseFont = true;
            this.Btn_AddOrderItem.Appearance.Options.UseForeColor = true;
            this.Btn_AddOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddOrderItem.Location = new System.Drawing.Point(275, 6);
            this.Btn_AddOrderItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AddOrderItem.Name = "Btn_AddOrderItem";
            this.Btn_AddOrderItem.Size = new System.Drawing.Size(263, 26);
            this.Btn_AddOrderItem.TabIndex = 2;
            this.Btn_AddOrderItem.Text = "إضافة منتج";
            this.Btn_AddOrderItem.Click += new System.EventHandler(this.AddOrderItem_Btn_Click);
            // 
            // Btn_DelOrderItem
            // 
            this.Btn_DelOrderItem.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_DelOrderItem.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_DelOrderItem.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_DelOrderItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_DelOrderItem.Appearance.Options.UseBackColor = true;
            this.Btn_DelOrderItem.Appearance.Options.UseFont = true;
            this.Btn_DelOrderItem.Appearance.Options.UseForeColor = true;
            this.Btn_DelOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DelOrderItem.Location = new System.Drawing.Point(4, 6);
            this.Btn_DelOrderItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_DelOrderItem.Name = "Btn_DelOrderItem";
            this.Btn_DelOrderItem.Size = new System.Drawing.Size(263, 26);
            this.Btn_DelOrderItem.TabIndex = 2;
            this.Btn_DelOrderItem.Text = "حذف منتج";
            this.Btn_DelOrderItem.Click += new System.EventHandler(this.Btn_DelOrderItem_Click);
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.Txtbx_OrderNotes, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.Lbl_Notes, 0, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel24.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(542, 104);
            this.tableLayoutPanel24.TabIndex = 1;
            // 
            // Txtbx_OrderNotes
            // 
            this.Txtbx_OrderNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txtbx_OrderNotes.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txtbx_OrderNotes.Location = new System.Drawing.Point(4, 6);
            this.Txtbx_OrderNotes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txtbx_OrderNotes.Multiline = true;
            this.Txtbx_OrderNotes.Name = "Txtbx_OrderNotes";
            this.Txtbx_OrderNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txtbx_OrderNotes.Size = new System.Drawing.Size(411, 92);
            this.Txtbx_OrderNotes.TabIndex = 10;
            // 
            // Lbl_Notes
            // 
            this.Lbl_Notes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Notes.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Notes.Appearance.Options.UseFont = true;
            this.Lbl_Notes.Location = new System.Drawing.Point(447, 6);
            this.Lbl_Notes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Notes.Name = "Lbl_Notes";
            this.Lbl_Notes.Size = new System.Drawing.Size(67, 24);
            this.Lbl_Notes.TabIndex = 0;
            this.Lbl_Notes.Text = "ملاحظات";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ClientSortLayout, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(570, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.79452F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.79452F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.49315F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.5493F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(802, 347);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.41133F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.58867F));
            this.tableLayoutPanel5.Controls.Add(this.Lbl_BillType, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ComboBox_OrderCategory, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Lbl_BillType
            // 
            this.Lbl_BillType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_BillType.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_BillType.Appearance.Options.UseFont = true;
            this.Lbl_BillType.Location = new System.Drawing.Point(690, 6);
            this.Lbl_BillType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_BillType.Name = "Lbl_BillType";
            this.Lbl_BillType.Size = new System.Drawing.Size(86, 24);
            this.Lbl_BillType.TabIndex = 0;
            this.Lbl_BillType.Text = "نوع الفاتورة";
            // 
            // ComboBox_OrderCategory
            // 
            this.ComboBox_OrderCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_OrderCategory.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.ComboBox_OrderCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_OrderCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_OrderCategory.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderCategory.Location = new System.Drawing.Point(377, 6);
            this.ComboBox_OrderCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComboBox_OrderCategory.Name = "ComboBox_OrderCategory";
            this.ComboBox_OrderCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComboBox_OrderCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_OrderCategory.Size = new System.Drawing.Size(290, 27);
            this.ComboBox_OrderCategory.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderCategory.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderCategory.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_OrderCategory.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderCategory.TabIndex = 1;
            this.ComboBox_OrderCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrderCategory_SelectedIndexChanged);
            this.ComboBox_OrderCategory.Leave += new System.EventHandler(this.ComboBox_OrderCategory_Leave);
            // 
            // ClientSortLayout
            // 
            this.ClientSortLayout.ColumnCount = 4;
            this.ClientSortLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.ClientSortLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ClientSortLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ClientSortLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClientSortLayout.Controls.Add(this.Lbl_ClientType, 0, 0);
            this.ClientSortLayout.Controls.Add(this.RadioButton_Client, 2, 0);
            this.ClientSortLayout.Controls.Add(this.RadioButton_Unit, 1, 0);
            this.ClientSortLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSortLayout.Location = new System.Drawing.Point(4, 57);
            this.ClientSortLayout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClientSortLayout.Name = "ClientSortLayout";
            this.ClientSortLayout.RowCount = 1;
            this.ClientSortLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClientSortLayout.Size = new System.Drawing.Size(794, 39);
            this.ClientSortLayout.TabIndex = 1;
            // 
            // Lbl_ClientType
            // 
            this.Lbl_ClientType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientType.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClientType.Appearance.Options.UseFont = true;
            this.Lbl_ClientType.Location = new System.Drawing.Point(690, 6);
            this.Lbl_ClientType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_ClientType.Name = "Lbl_ClientType";
            this.Lbl_ClientType.Size = new System.Drawing.Size(83, 24);
            this.Lbl_ClientType.TabIndex = 0;
            this.Lbl_ClientType.Text = "نوع العميل";
            // 
            // RadioButton_Client
            // 
            this.RadioButton_Client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton_Client.AutoSize = true;
            this.RadioButton_Client.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.RadioButton_Client.Location = new System.Drawing.Point(418, 6);
            this.RadioButton_Client.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RadioButton_Client.Name = "RadioButton_Client";
            this.RadioButton_Client.Size = new System.Drawing.Size(63, 25);
            this.RadioButton_Client.TabIndex = 2;
            this.RadioButton_Client.TabStop = true;
            this.RadioButton_Client.Text = "عميل";
            this.RadioButton_Client.UseVisualStyleBackColor = true;
            this.RadioButton_Client.CheckedChanged += new System.EventHandler(this.RadioButton_Client_CheckedChanged);
            // 
            // RadioButton_Unit
            // 
            this.RadioButton_Unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton_Unit.AutoSize = true;
            this.RadioButton_Unit.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.RadioButton_Unit.Location = new System.Drawing.Point(567, 6);
            this.RadioButton_Unit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RadioButton_Unit.Name = "RadioButton_Unit";
            this.RadioButton_Unit.Size = new System.Drawing.Size(60, 25);
            this.RadioButton_Unit.TabIndex = 1;
            this.RadioButton_Unit.TabStop = true;
            this.RadioButton_Unit.Text = "وحدة";
            this.RadioButton_Unit.UseVisualStyleBackColor = true;
            this.RadioButton_Unit.CheckedChanged += new System.EventHandler(this.RadioButton_Unit_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 207);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(794, 134);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.Lbl_Repayment, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.Lbl_Delivery, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.ComboBox_IsReceived, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.ComboBox_PaymentState, 1, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(401, 6);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(389, 122);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // Lbl_Repayment
            // 
            this.Lbl_Repayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Repayment.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Repayment.Appearance.Options.UseFont = true;
            this.Lbl_Repayment.Location = new System.Drawing.Point(301, 46);
            this.Lbl_Repayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Repayment.Name = "Lbl_Repayment";
            this.Lbl_Repayment.Size = new System.Drawing.Size(53, 24);
            this.Lbl_Repayment.TabIndex = 0;
            this.Lbl_Repayment.Text = "السداد";
            // 
            // Lbl_Delivery
            // 
            this.Lbl_Delivery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Delivery.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delivery.Appearance.Options.UseFont = true;
            this.Lbl_Delivery.Location = new System.Drawing.Point(297, 6);
            this.Lbl_Delivery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Delivery.Name = "Lbl_Delivery";
            this.Lbl_Delivery.Size = new System.Drawing.Size(61, 24);
            this.Lbl_Delivery.TabIndex = 0;
            this.Lbl_Delivery.Text = "التسليم";
            this.Lbl_Delivery.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // ComboBox_IsReceived
            // 
            this.ComboBox_IsReceived.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_IsReceived.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.ComboBox_IsReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_IsReceived.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_IsReceived.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_IsReceived.Location = new System.Drawing.Point(4, 6);
            this.ComboBox_IsReceived.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComboBox_IsReceived.Name = "ComboBox_IsReceived";
            this.ComboBox_IsReceived.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComboBox_IsReceived.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_IsReceived.Size = new System.Drawing.Size(258, 28);
            this.ComboBox_IsReceived.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_IsReceived.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_IsReceived.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_IsReceived.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_IsReceived.TabIndex = 1;
            this.ComboBox_IsReceived.Leave += new System.EventHandler(this.ComboBox_IsReceived_Leave);
            // 
            // ComboBox_PaymentState
            // 
            this.ComboBox_PaymentState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_PaymentState.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.ComboBox_PaymentState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_PaymentState.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_PaymentState.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_PaymentState.Location = new System.Drawing.Point(4, 46);
            this.ComboBox_PaymentState.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComboBox_PaymentState.Name = "ComboBox_PaymentState";
            this.ComboBox_PaymentState.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComboBox_PaymentState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_PaymentState.Size = new System.Drawing.Size(258, 28);
            this.ComboBox_PaymentState.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_PaymentState.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_PaymentState.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_PaymentState.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_PaymentState.TabIndex = 1;
            this.ComboBox_PaymentState.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Repayment_SelectedIndexChanged);
            this.ComboBox_PaymentState.Leave += new System.EventHandler(this.ComboBox_PaymentState_Leave);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.Lbl_TotoalPayment, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.Lbl_PaidOff, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.Lbl_RestOfPayment, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.Txt_PaidAmount, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.Txt_RemainPaymentAmount, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.Txt_TotalPriceAmount, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(389, 122);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // Lbl_TotoalPayment
            // 
            this.Lbl_TotoalPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_TotoalPayment.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_TotoalPayment.Appearance.Options.UseFont = true;
            this.Lbl_TotoalPayment.Location = new System.Drawing.Point(277, 6);
            this.Lbl_TotoalPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_TotoalPayment.Name = "Lbl_TotoalPayment";
            this.Lbl_TotoalPayment.Size = new System.Drawing.Size(101, 24);
            this.Lbl_TotoalPayment.TabIndex = 0;
            this.Lbl_TotoalPayment.Text = "إجمالي المبلغ";
            // 
            // Lbl_PaidOff
            // 
            this.Lbl_PaidOff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_PaidOff.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_PaidOff.Appearance.Options.UseFont = true;
            this.Lbl_PaidOff.Location = new System.Drawing.Point(273, 46);
            this.Lbl_PaidOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_PaidOff.Name = "Lbl_PaidOff";
            this.Lbl_PaidOff.Size = new System.Drawing.Size(109, 24);
            this.Lbl_PaidOff.TabIndex = 0;
            this.Lbl_PaidOff.Text = "المبلغ المسدد";
            this.Lbl_PaidOff.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // Lbl_RestOfPayment
            // 
            this.Lbl_RestOfPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_RestOfPayment.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_RestOfPayment.Appearance.Options.UseFont = true;
            this.Lbl_RestOfPayment.Location = new System.Drawing.Point(305, 86);
            this.Lbl_RestOfPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_RestOfPayment.Name = "Lbl_RestOfPayment";
            this.Lbl_RestOfPayment.Size = new System.Drawing.Size(45, 24);
            this.Lbl_RestOfPayment.TabIndex = 0;
            this.Lbl_RestOfPayment.Text = "الباقي";
            this.Lbl_RestOfPayment.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // Txt_PaidAmount
            // 
            this.Txt_PaidAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_PaidAmount.EditValue = "0";
            this.Txt_PaidAmount.Location = new System.Drawing.Point(4, 46);
            this.Txt_PaidAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_PaidAmount.Name = "Txt_PaidAmount";
            this.Txt_PaidAmount.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PaidAmount.Properties.Appearance.Options.UseFont = true;
            this.Txt_PaidAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_PaidAmount.Size = new System.Drawing.Size(258, 30);
            this.Txt_PaidAmount.TabIndex = 4;
            this.Txt_PaidAmount.TextChanged += new System.EventHandler(this.Txt_PaidAmount_TextChanged);
            // 
            // Txt_RemainPaymentAmount
            // 
            this.Txt_RemainPaymentAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_RemainPaymentAmount.EditValue = "0";
            this.Txt_RemainPaymentAmount.Location = new System.Drawing.Point(4, 86);
            this.Txt_RemainPaymentAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_RemainPaymentAmount.Name = "Txt_RemainPaymentAmount";
            this.Txt_RemainPaymentAmount.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_RemainPaymentAmount.Properties.Appearance.Options.UseFont = true;
            this.Txt_RemainPaymentAmount.Properties.ReadOnly = true;
            this.Txt_RemainPaymentAmount.Size = new System.Drawing.Size(258, 30);
            this.Txt_RemainPaymentAmount.TabIndex = 4;
            // 
            // Txt_TotalPriceAmount
            // 
            this.Txt_TotalPriceAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_TotalPriceAmount.EditValue = "0";
            this.Txt_TotalPriceAmount.Location = new System.Drawing.Point(4, 6);
            this.Txt_TotalPriceAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_TotalPriceAmount.Name = "Txt_TotalPriceAmount";
            this.Txt_TotalPriceAmount.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_TotalPriceAmount.Properties.Appearance.Options.UseFont = true;
            this.Txt_TotalPriceAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_TotalPriceAmount.Properties.ReadOnly = true;
            this.Txt_TotalPriceAmount.Size = new System.Drawing.Size(258, 30);
            this.Txt_TotalPriceAmount.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 108);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(794, 87);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.Lbl_Unit, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.Lbl_Delegate, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.ComboBox_Client, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.ComboBox_Unit, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(401, 6);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(389, 75);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Unit.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Unit.Appearance.Options.UseFont = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(303, 6);
            this.Lbl_Unit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(49, 24);
            this.Lbl_Unit.TabIndex = 0;
            this.Lbl_Unit.Text = "الوحدة";
            // 
            // Lbl_Delegate
            // 
            this.Lbl_Delegate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Delegate.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Delegate.Appearance.Options.UseFont = true;
            this.Lbl_Delegate.Location = new System.Drawing.Point(301, 43);
            this.Lbl_Delegate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_Delegate.Name = "Lbl_Delegate";
            this.Lbl_Delegate.Size = new System.Drawing.Size(54, 24);
            this.Lbl_Delegate.TabIndex = 0;
            this.Lbl_Delegate.Text = "العميل";
            // 
            // ComboBox_Client
            // 
            this.ComboBox_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_Client.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.ComboBox_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Client.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Client.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Client.Location = new System.Drawing.Point(4, 43);
            this.ComboBox_Client.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComboBox_Client.Name = "ComboBox_Client";
            this.ComboBox_Client.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComboBox_Client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Client.Size = new System.Drawing.Size(258, 26);
            this.ComboBox_Client.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Client.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Client.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Client.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Client.TabIndex = 1;
            this.ComboBox_Client.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Client_SelectedIndexChanged);
            this.ComboBox_Client.Leave += new System.EventHandler(this.ComboBox_Client_Leave);
            // 
            // ComboBox_Unit
            // 
            this.ComboBox_Unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_Unit.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.ComboBox_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Unit.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Unit.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Unit.Location = new System.Drawing.Point(4, 6);
            this.ComboBox_Unit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComboBox_Unit.Name = "ComboBox_Unit";
            this.ComboBox_Unit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComboBox_Unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Unit.Size = new System.Drawing.Size(258, 25);
            this.ComboBox_Unit.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Unit.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Unit.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Unit.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Unit.TabIndex = 1;
            this.ComboBox_Unit.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Unit_SelectedIndexChanged);
            this.ComboBox_Unit.Leave += new System.EventHandler(this.ComboBox_Unit_Leave);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.Btn_ShowUnitInfo, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.Btn_ShowClientInfo, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.Btn_AddClient, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.Btn_AddUnit, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(389, 75);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // Btn_ShowUnitInfo
            // 
            this.Btn_ShowUnitInfo.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_ShowUnitInfo.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_ShowUnitInfo.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ShowUnitInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_ShowUnitInfo.Appearance.Options.UseBackColor = true;
            this.Btn_ShowUnitInfo.Appearance.Options.UseFont = true;
            this.Btn_ShowUnitInfo.Appearance.Options.UseForeColor = true;
            this.Btn_ShowUnitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ShowUnitInfo.Location = new System.Drawing.Point(199, 6);
            this.Btn_ShowUnitInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ShowUnitInfo.Name = "Btn_ShowUnitInfo";
            this.Btn_ShowUnitInfo.Size = new System.Drawing.Size(186, 25);
            this.Btn_ShowUnitInfo.TabIndex = 2;
            this.Btn_ShowUnitInfo.Text = "عرض بيانات الوحدة";
            this.Btn_ShowUnitInfo.Click += new System.EventHandler(this.ShowUnitInfo_Btn_Click);
            // 
            // Btn_ShowClientInfo
            // 
            this.Btn_ShowClientInfo.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_ShowClientInfo.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_ShowClientInfo.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ShowClientInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_ShowClientInfo.Appearance.Options.UseBackColor = true;
            this.Btn_ShowClientInfo.Appearance.Options.UseFont = true;
            this.Btn_ShowClientInfo.Appearance.Options.UseForeColor = true;
            this.Btn_ShowClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ShowClientInfo.Location = new System.Drawing.Point(199, 43);
            this.Btn_ShowClientInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ShowClientInfo.Name = "Btn_ShowClientInfo";
            this.Btn_ShowClientInfo.Size = new System.Drawing.Size(186, 26);
            this.Btn_ShowClientInfo.TabIndex = 2;
            this.Btn_ShowClientInfo.Text = "عرض بيانات العميل";
            this.Btn_ShowClientInfo.Click += new System.EventHandler(this.ShowClientInfo_Btn_Click);
            // 
            // Btn_AddClient
            // 
            this.Btn_AddClient.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_AddClient.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_AddClient.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_AddClient.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_AddClient.Appearance.Options.UseBackColor = true;
            this.Btn_AddClient.Appearance.Options.UseFont = true;
            this.Btn_AddClient.Appearance.Options.UseForeColor = true;
            this.Btn_AddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddClient.Location = new System.Drawing.Point(4, 43);
            this.Btn_AddClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AddClient.Name = "Btn_AddClient";
            this.Btn_AddClient.Size = new System.Drawing.Size(187, 26);
            this.Btn_AddClient.TabIndex = 2;
            this.Btn_AddClient.Text = "إضافة عميل";
            this.Btn_AddClient.Click += new System.EventHandler(this.AddClient_Btn_Click);
            // 
            // Btn_AddUnit
            // 
            this.Btn_AddUnit.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_AddUnit.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Btn_AddUnit.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_AddUnit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_AddUnit.Appearance.Options.UseBackColor = true;
            this.Btn_AddUnit.Appearance.Options.UseFont = true;
            this.Btn_AddUnit.Appearance.Options.UseForeColor = true;
            this.Btn_AddUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddUnit.Location = new System.Drawing.Point(4, 6);
            this.Btn_AddUnit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AddUnit.Name = "Btn_AddUnit";
            this.Btn_AddUnit.Size = new System.Drawing.Size(187, 25);
            this.Btn_AddUnit.TabIndex = 2;
            this.Btn_AddUnit.Text = "إضافة وحدة";
            this.Btn_AddUnit.Click += new System.EventHandler(this.AddUnit_Btn_Click);
            // 
            // GrdControl_AddOrder
            // 
            this.GrdControl_AddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl_AddOrder.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GrdControl_AddOrder.Location = new System.Drawing.Point(3, 374);
            this.GrdControl_AddOrder.MainView = this.GridView_AddOrder;
            this.GrdControl_AddOrder.MenuManager = this.ribbon;
            this.GrdControl_AddOrder.Name = "GrdControl_AddOrder";
            this.GrdControl_AddOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.GrdControl_AddOrder.Size = new System.Drawing.Size(1378, 246);
            this.GrdControl_AddOrder.TabIndex = 1;
            this.GrdControl_AddOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_AddOrder});
            this.GrdControl_AddOrder.TextChanged += new System.EventHandler(this.GrdControl_AddOrder_TextChanged);
            // 
            // GridView_AddOrder
            // 
            this.GridView_AddOrder.ActiveFilterEnabled = false;
            this.GridView_AddOrder.Appearance.FixedLine.Font = new System.Drawing.Font("Tajawal Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView_AddOrder.Appearance.FixedLine.Options.UseFont = true;
            this.GridView_AddOrder.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_AddOrder.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView_AddOrder.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_AddOrder.Appearance.Row.Options.UseFont = true;
            this.GridView_AddOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColumn_ProductId,
            this.GrdColumn_CombinedId,
            this.GrdColumn_ProductName,
            this.GrdColumn_ProductQuantity,
            this.GrdColumn_UnitSell,
            this.GrdColumn_TotalPrice});
            this.GridView_AddOrder.GridControl = this.GrdControl_AddOrder;
            this.GridView_AddOrder.Name = "GridView_AddOrder";
            this.GridView_AddOrder.OptionsCustomization.AllowFilter = false;
            this.GridView_AddOrder.OptionsCustomization.AllowGroup = false;
            this.GridView_AddOrder.OptionsCustomization.AllowSort = false;
            this.GridView_AddOrder.OptionsFilter.AllowColumnMRUFilterList = false;
            this.GridView_AddOrder.OptionsFilter.AllowFilterEditor = false;
            this.GridView_AddOrder.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridView_AddOrder.OptionsFind.AllowFindPanel = false;
            this.GridView_AddOrder.OptionsFind.ShowSearchNavButtons = false;
            this.GridView_AddOrder.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridView_AddOrder.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridView_AddOrder.OptionsView.AllowHtmlDrawGroups = false;
            this.GridView_AddOrder.OptionsView.ShowFooter = true;
            this.GridView_AddOrder.OptionsView.ShowGroupPanel = false;
            this.GridView_AddOrder.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GridView_AddOrder_CustomSummaryCalculate);
            this.GridView_AddOrder.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView_AddOrder_CellValueChanged);
            this.GridView_AddOrder.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView_AddOrder_CellValueChanging);
            // 
            // GrdColumn_ProductId
            // 
            this.GrdColumn_ProductId.Caption = "رقم المنتج";
            this.GrdColumn_ProductId.Name = "GrdColumn_ProductId";
            this.GrdColumn_ProductId.OptionsColumn.ReadOnly = true;
            this.GrdColumn_ProductId.Visible = true;
            this.GrdColumn_ProductId.VisibleIndex = 0;
            // 
            // GrdColumn_CombinedId
            // 
            this.GrdColumn_CombinedId.Caption = "رقم المنتج المجمع";
            this.GrdColumn_CombinedId.Name = "GrdColumn_CombinedId";
            this.GrdColumn_CombinedId.Visible = true;
            this.GrdColumn_CombinedId.VisibleIndex = 1;
            // 
            // GrdColumn_ProductName
            // 
            this.GrdColumn_ProductName.Caption = "اسم الصنف";
            this.GrdColumn_ProductName.Name = "GrdColumn_ProductName";
            this.GrdColumn_ProductName.Visible = true;
            this.GrdColumn_ProductName.VisibleIndex = 2;
            // 
            // GrdColumn_ProductQuantity
            // 
            this.GrdColumn_ProductQuantity.Caption = "الكمية";
            this.GrdColumn_ProductQuantity.Name = "GrdColumn_ProductQuantity";
            this.GrdColumn_ProductQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.GrdColumn_ProductQuantity.Visible = true;
            this.GrdColumn_ProductQuantity.VisibleIndex = 3;
            // 
            // GrdColumn_UnitSell
            // 
            this.GrdColumn_UnitSell.Caption = "سعر الوحدة";
            this.GrdColumn_UnitSell.Name = "GrdColumn_UnitSell";
            this.GrdColumn_UnitSell.Visible = true;
            this.GrdColumn_UnitSell.VisibleIndex = 4;
            // 
            // GrdColumn_TotalPrice
            // 
            this.GrdColumn_TotalPrice.Caption = "السعر الاجمالي";
            this.GrdColumn_TotalPrice.Name = "GrdColumn_TotalPrice";
            this.GrdColumn_TotalPrice.Visible = true;
            this.GrdColumn_TotalPrice.VisibleIndex = 5;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FormAddOrder
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tajawal Black", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormAddOrder";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة طلب جديد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OrderNum.Properties)).EndInit();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NumOfVarieties.Properties)).EndInit();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Date.Properties)).EndInit();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).EndInit();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_OrderCategory)).EndInit();
            this.ClientSortLayout.ResumeLayout(false);
            this.ClientSortLayout.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_IsReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_PaymentState)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PaidAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RemainPaymentAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalPriceAmount.Properties)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Unit)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_AddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_AddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_SaveAndPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem Btn_ClearAll;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl Lbl_BillType;
        private System.Windows.Forms.TableLayoutPanel ClientSortLayout;
        private DevExpress.XtraEditors.LabelControl Lbl_ClientType;
        private System.Windows.Forms.RadioButton RadioButton_Unit;
        private System.Windows.Forms.RadioButton RadioButton_Client;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private DevExpress.XtraEditors.LabelControl Lbl_Delivery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private DevExpress.XtraEditors.LabelControl Lbl_Unit;
        private DevExpress.XtraEditors.LabelControl Lbl_Delegate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private DevExpress.XtraEditors.LabelControl Lbl_Date;
        private DevExpress.XtraEditors.TextEdit Txt_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private DevExpress.XtraEditors.LabelControl Lbl_Repayment;
        private DevExpress.XtraEditors.LabelControl Lbl_PaidOff;
        private DevExpress.XtraEditors.LabelControl Lbl_RestOfPayment;
        private DevExpress.XtraEditors.TextEdit Txt_RemainPaymentAmount;
        private DevExpress.XtraEditors.TextEdit Txt_PaidAmount;
        private DevExpress.XtraEditors.SimpleButton Btn_ShowUnitInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private DevExpress.XtraEditors.TextEdit Txt_OrderNum;
        private DevExpress.XtraEditors.LabelControl Lbl_OrderNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private DevExpress.XtraEditors.LabelControl Lbl_Quantity;
        private DevExpress.XtraEditors.LabelControl Lbl_TotoalPayment;
        
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_OrderCategory;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_IsReceived;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private DevExpress.XtraEditors.TextEdit Txt_NumOfVarieties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private DevExpress.XtraEditors.LabelControl Lbl_NumOfVarieties;
        private DevExpress.XtraEditors.TextEdit Txt_Quantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private DevExpress.XtraEditors.SimpleButton Btn_AddOrderItem;
        private DevExpress.XtraEditors.SimpleButton Btn_DelOrderItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private DevExpress.XtraEditors.LabelControl Lbl_Notes;
        private DevExpress.XtraEditors.TextEdit Txt_TotalPriceAmount;
        private System.Windows.Forms.TextBox Txtbx_OrderNotes;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_PaymentState;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Client;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Unit;
        private DevExpress.XtraEditors.SimpleButton Btn_ShowClientInfo;
        private DevExpress.XtraEditors.SimpleButton Btn_AddClient;
        private DevExpress.XtraEditors.SimpleButton Btn_AddUnit;
        private DevExpress.XtraGrid.GridControl GrdControl_AddOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_AddOrder;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductId;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_CombinedId;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_UnitSell;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_TotalPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}