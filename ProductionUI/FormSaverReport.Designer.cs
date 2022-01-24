
namespace ProductionUI
{
    partial class FormSaverReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaverReport));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPrintReport = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateEditTo = new DevExpress.XtraEditors.DateEdit();
            this.DateEdit_From = new DevExpress.XtraEditors.DateEdit();
            this.DataGridOrders = new DevExpress.XtraGrid.GridControl();
            this.GridView_Order = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LblDate = new DevExpress.XtraEditors.LabelControl();
            this.labelFrom = new DevExpress.XtraEditors.LabelControl();
            this.LblTo = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblPayment = new DevExpress.XtraEditors.LabelControl();
            this.TxtEdit_Payments = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEdit_Payments.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnSearch,
            this.BtnPrintReport,
            this.BtnExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(898, 164);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Caption = "بحث";
            this.BtnSearch.Id = 1;
            this.BtnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSearch.ImageOptions.SvgImage")));
            this.BtnSearch.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ItemAppearance.Disabled.Options.UseFont = true;
            this.BtnSearch.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ItemAppearance.Hovered.Options.UseFont = true;
            this.BtnSearch.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnSearch.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ItemAppearance.Pressed.Options.UseFont = true;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSearch_ItemClick);
            // 
            // BtnPrintReport
            // 
            this.BtnPrintReport.Caption = "طباعة التقرير";
            this.BtnPrintReport.Id = 2;
            this.BtnPrintReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPrintReport.ImageOptions.SvgImage")));
            this.BtnPrintReport.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnPrintReport.ItemAppearance.Disabled.Options.UseFont = true;
            this.BtnPrintReport.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnPrintReport.ItemAppearance.Hovered.Options.UseFont = true;
            this.BtnPrintReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnPrintReport.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPrintReport.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnPrintReport.ItemAppearance.Pressed.Options.UseFont = true;
            this.BtnPrintReport.Name = "BtnPrintReport";
            this.BtnPrintReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPrintReport_ItemClick);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "تقرير الخزينة";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSearch);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnPrintReport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnExit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DateEditTo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateEdit_From, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataGridOrders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DateEditTo
            // 
            this.DateEditTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEditTo.EditValue = null;
            this.DateEditTo.Location = new System.Drawing.Point(3, 3);
            this.DateEditTo.MenuManager = this.ribbon;
            this.DateEditTo.Name = "DateEditTo";
            this.DateEditTo.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEditTo.Properties.Appearance.Options.UseFont = true;
            this.DateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditTo.Size = new System.Drawing.Size(364, 30);
            this.DateEditTo.TabIndex = 12;
            // 
            // DateEdit_From
            // 
            this.DateEdit_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEdit_From.EditValue = null;
            this.DateEdit_From.Location = new System.Drawing.Point(423, 3);
            this.DateEdit_From.MenuManager = this.ribbon;
            this.DateEdit_From.Name = "DateEdit_From";
            this.DateEdit_From.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.DateEdit_From.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_From.Size = new System.Drawing.Size(363, 30);
            this.DateEdit_From.TabIndex = 11;
            // 
            // DataGridOrders
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridOrders, 5);
            this.DataGridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridOrders.Location = new System.Drawing.Point(3, 38);
            this.DataGridOrders.MainView = this.GridView_Order;
            this.DataGridOrders.MenuManager = this.ribbon;
            this.DataGridOrders.Name = "DataGridOrders";
            this.DataGridOrders.Size = new System.Drawing.Size(892, 365);
            this.DataGridOrders.TabIndex = 10;
            this.DataGridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Order});
            // 
            // GridView_Order
            // 
            this.GridView_Order.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Order.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView_Order.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Order.Appearance.Row.Options.UseFont = true;
            this.GridView_Order.GridControl = this.DataGridOrders;
            this.GridView_Order.Name = "GridView_Order";
            this.GridView_Order.OptionsBehavior.Editable = false;
            this.GridView_Order.OptionsCustomization.AllowFilter = false;
            this.GridView_Order.OptionsFind.AllowFindPanel = false;
            this.GridView_Order.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridView_Order.OptionsView.ShowGroupPanel = false;
            // 
            // LblDate
            // 
            this.LblDate.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.LblDate.Appearance.Options.UseFont = true;
            this.LblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDate.Location = new System.Drawing.Point(841, 3);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(54, 29);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "التاريخ";
            // 
            // labelFrom
            // 
            this.labelFrom.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.labelFrom.Appearance.Options.UseFont = true;
            this.labelFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFrom.Location = new System.Drawing.Point(792, 3);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(43, 29);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "من";
            // 
            // LblTo
            // 
            this.LblTo.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.LblTo.Appearance.Options.UseFont = true;
            this.LblTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTo.Location = new System.Drawing.Point(373, 3);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(44, 29);
            this.LblTo.TabIndex = 0;
            this.LblTo.Text = "إلي";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LblPayment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtEdit_Payments, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 409);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 29);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // LblPayment
            // 
            this.LblPayment.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.LblPayment.Appearance.Options.UseFont = true;
            this.LblPayment.Appearance.Options.UseTextOptions = true;
            this.LblPayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblPayment.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPayment.Location = new System.Drawing.Point(786, 3);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(103, 23);
            this.LblPayment.TabIndex = 0;
            this.LblPayment.Text = "المدفوع";
            // 
            // TxtEdit_Payments
            // 
            this.TxtEdit_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEdit_Payments.EditValue = "0";
            this.TxtEdit_Payments.Location = new System.Drawing.Point(680, 3);
            this.TxtEdit_Payments.MenuManager = this.ribbon;
            this.TxtEdit_Payments.Name = "TxtEdit_Payments";
            this.TxtEdit_Payments.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtEdit_Payments.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtEdit_Payments.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtEdit_Payments.Properties.ReadOnly = true;
            this.TxtEdit_Payments.Size = new System.Drawing.Size(100, 22);
            this.TxtEdit_Payments.TabIndex = 1;
            // 
            // FormSaverReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormSaverReport";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الخزينة";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEdit_Payments.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl LblDate;
        private DevExpress.XtraEditors.LabelControl labelFrom;
        private DevExpress.XtraEditors.LabelControl LblTo;
        private DevExpress.XtraGrid.GridControl DataGridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Order;
        private DevExpress.XtraEditors.DateEdit DateEditTo;
        private DevExpress.XtraEditors.DateEdit DateEdit_From;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl LblPayment;
        private DevExpress.XtraEditors.TextEdit TxtEdit_Payments;
        private DevExpress.XtraBars.BarButtonItem BtnSearch;
        private DevExpress.XtraBars.BarButtonItem BtnPrintReport;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}