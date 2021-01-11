using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddFacForm : Form
    {
        public string ShortName, FullName, DecanName;

        public AddFacForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled =
                textBox1.Text.Length > 0
                && textBox2.Text.Length > 0
                && textBox3.Text.Length > 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShortName = textBox2.Text;
            FullName = textBox1.Text;
            DecanName = textBox3.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}