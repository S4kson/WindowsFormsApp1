using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            textBoxUserName.MaxLength = 9;
            textBoxPass.MaxLength = 12;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
             
            if (userAuthSucceess())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                FormPolibii FormEvents = new FormPolibii();
                DialogResult dialogResult = FormEvents.ShowDialog();
            }
        }

        private bool userAuthSucceess()
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
                MessageBox.Show("Вы вошли");
                
                return true;
            }              
            else
            {
                MessageBox.Show("Не верный логин или пароль");
                return false;
            }
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxUserName.Text) || isUnCorrectField(textBoxPass.Text))
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
            string pass = md5.hashPassword(textBoxPass.Text);
            if (new Database("Data Source=dataBase.db;Version=3;").ValidUser(textBoxUserName.Text, pass) == true)
                return true;
            else return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLoginSystem FormStart = new formLoginSystem();
            DialogResult dialogResult = FormStart.ShowDialog();
           
           
           // FormPolibii FormEvents = new FormPolibii();
            //DialogResult dialogResult = FormEvents.ShowDialog();
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
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void FormAuthorization_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                buttonLogin_Click(buttonLogin, null);
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
    }
}
