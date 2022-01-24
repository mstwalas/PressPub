using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using ProductionLogic.Core.Domain;
using ProductionUI.Add;
using ProductionUI.Classes;
using System;
using System.Linq;
using ProductionUI.Classes.UI_Logic;

namespace ProductionUI.Show
{
    public partial class FormShowClientInfo : RibbonForm
    {
        private readonly Client client;
        private FormAddOrder parent;

        public FormShowClientInfo(Client client, FormAddOrder parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            this.client = client;
            LoadClientInfo(client);
            ControllersReadOnly();
        }

        private void ControllersReadOnly()
        {
            Txt_MobileNumber.ReadOnly = true;
            Txt_ClientName.ReadOnly = true;
            Cmbx_Degreee.Enabled = false;
            Cmbx_UnitName.Enabled = false;
            CheckBox_MobileNumber.ReadOnly = true;
        }

        private void LoadClientInfo(Client loadClient)
        {
            var units = GlobalData.UnitOfWork.Units.GetAllUnitsWithClients();
            var degrees = GlobalData.UnitOfWork.Degrees.GetAll().Where(e => e.IsEnabled && e.IsDeleted == false);
            Cmbx_UnitName.DataSource = units;
            Cmbx_UnitName.DisplayMember = "UnitName";
            Cmbx_UnitName.SelectedItem = loadClient.Unit;
            Cmbx_UnitName.Enabled = false;
            Txt_ClientName.Text = loadClient.ClientName;
            Cmbx_Degreee.DataSource = degrees;
            Cmbx_Degreee.DisplayMember = "DegreeName";
            Cmbx_Degreee.SelectedItem = this.client.Degree;
            Txt_MobileNumber.Text = loadClient.ClientPhoneNumber ?? "";
            CheckBox_MobileNumber.Checked = loadClient.ClientPhoneNumber != null;
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }


        private void CheckBox_MobileNumber_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValidate();
        }

        private void CheckBoxValidate()
        {
            if (CheckBox_MobileNumber.Checked)
            {
                //Txt_MobileNumber.Enabled = true;
                Txt_MobileNumber.ReadOnly = false;
            }
            else
            {
                //Txt_MobileNumber.Enabled = false;
                Txt_MobileNumber.ReadOnly = true;
            }
        }

        private void Btn_EditMobileNumberPen_Click(object sender, EventArgs e)
        {
            Txt_MobileNumber.ReadOnly = false;
            Txt_MobileNumber.Enabled = true;
            CheckBox_MobileNumber.ReadOnly = false;
            CheckBox_MobileNumber.Enabled = true;
        }

        private void Btn_EditUnitPen_Click(object sender, EventArgs e)
        {
            Cmbx_UnitName.Enabled = true;
        }

        private void Btn_EditDegreePen_Click(object sender, EventArgs e)
        {
            Cmbx_Degreee.Enabled = true;
        }

        private void Btn_EditCustmerNamePen_Click(object sender, EventArgs e)
        {
            Txt_ClientName.Enabled = true;
            Txt_ClientName.ReadOnly = false;
        }

        private void Btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditClientInfo();
        }

        private void EditClientInfo()
        {
            bool rightInfo= ValidateEditsMaked();
            if (rightInfo)
            {
                client.ClientName = Txt_ClientName.Text;
                client.Unit = Cmbx_UnitName.SelectedItem as Unit;
                client.Degree=Cmbx_Degreee.SelectedItem as Degree;
                //TODO MOBILE NUMBER MODIFICATION
               // client.ClientPhoneNumber=CheckBox_MobileNumber.Checked?Txt_MobileNumber.Text :"";
                GlobalData.UnitOfWork.Complete();
                parent?.UpdateClients();
                this.Close();
            }

        }
        
        private bool ValidateEditsMaked()
        {
            bool rightInfo = true;
            if (Txt_ClientName.Enabled|| Txt_MobileNumber.Enabled||Cmbx_Degreee.Enabled||Cmbx_UnitName.Enabled)
            {
                rightInfo&= UIValidation.ValidateStringTxtbxs(Txt_ClientName);
                rightInfo &= UIValidation.ValidatePhoneNUmbers(Txt_MobileNumber);
                rightInfo &= UIValidation.ValidateSfComboBox(Cmbx_Degreee);
                if (Txt_MobileNumber.Enabled && CheckBox_MobileNumber.Checked)
                {
                    rightInfo &= UIValidation.ValidateSfComboBox(Cmbx_UnitName);
                }
            }

            return rightInfo;

        }
    }
}