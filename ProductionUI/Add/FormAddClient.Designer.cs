namespace ProductionUI.Add
{
    partial class FormAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClient));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Save_Btn = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Earse = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_SaveAndExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_MobileNum = new DevExpress.XtraEditors.LabelControl();
            this.Txt_MobileNum = new DevExpress.XtraEditors.TextEdit();
            this.CheckBox_PhoneNumber = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Name = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Degree = new DevExpress.XtraEditors.LabelControl();
            this.Cmbx_Degree = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Unit = new DevExpress.XtraEditors.LabelControl();
            this.Cmbx_Unit = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MobileNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_PhoneNumber.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbx_Degree)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbx_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Save_Btn,
            this.Btn_Earse,
            this.Btn_Exit,
            this.Btn_SaveAndExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(648, 162);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Caption = "حفظ";
            this.Save_Btn.Id = 1;
            this.Save_Btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Save_Btn.ImageOptions.SvgImage")));
            this.Save_Btn.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemAppearance.Disabled.Options.UseFont = true;
            this.Save_Btn.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemAppearance.Hovered.Options.UseFont = true;
            this.Save_Btn.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemAppearance.Normal.Options.UseFont = true;
            this.Save_Btn.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemAppearance.Pressed.Options.UseFont = true;
            this.Save_Btn.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Save_Btn.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Save_Btn.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Save_Btn.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Save_Btn_ItemClick);
            // 
            // Btn_Earse
            // 
            this.Btn_Earse.Caption = "مسح";
            this.Btn_Earse.Id = 2;
            this.Btn_Earse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Earse.ImageOptions.SvgImage")));
            this.Btn_Earse.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Earse.Name = "Btn_Earse";
            this.Btn_Earse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Earse_ItemClick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Caption = "خروج";
            this.Btn_Exit.Id = 3;
            this.Btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Exit.ImageOptions.SvgImage")));
            this.Btn_Exit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Exit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Exit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Exit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Exit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_Exit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // Btn_SaveAndExit
            // 
            this.Btn_SaveAndExit.Caption = "حفظ و غلق";
            this.Btn_SaveAndExit.Id = 4;
            this.Btn_SaveAndExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_SaveAndExit.ImageOptions.SvgImage")));
            this.Btn_SaveAndExit.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_SaveAndExit.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_SaveAndExit.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_SaveAndExit.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_SaveAndExit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 9.75F);
            this.Btn_SaveAndExit.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_SaveAndExit.Name = "Btn_SaveAndExit";
            this.Btn_SaveAndExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_SaveAndExit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "إضافة مندوب";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Save_Btn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_SaveAndExit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Earse);
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 287);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Lbl_MobileNum, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Txt_MobileNum, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.CheckBox_PhoneNumber, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 216);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(642, 68);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // Lbl_MobileNum
            // 
            this.Lbl_MobileNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_MobileNum.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Lbl_MobileNum.Appearance.Options.UseFont = true;
            this.Lbl_MobileNum.Location = new System.Drawing.Point(532, 3);
            this.Lbl_MobileNum.Name = "Lbl_MobileNum";
            this.Lbl_MobileNum.Size = new System.Drawing.Size(106, 26);
            this.Lbl_MobileNum.TabIndex = 0;
            this.Lbl_MobileNum.Text = "رقم الموبايل";
            // 
            // Txt_MobileNum
            // 
            this.Txt_MobileNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_MobileNum.Location = new System.Drawing.Point(3, 3);
            this.Txt_MobileNum.MenuManager = this.ribbon;
            this.Txt_MobileNum.Name = "Txt_MobileNum";
            this.Txt_MobileNum.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Txt_MobileNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_MobileNum.Properties.MaskSettings.Set("mask", "\\d\\d\\d-\\d\\d\\d\\d-\\d\\d\\d\\d");
            this.Txt_MobileNum.Properties.MaxLength = 11;
            this.Txt_MobileNum.Size = new System.Drawing.Size(496, 32);
            this.Txt_MobileNum.TabIndex = 1;
            // 
            // CheckBox_PhoneNumber
            // 
            this.CheckBox_PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBox_PhoneNumber.Location = new System.Drawing.Point(505, 3);
            this.CheckBox_PhoneNumber.MenuManager = this.ribbon;
            this.CheckBox_PhoneNumber.Name = "CheckBox_PhoneNumber";
            this.CheckBox_PhoneNumber.Properties.Caption = "";
            this.CheckBox_PhoneNumber.Size = new System.Drawing.Size(19, 20);
            this.CheckBox_PhoneNumber.TabIndex = 2;
            this.CheckBox_PhoneNumber.CheckedChanged += new System.EventHandler(this.CheckBox_PhoneNumber_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Lbl_Name, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Txt_Name, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(642, 65);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Name.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Lbl_Name.Appearance.Options.UseFont = true;
            this.Lbl_Name.Location = new System.Drawing.Point(547, 3);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(51, 26);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "الاسم";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Name.Location = new System.Drawing.Point(3, 3);
            this.Txt_Name.MenuManager = this.ribbon;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Name_Properties_Validating);
            this.Txt_Name.Size = new System.Drawing.Size(496, 32);
            this.Txt_Name.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Lbl_Degree, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cmbx_Degree, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(642, 65);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Lbl_Degree
            // 
            this.Lbl_Degree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Degree.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Lbl_Degree.Appearance.Options.UseFont = true;
            this.Lbl_Degree.Location = new System.Drawing.Point(547, 3);
            this.Lbl_Degree.Name = "Lbl_Degree";
            this.Lbl_Degree.Size = new System.Drawing.Size(51, 26);
            this.Lbl_Degree.TabIndex = 0;
            this.Lbl_Degree.Text = "الدرجة";
            // 
            // Cmbx_Degree
            // 
            this.Cmbx_Degree.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cmbx_Degree.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Cmbx_Degree.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Degree.Location = new System.Drawing.Point(3, 3);
            this.Cmbx_Degree.Name = "Cmbx_Degree";
            this.Cmbx_Degree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmbx_Degree.Size = new System.Drawing.Size(496, 45);
            this.Cmbx_Degree.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Degree.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Degree.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cmbx_Degree.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Degree.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl_Unit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Cmbx_Unit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Unit.Appearance.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Lbl_Unit.Appearance.Options.UseFont = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(545, 3);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(54, 26);
            this.Lbl_Unit.TabIndex = 0;
            this.Lbl_Unit.Text = "الوحدة";
            // 
            // Cmbx_Unit
            // 
            this.Cmbx_Unit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cmbx_Unit.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.Cmbx_Unit.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Unit.Location = new System.Drawing.Point(3, 3);
            this.Cmbx_Unit.Name = "Cmbx_Unit";
            this.Cmbx_Unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmbx_Unit.Size = new System.Drawing.Size(496, 45);
            this.Cmbx_Unit.Style.EditorStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Unit.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Unit.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cmbx_Unit.Style.TokenStyle.Font = new System.Drawing.Font("Tajawal Black", 13F, System.Drawing.FontStyle.Bold);
            this.Cmbx_Unit.TabIndex = 1;
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "FormAddClient";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مندوب";
            this.Load += new System.EventHandler(this.Form_AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MobileNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox_PhoneNumber.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbx_Degree)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbx_Unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Save_Btn;
        private DevExpress.XtraBars.BarButtonItem Btn_Earse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl Lbl_Unit;
        private DevExpress.XtraEditors.TextEdit Txt_MobileNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LabelControl Lbl_MobileNum;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl Lbl_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl Lbl_Degree;
        private DevExpress.XtraBars.BarButtonItem Btn_SaveAndExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private Syncfusion.WinForms.ListView.SfComboBox Cmbx_Degree;
        private Syncfusion.WinForms.ListView.SfComboBox Cmbx_Unit;
        private DevExpress.XtraEditors.CheckEdit CheckBox_PhoneNumber;
    }
}