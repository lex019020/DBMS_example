using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class SemesterQueryForm : Form
    {
        private readonly lab3DataSet set;

        public SemesterQueryForm(lab3DataSet set)
        {
            InitializeComponent();
            this.set = set;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in set.Семестр.AsEnumerable()
                where row.Начало <= dateTimePicker1.Value &&
                      dateTimePicker1.Value <= row.Окончание
                select new
                {
                    row.Номер_семестра, row.Начало,
                    row.Окончание, row.Количество_недель
                };
            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }
    }
}