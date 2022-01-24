using ProductionUI.Classes.UI_Logic;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class FormLogin : Form
    {
        private readonly FormLoginLogic formLoginLogic;

        public FormLogin()
        {
            InitializeComponent();
            formLoginLogic = new FormLoginLogic();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LoginChecker();
        }

        private void Txt_Name_Properties_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            Txt_UserName.Focus();
        }


        private void Txt_PassWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_PassWord.Text))
            {
                Txt_PassWord.Properties.UseSystemPasswordChar = false;
                Txt_PassWord.Text = "كلمة السر";
            }
        }

        private void Txt_PassWord_Enter(object sender, EventArgs e)
        {
            if (Txt_PassWord.Text == "كلمة السر")
            {
                Txt_PassWord.Text = "";
                Txt_PassWord.Properties.UseSystemPasswordChar = true;
                Txt_PassWord.Properties.PasswordChar = '*';
            }
        }

        private void Btn_Login_Click_1(object sender, EventArgs e)
        {
            LoginChecker();
        }

        private void Pic_Close_Properties_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Txt_UserName_Properties_Enter(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "Username") Txt_UserName.Text = "";
        }

        public void LoginChecker()
        {
            if (string.IsNullOrEmpty(Txt_UserName.Text) || string.IsNullOrEmpty(Txt_PassWord.Text))
            {
                MessageBox.Show("برجاء إدخال اسم المستخدم و كلمة السر");
            }
            else
            {
                var appAccess = formLoginLogic.LoginChecker(Txt_UserName.Text, Txt_PassWord.Text);
                if (appAccess)
                {
                    Hide();
                    var main = new FormMainView();

                    main.Show();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
                }
            }
        }

        private void Txt_PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoginChecker();
        }

        private void Btn_Login_Click_2(object sender, EventArgs e)
        {
            LoginChecker();
        }

        private void Pic_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}