namespace ProductionUI.Show
{
    partial class FormShowAllProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowAllProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrdControl_AllProduct = new DevExpress.XtraGrid.GridControl();
            this.GridView_Products = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_SearchFilter = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SearchData = new DevExpress.XtraEditors.LabelControl();
            this.Txt_SearchData = new DevExpress.XtraEditors.TextEdit();
            this.ComboBox_SearchFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_AllProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Products)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_SearchFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Edit,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1068, 164);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Caption = "تعديل";
            this.Btn_Edit.Id = 1;
            this.Btn_Edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Edit.ImageOptions.SvgImage")));
            this.Btn_Edit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Edit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Edit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Edit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Edit_ItemClick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 2;
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
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "كل المنتجات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Edit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Exit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GrdControl_AllProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 435);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // GrdControl_AllProduct
            // 
            this.GrdControl_AllProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl_AllProduct.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GrdControl_AllProduct.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GrdControl_AllProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdControl_AllProduct.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GrdControl_AllProduct.Location = new System.Drawing.Point(4, 56);
            this.GrdControl_AllProduct.MainView = this.GridView_Products;
            this.GrdControl_AllProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdControl_AllProduct.MenuManager = this.ribbon;
            this.GrdControl_AllProduct.Name = "GrdControl_AllProduct";
            this.GrdControl_AllProduct.Size = new System.Drawing.Size(1060, 374);
            this.GrdControl_AllProduct.TabIndex = 0;
            this.GrdControl_AllProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Products});
            this.GrdControl_AllProduct.DoubleClick += new System.EventHandler(this.GrdControl_AllProduct_DoubleClick);
            // 
            // GridView_Products
            // 
            this.GridView_Products.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Products.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView_Products.Appearance.Row.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GridView_Products.Appearance.Row.Options.UseFont = true;
            this.GridView_Products.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GridView_Products.Appearance.SelectedRow.Options.UseFont = true;
            this.GridView_Products.DetailHeight = 584;
            this.GridView_Products.FixedLineWidth = 3;
            this.GridView_Products.GridControl = this.GrdControl_AllProduct;
            this.GridView_Products.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.GridView_Products.Name = "GridView_Products";
            this.GridView_Products.OptionsBehavior.Editable = false;
            this.GridView_Products.OptionsBehavior.ReadOnly = true;
            this.GridView_Products.OptionsCustomization.AllowFilter = false;
            this.GridView_Products.OptionsFind.AllowFindPanel = false;
            this.GridView_Products.OptionsView.ShowGroupPanel = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl_SearchFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_SearchData, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Txt_SearchData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_SearchFilter, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1060, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Lbl_SearchFilter
            // 
            this.Lbl_SearchFilter.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_SearchFilter.Appearance.Options.UseFont = true;
            this.Lbl_SearchFilter.Appearance.Options.UseTextOptions = true;
            this.Lbl_SearchFilter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_SearchFilter.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_SearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_SearchFilter.Location = new System.Drawing.Point(939, 5);
            this.Lbl_SearchFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lbl_SearchFilter.Name = "Lbl_SearchFilter";
            this.Lbl_SearchFilter.Size = new System.Drawing.Size(117, 31);
            this.Lbl_SearchFilter.TabIndex = 0;
            this.Lbl_SearchFilter.Text = "نوع البحث";
            // 
            // Lbl_SearchData
            // 
            this.Lbl_SearchData.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_SearchData.Appearance.Options.UseFont = true;
            this.Lbl_SearchData.Appearance.Options.UseTextOptions = true;
            this.Lbl_SearchData.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbl_SearchData.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbl_SearchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_SearchData.Location = new System.Drawing.Point(490, 5);
            this.Lbl_SearchData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lbl_SearchData.Name = "Lbl_SearchData";
            this.Lbl_SearchData.Size = new System.Drawing.Size(117, 31);
            this.Lbl_SearchData.TabIndex = 0;
            this.Lbl_SearchData.Text = "بيانات البحث";
            // 
            // Txt_SearchData
            // 
            this.Txt_SearchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SearchData.Location = new System.Drawing.Point(4, 5);
            this.Txt_SearchData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_SearchData.MenuManager = this.ribbon;
            this.Txt_SearchData.MinimumSize = new System.Drawing.Size(478, 25);
            this.Txt_SearchData.Name = "Txt_SearchData";
            this.Txt_SearchData.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_SearchData.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchData.Size = new System.Drawing.Size(478, 30);
            this.Txt_SearchData.TabIndex = 1;
            this.Txt_SearchData.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.Txt_SearchData_EditValueChanging);
            // 
            // ComboBox_SearchFilter
            // 
            this.ComboBox_SearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_SearchFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_SearchFilter.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Location = new System.Drawing.Point(615, 5);
            this.ComboBox_SearchFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_SearchFilter.MinimumSize = new System.Drawing.Size(315, 25);
            this.ComboBox_SearchFilter.Name = "ComboBox_SearchFilter";
            this.ComboBox_SearchFilter.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ComboBox_SearchFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_SearchFilter.Size = new System.Drawing.Size(316, 31);
            this.ComboBox_SearchFilter.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_SearchFilter.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.TabIndex = 2;
            this.ComboBox_SearchFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SearchFilter_SelectedIndexChanged);
            // 
            // FormShowAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FormShowAllProduct";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كل المنتجات";
            this.Load += new System.EventHandler(this.Form_ShowAllProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_AllProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Products)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_SearchFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Edit;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GrdControl_AllProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Products;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchFilter;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchData;
        private DevExpress.XtraEditors.TextEdit Txt_SearchData;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_SearchFilter;
    }
}