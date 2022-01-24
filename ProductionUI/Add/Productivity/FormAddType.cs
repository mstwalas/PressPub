using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using System;
using System.Windows.Forms;

namespace ProductionUI.Add.Productivity
{
    public partial class FormAddType : RibbonForm
    {
        private FormAddOrEditMaterial parent;
        private MaterialCategory selectedMaterial;

        public FormAddType(MaterialCategory selectedMaterial,FormAddOrEditMaterial parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.selectedMaterial = selectedMaterial;
        }

        private void Form_AddType_Load(object sender, EventArgs e)
        {
        }
        private void save()
        {
            var typeName = Txt_TypeName.Text;
            try
            {
                var materialType = new MaterialType();
                var materialCategory = selectedMaterial as MaterialCategory;
                materialType.MaterialCategory = materialCategory;
                materialType.MaterialTypeName = typeName;
                materialType.User = GlobalData.LoginUser;
                GlobalData.UnitOfWork.MaterialsTypes.Add(materialType);
                GlobalData.UnitOfWork.Complete();
                //this.Close();

            }
            catch (Exception ex)
            {
                // TODO: Handle failure
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.Message + "");

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
            parent?.updateSizesAndTypes();
        }
    }
}