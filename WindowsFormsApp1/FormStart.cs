using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formLoginSystem : Form
    {
        public formLoginSystem()
        {
            InitializeComponent();
        }
        
        
        
        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            DialogResult dialogResult =  formAuthorization.ShowDialog();
            
            
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            DialogResult dialogResult = formRegister.ShowDialog();
            
        }

        private void formLoginSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
