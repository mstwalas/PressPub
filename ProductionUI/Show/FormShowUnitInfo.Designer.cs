namespace ProductionUI.Show
{
    partial class FormShowUnitInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowUnitInfo));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Earse = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_UnitName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_UnitName = new DevExpress.XtraEditors.TextEdit();
            this.Btn_EditUnitPen = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_EditUnitPen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Btn_Save,
            this.Btn_Earse,
            this.Btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(531, 164);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Caption = "تعديل";
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
            this.Btn_Save.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Save_ItemClick);
            // 
            // Btn_Earse
            // 
            this.Btn_Earse.Caption = "مسح";
            this.Btn_Earse.Id = 2;
            this.Btn_Earse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Earse.ImageOptions.SvgImage")));
            this.Btn_Earse.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Earse.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Earse.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Normal.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Earse.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Earse.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.Btn_Earse.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.Btn_Earse.Name = "Btn_Earse";
            this.Btn_Earse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Erase_ItemClick);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 8F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "بيانات الوحدة";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 91);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel5.Controls.Add(this.Lbl_UnitName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Txt_UnitName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Btn_EditUnitPen, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(523, 39);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // Lbl_UnitName
            // 
            this.Lbl_UnitName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_UnitName.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_UnitName.Appearance.Options.UseFont = true;
            this.Lbl_UnitName.Location = new System.Drawing.Point(420, 6);
            this.Lbl_UnitName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lbl_UnitName.Name = "Lbl_UnitName";
            this.Lbl_UnitName.Size = new System.Drawing.Size(87, 24);
            this.Lbl_UnitName.TabIndex = 0;
            this.Lbl_UnitName.Text = "إسم الوحدة";
            // 
            // Txt_UnitName
            // 
            this.Txt_UnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_UnitName.EditValue = "";
            this.Txt_UnitName.Location = new System.Drawing.Point(56, 6);
            this.Txt_UnitName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_UnitName.Name = "Txt_UnitName";
            this.Txt_UnitName.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_UnitName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UnitName.Properties.ReadOnly = true;
            this.Txt_UnitName.Size = new System.Drawing.Size(343, 30);
            this.Txt_UnitName.TabIndex = 4;
            // 
            // Btn_EditUnitPen
            // 
            this.Btn_EditUnitPen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_EditUnitPen.EditValue = ((object)(resources.GetObject("Btn_EditUnitPen.EditValue")));
            this.Btn_EditUnitPen.Location = new System.Drawing.Point(4, 6);
            this.Btn_EditUnitPen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_EditUnitPen.MenuManager = this.ribbon;
            this.Btn_EditUnitPen.Name = "Btn_EditUnitPen";
            this.Btn_EditUnitPen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Btn_EditUnitPen.Properties.Appearance.Options.UseBackColor = true;
            this.Btn_EditUnitPen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Btn_EditUnitPen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.Btn_EditUnitPen.Size = new System.Drawing.Size(44, 27);
            this.Btn_EditUnitPen.TabIndex = 5;
            this.Btn_EditUnitPen.Click += new System.EventHandler(this.Btn_EditUnitPen_Click);
            // 
            // FormShowUnitInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 255);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tajawal Black", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormShowUnitInfo";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " بيانات الوحدة";
            this.Load += new System.EventHandler(this.Form_ShowUnitInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_EditUnitPen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Save;
        private DevExpress.XtraBars.BarButtonItem Btn_Earse;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl Lbl_UnitName;
        private DevExpress.XtraEditors.TextEdit Txt_UnitName;
        private DevExpress.XtraEditors.PictureEdit Btn_EditUnitPen;
    }
}