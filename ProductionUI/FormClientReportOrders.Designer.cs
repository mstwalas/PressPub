namespace ProductionUI
{
    partial class FormClientReportOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientReportOrders));
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Combobox_Client = new Syncfusion.WinForms.ListView.SfComboBox();
            this.Lbl_Client = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_DateForm = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_DateTo = new DevExpress.XtraEditors.LabelControl();
            this.DateEdit_From = new DevExpress.XtraEditors.DateEdit();
            this.DateEdit_To = new DevExpress.XtraEditors.DateEdit();
            this.Btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_RemainPaymentAmount = new System.Windows.Forms.TextBox();
            this.Txt_PaymentAmount = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Btn_Searchaaa = new DevExpress.XtraBars.BarButtonItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_Client)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGrid_OrdersInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.533898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.4661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 441);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "خروج";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPage1.Text = "الطلبات لعميل";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Combobox_Client, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_Client, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(452, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Combobox_Client
            // 
            this.Combobox_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.Combobox_Client.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Combobox_Client.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_Client.Location = new System.Drawing.Point(3, 3);
            this.Combobox_Client.Name = "Combobox_Client";
            this.Combobox_Client.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Combobox_Client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Combobox_Client.Size = new System.Drawing.Size(367, 26);
            this.Combobox_Client.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_Client.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_Client.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Combobox_Client.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_Client.TabIndex = 3;
            this.Combobox_Client.SelectedIndexChanged += new System.EventHandler(this.Combobox_Client_SelectedIndexChanged);
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Client.Appearance.Options.UseFont = true;
            this.Lbl_Client.Appearance.Options.UseTextOptions = true;
            this.Lbl_Client.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_Client.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_Client.AppearanceDisabled.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Client.AppearanceDisabled.Options.UseFont = true;
            this.Lbl_Client.AppearanceHovered.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Client.AppearanceHovered.Options.UseFont = true;
            this.Lbl_Client.AppearancePressed.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Client.AppearancePressed.Options.UseFont = true;
            this.Lbl_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Client.Location = new System.Drawing.Point(376, 3);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(64, 26);
            this.Lbl_Client.TabIndex = 0;
            this.Lbl_Client.Text = "العميل";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Date, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_DateForm, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_DateTo, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.DateEdit_From, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.DateEdit_To, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Clear, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(443, 32);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Appearance.Options.UseTextOptions = true;
            this.Lbl_Date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_Date.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Date.Location = new System.Drawing.Point(386, 3);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(54, 26);
            this.Lbl_Date.TabIndex = 0;
            this.Lbl_Date.Text = "التاريخ";
            // 
            // Lbl_DateForm
            // 
            this.Lbl_DateForm.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_DateForm.Appearance.Options.UseFont = true;
            this.Lbl_DateForm.Appearance.Options.UseTextOptions = true;
            this.Lbl_DateForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_DateForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_DateForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_DateForm.Location = new System.Drawing.Point(356, 3);
            this.Lbl_DateForm.Name = "Lbl_DateForm";
            this.Lbl_DateForm.Size = new System.Drawing.Size(24, 26);
            this.Lbl_DateForm.TabIndex = 1;
            this.Lbl_DateForm.Text = "من";
            // 
            // Lbl_DateTo
            // 
            this.Lbl_DateTo.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_DateTo.Appearance.Options.UseFont = true;
            this.Lbl_DateTo.Appearance.Options.UseTextOptions = true;
            this.Lbl_DateTo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_DateTo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_DateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_DateTo.Location = new System.Drawing.Point(194, 3);
            this.Lbl_DateTo.Name = "Lbl_DateTo";
            this.Lbl_DateTo.Size = new System.Drawing.Size(24, 26);
            this.Lbl_DateTo.TabIndex = 2;
            this.Lbl_DateTo.Text = "إلى";
            // 
            // DateEdit_From
            // 
            this.DateEdit_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEdit_From.EditValue = null;
            this.DateEdit_From.Location = new System.Drawing.Point(224, 3);
            this.DateEdit_From.MenuManager = this.ribbon;
            this.DateEdit_From.Name = "DateEdit_From";
            this.DateEdit_From.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEdit_From.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_From.Properties.Appearance.Options.UseTextOptions = true;
            this.DateEdit_From.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateEdit_From.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DateEdit_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Size = new System.Drawing.Size(126, 30);
            this.DateEdit_From.TabIndex = 3;
            // 
            // DateEdit_To
            // 
            this.DateEdit_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEdit_To.EditValue = null;
            this.DateEdit_To.Location = new System.Drawing.Point(62, 3);
            this.DateEdit_To.MenuManager = this.ribbon;
            this.DateEdit_To.Name = "DateEdit_To";
            this.DateEdit_To.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEdit_To.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_To.Properties.Appearance.Options.UseTextOptions = true;
            this.DateEdit_To.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateEdit_To.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DateEdit_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_To.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_To.Size = new System.Drawing.Size(126, 30);
            this.DateEdit_To.TabIndex = 4;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.AllowFocus = false;
            this.Btn_Clear.Appearance.Options.UseTextOptions = true;
            this.Btn_Clear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Clear.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Clear.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Clear.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.Btn_Clear.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Clear.AppearanceHovered.Options.UseBackColor = true;
            this.Btn_Clear.AppearanceHovered.Options.UseBorderColor = true;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Clear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Btn_Clear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Clear.ImageOptions.SvgImage")));
            this.Btn_Clear.Location = new System.Drawing.Point(3, 3);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Clear.Size = new System.Drawing.Size(53, 26);
            this.Btn_Clear.TabIndex = 5;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
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
            // 
            // FormClientReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormClientReportOrders";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الطلبات لعميل";
            this.Load += new System.EventHandler(this.FormClientReportOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_Client)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_To.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl Lbl_Client;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl Lbl_Date;
        private DevExpress.XtraEditors.LabelControl Lbl_DateForm;
        private DevExpress.XtraEditors.LabelControl Lbl_DateTo;
        private DevExpress.XtraEditors.DateEdit DateEdit_From;
        private DevExpress.XtraEditors.DateEdit DateEdit_To;
        private Syncfusion.WinForms.ListView.SfComboBox Combobox_Client;
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
        private DevExpress.XtraEditors.SimpleButton Btn_Clear;
    }
}