namespace ProductionUI.Add
{
    partial class FormAddUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUnit));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Earse = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_SaveAndExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.SpecialUnit_Label = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Quantity = new DevExpress.XtraEditors.LabelControl();
            this.Txt_UnitName = new DevExpress.XtraEditors.TextEdit();
            this.SpecialUnit_CheckBx = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialUnit_CheckBx.Properties)).BeginInit();
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
            this.Btn_Exit,
            this.Btn_SaveAndExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(500, 166);
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
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tajawal Black", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "إضافة وحدة";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_SaveAndExit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 140);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel21, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanel21.Controls.Add(this.SpecialUnit_Label, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.Lbl_Quantity, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.Txt_UnitName, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.SpecialUnit_CheckBx, 1, 1);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(488, 88);
            this.tableLayoutPanel21.TabIndex = 4;
            // 
            // SpecialUnit_Label
            // 
            this.SpecialUnit_Label.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.SpecialUnit_Label.Appearance.Options.UseFont = true;
            this.SpecialUnit_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpecialUnit_Label.Location = new System.Drawing.Point(403, 47);
            this.SpecialUnit_Label.Name = "SpecialUnit_Label";
            this.SpecialUnit_Label.Size = new System.Drawing.Size(82, 24);
            this.SpecialUnit_Label.TabIndex = 5;
            this.SpecialUnit_Label.Text = "وحدة خاصه";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.Appearance.Font = new System.Drawing.Font("Tajawal Black", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Quantity.Appearance.Options.UseFont = true;
            this.Lbl_Quantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_Quantity.Location = new System.Drawing.Point(398, 3);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(87, 24);
            this.Lbl_Quantity.TabIndex = 0;
            this.Lbl_Quantity.Text = "إسم الوحدة";
            // 
            // Txt_UnitName
            // 
            this.Txt_UnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_UnitName.EditValue = "";
            this.Txt_UnitName.Location = new System.Drawing.Point(3, 3);
            this.Txt_UnitName.Name = "Txt_UnitName";
            this.Txt_UnitName.Properties.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Txt_UnitName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UnitName.Size = new System.Drawing.Size(372, 32);
            this.Txt_UnitName.TabIndex = 4;
            // 
            // SpecialUnit_CheckBx
            // 
            this.SpecialUnit_CheckBx.Location = new System.Drawing.Point(300, 47);
            this.SpecialUnit_CheckBx.MenuManager = this.ribbon;
            this.SpecialUnit_CheckBx.Name = "SpecialUnit_CheckBx";
            this.SpecialUnit_CheckBx.Properties.Caption = "";
            this.SpecialUnit_CheckBx.Size = new System.Drawing.Size(75, 20);
            this.SpecialUnit_CheckBx.TabIndex = 6;
            // 
            // FormAddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(502, 275);
            this.Name = "FormAddUnit";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة وحدة";
            this.Load += new System.EventHandler(this.Form_AddUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialUnit_CheckBx.Properties)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private DevExpress.XtraEditors.LabelControl Lbl_Quantity;
        private DevExpress.XtraEditors.TextEdit Txt_UnitName;
        private DevExpress.XtraBars.BarButtonItem Btn_SaveAndExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.LabelControl SpecialUnit_Label;
        private DevExpress.XtraEditors.CheckEdit SpecialUnit_CheckBx;
    }
}