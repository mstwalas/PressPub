namespace ProductionUI
{
    partial class FormRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelease));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBox_MaterialType = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBox_MaterialSize = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_Department = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_MaterialCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_Material = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_MaterialType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_MaterialSize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_OrderedBy = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBox_Reason = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Quantity = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_OrderedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(598, 164);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "صرف و طباعه";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "صرف بدون طباعه";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "خروج";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "إذن صرف";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CheckBox_MaterialType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CheckBox_MaterialSize, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_Department, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_MaterialCategory, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_Material, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_MaterialType, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_MaterialSize, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_OrderedBy, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelControl8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_Reason, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelControl9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Quantity, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Notes, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 355);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CheckBox_MaterialType
            // 
            this.CheckBox_MaterialType.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBox_MaterialType.Location = new System.Drawing.Point(450, 124);
            this.CheckBox_MaterialType.MenuManager = this.ribbon;
            this.CheckBox_MaterialType.Name = "CheckBox_MaterialType";
            this.CheckBox_MaterialType.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_MaterialType.Properties.Appearance.Options.UseFont = true;
            this.CheckBox_MaterialType.Properties.Caption = "";
            this.CheckBox_MaterialType.Size = new System.Drawing.Size(20, 20);
            this.CheckBox_MaterialType.TabIndex = 1;
            this.CheckBox_MaterialType.CheckedChanged += new System.EventHandler(this.CheckBox_MaterialType_CheckedChanged);
            // 
            // CheckBox_MaterialSize
            // 
            this.CheckBox_MaterialSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBox_MaterialSize.Location = new System.Drawing.Point(450, 161);
            this.CheckBox_MaterialSize.Name = "CheckBox_MaterialSize";
            this.CheckBox_MaterialSize.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_MaterialSize.Properties.Appearance.Options.UseFont = true;
            this.CheckBox_MaterialSize.Properties.Caption = "";
            this.CheckBox_MaterialSize.Size = new System.Drawing.Size(20, 20);
            this.CheckBox_MaterialSize.TabIndex = 1;
            this.CheckBox_MaterialSize.CheckedChanged += new System.EventHandler(this.CheckBox_MaterialSize_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(511, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "القسم";
            // 
            // ComboBox_Department
            // 
            this.ComboBox_Department.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_Department.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Department.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Location = new System.Drawing.Point(3, 13);
            this.ComboBox_Department.Name = "ComboBox_Department";
            this.ComboBox_Department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Department.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_Department.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Department.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(483, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تصنيف الخامة";
            // 
            // ComboBox_MaterialCategory
            // 
            this.ComboBox_MaterialCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_MaterialCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialCategory.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategory.Location = new System.Drawing.Point(3, 50);
            this.ComboBox_MaterialCategory.Name = "ComboBox_MaterialCategory";
            this.ComboBox_MaterialCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialCategory.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_MaterialCategory.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategory.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategory.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialCategory.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategory.TabIndex = 2;
            this.ComboBox_MaterialCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MaterialCategory_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(512, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 24);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "الخامة";
            // 
            // ComboBox_Material
            // 
            this.ComboBox_Material.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_Material.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Material.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Location = new System.Drawing.Point(3, 87);
            this.ComboBox_Material.Name = "ComboBox_Material";
            this.ComboBox_Material.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Material.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_Material.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Material.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.TabIndex = 2;
            this.ComboBox_Material.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Material_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(497, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 24);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "نوع الخامة";
            // 
            // ComboBox_MaterialType
            // 
            this.ComboBox_MaterialType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_MaterialType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialType.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Location = new System.Drawing.Point(3, 124);
            this.ComboBox_MaterialType.Name = "ComboBox_MaterialType";
            this.ComboBox_MaterialType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialType.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_MaterialType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ComboBox_MaterialType.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialType.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(486, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 24);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "مقاس الخامة";
            // 
            // ComboBox_MaterialSize
            // 
            this.ComboBox_MaterialSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_MaterialSize.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialSize.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Location = new System.Drawing.Point(3, 161);
            this.ComboBox_MaterialSize.Name = "ComboBox_MaterialSize";
            this.ComboBox_MaterialSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialSize.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_MaterialSize.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialSize.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(508, 235);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 24);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "بأمر من";
            // 
            // ComboBox_OrderedBy
            // 
            this.ComboBox_OrderedBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_OrderedBy.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_OrderedBy.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderedBy.Location = new System.Drawing.Point(3, 235);
            this.ComboBox_OrderedBy.Name = "ComboBox_OrderedBy";
            this.ComboBox_OrderedBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_OrderedBy.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_OrderedBy.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderedBy.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderedBy.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_OrderedBy.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_OrderedBy.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(510, 272);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 24);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "السبب";
            // 
            // ComboBox_Reason
            // 
            this.ComboBox_Reason.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_Reason.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Reason.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Reason.Location = new System.Drawing.Point(3, 272);
            this.ComboBox_Reason.Name = "ComboBox_Reason";
            this.ComboBox_Reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Reason.Size = new System.Drawing.Size(441, 31);
            this.ComboBox_Reason.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Reason.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Reason.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Reason.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Reason.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(501, 309);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 24);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "ملحوظات";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(512, 198);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 24);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "الكمية";
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.Txt_Quantity.Location = new System.Drawing.Point(3, 198);
            this.Txt_Quantity.MenuManager = this.ribbon;
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Quantity.Properties.Appearance.Options.UseFont = true;
            this.Txt_Quantity.Size = new System.Drawing.Size(441, 30);
            this.Txt_Quantity.TabIndex = 5;
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Notes.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Notes.Location = new System.Drawing.Point(3, 309);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(441, 31);
            this.Txt_Notes.TabIndex = 6;
            // 
            // Form_Release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(600, 520);
            this.Name = "FormRelease";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إذن صرف";
            this.Load += new System.EventHandler(this.Form_Release_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_OrderedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.CheckEdit CheckBox_MaterialType;
        private DevExpress.XtraEditors.CheckEdit CheckBox_MaterialSize;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Department;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialCategory;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Material;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialSize;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_OrderedBy;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Reason;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit Txt_Quantity;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TextBox Txt_Notes;
    }
}