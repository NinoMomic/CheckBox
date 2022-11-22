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

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox.AppendText("Odabrali ste:" + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox.Clear();
            textBox.AppendText("Odabrali ste:" + Environment.NewLine);
            if (checkBoxDorucak.Checked) textBox.AppendText(checkBoxDorucak.Text + Environment.NewLine);
            if (checkBoxRucak.Checked) textBox.AppendText(checkBoxRucak.Text + Environment.NewLine);
            if (checkBoxVecera.Checked) textBox.AppendText(checkBoxVecera.Text + Environment.NewLine);

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSakrijNarudzbu.Checked) textBox.Hide();
            else textBox.Show();
        }
    }
}

