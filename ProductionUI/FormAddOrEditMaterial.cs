using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Add.Productivity;
using ProductionUI.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormAddOrEditMaterial : RibbonForm
    {
        private readonly Material material;
        public bool AddFlag = true;

        public FormAddOrEditMaterial(Material material = null)
        {
            InitializeComponent();
            this.material = material;
            Btn_AddSize.Enabled = false;
            Btn_AddType.Enabled = false;

            LoadCategoriesData();
            LoadAndViewMaterialsTypesDataInGridView();
            LoadMaterialsSizesData();
            GridsBestFit();
        }


        private void Btn_AddSize_Click(object sender, EventArgs e)
        {
            var addSize = new FormAddSize();
            addSize.Show();
        }

        

        private void Btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (AddFlag)
            {
                case false:
                    EditMaterialWithTypesAndSizes();
                    EraseAllFields();
                    break;
                case true:
                    ValidateMaterial();
                    EraseAllFields();
                    break;
            }
        }


        public void Material_Load(object sender, EventArgs e)
        {
        }

        private void GridsBestFit()
        {
            GridView_MaterialSizes.BestFitColumns();
            GridView_MaterialTypes.BestFitColumns();
        }

        //ACTIONS START
        private void ComboBox_MaterialCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadAndViewMaterialsTypesDataInGridView();
            LoadMaterialsSizesData();
            Checkbx_HasTypes.Enabled = true;
            Checkbx_HasSizes.Enabled = true;
            if(ComboBox_MaterialCategry.SelectedItem != null && Checkbx_HasSizes.Checked)
            {
                Btn_AddSize.Enabled = true;
            }
            if (ComboBox_MaterialCategry.SelectedItem != null && Checkbx_HasTypes.Checked)
            {
                Btn_AddType.Enabled = true;
            }
        }

        private void Checkbx_HasSizes_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbx_HasSizes.Checked)
            {
                Btn_AddSize.Enabled = true;
                LoadMaterialsSizesData();
            }
            else
            {
                Btn_AddSize.Enabled = false;
                MakeAllMaterialSizesUnchecked();
                DtGrd_MaterialsSizes.Hide();
            }
        }

        private void Checkbx_HasTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbx_HasTypes.Checked)
            {
                Btn_AddType.Enabled = true;
                LoadAndViewMaterialsTypesDataInGridView();
            }
            else
            {
                Btn_AddType.Enabled = false;
                MakeAllMaterialTypesUnchecked();
                DtGrd_MaterialsTypes.Hide();
            }
        }


        public void LoadAndViewMaterialsTypesDataInGridView()
        {
            if (ComboBox_MaterialCategry.SelectedItem != null || ComboBox_MaterialCategry.Text != ""
            )
            {
                DtGrd_MaterialsTypes.Show();
                var selectedMaterialCategory = ComboBox_MaterialCategry.SelectedItem as MaterialCategory;
                var materialTypes = GlobalData.UnitOfWork.MaterialsTypes
                    .Find(e => e.MaterialCategoryId == selectedMaterialCategory.MaterialCategoryId);

                var dt = new DataTable();
                dt.Columns.Add("الرقم التعريفي");
                dt.Columns.Add("المقاسات");
                DtGrd_MaterialsTypes.DataSource = dt;
                DtGrd_MaterialsTypes.MainView.PopulateColumns();


                foreach (var materialType in materialTypes.Select(e => new { e.MaterialTypeId, e.MaterialTypeName }))
                {
                    var dr = dt.NewRow();
                    dr["الرقم التعريفي"] = materialType.MaterialTypeId;
                    dr["المقاسات"] = materialType.MaterialTypeName;
                    dt.Rows.Add(dr);
                }
            }
        }

        public void LoadMaterialsSizesData()
        {
            if (ComboBox_MaterialCategry.SelectedItem != null)
            {
                DtGrd_MaterialsSizes.Show();
                var selectedMaterialCategory = ComboBox_MaterialCategry.SelectedItem as MaterialCategory;
                var materialSizes = GlobalData.UnitOfWork.MaterialsSizes
                    .Find(e => e.MaterialCategoryId == selectedMaterialCategory.MaterialCategoryId);

                var dt = new DataTable();
                dt.Columns.Add("الرقم التعريفي");
                dt.Columns.Add("المقاسات");
                foreach (var materialSize in materialSizes.Select(e => new { e.MaterialSizeId, e.MaterialSizeName }))
                {
                    var dr = dt.NewRow();
                    dr["الرقم التعريفي"] = materialSize.MaterialSizeId;
                    dr["المقاسات"] = materialSize.MaterialSizeName;
                    dt.Rows.Add(dr);
                }

                DtGrd_MaterialsSizes.DataSource = dt;
                DtGrd_MaterialsSizes.MainView.PopulateColumns();
            }
        }

        public void LoadCategoriesData()
        {
            var categories = GlobalData.UnitOfWork.MaterialsCategories
                .Find(e => e.IsEnabled && !e.IsDeleted);
            ComboBox_MaterialCategry.DataSource = categories;
            ComboBox_MaterialCategry.DisplayMember = "CategoryName";
        }

        public void AddMaterialWithTypesAndSizes()
        {
            //null exception must solve-------
            var selectedMaterialCategory = ComboBox_MaterialCategry.SelectedItem as MaterialCategory;
            var newMaterial = new Material
            {
                CreatedUserId = GlobalData.LoginUser.UserId,
                MaterialName = Txt_MaterialName.Text,
                MaterialCategory = selectedMaterialCategory
            };
            GlobalData.UnitOfWork.Materials.Add(newMaterial);


            foreach (var materialTypesId in GetMaterialTypesIds())
                GlobalData.UnitOfWork.MaterialsTypesAssigned.Add(new MaterialTypeAssigned
                {
                    MaterialType = GlobalData.UnitOfWork.MaterialsTypes.Get(materialTypesId),
                    MaterialCategory = selectedMaterialCategory,
                    Material = newMaterial,
                    User = GlobalData.LoginUser
                });

            foreach (var materialSizesId in GetMaterialSizesIds())
                GlobalData.UnitOfWork.MaterialsSizesAssigned.Add(new MaterialSizeAssigned
                {
                    MaterialSize = GlobalData.UnitOfWork.MaterialsSizes.Get(materialSizesId),
                    MaterialCategory = selectedMaterialCategory,
                    Material = newMaterial,
                    User = GlobalData.LoginUser
                });

            GlobalData.UnitOfWork.Complete();
        }

        private IEnumerable<int> GetMaterialSizesIds()
        {
            //MessageBox.Show("تم إضافة خامة");
            var rows = new ArrayList();

            // Add the selected rows to the list.
            var selectedRowHandles = GridView_MaterialSizes.GetSelectedRows();
            foreach (var selectedRowHandle in selectedRowHandles)
                if (selectedRowHandle >= 0)
                    rows.Add(GridView_MaterialSizes.GetDataRow(selectedRowHandle));

            var materialSizesIds = new List<int>();
            foreach (DataRow row in rows) materialSizesIds.Add(int.Parse(row["الرقم التعريفي"].ToString()));

            return materialSizesIds;
        }

        private IEnumerable<int> GetMaterialTypesIds()
        {
            var rows = new ArrayList();

            // Add the selected rows to the list.
            var selectedRowHandles = GridView_MaterialTypes.GetSelectedRows();
            foreach (var selectedRowHandle in selectedRowHandles)
                if (selectedRowHandle >= 0)
                    rows.Add(GridView_MaterialTypes.GetDataRow(selectedRowHandle));

            var materialTypesIds = new List<int>();
            foreach (DataRow row in rows) materialTypesIds.Add(int.Parse(row["الرقم التعريفي"].ToString()));

            return materialTypesIds;
        }

        public void ValidateMaterial()
        {
            if (GlobalData.UnitOfWork.Materials.SingleOrDefault(e => e.MaterialName == Txt_MaterialName.Text) ==
                    null && AddFlag)
                //ADD MODE
                AddMaterialWithTypesAndSizes();
            else if (GlobalData.UnitOfWork.Materials.SingleOrDefault(e => e.MaterialName == Txt_MaterialName.Text) ==
                    null && AddFlag == false)
                //EDIT MODE
                EditMaterialWithTypesAndSizes();
            else
                MessageBox.Show("اسم الخامة موجود مسبقا");
        }


        public void EditMaterialWithTypesAndSizes()
        {
            UpdateSizes();
            UpdateTypes();
        }


        public void UpdateSizes()
        {
            //SIZES LIST
            var newSizesIdInt = new List<int>();
            var oldSizesIdInt = new List<int>();
            //TYPES LIST

            foreach (var sizeAssigned in material.MaterialSizeAssigned.Where(e => e.IsEnabled))
                oldSizesIdInt.Add(sizeAssigned.MaterialSizeId);

            foreach (var rowSelected in GridView_MaterialSizes.GetSelectedRows())
                newSizesIdInt.Add(Convert.ToInt32(GridView_MaterialSizes.GetDataRow(rowSelected)[0]));

            var diffNewRows = newSizesIdInt.Except(oldSizesIdInt);
            var diffrentDisabled = oldSizesIdInt.Except(newSizesIdInt);
            if (diffrentDisabled.Count() != 0)
                foreach (var diffRowDisable in diffrentDisabled)
                {
                    var assignedSize =
                        material.MaterialSizeAssigned.SingleOrDefault(e => e.MaterialSizeId == diffRowDisable);

                    if (assignedSize != null)
                        assignedSize.IsEnabled = true;
                    else
                        GlobalData.UnitOfWork.MaterialsSizesAssigned.Add(new MaterialSizeAssigned
                        {
                            Material = material,
                            MaterialCategory = material.MaterialCategory,
                            MaterialSizeId = diffRowDisable,
                            User = GlobalData.LoginUser
                        });

                    foreach (var diffRowDisabled in diffrentDisabled)
                        //MessageBox.Show(diffRowDisabled.ToString());
                        material.MaterialSizeAssigned
                            .Single(e => e.MaterialSizeId == diffRowDisabled)
                            .IsEnabled = false;

                    GlobalData.UnitOfWork.Complete();
                }

            if (diffNewRows.Count() != 0)
                foreach (var diffRowNew in diffNewRows)
                {
                    var assignedSize =
                        material.MaterialSizeAssigned.SingleOrDefault(e => e.MaterialSizeId == diffRowNew);

                    if (assignedSize != null)
                        assignedSize.IsEnabled = true;
                    else
                        GlobalData.UnitOfWork.MaterialsSizesAssigned.Add(new MaterialSizeAssigned
                        {
                            Material = material,
                            MaterialCategory = material.MaterialCategory,
                            MaterialSizeId = diffRowNew,
                            User = GlobalData.LoginUser
                        });

                    foreach (var diffRowDisabled in diffrentDisabled)
                        material.MaterialSizeAssigned
                            .Single(e => e.MaterialSizeId == diffRowDisabled)
                            .IsEnabled = false;

                    GlobalData.UnitOfWork.Complete();
                }
        }

        //public void UpdateTypes()
        //{
        //    //TYPES LIST
        //    List<int> newTypesIdInt = new List<int>();
        //    List<int> oldTypesIdInt = new List<int>();

        //    foreach (var TypeAssigned in selectedMaterial.MaterialTypeAssigned.
        //        Where(e => e.IsEnabled == true))
        //    {
        //        oldTypesIdInt.Add(TypeAssigned.MaterialTypeId);
        //    }

        //    foreach (var rowSelected in GridView_MaterialTypes.GetSelectedRows())
        //    {
        //        newTypesIdInt.Add(Convert.ToInt32(GridView_MaterialTypes.GetDataRow(rowSelected)[0]));
        //    }

        //    var differentNew = newTypesIdInt.Except(oldTypesIdInt);
        //    var differentDisabled = oldTypesIdInt.Except(newTypesIdInt);
        //    if (differentDisabled.Count() != 0)
        //    {
        //        foreach (var diffRowDisable in differentDisabled)
        //        {
        //            var assignedType = selectedMaterial.MaterialTypeAssigned.
        //                SingleOrDefault(e => e.MaterialTypeId == diffRowDisable);
        //            bool isExist = assignedType != null;
        //            if (isExist)
        //            {
        //                assignedType.IsEnabled = true;
        //            }
        //            else
        //            {
        //                GlobalData.unitOfWork.MaterialsTypesAssigned.Add(new MaterialTypeAssigned
        //                {
        //                    Material = this.selectedMaterial,
        //                    MaterialCategory = this.selectedMaterial.MaterialCategory,
        //                    MaterialTypeId = diffRowDisable,
        //                    User = GlobalData.LoginUser,
        //                });


        //            }

        //            foreach (var diffRowDisabled in differentDisabled)
        //            {
        //              //  MessageBox.Show(diffRowDisabled.ToString());
        //                selectedMaterial.MaterialTypeAssigned
        //                    .Single(e => e.MaterialTypeId == diffRowDisabled)
        //                    .IsEnabled = false;
        //            }

        //            GlobalData.unitOfWork.Complete();

        //        }
        //    }
        //    if (differentNew.Count() != 0)
        //    {
        //        foreach (var diffRowNew in differentNew)
        //        {
        //           // MessageBox.Show(diffRowNew.ToString());
        //            var assignedType = selectedMaterial.MaterialTypeAssigned.
        //                SingleOrDefault(e => e.MaterialTypeId == diffRowNew);
        //            bool isExist = assignedType != null;
        //            if (isExist)
        //            {
        //                assignedType.IsEnabled = true;
        //            }
        //            else
        //            {
        //                GlobalData.unitOfWork.MaterialsTypesAssigned.Add(new MaterialTypeAssigned
        //                {
        //                    Material = this.selectedMaterial,
        //                    MaterialCategory = this.selectedMaterial.MaterialCategory,
        //                    MaterialTypeId = diffRowNew,
        //                    User = GlobalData.LoginUser,
        //                });


        //            }

        //            foreach (var diffRowDisabled in differentDisabled)
        //            {
        //               // MessageBox.Show(diffRowDisabled.ToString());
        //                selectedMaterial.MaterialTypeAssigned
        //                    .Single(e => e.MaterialTypeId == diffRowDisabled)
        //                    .IsEnabled = false;
        //            }

        //            GlobalData.unitOfWork.Complete();


        //        }
        //    }
        //}

        public void UpdateTypes()
        {
            //SIZES LIST
            var newTypesIdInt = new List<int>();
            var oldTypesIdInt = new List<int>();
            //TYPES LIST

            foreach (var typeAssigned in material.MaterialTypeAssigned.Where(e => e.IsEnabled))
                oldTypesIdInt.Add(typeAssigned.MaterialTypeId);

            foreach (var rowSelected in GridView_MaterialTypes.GetSelectedRows())
                newTypesIdInt.Add(Convert.ToInt32(GridView_MaterialTypes.GetDataRow(rowSelected)[0]));

            var differentNew = newTypesIdInt.Except(oldTypesIdInt);

            var differentDisabled = oldTypesIdInt.Except(newTypesIdInt);

            if (differentDisabled.Count() != 0)
                foreach (var diffRowDisable in differentDisabled)
                {
                    var assignedType =
                        material.MaterialTypeAssigned
                            .SingleOrDefault(e =>
                                e.MaterialTypeId == diffRowDisable);
                    if (assignedType != null)
                        assignedType.IsEnabled = true;
                    else
                        GlobalData.UnitOfWork.MaterialsTypesAssigned.Add(new MaterialTypeAssigned
                        {
                            Material = material,
                            MaterialCategory = material.MaterialCategory,
                            MaterialTypeId = diffRowDisable,
                            User = GlobalData.LoginUser
                        });

                    foreach (var diffRowDisabled in differentDisabled)
                        //MessageBox.Show(diffRowDisabled.ToString());
                        material.MaterialTypeAssigned
                            .Single(e => e.MaterialTypeId == diffRowDisabled)
                            .IsEnabled = false;

                    GlobalData.UnitOfWork.Complete();
                }

            if (differentNew.Count() != 0)
                foreach (var diffRowNew in differentNew)
                {
                    // MessageBox.Show(diffRowNew.ToString());
                    var assignedType =
                        material.MaterialTypeAssigned.SingleOrDefault(e => e.MaterialTypeId == diffRowNew);

                    if (assignedType != null)
                        assignedType.IsEnabled = true;
                    else
                        GlobalData.UnitOfWork.MaterialsTypesAssigned.Add(new MaterialTypeAssigned
                        {
                            Material = material,
                            MaterialCategory = material.MaterialCategory,
                            MaterialTypeId = diffRowNew,
                            User = GlobalData.LoginUser
                        });

                    foreach (var diffRowDisabled in differentDisabled)
                        // MessageBox.Show(diffRowDisabled.ToString());
                        material.MaterialTypeAssigned
                            .Single(e => e.MaterialTypeId == diffRowDisabled)
                            .IsEnabled = false;

                    GlobalData.UnitOfWork.Complete();
                }
        }


        public void LoadMaterialForViewAndEdit(Material selectedMaterial)
        {
            ViewAndEditControlsConfiguration();

            Txt_MaterialName.Text = selectedMaterial.MaterialName;
            ComboBox_MaterialCategry.SelectedValue = selectedMaterial.MaterialCategory.CategoryName;

            LoadCheckedMaterialSizesForMaterial(material);

            LoadCheckedMaterialTypesForMaterial(material);
        }

        private void MakeAllMaterialTypesUnchecked()
        {
            for (var row = 0; row < GridView_MaterialTypes.RowCount; row++)
            {
                GridView_MaterialTypes.FocusedRowHandle = row;
                GridView_MaterialTypes.UnselectRow(row);
            }
        }

        private void MakeAllMaterialSizesUnchecked()
        {
            for (var row = 0; row < GridView_MaterialSizes.RowCount; row++)
            {
                GridView_MaterialSizes.FocusedRowHandle = row;
                GridView_MaterialSizes.UnselectRow(row);
            }
        }

        private void LoadCheckedMaterialTypesForMaterial(Material material1)
        {
            var enabledMaterialTypesAssignedIds
                = material.MaterialTypeAssigned
                    .Where(e => e.IsEnabled)
                    .Select(e => e.MaterialTypeId);

            foreach (var materialTypeId in enabledMaterialTypesAssignedIds)
                for (var row = 0; row < GridView_MaterialTypes.RowCount; row++)
                {
                    var check = GridView_MaterialTypes.GetDataRow(row);
                    if (Convert.ToInt32(check[0]) == materialTypeId)
                    {
                        GridView_MaterialTypes.FocusedRowHandle = row;
                        GridView_MaterialTypes.SelectRow(row);
                    }
                }
        }

        private void LoadCheckedMaterialSizesForMaterial(Material material)
        {
            var enabledMaterialSizesAssignedIds
                = this.material.MaterialSizeAssigned
                    .Where(e => e.IsEnabled)
                    .Select(e => e.MaterialSizeId);

            foreach (var materialSizeId in enabledMaterialSizesAssignedIds)
                for (var row = 0; row < GridView_MaterialSizes.RowCount; row++)
                {
                    var check = GridView_MaterialSizes.GetDataRow(row);
                    if (Convert.ToInt32(check[0]) == materialSizeId)
                    {
                        GridView_MaterialSizes.FocusedRowHandle = row;
                        GridView_MaterialSizes.SelectRow(row);
                    }
                }
        }

        private void ViewAndEditControlsConfiguration()
        {
            Txt_MaterialName.ReadOnly = true;
            ComboBox_MaterialCategry.TextBox.ReadOnly = true;
            ComboBox_MaterialCategry.Enabled = false;

            Btn_Save.Enabled = false;

            Checkbx_HasTypes.Enabled = true;
            Checkbx_HasTypes.Checked = true;

            Checkbx_HasSizes.Enabled = true;
            Checkbx_HasSizes.Checked = true;


            DtGrd_MaterialsSizes.Visible = true;
            DtGrd_MaterialsTypes.Visible = true;
        }


        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (AddFlag)
            {
                case false:
                    EditMaterialWithTypesAndSizes();
                    break;
                case true:
                    ValidateMaterial();
                    break;
            }

            Close();
        }

        public void EraseAllFields()
        {
            GridView_MaterialTypes.CancelSelection();
            Txt_MaterialName.Text = "";

            ComboBox_MaterialCategry.Text = "";
        }

        private void Btn_Erase_ItemClick(object sender, ItemClickEventArgs e)
        {
            EraseAllFields();
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        
        private void Btn_AddSize_Click_1(object sender, EventArgs e)
        {
            var selectedMaterial = ComboBox_MaterialCategry.SelectedItem as MaterialCategory;
            
            FormAddSize formAddSize = new FormAddSize(selectedMaterial,this);
            formAddSize.Show();
        }

        public void updateSizesAndTypes()
        {
            if (AddFlag == true)
            {
                LoadAndViewMaterialsTypesDataInGridView();
                LoadMaterialsSizesData();
                GridsBestFit();
            }
            else
            {
                LoadAndViewMaterialsTypesDataInGridView();
                LoadMaterialForViewAndEdit(material);
                GridsBestFit();
            }
        }
        private void Btn_AddType_Click_1(object sender, EventArgs e)
        {
            var selectedMaterial = ComboBox_MaterialCategry.SelectedItem as MaterialCategory;
            FormAddType formAddType = new FormAddType(selectedMaterial,this);
            formAddType.Show();
        }
    }
}