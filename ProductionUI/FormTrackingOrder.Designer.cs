namespace ProductionUI
{
    partial class FormTrackingOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrackingOrder));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrdControl_Tracking = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColumn_CombinedProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColumn_RunState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Txt_OrderNum = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Unit = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Client = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Delivary = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_ClientInfo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_Tracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OrderNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Delivary)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(848, 164);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 1;
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
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "تتبع الطلب";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Exit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.07005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.92995F));
            this.tableLayoutPanel1.Controls.Add(this.GrdControl_Tracking, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_OrderNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Unit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Client, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Delivary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ClientInfo, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 335);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // GrdControl_Tracking
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GrdControl_Tracking, 3);
            this.GrdControl_Tracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl_Tracking.Location = new System.Drawing.Point(3, 135);
            this.GrdControl_Tracking.MainView = this.gridView1;
            this.GrdControl_Tracking.MenuManager = this.ribbon;
            this.GrdControl_Tracking.Name = "GrdControl_Tracking";
            this.GrdControl_Tracking.Size = new System.Drawing.Size(842, 197);
            this.GrdControl_Tracking.TabIndex = 1;
            this.GrdControl_Tracking.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColumn_CombinedProduct,
            this.GrdColumn_Product,
            this.GrdColumn_ProductName,
            this.GrdColumn_RunState});
            this.gridView1.GridControl = this.GrdControl_Tracking;
            this.gridView1.Name = "gridView1";
            // 
            // GrdColumn_CombinedProduct
            // 
            this.GrdColumn_CombinedProduct.Caption = "رقم المنتج المجمع";
            this.GrdColumn_CombinedProduct.Name = "GrdColumn_CombinedProduct";
            this.GrdColumn_CombinedProduct.Visible = true;
            this.GrdColumn_CombinedProduct.VisibleIndex = 0;
            // 
            // GrdColumn_Product
            // 
            this.GrdColumn_Product.Caption = "رقم المنتج";
            this.GrdColumn_Product.Name = "GrdColumn_Product";
            this.GrdColumn_Product.Visible = true;
            this.GrdColumn_Product.VisibleIndex = 1;
            // 
            // GrdColumn_ProductName
            // 
            this.GrdColumn_ProductName.Caption = "اسم المنتج";
            this.GrdColumn_ProductName.Name = "GrdColumn_ProductName";
            this.GrdColumn_ProductName.Visible = true;
            this.GrdColumn_ProductName.VisibleIndex = 2;
            // 
            // GrdColumn_RunState
            // 
            this.GrdColumn_RunState.Caption = "حاله التشغيل";
            this.GrdColumn_RunState.Name = "GrdColumn_RunState";
            this.GrdColumn_RunState.Visible = true;
            this.GrdColumn_RunState.VisibleIndex = 3;
            // 
            // Txt_OrderNum
            // 
            this.Txt_OrderNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_OrderNum.Location = new System.Drawing.Point(292, 3);
            this.Txt_OrderNum.MenuManager = this.ribbon;
            this.Txt_OrderNum.Name = "Txt_OrderNum";
            this.Txt_OrderNum.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_OrderNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_OrderNum.Size = new System.Drawing.Size(428, 30);
            this.Txt_OrderNum.TabIndex = 2;
            // 
            // Txt_Unit
            // 
            this.Txt_Unit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_Unit.Location = new System.Drawing.Point(292, 36);
            this.Txt_Unit.Name = "Txt_Unit";
            this.Txt_Unit.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Unit.Properties.Appearance.Options.UseFont = true;
            this.Txt_Unit.Size = new System.Drawing.Size(428, 30);
            this.Txt_Unit.TabIndex = 2;
            // 
            // Txt_Client
            // 
            this.Txt_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_Client.Location = new System.Drawing.Point(292, 69);
            this.Txt_Client.Name = "Txt_Client";
            this.Txt_Client.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Client.Properties.Appearance.Options.UseFont = true;
            this.Txt_Client.Size = new System.Drawing.Size(428, 30);
            this.Txt_Client.TabIndex = 2;
            // 
            // Txt_Delivary
            // 
            this.Txt_Delivary.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_Delivary.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Txt_Delivary.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Delivary.Location = new System.Drawing.Point(292, 102);
            this.Txt_Delivary.Name = "Txt_Delivary";
            this.Txt_Delivary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Delivary.Size = new System.Drawing.Size(428, 27);
            this.Txt_Delivary.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Delivary.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Delivary.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txt_Delivary.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Delivary.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(761, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "الوحدة";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(759, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "العميل";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(755, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "التسليم";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(742, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "رقم الفاتورة";
            // 
            // Btn_ClientInfo
            // 
            this.Btn_ClientInfo.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ClientInfo.Appearance.Options.UseFont = true;
            this.Btn_ClientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ClientInfo.Location = new System.Drawing.Point(3, 69);
            this.Btn_ClientInfo.Name = "Btn_ClientInfo";
            this.Btn_ClientInfo.Size = new System.Drawing.Size(283, 27);
            this.Btn_ClientInfo.TabIndex = 5;
            this.Btn_ClientInfo.Text = "عرض بيانات العميل";
            // 
            // FormTrackingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FormTrackingOrder";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تتبع الطلب";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_Tracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OrderNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Delivary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GrdControl_Tracking;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit Txt_OrderNum;
        private DevExpress.XtraEditors.TextEdit Txt_Unit;
        private DevExpress.XtraEditors.TextEdit Txt_Client;
        private Syncfusion.WinForms.ListView.SfComboBox Txt_Delivary;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton Btn_ClientInfo;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_CombinedProduct;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_Product;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColumn_RunState;
    }
}