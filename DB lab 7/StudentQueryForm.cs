using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class StudentQueryForm : Form
    {
        private readonly lab3DataSet dataSet;

        public StudentQueryForm(lab3DataSet dataDet)
        {
            InitializeComponent();
            dataSet = dataDet;
        }

        private void StudentQueryForm_Load(object sender, EventArgs e)
        {
            sql_студенты_москвы_и_областиTableAdapter.Fill(lab3DataSet.sql_студенты_москвы_и_области);
            группаTableAdapter.Fill(lab3DataSet.Группа);
            sql_студенты_средний_баллTableAdapter.Fill(lab3DataSet.sql_студенты_средний_балл);
            вывести_всех_студентов__живущих__в_общежитииTableAdapter.Fill(lab3DataSet
                ._Вывести_всех_студентов__живущих__в_общежитии);
            sql_студенты_москвы_и_области_2TableAdapter.Fill(lab3DataSet.sql_студенты_москвы_и_области_2);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new QueryForm(bindingSource3))
            {
                form.ShowDialog(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in dataSet.Студент.AsEnumerable()
                where row.Фамилия.ToLower().Contains(textBoxF.Text.ToLower())
                      && row.Имя.ToLower().Contains(textBoxN.Text.ToLower())
                      && row.Отчество.ToLower().Contains(textBoxSn.Text.ToLower())
                      && row.Регион.ToLower().Contains(textBoxRegion.Text.ToLower())
                      && (!checkBox1.Checked || row.Номер_группы == (int) comboBox1.SelectedValue)
                select new
                {
                    row.Номер_студенческого_билета, row.Номер_группы, row.Фамилия,
                    row.Имя, row.Отчество, row.Дата_рождения, row.Пол, row.Регион,
                    row.Проживание_в_общежитии, row.Идентификатор_факультета
                };
            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }
    }
}