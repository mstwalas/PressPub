using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Add;
using ProductionUI.Classes;
using System;

namespace ProductionUI.Show
{
    public partial class FormShowUnitInfo : RibbonForm
    {
        private readonly Unit oldUnit;
        private readonly FormAddOrder parent;

        public FormShowUnitInfo(Unit unit, FormAddOrder parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            ShowUnit(unit);
            oldUnit = unit;
        }

        private void ShowUnit(Unit unit)
        {
            if (unit != null) Txt_UnitName.Text = unit.UnitName;
        }

        private void Form_ShowUnitInfo_Load(object sender, EventArgs e)
        {
        }

        private void Btn_EditUnitPen_Click(object sender, EventArgs e)
        {
            Txt_UnitName.Enabled = true;
            Txt_UnitName.ReadOnly = false;
        }

        private void Btn_Erase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Txt_UnitName.Enabled) Txt_UnitName.Text = "";
        }

        private void Btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Txt_UnitName.Enabled)
            {
                oldUnit.UnitName = Txt_UnitName.Text;
                GlobalData.UnitOfWork.Complete();
                parent?.UpdateUnits();
                Close();
            }
        }
    }
}