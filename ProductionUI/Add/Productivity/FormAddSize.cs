using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using System;
using System.Windows.Forms;

namespace ProductionUI.Add.Productivity
{
    public partial class FormAddSize : RibbonForm
    {
        private MaterialCategory selectedMaterial;
        private FormAddOrEditMaterial parent;
        public FormAddSize()
        {
            InitializeComponent();
        }

        public FormAddSize(MaterialCategory selectedMaterial,FormAddOrEditMaterial parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.selectedMaterial = selectedMaterial;
        }

        private void Btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
            parent?.updateSizesAndTypes();
        }

        private void save()
        {
            var sizeName = Txt_SizeName.Text;
            var height = Convert.ToDouble(Txt_Height.Text);
            var width = Convert.ToDouble(Txt_Width.Text);
            try
            {
                var materialSize = new MaterialSize() ;
                var materialCategory = selectedMaterial as MaterialCategory;
                materialSize.MaterialCategory = materialCategory;
                materialSize.MaterialSizeName = sizeName;
                materialSize.Height = height;
                materialSize.Width = width;
                materialSize.User = GlobalData.LoginUser;
                GlobalData.UnitOfWork.MaterialsSizes.Add(materialSize);
                GlobalData.UnitOfWork.Complete();
                this.Close();

            }
            catch (Exception ex)
            {
                // TODO: Handle failure
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.Message + "");
                
            }
        }
    }
}