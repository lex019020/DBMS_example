using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class GroupQueryForm : Form
    {
        private readonly lab3DataSet dataSet;

        public GroupQueryForm(lab3DataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
        }

        private void GroupQueryForm_Load(object sender, EventArgs e)
        {
            факультетTableAdapter.Fill(lab3DataSet1.Факультет);
            вывести_маленькие_группыTableAdapter.Fill(lab3DataSet1.Вывести_маленькие_группы);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QueryForm(bindingSource1))
            {
                form.ShowDialog(this);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in dataSet.Группа.AsEnumerable()
                where row.Идентификатор_факультета == (int) comboBox1.SelectedValue
                select new
                {
                    row.Идентификатор_факультета, row.Номер_группы, row.Количество_студентов,
                    row.Идентификатор_старосты, row.Идентификатор_профорга
                };

            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }
    }
}