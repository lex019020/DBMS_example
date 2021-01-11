using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void AddMark_Click(object sender, EventArgs e)
        {
            using (var form = new AddMarkForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    var mark = form.Mark;
                    lab3DataSet.Успеваемость.AddУспеваемостьRow(mark.Дата_проведения.Date,
                        mark.Оценка, mark.СтудентRow, mark.ПредметRow, mark.СеместрRow);
                    SaveDb();
                    UpdadeDb();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка при добавлении",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DelMark_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MarksDataGridView.Rows.RemoveAt(MarksDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void MarkQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new MarkQueryForm(lab3DataSet))
            {
                form.ShowDialog(this);
            }
        }
    }
}