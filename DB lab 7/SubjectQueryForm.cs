using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class SubjectQueryForm : Form
    {
        private readonly lab3DataSet dataSet;

        public SubjectQueryForm(lab3DataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from row in dataSet.Предмет.AsEnumerable()
                where row.Название_предмета.ToLower().Contains(textBox1.Text.ToLower())
                select new
                {
                    row.Идентификатор_предмета, row.Название_предмета,
                    row.Краткое_название, row.Количество_часов
                };
            using (var form = new QueryForm(q.ToList()))
            {
                form.ShowDialog(this);
            }
        }
    }
}