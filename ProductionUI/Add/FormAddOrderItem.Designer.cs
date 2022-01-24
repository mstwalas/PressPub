namespace ProductionUI.Add
{
    partial class FormAddOrderItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrderItem));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Clear = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.خروج = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_SearchData = new DevExpress.XtraEditors.LabelControl();
            this.Txt_SearchDetails = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_SearchFilter = new DevExpress.XtraEditors.LabelControl();
            this.Txt_FilterSearch = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Grid_Products = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grid_Client = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents2 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchDetails.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FilterSearch)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Save,
            this.Btn_Clear,
            this.Btn_Exit,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(998, 162);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Caption = "حفظ";
            this.Btn_Save.Id = 1;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Save.ImageOptions.SvgImage")));
            this.Btn_Save.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.Name = "Btn_Save";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Caption = "مسح";
            this.Btn_Clear.Id = 2;
            this.Btn_Clear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Clear.ImageOptions.SvgImage")));
            this.Btn_Clear.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Clear.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Clear.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Clear.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Clear.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Clear.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Clear.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Clear.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Clear.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Clear.Name = "Btn_Clear";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 3;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
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
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "vvvvv";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.خروج,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "بيانات الأصناف";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // خروج
            // 
            this.خروج.ItemLinks.Add(this.Btn_Clear);
            this.خروج.Name = "خروج";
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.661417F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.33858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 412);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Lbl_SearchData, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Txt_SearchDetails, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(335, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(324, 23);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // Lbl_SearchData
            // 
            this.Lbl_SearchData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchData.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Lbl_SearchData.Appearance.Options.UseFont = true;
            this.Lbl_SearchData.Location = new System.Drawing.Point(234, 3);
            this.Lbl_SearchData.Name = "Lbl_SearchData";
            this.Lbl_SearchData.Size = new System.Drawing.Size(82, 26);
            this.Lbl_SearchData.TabIndex = 1;
            this.Lbl_SearchData.Text = "بيانات البحث";
            // 
            // Txt_SearchDetails
            // 
            this.Txt_SearchDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_SearchDetails.Location = new System.Drawing.Point(3, 3);
            this.Txt_SearchDetails.MenuManager = this.ribbon;
            this.Txt_SearchDetails.Name = "Txt_SearchDetails";
            this.Txt_SearchDetails.Properties.Appearance.Font = new System.Drawing.Font("Sultan bold", 12.5F);
            this.Txt_SearchDetails.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchDetails.Size = new System.Drawing.Size(219, 28);
            this.Txt_SearchDetails.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Lbl_SearchFilter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Txt_FilterSearch, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(665, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(324, 23);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Lbl_SearchFilter
            // 
            this.Lbl_SearchFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchFilter.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Lbl_SearchFilter.Appearance.Options.UseFont = true;
            this.Lbl_SearchFilter.Location = new System.Drawing.Point(252, 3);
            this.Lbl_SearchFilter.Name = "Lbl_SearchFilter";
            this.Lbl_SearchFilter.Size = new System.Drawing.Size(62, 26);
            this.Lbl_SearchFilter.TabIndex = 0;
            this.Lbl_SearchFilter.Text = "نوع البحث";
            // 
            // Txt_FilterSearch
            // 
            this.Txt_FilterSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_FilterSearch.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Txt_FilterSearch.Font = new System.Drawing.Font("Sultan bold", 12.5F);
            this.Txt_FilterSearch.Location = new System.Drawing.Point(3, 3);
            this.Txt_FilterSearch.Name = "Txt_FilterSearch";
            this.Txt_FilterSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FilterSearch.Size = new System.Drawing.Size(236, 17);
            this.Txt_FilterSearch.Style.EditorStyle.Font = new System.Drawing.Font("Sultan bold", 12.5F);
            this.Txt_FilterSearch.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Sultan bold", 12.5F);
            this.Txt_FilterSearch.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txt_FilterSearch.Style.TokenStyle.Font = new System.Drawing.Font("Sultan bold", 12.5F);
            this.Txt_FilterSearch.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(992, 371);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 365);
            this.panel1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.Grid_Products);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Grid_Client);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(986, 365);
            this.splitContainerControl1.SplitterPosition = 499;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // Grid_Products
            // 
            this.Grid_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Products.Location = new System.Drawing.Point(0, 0);
            this.Grid_Products.MainView = this.gridView1;
            this.Grid_Products.MenuManager = this.ribbon;
            this.Grid_Products.Name = "Grid_Products";
            this.Grid_Products.Size = new System.Drawing.Size(499, 365);
            this.Grid_Products.TabIndex = 0;
            this.Grid_Products.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.Grid_Products.DoubleClick += new System.EventHandler(this.Products_Grid_DoubleClick);
            this.Grid_Products.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Products_Grid_KeyDown);
            // 
            // gridView1
            // 
            this.behaviorManager1.SetBehaviors(this.gridView1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents2)))});
            this.gridView1.GridControl = this.Grid_Products;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Grid_Products;
            this.gridView2.Name = "gridView2";
            // 
            // Grid_Client
            // 
            this.Grid_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Client.Location = new System.Drawing.Point(0, 0);
            this.Grid_Client.MainView = this.gridView3;
            this.Grid_Client.MenuManager = this.ribbon;
            this.Grid_Client.Name = "Grid_Client";
            this.Grid_Client.Size = new System.Drawing.Size(477, 365);
            this.Grid_Client.TabIndex = 0;
            this.Grid_Client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.Grid_Client.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Client_Grid_KeyDown);
            // 
            // gridView3
            // 
            this.behaviorManager1.SetBehaviors(this.gridView3, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents1)))});
            this.gridView3.GridControl = this.Grid_Client;
            this.gridView3.Name = "gridView3";
            // 
            // Form_AddOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormAddOrderItem";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddOrderItem_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchDetails.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FilterSearch)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Save;
        private DevExpress.XtraBars.BarButtonItem Btn_Clear;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup خروج;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchData;
        private DevExpress.XtraEditors.TextEdit Txt_SearchDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.WinForms.ListView.SfComboBox Txt_FilterSearch;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl Grid_Products;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grid_Client;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}