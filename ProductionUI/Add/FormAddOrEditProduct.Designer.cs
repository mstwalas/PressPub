namespace ProductionUI.Add
{
    partial class FormAddOrEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Easer = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_SaveAndExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBox_MaterialSize = new DevExpress.XtraEditors.CheckEdit();
            this.Txt_Suggestion = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ProductName = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ProductPrice = new DevExpress.XtraEditors.TextEdit();
            this.SpnEdit_WastRatio = new DevExpress.XtraEditors.SpinEdit();
            this.ComboBox_Department = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_ProductionProcess = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_MaterialCategories = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_Material = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_MaterialType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_MaterialSize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBox_ReleaseSize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.CheckBox_MaterialType = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBox_ProductHasMaterial = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Suggestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpnEdit_WastRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_ProductionProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_ReleaseSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialType.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_ProductHasMaterial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Save,
            this.Btn_Easer,
            this.Btn_Exit,
            this.Btn_SaveAndExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1068, 164);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Caption = "حفظ";
            this.Btn_Save.Id = 1;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Save.ImageOptions.SvgImage")));
            this.Btn_Save.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Save_ItemClick);
            // 
            // Btn_Easer
            // 
            this.Btn_Easer.Caption = "مسح";
            this.Btn_Easer.Id = 2;
            this.Btn_Easer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Easer.ImageOptions.SvgImage")));
            this.Btn_Easer.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Easer.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Easer.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Easer.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Easer.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Easer.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Easer.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Easer.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Easer.Name = "Btn_Easer";
            this.Btn_Easer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Easer_ItemClick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 3;
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
            // Btn_SaveAndExit
            // 
            this.Btn_SaveAndExit.Caption = "حفظ و خروج";
            this.Btn_SaveAndExit.Id = 4;
            this.Btn_SaveAndExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_SaveAndExit.ImageOptions.SvgImage")));
            this.Btn_SaveAndExit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndExit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndExit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndExit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveAndExit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_SaveAndExit.Name = "Btn_SaveAndExit";
            this.Btn_SaveAndExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_SaveAndExit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "اضافة منتج";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_SaveAndExit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Easer);
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 435);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelControl5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelControl6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelControl7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelControl8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelControl9, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelControl10, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelControl11, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelControl12, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.CheckBox_MaterialSize, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Suggestion, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.Txt_ProductName, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.Txt_ProductPrice, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.SpnEdit_WastRatio, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Department, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_ProductionProcess, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_MaterialCategories, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Material, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_MaterialType, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_MaterialSize, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_ReleaseSize, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.CheckBox_MaterialType, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 384);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(915, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "القسم";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(915, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "العملية";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(915, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 28);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تصنيف الخامات";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(915, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(144, 28);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "الخامة";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(915, 139);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(144, 28);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "نوع الخامة";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(915, 173);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(144, 28);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "مقاس الخامة";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(915, 207);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(144, 28);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "مقاس الصرف";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl9.Location = new System.Drawing.Point(915, 241);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(144, 28);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "نسبة الهدر";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl10.Location = new System.Drawing.Point(915, 275);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(144, 28);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "الاسم المقترح";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl11.Location = new System.Drawing.Point(915, 309);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(144, 28);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "اسم المنتج";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl12.Location = new System.Drawing.Point(915, 343);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(144, 38);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "سعر المنتج";
            // 
            // CheckBox_MaterialSize
            // 
            this.CheckBox_MaterialSize.Location = new System.Drawing.Point(865, 173);
            this.CheckBox_MaterialSize.MenuManager = this.ribbon;
            this.CheckBox_MaterialSize.Name = "CheckBox_MaterialSize";
            this.CheckBox_MaterialSize.Properties.Caption = "";
            this.CheckBox_MaterialSize.Size = new System.Drawing.Size(44, 20);
            this.CheckBox_MaterialSize.TabIndex = 1;
            this.CheckBox_MaterialSize.CheckedChanged += new System.EventHandler(this.CheckBox_MaterialSize_CheckedChanged);
            // 
            // Txt_Suggestion
            // 
            this.Txt_Suggestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Suggestion.Location = new System.Drawing.Point(3, 275);
            this.Txt_Suggestion.MenuManager = this.ribbon;
            this.Txt_Suggestion.Name = "Txt_Suggestion";
            this.Txt_Suggestion.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Suggestion.Properties.Appearance.Options.UseFont = true;
            this.Txt_Suggestion.Size = new System.Drawing.Size(856, 30);
            this.Txt_Suggestion.TabIndex = 3;
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ProductName.Location = new System.Drawing.Point(3, 309);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ProductName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ProductName.Size = new System.Drawing.Size(856, 30);
            this.Txt_ProductName.TabIndex = 3;
            // 
            // Txt_ProductPrice
            // 
            this.Txt_ProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ProductPrice.Location = new System.Drawing.Point(3, 343);
            this.Txt_ProductPrice.Name = "Txt_ProductPrice";
            this.Txt_ProductPrice.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ProductPrice.Properties.Appearance.Options.UseFont = true;
            this.Txt_ProductPrice.Size = new System.Drawing.Size(856, 30);
            this.Txt_ProductPrice.TabIndex = 3;
            // 
            // SpnEdit_WastRatio
            // 
            this.SpnEdit_WastRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpnEdit_WastRatio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpnEdit_WastRatio.Location = new System.Drawing.Point(3, 241);
            this.SpnEdit_WastRatio.MenuManager = this.ribbon;
            this.SpnEdit_WastRatio.Name = "SpnEdit_WastRatio";
            this.SpnEdit_WastRatio.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.SpnEdit_WastRatio.Properties.Appearance.Options.UseFont = true;
            this.SpnEdit_WastRatio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpnEdit_WastRatio.Size = new System.Drawing.Size(856, 30);
            this.SpnEdit_WastRatio.TabIndex = 4;
            this.SpnEdit_WastRatio.EditValueChanged += new System.EventHandler(this.SpnEdit_WastRatio_EditValueChanged);
            // 
            // ComboBox_Department
            // 
            this.ComboBox_Department.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Department.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Department.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Location = new System.Drawing.Point(3, 3);
            this.ComboBox_Department.Name = "ComboBox_Department";
            this.ComboBox_Department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Department.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_Department.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Department.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Department.TabIndex = 5;
            this.ComboBox_Department.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Department_SelectedIndexChanged_1);
            // 
            // ComboBox_ProductionProcess
            // 
            this.ComboBox_ProductionProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_ProductionProcess.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_ProductionProcess.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ProductionProcess.Location = new System.Drawing.Point(3, 37);
            this.ComboBox_ProductionProcess.Name = "ComboBox_ProductionProcess";
            this.ComboBox_ProductionProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_ProductionProcess.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_ProductionProcess.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ProductionProcess.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ProductionProcess.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_ProductionProcess.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ProductionProcess.TabIndex = 5;
            this.ComboBox_ProductionProcess.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ProductionProcess_SelectedIndexChanged);
            // 
            // ComboBox_MaterialCategories
            // 
            this.ComboBox_MaterialCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_MaterialCategories.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialCategories.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategories.Location = new System.Drawing.Point(3, 71);
            this.ComboBox_MaterialCategories.Name = "ComboBox_MaterialCategories";
            this.ComboBox_MaterialCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialCategories.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_MaterialCategories.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategories.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategories.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialCategories.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialCategories.TabIndex = 5;
            this.ComboBox_MaterialCategories.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MaterialCategories_SelectedIndexChanged);
            // 
            // ComboBox_Material
            // 
            this.ComboBox_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Material.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_Material.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Location = new System.Drawing.Point(3, 105);
            this.ComboBox_Material.Name = "ComboBox_Material";
            this.ComboBox_Material.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_Material.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_Material.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Material.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Material.TabIndex = 5;
            this.ComboBox_Material.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Material_SelectedIndexChanged);
            // 
            // ComboBox_MaterialType
            // 
            this.ComboBox_MaterialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_MaterialType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialType.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Location = new System.Drawing.Point(3, 139);
            this.ComboBox_MaterialType.Name = "ComboBox_MaterialType";
            this.ComboBox_MaterialType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialType.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_MaterialType.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialType.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialType.TabIndex = 5;
            this.ComboBox_MaterialType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MaterialType_SelectedIndexChanged);
            // 
            // ComboBox_MaterialSize
            // 
            this.ComboBox_MaterialSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_MaterialSize.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_MaterialSize.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Location = new System.Drawing.Point(3, 173);
            this.ComboBox_MaterialSize.Name = "ComboBox_MaterialSize";
            this.ComboBox_MaterialSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_MaterialSize.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_MaterialSize.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_MaterialSize.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_MaterialSize.TabIndex = 5;
            this.ComboBox_MaterialSize.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MaterialSize_SelectedIndexChanged);
            // 
            // ComboBox_ReleaseSize
            // 
            this.ComboBox_ReleaseSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_ReleaseSize.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.ComboBox_ReleaseSize.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ReleaseSize.Location = new System.Drawing.Point(3, 207);
            this.ComboBox_ReleaseSize.Name = "ComboBox_ReleaseSize";
            this.ComboBox_ReleaseSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBox_ReleaseSize.Size = new System.Drawing.Size(856, 28);
            this.ComboBox_ReleaseSize.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ReleaseSize.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ReleaseSize.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_ReleaseSize.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_ReleaseSize.TabIndex = 5;
            this.ComboBox_ReleaseSize.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ReleaseSize_SelectedIndexChanged);
            // 
            // CheckBox_MaterialType
            // 
            this.CheckBox_MaterialType.Location = new System.Drawing.Point(865, 139);
            this.CheckBox_MaterialType.Name = "CheckBox_MaterialType";
            this.CheckBox_MaterialType.Properties.Caption = "";
            this.CheckBox_MaterialType.Size = new System.Drawing.Size(44, 20);
            this.CheckBox_MaterialType.TabIndex = 1;
            this.CheckBox_MaterialType.CheckedChanged += new System.EventHandler(this.CheckBox_MaterialType_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CheckBox_ProductHasMaterial, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1062, 39);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // CheckBox_ProductHasMaterial
            // 
            this.CheckBox_ProductHasMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox_ProductHasMaterial.Location = new System.Drawing.Point(384, 3);
            this.CheckBox_ProductHasMaterial.MenuManager = this.ribbon;
            this.CheckBox_ProductHasMaterial.Name = "CheckBox_ProductHasMaterial";
            this.CheckBox_ProductHasMaterial.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_ProductHasMaterial.Properties.Appearance.Options.UseFont = true;
            this.CheckBox_ProductHasMaterial.Properties.Appearance.Options.UseTextOptions = true;
            this.CheckBox_ProductHasMaterial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CheckBox_ProductHasMaterial.Properties.Caption = "المنتج يصرف له خامات";
            this.CheckBox_ProductHasMaterial.Size = new System.Drawing.Size(294, 33);
            this.CheckBox_ProductHasMaterial.TabIndex = 0;
            this.CheckBox_ProductHasMaterial.CheckedChanged += new System.EventHandler(this.CheckBox_ProductHasMaterial_CheckedChanged);
            // 
            // FormAddOrEditProduct
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FormAddOrEditProduct";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة منتج";
            this.Load += new System.EventHandler(this.Form_AddOrEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Suggestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpnEdit_WastRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_ProductionProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_MaterialSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_ReleaseSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_MaterialType.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_ProductHasMaterial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Save;
        private DevExpress.XtraBars.BarButtonItem Btn_Easer;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit CheckBox_MaterialSize;
        private DevExpress.XtraEditors.TextEdit Txt_Suggestion;
        private DevExpress.XtraEditors.TextEdit Txt_ProductName;
        private DevExpress.XtraEditors.TextEdit Txt_ProductPrice;
        private DevExpress.XtraEditors.CheckEdit CheckBox_MaterialType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.CheckEdit CheckBox_ProductHasMaterial;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SpinEdit SpnEdit_WastRatio;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Department;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_ProductionProcess;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialCategories;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_Material;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialType;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_MaterialSize;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBox_ReleaseSize;
        private DevExpress.XtraBars.BarButtonItem Btn_SaveAndExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}