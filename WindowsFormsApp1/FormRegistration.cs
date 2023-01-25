using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            textBoxUserName.MaxLength = 9;
            textBoxPass.MaxLength = 12;
            textBoxPassAgain.MaxLength = 12;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {        
            if (textBoxUserName.TextLength < 4)
            {
                label1.Text = "Минимальная длина 4 символа.";                
            }
            else 
            {
                label1.Text = "";
            } 

            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||(e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' ||  e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (userRegSucceess() == true)
            {
                string pass = md5.hashPassword(textBoxPass.Text);
                new Database("Data Source=dataBase.db;Version=3;").createUser(textBoxUserName.Text, pass);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }  
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
        private bool userRegSucceess()
        {
            string pass = md5.hashPassword(textBoxPass.Text);
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Не корректные поля на форме");
                return false;
            }
            else if ((Convert.ToInt32(textBoxPass.TextLength) < 4) || (Convert.ToInt32(textBoxUserName.TextLength) < 4))
            {
                MessageBox.Show("Логин или пароль записан не корректно");
                return false;
            }
            if (hasUser() == true)
            {
                MessageBox.Show("Такой логин уже испольуется");
                return false;
            }
            if (textBoxPass.Text == textBoxPassAgain.Text)
            {
                MessageBox.Show("Регистрация выполнена");

                return true;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxUserName.Text) || isUnCorrectField(textBoxPass.Text) || isUnCorrectField(textBoxPassAgain.Text))
                return true;
            return false;

        }
        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }
        private bool hasUser()
        {
            if (new Database("Data Source=dataBase.db;Version=3;").CheckLoginUser(textBoxUserName.Text) == false)
                return false;
            else return true;
        }

        private void FormRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button_Click(button, null);
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPass.TextLength < 4)
            {
                label2.Text = "Минимальная длина 4 символа.";
            }
            else
            {
                label2.Text = "";
            }

            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxPassAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPassAgain.TextLength < 4)
            {
                label3.Text = "Минимальная длина 4 символа.";
            }
            else
            {
                label3.Text = "";
            }

            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }   
}
