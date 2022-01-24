using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using ProductionUI.Classes.UI_Logic;
using System;
using System.Globalization;
using System.Windows.Forms;
using ProductionUI.Show;

namespace ProductionUI.Add
{
    public partial class FormAddOrEditProduct : RibbonForm
    {
        public bool AddFlag;

        private readonly Product product;
        private readonly FormShowProducts parent;
        public FormAddOrEditProduct(FormShowProducts parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            LoadDepartments();
            LoadMaterialCategories();
            DisableAndResetControls();
        }

        public FormAddOrEditProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            DisableNotEditableComponent();
            LoadProduct();
            LoadMaterialsSizesByCategory();
        }

        //Edit Mode
        //TODO: edit load material sizes for production and release
        private void LoadMaterialsSizesByCategory()

        {
            var materialSizes = GlobalData.UnitOfWork.MaterialsSizes
                .Find(e => e.IsEnabled &&
                           e.IsDeleted == false && e.MaterialCategoryId == product.MaterialCategoryId);
            ComboBox_ReleaseSize.DataSource = materialSizes;
            ComboBox_ReleaseSize.DisplayMember = "MaterialSizeName";
        }

        private void LoadProduct()
        {
            ComboBox_Department.Text = product.Department != null ? product.Department.DepartmentName : "";

            ComboBox_Material.Text = product.Material != null ? product.Material.MaterialName : "";

            ComboBox_ReleaseSize.Text = product.ReleaseSize != null ? product.ReleaseSize.MaterialSizeName : "";

            ComboBox_MaterialSize.Text = product.MaterialSize != null ? product.MaterialSize.MaterialSizeName : "";

            ComboBox_MaterialType.Text = product.MaterialType != null ? product.MaterialType.MaterialTypeName : "";

            ComboBox_ProductionProcess.Text =
                product.ProductionProcess != null ? product.ProductionProcess.ProductionProcessName : "";

            ComboBox_MaterialCategories.Text =
                product.MaterialCategory != null ? product.MaterialCategory.CategoryName : "";

            SpnEdit_WastRatio.Text = product.MaterialWastRatio != null ? product.MaterialWastRatio.ToString() : "";

            Txt_ProductName.Text = product.ProductName ?? "";

            Txt_ProductPrice.Text = product.ProductSellPrice.ToString(CultureInfo.InvariantCulture);

            Txt_Suggestion.Text = "";
        }

        private void DisableNotEditableComponent()
        {
            ComboBox_Department.TextBox.ReadOnly = true;
            ComboBox_Material.Enabled = false;
            ComboBox_ReleaseSize.TextBox.ReadOnly = true;
            ComboBox_MaterialSize.TextBox.ReadOnly = true;
            ComboBox_MaterialType.TextBox.ReadOnly = true;
            ComboBox_ProductionProcess.TextBox.ReadOnly = true;
            ComboBox_MaterialCategories.TextBox.ReadOnly = true;
            CheckBox_MaterialType.ReadOnly = true;
            ComboBox_Material.TextBox.ReadOnly = true;
            ComboBox_Material.Enabled = true;

            //  CheckBox_MaterialSize.ReadOnly = true;

            CheckBox_ProductHasMaterial.ReadOnly = true;
            Btn_Easer.Enabled = false;

            SpnEdit_WastRatio.ReadOnly = false;
            CheckBox_MaterialSize.ReadOnly = false;
        }

        private void Form_AddOrEditProduct_Load(object sender, EventArgs e)
        {
            // DisableAndResetControls();
        }

        private bool ValidateForm()
        {
            var output = true;

            output &= UIValidation.ValidateStringTxtbxs(Txt_ProductName);
            output &= UIValidation.ValidateNumericTxtEdit(Txt_ProductPrice);


            output &= UIValidation.ValidateSfComboBox(ComboBox_Material);
            output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialType);
            output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialCategories);
            output &= UIValidation.ValidateSfComboBox(ComboBox_MaterialSize);
            output &= UIValidation.ValidateSfComboBox(ComboBox_Department);
            output &= UIValidation.ValidateSfComboBox(ComboBox_ReleaseSize);
            output &= UIValidation.ValidateSfComboBox(ComboBox_ProductionProcess);


            // TxtBx_ItemPrice.Text = "1";

            return output;
        }

        public void DisableAndResetControls()
        {
            ComboBox_Department.SelectedIndex = -1;
            ComboBox_Department.Text = "--برجاء اختيار القسم";
            ComboBox_Department.Enabled = true;
            ComboBox_Material.Enabled = false;
            ComboBox_Material.SelectedIndex = -1;
            ComboBox_ReleaseSize.Enabled = false;
            ComboBox_ReleaseSize.SelectedIndex = -1;
            ComboBox_MaterialSize.Enabled = false;
            ComboBox_MaterialSize.SelectedIndex = -1;
            ComboBox_MaterialType.Enabled = false;
            ComboBox_MaterialType.SelectedIndex = -1;
            ComboBox_ProductionProcess.Enabled = false;
            ComboBox_ProductionProcess.SelectedIndex = -1;
            //
            ComboBox_MaterialCategories.SelectedIndex = -1;
            ComboBox_MaterialCategories.Enabled = false;
            SpnEdit_WastRatio.Enabled = false;
            SpnEdit_WastRatio.Text = "0";
            CheckBox_MaterialSize.Checked = false;
            CheckBox_MaterialType.Checked = false;
            CheckBox_ProductHasMaterial.Checked = false;

            Txt_ProductName.Enabled = true;
            Txt_ProductName.Text = "";
            Txt_ProductPrice.Enabled = true;
            Txt_ProductPrice.Text = "";
            Txt_Suggestion.Enabled = true;
            Txt_Suggestion.Text = "";
            CheckBox_MaterialType.Enabled = false;
            CheckBox_MaterialSize.Enabled = false;
        }

        private void EnableMaterialCategries()
        {
            //if (ComboBox_MaterialCategories.SelectedIndex != -1 && CheckBox_ProductHasMaterial.Checked == true || CheckBox_ProductHasMaterial.Checked == true)
            if (ComboBox_MaterialCategories.SelectedIndex != -1 && CheckBox_ProductHasMaterial.Checked ||
                CheckBox_ProductHasMaterial.Checked)
            {
                CheckBox_MaterialSize.Enabled = true;
                CheckBox_MaterialType.Enabled = true;
                ComboBox_MaterialCategories.Enabled = true;
                ComboBox_Material.Enabled = true;
                ComboBox_MaterialCategories.Text = "--برجاء اختيار التصنيف --";
                ComboBox_MaterialCategories.Enabled = true;
                ComboBox_Material.Text = "--برجاء اختيار الخامة --";
            }
            else
            {
                ComboBox_MaterialCategories.Text = "";
                ComboBox_Material.Text = "";
                ComboBox_MaterialCategories.SelectedIndex = -1;
                ComboBox_MaterialCategories.Enabled = false;

                CheckBox_MaterialSize.Enabled = false;
                CheckBox_MaterialSize.Checked = false;
                CheckBox_MaterialType.Enabled = false;
                CheckBox_MaterialType.Checked = false;

                ComboBox_Material.Enabled = false;
                ComboBox_Material.SelectedIndex = -1;

                ComboBox_MaterialSize.Enabled = false;

                ComboBox_MaterialType.Enabled = false;

                ComboBox_MaterialSize.SelectedIndex = -1;

                ComboBox_MaterialType.SelectedIndex = -1;

                ComboBox_ReleaseSize.Enabled = false;

                ComboBox_ReleaseSize.SelectedIndex = -1;

                ComboBox_Material.SelectedIndex = -1;
                SpnEdit_WastRatio.Text = "";
                SpnEdit_WastRatio.Enabled = false;
            }
        }

        private void CheckBox_ProductHasMaterial_CheckedChanged(object sender, EventArgs e)
        {
            EnableMaterialCategries();
        }

        private void ComboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("cmb_Department" + ComboBox_Department.SelectedIndex + "");

            if (ComboBox_Department.SelectedIndex != -1) ComboBox_ProductionProcess.Enabled = true;
        }


        public void LoadDepartments()
        {
            var departments = GlobalData.UnitOfWork.Departments
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_Department.DataSource = departments;
            ComboBox_Department.DisplayMember = "DepartmentName";
        }

        private void Btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (!ValidateForm())
            {
                UIValidation.ShowErrorMessage();
            }
            else
            {
                if (product == null )
                {
                    AddProduct();
                    DisableAndResetControls();
                    parent?.LoadNewProductToGridView();
                }
                else
                {
                    EditProduct();
                }
            }
        }

        private void EditProduct()
        {
            product.ProductName = Txt_ProductName.Text;
            product.ProductSellPrice = Convert.ToDecimal(Txt_ProductPrice.Text);
            product.MaterialWastRatio = SpnEdit_WastRatio.Value;
            product.ReleaseSize = (MaterialSize)ComboBox_ReleaseSize.SelectedItem;
            GlobalData.UnitOfWork.Complete();
        }

        private void AddProduct()
        {
            GlobalData.UnitOfWork.Products.Add(new Product
            {
                Department = ComboBox_Department.SelectedItem as Department,
                ProductionProcess = ComboBox_ProductionProcess.SelectedItem as ProductionProcess,
                MaterialCategory = CheckBox_ProductHasMaterial.Checked
                    ? ComboBox_MaterialCategories.SelectedItem as MaterialCategory
                    : null,
                Material = CheckBox_ProductHasMaterial.Checked ? ComboBox_Material.SelectedItem as Material : null,
                MaterialType = CheckBox_MaterialType.Checked ? ComboBox_MaterialType.SelectedItem as MaterialType : null,
                MaterialSize = CheckBox_MaterialSize.Checked ? ComboBox_MaterialSize.SelectedItem as MaterialSize : null,
                ReleaseSize = CheckBox_MaterialSize.Checked ? ComboBox_ReleaseSize.SelectedItem as MaterialSize : null,
                MaterialWastRatio = CheckBox_MaterialSize.Checked ? Convert.ToDecimal(SpnEdit_WastRatio.Text) : 0,
                ProductSellPrice = Convert.ToDecimal(Txt_ProductPrice.Text),
                ProductName = Txt_ProductName.Text,
                CreatedUserId = GlobalData.LoginUser.UserId
            });
            GlobalData.UnitOfWork.Complete();
        }


        private void ComboBox_Department_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBox_Department.SelectedIndex != -1) LoadProductionsProcesses();
        }

        private void LoadProductionsProcesses()
        {
            var productionProcesses =
                GlobalData.UnitOfWork.ProductionsProcesses
                    .Find(process => process.IsEnabled && process.IsDeleted == false
                                                       && process.DepartmentId ==
                                                       ((Department)ComboBox_Department.SelectedItem).DepartmentId);
            ComboBox_ProductionProcess.DataSource = productionProcesses;
            ComboBox_ProductionProcess.DisplayMember = "ProductionProcessName";
            ComboBox_ProductionProcess.Enabled = true;
            ComboBox_ProductionProcess.Text = "--برجاء اختيار العملية";
        }

        private void LoadMaterialCategories()
        {
            var materialsCategories = GlobalData.UnitOfWork.MaterialsCategories
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_MaterialCategories.DataSource = materialsCategories;
            ComboBox_MaterialCategories.DisplayMember = "CategoryName";
        }

        private void LoadMaterials()
        {
            var materials = GlobalData.UnitOfWork.Materials
                .Find(e => e.IsEnabled && e.IsDeleted == false
                                       && e.MaterialCategoryId ==
                                       ((MaterialCategory)ComboBox_MaterialCategories.SelectedItem).MaterialCategoryId);
            ComboBox_Material.DataSource = materials;
            ComboBox_Material.DisplayMember = "MaterialName";
        }


        private void LoadMaterialsTypes()
        {
            var materialsTypes =
                GlobalData.UnitOfWork.Materials.GetEnabledMaterialTypesOfMaterial(
                    ((Material)ComboBox_Material.SelectedItem).MaterialId);
            //Sakr Code
            ComboBox_MaterialType.DataSource = materialsTypes;
            ComboBox_MaterialType.DisplayMember = "MaterialTypeName";
            //ComboBox_MaterialType.Text = "--برجاء اختيار نوع الخامة --";
            //CheckBox_MaterialType.Enabled = true;
        }

        private void LoadMaterialsSizes()
        {
            var materialSizes = GlobalData.UnitOfWork.Materials
                .Find(e => e.IsEnabled && e.IsDeleted == false
                                       && e.MaterialId == ((Material)ComboBox_Material.SelectedItem).MaterialId);
            ComboBox_MaterialType.DataSource = materialSizes;
            ComboBox_MaterialType.DisplayMember = "MaterialName";
        }

        private void ComboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Material.SelectedIndex != -1 && CheckBox_MaterialSize.Checked)
            {
                ComboBox_MaterialSize.Enabled = true;
                ComboBox_MaterialSize.Text = "---اختر مقاس الخامة ---";
                LoadMaterialSize();
            }
            else if (ComboBox_Material.SelectedIndex != -1 && CheckBox_MaterialType.Checked)
            {
                ComboBox_MaterialType.Enabled = true;

                ComboBox_MaterialType.Text = "---اختر نوع الخامة ---";
                LoadMaterialsTypes();
            }
        }

        private void ComboBox_MaterialCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateMaterialCategories();
        }

        private void ValidateMaterialCategories()
        {
            if (ComboBox_MaterialCategories.SelectedIndex != -1)
            {
                LoadMaterials();
                EnableMaterial();
            }
        }

        private void EnableMaterial()
        {
            if (CheckBox_ProductHasMaterial.Checked)
            {
                ComboBox_Material.Enabled = true;
                ComboBox_Material.Text = "--برجاء اختيار الخامة --";
            }
            else
            {
                ComboBox_Material.Enabled = false;
                ComboBox_Material.Text = "";
            }
        }

        private void ComboBox_ProductionProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void Btn_Easer_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisableAndResetControls();
        }

        private void EnableMaterialType()
        {
            if (CheckBox_MaterialType.Checked && ComboBox_Material.SelectedIndex != -1)
            {
                ComboBox_MaterialType.Text = "--برجاء ادخال نوع الخامة --";
                ComboBox_MaterialType.Enabled = true;
            }
            else
            {
                ComboBox_MaterialType.Enabled = false;
                ComboBox_MaterialType.Text = "";
            }
        }

        private void CheckBox_MaterialType_CheckedChanged(object sender, EventArgs e)
        {
            //if (CheckBox_MaterialType.Checked && ComboBox_Material.SelectedIndex != -1)
            //{
            //    LoadMaterialsTypes();
            //    EnableMaterialType();
            //}
            //else if (CheckBox_MaterialSize.Checked && ComboBox_Material.SelectedIndex != -1)
            //{
            //    ValidateMaterialType();
            //}
            //else
            //{
            //    ComboBox_MaterialType.Enabled = false;
            //    ComboBox_MaterialType.Text = "";
            //    ComboBox_MaterialSize.Enabled = false;
            //    ComboBox_MaterialSize.Text = "";
            //}
            if (CheckBox_MaterialType.Checked && ComboBox_Material.SelectedIndex != -1)
            {
                EnableMaterialType();
                LoadMaterialsTypes();
            }
            else
            {
                ComboBox_MaterialType.Enabled = false;
                ComboBox_MaterialType.Text = "";
                ComboBox_MaterialType.SelectedIndex = -1;
                //ComboBox_MaterialSize.Enabled = false;
                //ComboBox_MaterialSize.Text = "";
            }
        }

        private void ComboBox_MaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ValidateMaterialType();
        }

        private void ValidateMaterialType()
        {
            if (ComboBox_Material.SelectedIndex != -1 && CheckBox_MaterialSize.Checked)
            {
                ComboBox_MaterialSize.Enabled = true;
                ComboBox_MaterialSize.Text = "---اختر مقاس الخامة ---";
                LoadMaterialSize();
            }
            //else if (CheckBox_MaterialSize.Checked==false)
            //{
            //    ComboBox_MaterialSize.Enabled = false;
            //    ComboBox_ReleaseSize.Enabled = false;
            //}
            else
            {
                ComboBox_MaterialSize.Text = "";
                ComboBox_MaterialSize.Enabled = false;
                ComboBox_ReleaseSize.Enabled = false;
                ComboBox_MaterialSize.SelectedIndex = -1;
                ComboBox_ReleaseSize.SelectedIndex = -1;
                SpnEdit_WastRatio.Text = "";
                SpnEdit_WastRatio.Enabled = false;
                ValidateMaterialSize();
            }
        }

        private void LoadMaterialSize()
        {
            var materialSize =
                GlobalData.UnitOfWork.Materials.GetEnabledMaterialSizesOfMaterial(
                    (ComboBox_Material.SelectedItem as Material).MaterialId);
            ComboBox_MaterialSize.DataSource = materialSize;
            ComboBox_MaterialSize.DisplayMember = "MaterialSizeName";
        }

        private void ComboBox_MaterialSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateMaterialSize();
        }

        private void ValidateMaterialSize()
        {
            if (ComboBox_MaterialSize.SelectedIndex != -1 && ComboBox_MaterialSize.Enabled)
            {
                ComboBox_ReleaseSize.Enabled = true;
                ComboBox_ReleaseSize.Text = "---اختر مقاس الصرف ---";
                LoadReleaseSize();
            }
            else
            {
                ComboBox_ReleaseSize.Text = "";
            }
        }

        private void LoadReleaseSize()
        {
            var releaseSize = GlobalData.UnitOfWork.MaterialsSizes
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            ComboBox_ReleaseSize.DataSource = releaseSize;
            ComboBox_ReleaseSize.DisplayMember = "MaterialSizeName";
        }

        private void ComboBox_ReleaseSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateReleaseSize();
        }

        private void ValidateReleaseSize()
        {
            if (ComboBox_ReleaseSize.SelectedIndex != -1) SpnEdit_WastRatio.Enabled = true;
        }

        private void SpnEdit_WastRatio_EditValueChanged(object sender, EventArgs e)
        {
            ValidateSpnEdit();
        }

        private void ValidateSpnEdit()
        {
            if (SpnEdit_WastRatio.Value > 0 && SpnEdit_WastRatio.Value < 100)
            {
                Txt_Suggestion.Enabled = true;
                Txt_Suggestion.Enabled = true;
                Txt_ProductName.Enabled = true;
                Txt_ProductPrice.Enabled = true;
            }
        }

        private void CheckBox_MaterialSize_CheckedChanged(object sender, EventArgs e)
        {
            ValidateMaterialType();
        }

        private void Btn_SaveAndExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (product == null)
                AddProduct();
            else
                EditProduct();

            Close();
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}