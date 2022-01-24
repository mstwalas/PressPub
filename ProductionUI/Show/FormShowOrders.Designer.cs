namespace ProductionUI.Show
{
    partial class FormShowOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowOrders));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_EditOrder = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_DeleteOrder = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_SearchData = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_SearchData = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Combobox_SearchFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.Lbl_SearchFilter = new DevExpress.XtraEditors.LabelControl();
            this.DataGrid_OrdersInfo = new DevExpress.XtraGrid.GridControl();
            this.GridView_Order = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_SearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_EditOrder,
            this.Btn_DeleteOrder,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1070, 164);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // Btn_EditOrder
            // 
            this.Btn_EditOrder.Caption = "تعديل";
            this.Btn_EditOrder.Id = 1;
            this.Btn_EditOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_EditOrder.ImageOptions.SvgImage")));
            this.Btn_EditOrder.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditOrder.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditOrder.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditOrder.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditOrder.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditOrder.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_EditOrder.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_EditOrder.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditOrder.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditOrder.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_EditOrder.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditOrder.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_EditOrder.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditOrder.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_EditOrder.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_EditOrder.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_EditOrder.Name = "Btn_EditOrder";
            this.Btn_EditOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_EditOrder_ItemClick);
            // 
            // Btn_DeleteOrder
            // 
            this.Btn_DeleteOrder.Caption = "حذف";
            this.Btn_DeleteOrder.Id = 2;
            this.Btn_DeleteOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_DeleteOrder.ImageOptions.SvgImage")));
            this.Btn_DeleteOrder.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteOrder.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteOrder.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteOrder.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_DeleteOrder.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteOrder.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteOrder.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteOrder.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_DeleteOrder.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_DeleteOrder.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_DeleteOrder.Name = "Btn_DeleteOrder";
            this.Btn_DeleteOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_DeleteOrder_ItemClick);
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
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Exit.ItemInMenuAppearance.Pressed.Options.UseFont = true;
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
            this.ribbonPage1.Text = "عرض الطلبات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_EditOrder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_DeleteOrder);
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataGrid_OrdersInfo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1064, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1058, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Txt_SearchData, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Lbl_SearchData, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(629, 39);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // Txt_SearchData
            // 
            this.Txt_SearchData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_SearchData.Location = new System.Drawing.Point(3, 3);
            this.Txt_SearchData.MenuManager = this.ribbon;
            this.Txt_SearchData.Name = "Txt_SearchData";
            this.Txt_SearchData.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_SearchData.Properties.Appearance.Options.UseFont = true;
            this.Txt_SearchData.Size = new System.Drawing.Size(501, 30);
            this.Txt_SearchData.TabIndex = 2;
            this.Txt_SearchData.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.Txt_SearchData_EditValueChanging);
            // 
            // Lbl_SearchData
            // 
            this.Lbl_SearchData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchData.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SearchData.Appearance.Options.UseFont = true;
            this.Lbl_SearchData.Location = new System.Drawing.Point(521, 3);
            this.Lbl_SearchData.Name = "Lbl_SearchData";
            this.Lbl_SearchData.Size = new System.Drawing.Size(95, 24);
            this.Lbl_SearchData.TabIndex = 1;
            this.Lbl_SearchData.Text = "بيانات البحث";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Combobox_SearchFilter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_SearchFilter, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(638, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 39);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Combobox_SearchFilter
            // 
            this.Combobox_SearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Combobox_SearchFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Combobox_SearchFilter.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_SearchFilter.Location = new System.Drawing.Point(3, 3);
            this.Combobox_SearchFilter.Name = "Combobox_SearchFilter";
            this.Combobox_SearchFilter.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Combobox_SearchFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Combobox_SearchFilter.Size = new System.Drawing.Size(303, 30);
            this.Combobox_SearchFilter.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_SearchFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_SearchFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Combobox_SearchFilter.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Combobox_SearchFilter.TabIndex = 2;
            this.Combobox_SearchFilter.SelectedIndexChanged += new System.EventHandler(this.Combobox_SearchFilter_SelectedIndexChanged);
            // 
            // Lbl_SearchFilter
            // 
            this.Lbl_SearchFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_SearchFilter.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SearchFilter.Appearance.Options.UseFont = true;
            this.Lbl_SearchFilter.Location = new System.Drawing.Point(326, 3);
            this.Lbl_SearchFilter.Name = "Lbl_SearchFilter";
            this.Lbl_SearchFilter.Size = new System.Drawing.Size(74, 24);
            this.Lbl_SearchFilter.TabIndex = 1;
            this.Lbl_SearchFilter.Text = "نوع البحث";
            // 
            // DataGrid_OrdersInfo
            // 
            this.DataGrid_OrdersInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_OrdersInfo.Location = new System.Drawing.Point(3, 54);
            this.DataGrid_OrdersInfo.MainView = this.GridView_Order;
            this.DataGrid_OrdersInfo.MenuManager = this.ribbon;
            this.DataGrid_OrdersInfo.Name = "DataGrid_OrdersInfo";
            this.DataGrid_OrdersInfo.Size = new System.Drawing.Size(1058, 348);
            this.DataGrid_OrdersInfo.TabIndex = 1;
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
            // FormShowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(919, 525);
            this.Name = "FormShowOrders";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الطلبات";
            this.Load += new System.EventHandler(this.Form_ShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SearchData.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_SearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_OrdersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_EditOrder;
        private DevExpress.XtraBars.BarButtonItem Btn_DeleteOrder;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.TextEdit Txt_SearchData;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LabelControl Lbl_SearchFilter;
        private DevExpress.XtraGrid.GridControl DataGrid_OrdersInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView_Order;
        private Syncfusion.WinForms.ListView.SfComboBox Combobox_SearchFilter;
    }
}