namespace ProductionUI.Add.Productivity
{
    partial class FormAddType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddType));
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
            this.Txt_TypeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TypeName.Properties)).BeginInit();
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
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(307, 162);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Caption = "حفظ";
            this.Btn_Save.Id = 1;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.Btn_Save.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Save.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Save.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // Btn_Earse
            // 
            this.Btn_Earse.Caption = "مسح";
            this.Btn_Earse.Id = 2;
            this.Btn_Earse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Earse.ImageOptions.SvgImage")));
            this.Btn_Earse.ItemAppearance.Disabled.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Hovered.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemAppearance.Hovered.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Normal.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Earse.ItemAppearance.Pressed.Font = new System.Drawing.Font("Sultan bold", 9.75F);
            this.Btn_Earse.ItemAppearance.Pressed.Options.UseFont = true;
            this.Btn_Earse.Name = "Btn_Earse";
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
            this.Btn_Exit.Name = "Btn_Exit";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "إضافة نوع";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 154);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Txt_TypeName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(301, 45);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // Txt_TypeName
            // 
            this.Txt_TypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_TypeName.Location = new System.Drawing.Point(3, 3);
            this.Txt_TypeName.Name = "Txt_TypeName";
            this.Txt_TypeName.Properties.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F);
            this.Txt_TypeName.Properties.Appearance.Options.UseFont = true;
            this.Txt_TypeName.Size = new System.Drawing.Size(213, 32);
            this.Txt_TypeName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sultan bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(238, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "النـــوع";
            // 
            // FormAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 316);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormAddType";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة نوع";
            this.Load += new System.EventHandler(this.Form_AddType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TypeName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.TextEdit Txt_TypeName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Save;
        private DevExpress.XtraBars.BarButtonItem Btn_Earse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem Btn_Exit;
    }
}