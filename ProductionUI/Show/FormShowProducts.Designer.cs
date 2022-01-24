namespace ProductionUI.Show
{
    partial class FormShowProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowProducts));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Brn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CombinedProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrdControl_Product = new DevExpress.XtraGrid.GridControl();
            this.GridView_Products = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_SearchData = new DevExpress.XtraEditors.TextEdit();
            this.ComboBox_SearchFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_Product)).BeginInit();
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
            this.barButtonItem2,
            this.Brn_Exit,
            this.Btn_CombinedProduct});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1224, 164);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "مسح";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.ItemAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Brn_Exit
            // 
            this.Brn_Exit.Caption = "خروج";
            this.Brn_Exit.Id = 3;
            this.Brn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Brn_Exit.ImageOptions.SvgImage")));
            this.Brn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Brn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Brn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Brn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Brn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Brn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Brn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Brn_Exit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Brn_Exit.Name = "Brn_Exit";
            this.Brn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brn_Exit_ItemClick);
            // 
            // Btn_CombinedProduct
            // 
            this.Btn_CombinedProduct.Caption = "إضافة منتج";
            this.Btn_CombinedProduct.Id = 4;
            this.Btn_CombinedProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_CombinedProduct.ImageOptions.SvgImage")));
            this.Btn_CombinedProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_CombinedProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_CombinedProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_CombinedProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_CombinedProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_CombinedProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_CombinedProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_CombinedProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_CombinedProduct.Name = "Btn_CombinedProduct";
            this.Btn_CombinedProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CombinedProduct_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "المنتجات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Edit);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_CombinedProduct);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Brn_Exit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GrdControl_Product, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 435);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // GrdControl_Product
            // 
            this.GrdControl_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl_Product.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GrdControl_Product.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GrdControl_Product.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdControl_Product.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.GrdControl_Product.Location = new System.Drawing.Point(4, 51);
            this.GrdControl_Product.MainView = this.GridView_Products;
            this.GrdControl_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdControl_Product.MenuManager = this.ribbon;
            this.GrdControl_Product.Name = "GrdControl_Product";
            this.GrdControl_Product.Size = new System.Drawing.Size(1216, 379);
            this.GrdControl_Product.TabIndex = 0;
            this.GrdControl_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Products});
            this.GrdControl_Product.Load += new System.EventHandler(this.GrdControl_Product_Load);
            this.GrdControl_Product.DoubleClick += new System.EventHandler(this.GrdControl_Product_DoubleClick);
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
            this.GridView_Products.GridControl = this.GrdControl_Product;
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
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Txt_SearchData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_SearchFilter, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1216, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(1095, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "نوع البحث";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(584, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "بيانات البحث";
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
            this.Txt_SearchData.Size = new System.Drawing.Size(572, 30);
            this.Txt_SearchData.TabIndex = 1;
            // 
            // ComboBox_SearchFilter
            // 
            this.ComboBox_SearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_SearchFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_SearchFilter.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Location = new System.Drawing.Point(709, 5);
            this.ComboBox_SearchFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_SearchFilter.MinimumSize = new System.Drawing.Size(315, 25);
            this.ComboBox_SearchFilter.Name = "ComboBox_SearchFilter";
            this.ComboBox_SearchFilter.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ComboBox_SearchFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_SearchFilter.Size = new System.Drawing.Size(378, 26);
            this.ComboBox_SearchFilter.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_SearchFilter.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SearchFilter.TabIndex = 2;
            // 
            // FormShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FormShowProducts";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.Form_ShowProducts_Load);
            this.Shown += new System.EventHandler(this.Form_ShowProducts_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_ShowProducts_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl_Product)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem Brn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GrdControl_Product;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Products;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_SearchData;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_SearchFilter;
        private DevExpress.XtraBars.BarButtonItem Btn_CombinedProduct;
    }
}