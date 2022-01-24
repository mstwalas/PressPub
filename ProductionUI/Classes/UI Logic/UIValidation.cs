using DevExpress.XtraEditors;
using Syncfusion.WinForms.ListView;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ProductionUI.Classes.UI_Logic
{
    public static class UIValidation
    {
        public static Color ErrorColor = Color.IndianRed;
        public static Color DefaultColor = Color.White;

        public static void ShowErrorMessage()
        {
            MessageBox.Show("يوجد قيم غير صحيحة.برجاء, إدخال قيم صحيحة.");
        }

        public static bool ValidatePhoneNUmbers(TextEdit txtbx)
        {
            var output = true;
            if (txtbx.Enabled && txtbx.Visible && !txtbx.ReadOnly)
                if (txtbx.Text == string.Empty || txtbx.Text.Length < 11)
                {
                    txtbx.BackColor = ErrorColor;
                    output = false;
                }

            return output;
        }

        public static bool ValidateStringTxtbxs(TextEdit txtBox)
        {
            var output = true;
            if (txtBox.Enabled && txtBox.Visible && !txtBox.ReadOnly)
            {
                txtBox.Enter += TxtBx_Enter;
                if (txtBox.Text == string.Empty)
                {
                    txtBox.BackColor = ErrorColor;
                    output = false;
                }
            }

            return output;
        }


        public static bool ValidateStringTxtbxs(TextEdit txtBox, bool isCorrect)
        {
            var output = true;
            if (txtBox.Enabled && txtBox.Visible)
            {
                txtBox.Enter += TxtBx_Enter;
                txtBox.KeyPress += TxtBx_Enter;
                if (txtBox.Text == string.Empty || !isCorrect)
                {
                    txtBox.BackColor = ErrorColor;
                    output = false;
                }
            }

            return output;
        }


        public static bool ValidateNumericTxtEdit(TextEdit txtBox)
        {
            var output = true;
            if (txtBox.Enabled && txtBox.Visible && !txtBox.ReadOnly)
            {
                txtBox.Enter += TxtBx_Enter;
                txtBox.KeyPress += TxtBx_KeyPress;
                txtBox.KeyPress += TxtBx_DigitOnly_KeyPress;
                if (txtBox.Text == string.Empty)
                {
                    txtBox.BackColor = ErrorColor;
                    output = false;
                }
            }

            return output;
        }

        private static void TxtBx_Enter(object sender, EventArgs e)
        {
            var textEdit = (TextEdit)sender;
            textEdit.BackColor = DefaultColor;
        }

        public static bool IsNotDigit(char character)
        {
            bool output;

            var DSEP = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(character) && character != 8 && character != DSEP)
                output = true;
            else
                output = false;

            return output;
        }

        private static void TxtBx_DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNotDigit(e.KeyChar)) e.Handled = true;
        }

        private static void TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtbx = (TextEdit)sender;
            txtbx.BackColor = DefaultColor;
        }

        public static bool ValidateComboBox(ComboBox comboBox)
        {
            var output = true;
            if (comboBox.Enabled && comboBox.Visible)
            {
                comboBox.Enter += ComboBox_Enter;
                comboBox.KeyPress += TxtBx_KeyPress;

                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.BackColor = ErrorColor;
                    output = false;
                }
            }


            return output;
        }
        //DevExpress.XtraGrid.Views.Grid.GridView
        public static bool ValidateDevExpressDataGrid(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            if (gridView.RowCount>0)
            {
                
                return true;
            }
            else
            {
                XtraMessageBox.Show("برجاء إختيار منتج", "خطأ", MessageBoxButtons.OK);
                return false;
                
            }
            
        }
        public static bool ValidateSfComboBox(SfComboBox comboBox)
        {
            var output = true;
            if (comboBox.Enabled && comboBox.Visible && !comboBox.TextBox.ReadOnly)
            {
                comboBox.Enter += SFComboBox_Enter;
                comboBox.KeyPress += TxtBx_KeyPress;

                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.BackColor = ErrorColor;
                    output = false;
                }
            }


            return output;
        }

        private static void ComboBox_Enter(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            comboBox.BackColor = DefaultColor;
        }

        private static void SFComboBox_Enter(object sender, EventArgs e)
        {
            var comboBox = (SfComboBox)sender;
            comboBox.BackColor = DefaultColor;
        }
    }
}