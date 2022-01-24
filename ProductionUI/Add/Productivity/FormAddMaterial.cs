using DevExpress.XtraBars.Ribbon;
using System;

namespace ProductionUI.Add.Productivity
{
    public partial class FormAddMaterial : RibbonForm
    {
        public FormAddMaterial()
        {
            InitializeComponent();
        }

        private void Btn_AddCategory_Click(object sender, EventArgs e)
        {
            var addCat = new FormAddCategory();
            addCat.Show();
        }
    }
}