namespace ProductionUI
{
    partial class FormReportOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportOrders));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGrid_OrdersInfo = new DevExpress.XtraGrid.GridControl();
            this.GridView_Order = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_PrintReport = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Search = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_RemainPaymentAmount = new System.Windows.Forms.TextBox();
            this.Txt_PaymentAmount = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DateEdit_To = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.DateEdit_From = new DevExpress.XtraEditors.DateEdit();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Btn_Searchaaa = new DevExpress.XtraBars.BarButtonItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.DataGrid_OrdersInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.533898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.4661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // DataGrid_OrdersInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DataGrid_OrdersInfo, 2);
            this.DataGrid_OrdersInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_OrdersInfo.Location = new System.Drawing.Point(3, 41);
            this.DataGrid_OrdersInfo.MainView = this.GridView_Order;
            this.DataGrid_OrdersInfo.MenuManager = this.ribbon;
            this.DataGrid_OrdersInfo.Name = "DataGrid_OrdersInfo";
            this.DataGrid_OrdersInfo.Size = new System.Drawing.Size(892, 356);
            this.DataGrid_OrdersInfo.TabIndex = 2;
            this.DataGrid_OrdersInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Order});
            this.DataGrid_OrdersInfo.Click += new System.EventHandler(this.DataGrid_OrdersInfo_Click);
            this.DataGrid_OrdersInfo.DoubleClick += new System.EventHandler(this.DataGrid_OrdersInfo_DoubleClick);
            // 
            // GridView_Order
            // 
            this.GridView_Order.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Order.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView_Order.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Order.Appearance.Row.Options.UseFont = true;
            this.GridView_Order.GridControl = this.DataGrid_OrdersInfo;
            this.GridView_Order.Name = "GridView_Order";
            this.GridView_Order.OptionsBehavior.Editable = false;
            this.GridView_Order.OptionsCustomization.AllowFilter = false;
            this.GridView_Order.OptionsFind.AllowFindPanel = false;
            this.GridView_Order.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridView_Order.OptionsView.ShowGroupPanel = false;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.BtnExit,
            this.Btn_PrintReport,
            this.Btn_Search});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon.Size = new System.Drawing.Size(898, 164);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "خروج";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Caption = "خروج";
            this.BtnExit.Id = 3;
            this.BtnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExit.ImageOptions.SvgImage")));
            this.BtnExit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ItemAppearance.Disabled.Options.UseFont = true;
            this.BtnExit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ItemAppearance.Hovered.Options.UseFont = true;
            this.BtnExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnExit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ItemAppearance.Pressed.Options.UseFont = true;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExit_ItemClick);
            // 
            // Btn_PrintReport
            // 
            this.Btn_PrintReport.Caption = "طباعه التقرير";
            this.Btn_PrintReport.Id = 4;
            this.Btn_PrintReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_PrintReport.ImageOptions.SvgImage")));
            this.Btn_PrintReport.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_PrintReport.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_PrintReport.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_PrintReport.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_PrintReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_PrintReport.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_PrintReport.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_PrintReport.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_PrintReport.Name = "Btn_PrintReport";
            this.Btn_PrintReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_PrintReport_ItemClick);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Caption = "بحث";
            this.Btn_Search.Id = 5;
            this.Btn_Search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Search.ImageOptions.SvgImage")));
            this.Btn_Search.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Search.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Search.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Search.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Search_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "تقرير الطلبات";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_Search);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Btn_PrintReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnExit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel4.Controls.Add(this.Txt_RemainPaymentAmount, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.Txt_PaymentAmount, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelControl5, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelControl3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Txt_Total, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(892, 35);
            this.tableLayoutPanel4.TabIndex = 3;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // Txt_RemainPaymentAmount
            // 
            this.Txt_RemainPaymentAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_RemainPaymentAmount.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_RemainPaymentAmount.Location = new System.Drawing.Point(3, 3);
            this.Txt_RemainPaymentAmount.Name = "Txt_RemainPaymentAmount";
            this.Txt_RemainPaymentAmount.ReadOnly = true;
            this.Txt_RemainPaymentAmount.Size = new System.Drawing.Size(183, 31);
            this.Txt_RemainPaymentAmount.TabIndex = 8;
            this.Txt_RemainPaymentAmount.Text = "0";
            this.Txt_RemainPaymentAmount.TextChanged += new System.EventHandler(this.Txt_RemainPaymentAmount_TextChanged);
            // 
            // Txt_PaymentAmount
            // 
            this.Txt_PaymentAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_PaymentAmount.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PaymentAmount.Location = new System.Drawing.Point(303, 3);
            this.Txt_PaymentAmount.Name = "Txt_PaymentAmount";
            this.Txt_PaymentAmount.ReadOnly = true;
            this.Txt_PaymentAmount.Size = new System.Drawing.Size(179, 31);
            this.Txt_PaymentAmount.TabIndex = 7;
            this.Txt_PaymentAmount.Text = "0";
            this.Txt_PaymentAmount.TextChanged += new System.EventHandler(this.Txt_PaymentAmount_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(192, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 29);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "المتبقى";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(488, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 29);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "المدفوع";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(784, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "المبلغ الإجمالى";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // Txt_Total
            // 
            this.Txt_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Total.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Total.Location = new System.Drawing.Point(599, 3);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(179, 31);
            this.Txt_Total.TabIndex = 6;
            this.Txt_Total.Text = "0";
            this.Txt_Total.TextChanged += new System.EventHandler(this.Txt_Total_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DateEdit_To, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DateEdit_From, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 32);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // DateEdit_To
            // 
            this.DateEdit_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEdit_To.EditValue = null;
            this.DateEdit_To.Location = new System.Drawing.Point(3, 3);
            this.DateEdit_To.MenuManager = this.ribbon;
            this.DateEdit_To.Name = "DateEdit_To";
            this.DateEdit_To.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEdit_To.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_To.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_To.Size = new System.Drawing.Size(352, 30);
            this.DateEdit_To.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(361, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 26);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "إلى";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(768, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 26);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "من";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(818, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "التاريخ";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // DateEdit_From
            // 
            this.DateEdit_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEdit_From.EditValue = null;
            this.DateEdit_From.Location = new System.Drawing.Point(411, 3);
            this.DateEdit_From.MenuManager = this.ribbon;
            this.DateEdit_From.Name = "DateEdit_From";
            this.DateEdit_From.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEdit_From.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Size = new System.Drawing.Size(351, 30);
            this.DateEdit_From.TabIndex = 2;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Btn_Searchaaa
            // 
            this.Btn_Searchaaa.Caption = "بحث";
            this.Btn_Searchaaa.Id = 2;
            this.Btn_Searchaaa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Searchaaa.ImageOptions.SvgImage")));
            this.Btn_Searchaaa.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Searchaaa.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Searchaaa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Searchaaa.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Searchaaa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Searchaaa.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Searchaaa.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Searchaaa.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Searchaaa.Name = "Btn_Searchaaa";
            this.Btn_Searchaaa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Searchaaa_ItemClick);
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormReportOrders";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الطلبات ";
            this.Load += new System.EventHandler(this.FormReportOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraBars.BarButtonItem Btn_PrintReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl DataGrid_OrdersInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Order;
        private DevExpress.XtraBars.BarButtonItem Btn_Search;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Searchaaa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Txt_RemainPaymentAmount;
        private System.Windows.Forms.TextBox Txt_PaymentAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit DateEdit_From;
        private DevExpress.XtraEditors.DateEdit DateEdit_To;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}