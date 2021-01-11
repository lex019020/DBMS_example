using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class FacsQueriesForm : Form
    {
        public FacsQueriesForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new QueryForm(bindingSource3))
            {
                form.ShowDialog(this);
            }
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

        private void FacsQueriesForm_Load(object sender, EventArgs e)
        {
            _1sql_вложенный__факи_с_большими_группами_TableAdapter.Fill(lab3DataSet1
                ._1sql_вложенный__факи_с_большими_группами_);
            sql_факультеты_с_числом_студентовTableAdapter.Fill(lab3DataSet1.sql_факультеты_с_числом_студентов);
            _1sql_вложенный__факи_без_групп_TableAdapter.Fill(lab3DataSet1._1sql_вложенный__факи_без_групп_);
            факультетTableAdapter1.Fill(lab3DataSet1.Факультет);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in lab3DataSet1.Факультет.AsEnumerable()
                where row.Декан.ToLower().Contains(textBox2.Text.ToLower())
                      && row.Полное_название.ToLower().Contains(textBox1.Text.ToLower())
                select new
                {
                    row.Идентификатор_факультета, row.Краткое_название,
                    row.Полное_название, row.Декан
                };
            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}