using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormPolibii : Form
    {
        public FormPolibii()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEncoder_Click(object sender, EventArgs e)
        {
            if (textBoxInput.TextLength > 1)
            {
                textBoxOutput.Text = Polibii.PolibiliHASH(textBoxInput.Text);
            }
            else
            {
                MessageBox.Show("Получены некоректные данные");
            }
        }

        private void ButtonDecoder_Click(object sender, EventArgs e)
        {
            if ((textBoxInput.TextLength)%2 !=0)
            {
                MessageBox.Show("Получены некоректные данные");
                return;
            }
            if ((IsDigitsOnly(textBoxInput.Text) == true))
            {
                textBoxOutput.Text = Polibii.PolibiliUnHASH(textBoxInput.Text);
            }
            else
            {
                MessageBox.Show("Расшифровщик понимает только цифры!");
            }
           

        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBoxInput.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBoxInput.Text);
            System.IO.File.WriteAllText(filename, textBoxOutput.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
