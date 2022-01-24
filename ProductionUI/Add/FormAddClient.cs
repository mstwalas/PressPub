using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;
using ProductionUI.Classes.UI_Logic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking.Helpers;

namespace ProductionUI.Add
{
    public partial class FormAddClient : RibbonForm
    {
        //public static ;
        private readonly FormAddOrder parent;

        

        public FormAddClient(FormAddOrder parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            CheckEnableOrDisablePhoneNumberCheckbox();
        }

        private void CheckEnableOrDisablePhoneNumberCheckbox()
        {
            if (CheckBox_PhoneNumber.Checked)
            {
                Txt_MobileNum.Enabled = true;
                Txt_MobileNum.BackColor = Color.White;
            }
            else
            {
                Txt_MobileNum.BackColor = Color.FromArgb(240, 240, 240);
                Txt_MobileNum.Enabled = false;

                Txt_MobileNum.Text = "";
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show(Size.ToString());
        }

        private void Save_Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveInformations();
        }

        private void SaveInformations()
        {
            UIValidation.ValidateSfComboBox(Cmbx_Unit);
            UIValidation.ValidateSfComboBox(Cmbx_Degree);
            UIValidation.ValidateStringTxtbxs(Txt_Name);
            if (CheckBox_PhoneNumber.Checked)
            {
                if (UIValidation.ValidatePhoneNUmbers(Txt_MobileNum))
                {
                    if (CheckValidateDuplicatePhoneNumber(Txt_MobileNum))
                    {
                        AddClient();
                        parent?.UpdateClients();
                    }
                    else
                    {
                        MessageBox.Show(@"هذا العميل مسجل مسبقا");
                    }
                }
                else
                {
                    MessageBox.Show(@"يرجى ادخال رقم صحيح");
                }
            }
            else
            {
                
                if (CheckValidateDuplicateNameWithUnit(Txt_Name.Text, Cmbx_Unit.SelectedItem))
                {
                    AddClient();
                    parent?.UpdateClients();
                }
                else
                {
                    MessageBox.Show(@"هذا العميل مسجل مسبقا");
                }

            }
        }

        private bool CheckValidateDuplicateNameWithUnit(string clientName, object unit)
        {
            var client = GlobalData.UnitOfWork.Clients.SingleOrDefault(e => e.IsEnabled && e.ClientName == clientName && e.Unit == unit);
            if (client != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckValidateDuplicatePhoneNumber(TextEdit mobileNumber)
        {
            var client = GlobalData.UnitOfWork.Clients
                .SingleOrDefault(e => e.IsEnabled && e.ClientPhoneNumber == mobileNumber.Text);
            if (client != null)
                return false;
            return true;
        }

        private void Txt_Name_Properties_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Form_AddClient_Load(object sender, EventArgs e)
        {
            ComboboxLoadData();
        }

        public void ComboboxLoadData()
        {
            var degrees = GlobalData.UnitOfWork.Degrees
                .Find(e => e.IsEnabled && e.IsDeleted == false);
            Cmbx_Degree.DataSource = degrees;
            Cmbx_Degree.DisplayMember = "DegreeName";
            var units = GlobalData.UnitOfWork.Units.Find(e => e.IsEnabled && e.IsDeleted == false);
            Cmbx_Unit.DataSource = units;
            Cmbx_Unit.DisplayMember = "UnitName";
            Cmbx_Unit.Text = "--برجاء إختيار الوحدة--";
            Cmbx_Degree.Text = "--برجاء إختيار الدرجة--";
        }

        public void AddClient()
        {
            GlobalData.UnitOfWork.Clients.Add(new Client
            {
                CreatedUserId = GlobalData.LoginUser.UserId,

                ClientName = Txt_Name.Text,
                ClientPhoneNumber = CheckBox_PhoneNumber.Checked ? Txt_MobileNum.Text : null,
                Unit = (Unit)Cmbx_Unit.SelectedItem,
                Degree = (Degree)Cmbx_Degree.SelectedItem
            });
            GlobalData.UnitOfWork.Complete();

            MessageBox.Show("تم إضافة مندوب");
        }

        private void CheckBox_PhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            CheckEnableOrDisablePhoneNumberCheckbox();
        }

        private void Btn_SaveAndExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveInformations();
            this.Close();
        }

        private void Btn_Earse_ItemClick(object sender, ItemClickEventArgs e)
        {
            EarseAllInfo();
        }

        private void EarseAllInfo()
        {
            Txt_Name.Text = "";
            Txt_MobileNum.Text = "";
            Cmbx_Unit.Text = "اختر الوحدة";
            Cmbx_Degree.Text = "اختر الدرجة";
            CheckBox_PhoneNumber.Checked = false;
        }
    }
}