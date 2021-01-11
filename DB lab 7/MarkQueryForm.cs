using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class MarkQueryForm : Form
    {
        private readonly lab3DataSet set;

        public MarkQueryForm(lab3DataSet set)
        {
            InitializeComponent();
            this.set = set;
        }

        private void MarkQueryForm_Load(object sender, EventArgs e)
        {
            предметTableAdapter.Fill(lab3DataSet.Предмет);
            студентTableAdapter.Fill(lab3DataSet.Студент);
            средняя_успеваемость_студентовTableAdapter.Fill(lab3DataSet.Средняя_успеваемость_студентов);
            вывести_все_двойкиTableAdapter.Fill(lab3DataSet.Вывести_все_двойки);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in set.Успеваемость.AsEnumerable()
                where (textBoxMark.TextLength == 0 || row.Оценка == int.Parse(textBoxMark.Text))
                      && (!checkBoxDate.Checked || row.Дата_проведения == dateTimePicker1.Value)
                      && (!checkBoxNum.Checked || row.Номер_студенческого_билета ==
                          (int) comboBoxNum.SelectedValue)
                      && (!checkBoxSubj.Checked || row.Идентификатор_предмета ==
                          (int) comboBoxSubj.SelectedValue)
                select new
                {
                    row.Номер_студенческого_билета, row.Идентификатор_предмета,
                    row.Номер_семестра, row.Дата_проведения, row.Оценка
                };
            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }

        private void NumberOnlyTextBox_OnKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxSubj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QueryForm(bindingSource1))
            {
                form.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new QueryForm(bindingSource2))
            {
                form.ShowDialog(this);
            }
        }
    }
}