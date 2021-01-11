using System;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddMarkForm : Form
    {
        public lab3DataSet.УспеваемостьRow Mark;

        public AddMarkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Mark = lab3DataSet.Успеваемость.NewУспеваемостьRow();
                Mark.Номер_студенческого_билета = (int) comboBoxNum.SelectedValue;
                Mark.Дата_проведения = dateTimePicker4.Value;
                Mark.Идентификатор_предмета = (int) comboBoxSubj.SelectedValue;
                Mark.Номер_семестра = (int) comboBoxSem.SelectedValue;
                Mark.Оценка = int.Parse(textBoxMark.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка при вводе данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInput()
        {
            if (textBoxMark.Text.Length != 1) return false;
            return успеваемостьTableAdapter1.GetData().All(row =>
                row.Номер_студенческого_билета != (int) comboBoxNum.SelectedValue
                || row.Идентификатор_предмета != (int) comboBoxSubj.SelectedValue
                || row.Номер_семестра != (int) comboBoxSem.SelectedValue);
        }

        private void AddMarkForm_Load(object sender, EventArgs e)
        {
            семестрTableAdapter.Fill(lab3DataSet.Семестр);
            предметTableAdapter.Fill(lab3DataSet.Предмет);
            студентTableAdapter.Fill(lab3DataSet.Студент);
            успеваемостьTableAdapter1.Fill(lab3DataSet.Успеваемость);
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxMark_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            var array = new[] {'2', '3', '4', '5', (char) Keys.Back};
            e.Handled = !array.Contains(e.KeyChar);
        }
    }
}