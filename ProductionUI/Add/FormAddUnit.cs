using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using System;
using System.Windows.Forms;

namespace ProductionUI.Add
{
    public partial class FormAddUnit : RibbonForm
    {
        private readonly FormAddOrder parent;

        public FormAddUnit(FormAddOrder parent = null)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form_AddUnit_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUnit();
            parent?.UpdateUnits();
        }


        public void AddUnit()
        {
            if (SpecialUnit_CheckBx.Checked)
            {
                AddSpecialUnit();
            }
            else
            {
                AddNormailUnit();
            }

            Txt_UnitName.Text = "";
            
            MessageBox.Show("تم إضافة وحدة");
        }

        private void AddNormailUnit()
        {
            GlobalData.UnitOfWork.Units.Add(new Unit
            {
                UnitName = Txt_UnitName.Text,
                CreatedUserId = GlobalData.LoginUser.UserId
            });
            GlobalData.UnitOfWork.Complete();
        }

        private void AddSpecialUnit()
        {
            var maxsortnum = GlobalData.UnitOfWork.Units.GetAllUnitsWithClients().FindLast(e => e.IsDeleted == false && e.IsEnabled && e.IsSpecial).SortNo;
            GlobalData.UnitOfWork.Units.Add(new Unit
            {
                UnitName = Txt_UnitName.Text,
                CreatedUserId = GlobalData.LoginUser.UserId,
                IsSpecial = true,
                SortNo=maxsortnum+1,
                
            });
            GlobalData.UnitOfWork.Complete();
        }

        private void Btn_SaveAndExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUnit();
            parent?.UpdateUnits();
            Close();
        }
    }
}