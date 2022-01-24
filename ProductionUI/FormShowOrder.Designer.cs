namespace ProductionUI
{
    partial class FormShowOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowOrder));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Close = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Print = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridControl_ShowOrder = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColumn_ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_CombinedId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_UnitSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_BillType = new System.Windows.Forms.TextBox();
            this.Txt_RestOfPayment = new System.Windows.Forms.TextBox();
            this.Txt_TotalPayment = new System.Windows.Forms.TextBox();
            this.Lbl_BillType = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_RestOfPayment = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PaidOff = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TotalPayment = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ClientType = new System.Windows.Forms.TextBox();
            this.Lbl_ClientType = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Unit = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Unit = new System.Windows.Forms.TextBox();
            this.Lbl_Client = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Client = new System.Windows.Forms.TextBox();
            this.Lbl_Delivary = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Delivary = new System.Windows.Forms.TextBox();
            this.Txt_PaymentState = new System.Windows.Forms.TextBox();
            this.Lbl_Payment = new DevExpress.XtraEditors.LabelControl();
            this.Btn_ClientInfo = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_UnitInfo = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_PaidOff = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_NumOfOrder = new System.Windows.Forms.TextBox();
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.Txt_Quantity = new System.Windows.Forms.TextBox();
            this.Txt_NumOfVarieties = new System.Windows.Forms.TextBox();
            this.Lbl_OrderNumber = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_NumOfVarieties = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Quantity = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.Lbl_Notes = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_BillNumber = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_BillNUmber = new DevExpress.XtraEditors.TextEdit();
            this.chckedit_SpecialBill = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_ShowOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BillNUmber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckedit_SpecialBill.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Close,
            this.Btn_Print});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon.Size = new System.Drawing.Size(1070, 164);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Caption = "خروج";
            this.Btn_Close.Id = 1;
            this.Btn_Close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Close.ImageOptions.SvgImage")));
            this.Btn_Close.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Close.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Close.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Close.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Close_ItemClick);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Caption = "طباعه";
            this.Btn_Print.Id = 2;
            this.Btn_Print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Print.ImageOptions.SvgImage")));
            this.Btn_Print.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Print.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Print.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Print.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Print_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "عرض طلب";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Print);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Close);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GridControl_ShowOrder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 499);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // GridControl_ShowOrder
            // 
            this.GridControl_ShowOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl_ShowOrder.Location = new System.Drawing.Point(3, 280);
            this.GridControl_ShowOrder.MainView = this.gridView1;
            this.GridControl_ShowOrder.MenuManager = this.ribbon;
            this.GridControl_ShowOrder.Name = "GridControl_ShowOrder";
            this.GridControl_ShowOrder.Size = new System.Drawing.Size(1064, 216);
            this.GridControl_ShowOrder.TabIndex = 3;
            this.GridControl_ShowOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColumn_ProductId,
            this.GrdColumn_CombinedId,
            this.GrdColumn_ProductName,
            this.GrdColumn_ProductQuantity,
            this.GrdColumn_UnitSell,
            this.GrdColumn_TotalPrice});
            this.gridView1.GridControl = this.GridControl_ShowOrder;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // GrdColumn_ProductId
            // 
            this.GrdColumn_ProductId.Caption = "رقم المنتج";
            this.GrdColumn_ProductId.Name = "GrdColumn_ProductId";
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
            this.GrdColumn_TotalPrice.Caption = "السعر الاجمالى";
            this.GrdColumn_TotalPrice.Name = "GrdColumn_TotalPrice";
            this.GrdColumn_TotalPrice.Visible = true;
            this.GrdColumn_TotalPrice.VisibleIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.08475F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.91525F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1064, 231);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.tableLayoutPanel3.Controls.Add(this.Txt_BillType, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Txt_RestOfPayment, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.Txt_TotalPayment, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_BillType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_RestOfPayment, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_PaidOff, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_TotalPayment, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.Txt_ClientType, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_ClientType, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Unit, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Txt_Unit, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Client, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Txt_Client, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Delivary, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Txt_Delivary, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Txt_PaymentState, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Payment, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Btn_ClientInfo, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.Btn_UnitInfo, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Txt_PaidOff, 3, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(481, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(580, 225);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Txt_BillType
            // 
            this.Txt_BillType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BillType.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_BillType.Location = new System.Drawing.Point(242, 3);
            this.Txt_BillType.Name = "Txt_BillType";
            this.Txt_BillType.ReadOnly = true;
            this.Txt_BillType.Size = new System.Drawing.Size(235, 31);
            this.Txt_BillType.TabIndex = 0;
            // 
            // Txt_RestOfPayment
            // 
            this.Txt_RestOfPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_RestOfPayment.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_RestOfPayment.Location = new System.Drawing.Point(3, 188);
            this.Txt_RestOfPayment.Name = "Txt_RestOfPayment";
            this.Txt_RestOfPayment.ReadOnly = true;
            this.Txt_RestOfPayment.Size = new System.Drawing.Size(125, 31);
            this.Txt_RestOfPayment.TabIndex = 0;
            // 
            // Txt_TotalPayment
            // 
            this.Txt_TotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_TotalPayment.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_TotalPayment.Location = new System.Drawing.Point(3, 114);
            this.Txt_TotalPayment.Name = "Txt_TotalPayment";
            this.Txt_TotalPayment.ReadOnly = true;
            this.Txt_TotalPayment.Size = new System.Drawing.Size(125, 31);
            this.Txt_TotalPayment.TabIndex = 0;
            // 
            // Lbl_BillType
            // 
            this.Lbl_BillType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_BillType.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_BillType.Appearance.Options.UseFont = true;
            this.Lbl_BillType.Location = new System.Drawing.Point(483, 3);
            this.Lbl_BillType.Name = "Lbl_BillType";
            this.Lbl_BillType.Size = new System.Drawing.Size(83, 24);
            this.Lbl_BillType.TabIndex = 2;
            this.Lbl_BillType.Text = "نوع الفاتورة";
            this.Lbl_BillType.Click += new System.EventHandler(this.LabelControl1_Click);
            // 
            // Lbl_RestOfPayment
            // 
            this.Lbl_RestOfPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_RestOfPayment.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_RestOfPayment.Appearance.Options.UseFont = true;
            this.Lbl_RestOfPayment.Location = new System.Drawing.Point(134, 188);
            this.Lbl_RestOfPayment.Name = "Lbl_RestOfPayment";
            this.Lbl_RestOfPayment.Size = new System.Drawing.Size(42, 24);
            this.Lbl_RestOfPayment.TabIndex = 2;
            this.Lbl_RestOfPayment.Text = "الباقى";
            // 
            // Lbl_PaidOff
            // 
            this.Lbl_PaidOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PaidOff.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_PaidOff.Appearance.Options.UseFont = true;
            this.Lbl_PaidOff.Location = new System.Drawing.Point(134, 151);
            this.Lbl_PaidOff.Name = "Lbl_PaidOff";
            this.Lbl_PaidOff.Size = new System.Drawing.Size(103, 24);
            this.Lbl_PaidOff.TabIndex = 2;
            this.Lbl_PaidOff.Text = "المبلغ المسدد";
            // 
            // Lbl_TotalPayment
            // 
            this.Lbl_TotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TotalPayment.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_TotalPayment.Appearance.Options.UseFont = true;
            this.Lbl_TotalPayment.Location = new System.Drawing.Point(134, 114);
            this.Lbl_TotalPayment.Name = "Lbl_TotalPayment";
            this.Lbl_TotalPayment.Size = new System.Drawing.Size(95, 24);
            this.Lbl_TotalPayment.TabIndex = 2;
            this.Lbl_TotalPayment.Text = "اجمالى المبلغ";
            // 
            // Txt_ClientType
            // 
            this.Txt_ClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ClientType.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ClientType.Location = new System.Drawing.Point(3, 3);
            this.Txt_ClientType.Name = "Txt_ClientType";
            this.Txt_ClientType.ReadOnly = true;
            this.Txt_ClientType.Size = new System.Drawing.Size(125, 31);
            this.Txt_ClientType.TabIndex = 0;
            // 
            // Lbl_ClientType
            // 
            this.Lbl_ClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ClientType.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClientType.Appearance.Options.UseFont = true;
            this.Lbl_ClientType.Location = new System.Drawing.Point(134, 3);
            this.Lbl_ClientType.Name = "Lbl_ClientType";
            this.Lbl_ClientType.Size = new System.Drawing.Size(78, 24);
            this.Lbl_ClientType.TabIndex = 2;
            this.Lbl_ClientType.Text = "نوع العميل";
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Unit.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Unit.Appearance.Options.UseFont = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(483, 40);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(46, 24);
            this.Lbl_Unit.TabIndex = 2;
            this.Lbl_Unit.Text = "الوحدة";
            this.Lbl_Unit.Click += new System.EventHandler(this.LabelControl3_Click);
            // 
            // Txt_Unit
            // 
            this.Txt_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Unit.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Unit.Location = new System.Drawing.Point(242, 40);
            this.Txt_Unit.Name = "Txt_Unit";
            this.Txt_Unit.ReadOnly = true;
            this.Txt_Unit.Size = new System.Drawing.Size(235, 31);
            this.Txt_Unit.TabIndex = 0;
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Client.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Client.Appearance.Options.UseFont = true;
            this.Lbl_Client.Location = new System.Drawing.Point(483, 77);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(50, 24);
            this.Lbl_Client.TabIndex = 2;
            this.Lbl_Client.Text = "العميل";
            // 
            // Txt_Client
            // 
            this.Txt_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Client.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Client.Location = new System.Drawing.Point(242, 77);
            this.Txt_Client.Name = "Txt_Client";
            this.Txt_Client.ReadOnly = true;
            this.Txt_Client.Size = new System.Drawing.Size(235, 31);
            this.Txt_Client.TabIndex = 0;
            // 
            // Lbl_Delivary
            // 
            this.Lbl_Delivary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Delivary.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Delivary.Appearance.Options.UseFont = true;
            this.Lbl_Delivary.Location = new System.Drawing.Point(483, 114);
            this.Lbl_Delivary.Name = "Lbl_Delivary";
            this.Lbl_Delivary.Size = new System.Drawing.Size(56, 24);
            this.Lbl_Delivary.TabIndex = 2;
            this.Lbl_Delivary.Text = "التسليم";
            // 
            // Txt_Delivary
            // 
            this.Txt_Delivary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Delivary.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Delivary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Delivary.Location = new System.Drawing.Point(242, 114);
            this.Txt_Delivary.Name = "Txt_Delivary";
            this.Txt_Delivary.ReadOnly = true;
            this.Txt_Delivary.Size = new System.Drawing.Size(235, 31);
            this.Txt_Delivary.TabIndex = 0;
            // 
            // Txt_PaymentState
            // 
            this.Txt_PaymentState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_PaymentState.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PaymentState.Location = new System.Drawing.Point(242, 151);
            this.Txt_PaymentState.Name = "Txt_PaymentState";
            this.Txt_PaymentState.ReadOnly = true;
            this.Txt_PaymentState.Size = new System.Drawing.Size(235, 31);
            this.Txt_PaymentState.TabIndex = 0;
            // 
            // Lbl_Payment
            // 
            this.Lbl_Payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Payment.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Payment.Appearance.Options.UseFont = true;
            this.Lbl_Payment.Location = new System.Drawing.Point(483, 151);
            this.Lbl_Payment.Name = "Lbl_Payment";
            this.Lbl_Payment.Size = new System.Drawing.Size(49, 24);
            this.Lbl_Payment.TabIndex = 2;
            this.Lbl_Payment.Text = "السداد";
            // 
            // Btn_ClientInfo
            // 
            this.Btn_ClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClientInfo.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ClientInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_ClientInfo.Appearance.Options.UseFont = true;
            this.Btn_ClientInfo.Appearance.Options.UseForeColor = true;
            this.tableLayoutPanel3.SetColumnSpan(this.Btn_ClientInfo, 2);
            this.Btn_ClientInfo.Location = new System.Drawing.Point(3, 77);
            this.Btn_ClientInfo.Name = "Btn_ClientInfo";
            this.Btn_ClientInfo.Size = new System.Drawing.Size(233, 28);
            this.Btn_ClientInfo.TabIndex = 1;
            this.Btn_ClientInfo.Text = "عرض بيانات العميل";
            // 
            // Btn_UnitInfo
            // 
            this.Btn_UnitInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_UnitInfo.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_UnitInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_UnitInfo.Appearance.Options.UseFont = true;
            this.Btn_UnitInfo.Appearance.Options.UseForeColor = true;
            this.tableLayoutPanel3.SetColumnSpan(this.Btn_UnitInfo, 2);
            this.Btn_UnitInfo.Location = new System.Drawing.Point(3, 40);
            this.Btn_UnitInfo.Name = "Btn_UnitInfo";
            this.Btn_UnitInfo.Size = new System.Drawing.Size(233, 30);
            this.Btn_UnitInfo.TabIndex = 1;
            this.Btn_UnitInfo.Text = "عرض بيانات الوحدة";
            this.Btn_UnitInfo.Click += new System.EventHandler(this.Btn_UnitInfo_Click);
            // 
            // Txt_PaidOff
            // 
            this.Txt_PaidOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_PaidOff.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PaidOff.Location = new System.Drawing.Point(3, 151);
            this.Txt_PaidOff.Name = "Txt_PaidOff";
            this.Txt_PaidOff.ReadOnly = true;
            this.Txt_PaidOff.Size = new System.Drawing.Size(125, 31);
            this.Txt_PaidOff.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.28692F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.71308F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 225);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Txt_NumOfOrder, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Txt_Date, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.Txt_Quantity, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.Txt_NumOfVarieties, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.Lbl_OrderNumber, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Lbl_NumOfVarieties, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Lbl_Quantity, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.Lbl_Date, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(466, 75);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Txt_NumOfOrder
            // 
            this.Txt_NumOfOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NumOfOrder.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NumOfOrder.Location = new System.Drawing.Point(236, 3);
            this.Txt_NumOfOrder.Name = "Txt_NumOfOrder";
            this.Txt_NumOfOrder.ReadOnly = true;
            this.Txt_NumOfOrder.Size = new System.Drawing.Size(127, 31);
            this.Txt_NumOfOrder.TabIndex = 0;
            // 
            // Txt_Date
            // 
            this.Txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Date.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Date.Location = new System.Drawing.Point(3, 3);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.ReadOnly = true;
            this.Txt_Date.Size = new System.Drawing.Size(127, 31);
            this.Txt_Date.TabIndex = 0;
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Quantity.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Quantity.Location = new System.Drawing.Point(3, 40);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.ReadOnly = true;
            this.Txt_Quantity.Size = new System.Drawing.Size(127, 31);
            this.Txt_Quantity.TabIndex = 0;
            // 
            // Txt_NumOfVarieties
            // 
            this.Txt_NumOfVarieties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NumOfVarieties.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NumOfVarieties.Location = new System.Drawing.Point(236, 40);
            this.Txt_NumOfVarieties.Name = "Txt_NumOfVarieties";
            this.Txt_NumOfVarieties.ReadOnly = true;
            this.Txt_NumOfVarieties.Size = new System.Drawing.Size(127, 31);
            this.Txt_NumOfVarieties.TabIndex = 0;
            // 
            // Lbl_OrderNumber
            // 
            this.Lbl_OrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_OrderNumber.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_OrderNumber.Appearance.Options.UseFont = true;
            this.Lbl_OrderNumber.Location = new System.Drawing.Point(369, 3);
            this.Lbl_OrderNumber.Name = "Lbl_OrderNumber";
            this.Lbl_OrderNumber.Size = new System.Drawing.Size(75, 24);
            this.Lbl_OrderNumber.TabIndex = 2;
            this.Lbl_OrderNumber.Text = "رقم الطلب";
            // 
            // Lbl_NumOfVarieties
            // 
            this.Lbl_NumOfVarieties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NumOfVarieties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_NumOfVarieties.Appearance.Options.UseFont = true;
            this.Lbl_NumOfVarieties.Location = new System.Drawing.Point(369, 40);
            this.Lbl_NumOfVarieties.Name = "Lbl_NumOfVarieties";
            this.Lbl_NumOfVarieties.Size = new System.Drawing.Size(90, 24);
            this.Lbl_NumOfVarieties.TabIndex = 2;
            this.Lbl_NumOfVarieties.Text = "عدد الأصناف";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Quantity.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Quantity.Appearance.Options.UseFont = true;
            this.Lbl_Quantity.Location = new System.Drawing.Point(136, 40);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(45, 24);
            this.Lbl_Quantity.TabIndex = 2;
            this.Lbl_Quantity.Text = "الكمية";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(136, 3);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(46, 24);
            this.Lbl_Date.TabIndex = 2;
            this.Lbl_Date.Text = "التاريخ";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.Txt_Notes, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.Lbl_Notes, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(466, 138);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Notes.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Notes.Location = new System.Drawing.Point(3, 3);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.ReadOnly = true;
            this.Txt_Notes.Size = new System.Drawing.Size(360, 132);
            this.Txt_Notes.TabIndex = 4;
            // 
            // Lbl_Notes
            // 
            this.Lbl_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Notes.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Notes.Appearance.Options.UseFont = true;
            this.Lbl_Notes.Location = new System.Drawing.Point(369, 3);
            this.Lbl_Notes.Name = "Lbl_Notes";
            this.Lbl_Notes.Size = new System.Drawing.Size(64, 24);
            this.Lbl_Notes.TabIndex = 2;
            this.Lbl_Notes.Text = "ملاحظات";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel7.Controls.Add(this.Lbl_BillNumber, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Btn_Search, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.Txt_BillNUmber, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.chckedit_SpecialBill, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1064, 34);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // Lbl_BillNumber
            // 
            this.Lbl_BillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_BillNumber.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_BillNumber.Appearance.Options.UseFont = true;
            this.Lbl_BillNumber.Location = new System.Drawing.Point(967, 3);
            this.Lbl_BillNumber.Name = "Lbl_BillNumber";
            this.Lbl_BillNumber.Size = new System.Drawing.Size(85, 24);
            this.Lbl_BillNumber.TabIndex = 2;
            this.Lbl_BillNumber.Text = "رقم الفاتورة";
            this.Lbl_BillNumber.Click += new System.EventHandler(this.LabelControl1_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.Btn_Search.Appearance.Options.UseFont = true;
            this.Btn_Search.Appearance.Options.UseForeColor = true;
            this.Btn_Search.Location = new System.Drawing.Point(3, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(444, 27);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "بحث";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_BillNUmber
            // 
            this.Txt_BillNUmber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_BillNUmber.Location = new System.Drawing.Point(573, 3);
            this.Txt_BillNUmber.MenuManager = this.ribbon;
            this.Txt_BillNUmber.Name = "Txt_BillNUmber";
            this.Txt_BillNUmber.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_BillNUmber.Properties.Appearance.Options.UseFont = true;
            this.Txt_BillNUmber.Size = new System.Drawing.Size(388, 30);
            this.Txt_BillNUmber.TabIndex = 3;
            this.Txt_BillNUmber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BillNUmber_KeyDown);
            // 
            // chckedit_SpecialBill
            // 
            this.chckedit_SpecialBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chckedit_SpecialBill.Location = new System.Drawing.Point(453, 3);
            this.chckedit_SpecialBill.MenuManager = this.ribbon;
            this.chckedit_SpecialBill.Name = "chckedit_SpecialBill";
            this.chckedit_SpecialBill.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.chckedit_SpecialBill.Properties.Appearance.Options.UseFont = true;
            this.chckedit_SpecialBill.Properties.Caption = "فاتورة خاصه";
            this.chckedit_SpecialBill.Size = new System.Drawing.Size(114, 28);
            this.chckedit_SpecialBill.TabIndex = 4;
            // 
            // FormShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(919, 576);
            this.Name = "FormShowOrder";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض طلب";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_ShowOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BillNUmber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckedit_SpecialBill.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Txt_BillType;
        private System.Windows.Forms.TextBox Txt_ClientType;
        private System.Windows.Forms.TextBox Txt_Unit;
        private System.Windows.Forms.TextBox Txt_Client;
        private System.Windows.Forms.TextBox Txt_Delivary;
        private System.Windows.Forms.TextBox Txt_PaymentState;
        private System.Windows.Forms.TextBox Txt_RestOfPayment;
        private System.Windows.Forms.TextBox Txt_PaidOff;
        private System.Windows.Forms.TextBox Txt_TotalPayment;
        private DevExpress.XtraEditors.SimpleButton Btn_ClientInfo;
        private DevExpress.XtraEditors.SimpleButton Btn_UnitInfo;
        private DevExpress.XtraEditors.LabelControl Lbl_BillType;
        private DevExpress.XtraEditors.LabelControl Lbl_ClientType;
        private DevExpress.XtraEditors.LabelControl Lbl_Unit;
        private DevExpress.XtraEditors.LabelControl Lbl_Client;
        private DevExpress.XtraEditors.LabelControl Lbl_Delivary;
        private DevExpress.XtraEditors.LabelControl Lbl_Payment;
        private DevExpress.XtraEditors.LabelControl Lbl_RestOfPayment;
        private DevExpress.XtraEditors.LabelControl Lbl_PaidOff;
        private DevExpress.XtraEditors.LabelControl Lbl_TotalPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox Txt_NumOfOrder;
        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.TextBox Txt_Quantity;
        private System.Windows.Forms.TextBox Txt_NumOfVarieties;
        private DevExpress.XtraEditors.LabelControl Lbl_OrderNumber;
        private DevExpress.XtraEditors.LabelControl Lbl_NumOfVarieties;
        private DevExpress.XtraEditors.LabelControl Lbl_Quantity;
        private DevExpress.XtraEditors.LabelControl Lbl_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.LabelControl Lbl_Notes;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.LabelControl Lbl_BillNumber;
        private DevExpress.XtraEditors.SimpleButton Btn_Search;
        private DevExpress.XtraGrid.GridControl GridControl_ShowOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductId;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_CombinedId;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_UnitSell;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_TotalPrice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Close;
        private DevExpress.XtraBars.BarButtonItem Btn_Print;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.TextEdit Txt_BillNUmber;
        private DevExpress.XtraEditors.CheckEdit chckedit_SpecialBill;
    }
}