using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using ProductionUI.Classes.UI_Logic;
using Syncfusion.WinForms.ListView;
using System;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormRelease : RibbonForm
    {
        public FormRelease()
        {
            InitializeComponent();
            CheckBoxValidation(CheckBox_MaterialSize, ComboBox_MaterialSize);
            CheckBoxValidation(CheckBox_MaterialType, ComboBox_MaterialType);
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadDepartment();
            LoadMaterialCategory();


            LoadOrderedBy();
            LoadReason();
        }

        private void LoadReason()
        {
            var reason = GlobalData.UnitOfWork.MaterialsReleasesReasons
                .Find(e => e.IsEnabled && !e.IsDeleted && e.IsChoosable);
            ComboBox_Reason.DataSource = reason;
            ComboBox_Reason.DisplayMember = "MaterialReleaseReason";
            ComboBox_Reason.Text = "----اختر----";
        }

        private void LoadOrderedBy()
        {
            var orderBy = GlobalData.UnitOfWork.Users.Find(e => e.IsEnabled && e.IsLeader && e.IsDeleted == false);
            ComboBox_OrderedBy.DataSource = orderBy;
            ComboBox_OrderedBy.DisplayMember = "UserName";
            ComboBox_OrderedBy.Text = "----اختر----";
        }

        private void LoadMaterialSizes()
        {
            var materialSize =
                GlobalData.UnitOfWork.Materials.GetEnabledMaterialSizesOfMaterial(
                    ((Material)ComboBox_Material.SelectedItem).MaterialId);
            ComboBox_MaterialSize.DataSource = materialSize;
            ComboBox_MaterialSize.DisplayMember = "MaterialSizeName";
        }

        private void LoadMaterialTypes()
        {
            var materialsTypes =
                GlobalData.UnitOfWork.Materials.GetEnabledMaterialTypesOfMaterial(
                    ((Material)ComboBox_Material.SelectedItem).MaterialId);
            //Sakr Code
            ComboBox_MaterialType.DataSource = materialsTypes;
            ComboBox_MaterialType.DisplayMember = "MaterialTypeName";

            //CheckBox_MaterialType.Enabled = true;
        }

        private void LoadMaterial(MaterialCategory materialCategory)
        {
            var material = GlobalData.UnitOfWork.Materials
                .Find(e => e.IsEnabled && e.IsDeleted == false &&
                           e.MaterialCategoryId == materialCategory.MaterialCategoryId);
            ComboBox_Material.DataSource = material;
            ComboBox_Material.DisplayMember = "MaterialName";
            ComboBox_Material.Text = "----اختر----";
        }

        private void LoadMaterialCategory()
        {
            var materialCategory = GlobalData.UnitOfWork.MaterialCategories
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_MaterialCategory.DataSource = materialCategory;
            ComboBox_MaterialCategory.DisplayMember = "CategoryName";
            ComboBox_MaterialCategory.Text = "----اختر----";
        }


        private void LoadDepartment()
        {
            var departments = GlobalData.UnitOfWork.Departments
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_Department.DataSource = departments;
            ComboBox_Department.DisplayMember = "DepartmentName";
            ComboBox_Department.Text = "----اختر----";
        }


        private void CheckBox_MaterialType_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValidation(CheckBox_MaterialType, ComboBox_MaterialType);

            if (ComboBox_Material.SelectedIndex != -1) LoadMaterialTypes();
        }

        private void CheckBox_MaterialSize_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValidation(CheckBox_MaterialSize, ComboBox_MaterialSize);
            if (ComboBox_Material.SelectedIndex != -1) LoadMaterialSizes();
        }

        private void CheckBoxValidation(CheckEdit checkBox, SfComboBox comboBox)
        {
            comboBox.Enabled = checkBox.Checked;
        }

        private void Form_Release_Load(object sender, EventArgs e)
        {
        }

        private void ComboBox_MaterialCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var materialCategory = ComboBox_MaterialCategory.SelectedItem as MaterialCategory;
            LoadMaterial(materialCategory);
        }

        private void ComboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckBox_MaterialSize.Checked)
                LoadMaterialSizes();
            else if (CheckBox_MaterialType.Checked) LoadMaterialTypes();
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReleaseOrder();
            PrintRelease();
        }

        private void ReleaseOrder()
        {
            if (ValidateInputs()) SaveReleaseOrder();
        }

        private void SaveReleaseOrder()
        {
            GlobalData.UnitOfWork.MaterialsReleases.Add(new MaterialRelease
            {
                Department = ComboBox_Department.SelectedItem as Department,
                MaterialCategory = ComboBox_MaterialCategory.SelectedItem as MaterialCategory,
                Material = ComboBox_Material.SelectedItem as Material,
                MaterialType = CheckBox_MaterialType.Checked ? ComboBox_MaterialType.SelectedItem as MaterialType : null,
                MaterialReleaseSize =
                    CheckBox_MaterialSize.Checked ? ComboBox_MaterialSize.SelectedItem as MaterialSize : null,
                ReleaseQuantity = Convert.ToInt32(Txt_Quantity.Text),
                ByOrderOfLeader = ComboBox_OrderedBy.SelectedItem as User,
                MaterialReleaseReasons = ComboBox_Reason.SelectedItem as MaterialReleaseReasons
            });
            GlobalData.UnitOfWork.Complete();
            MessageBox.Show("تم الصرف");
        }

        private bool ValidateInputs()
        {
            var output = true;
            output &= UIValidation.ValidateSfComboBox(ComboBox_Department);
            output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialCategory);
            output &= UIValidation.ValidateSfComboBox(ComboBox_Material);

            output &= UIValidation.ValidateNumericTxtEdit(Txt_Quantity);
            output &= UIValidation.ValidateSfComboBox(ComboBox_OrderedBy);
            output &= UIValidation.ValidateSfComboBox(ComboBox_Reason);
            if (CheckBox_MaterialSize.Checked) output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialSize);

            if (CheckBox_MaterialType.Checked) output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialType);

            return output;
        }

        private void PrintRelease()
        {
            //TODO PRINT FUN
            throw new NotImplementedException();
        }
    }
}