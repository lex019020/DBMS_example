using System;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddGroupForm : Form
    {
        public int Number, Count, Fac, SId, PId;

        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void AddGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab3DataSet.Факультет". При необходимости она может быть перемещена или удалена.
            факультетTableAdapter.Fill(lab3DataSet.Факультет);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                MessageBox.Show("Ошибка при вводе. Проверьте правильность данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Number = int.Parse(textBox6.Text);
            Count = int.Parse(textBox3.Text);
            SId = int.Parse(textBox5.Text);
            PId = int.Parse(textBox4.Text);
            Fac = (int) comboBox1.SelectedValue;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool checkInput()
        {
            if (группаTableAdapter1.GetData().Any(row =>
                row.Номер_группы.ToString().Equals(textBox6.Text))) // LINQ
                return false;
            return textBox5.Text.Length > 0
                   && textBox4.Text.Length > 0
                   && textBox3.Text.Length > 0
                   && textBox6.Text.Length > 0
                   && textBox3.Text.All(char.IsDigit)
                   && textBox4.Text.All(char.IsDigit)
                   && textBox5.Text.All(char.IsDigit)
                   && textBox6.Text.All(char.IsDigit);
        }
    }
}