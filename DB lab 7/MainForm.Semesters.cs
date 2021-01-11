using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void AddSemester_Click(object sender, EventArgs e)
        {
            using (var form = new AddSemesterForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    var sem = form.Semester;
                    lab3DataSet.Семестр.AddСеместрRow(sem.Начало, sem.Окончание,
                        sem.Количество_недель);
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

        private void DelSemester_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SemesterDataGridView.Rows.RemoveAt(SemesterDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void SemesterQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new SemesterQueryForm(lab3DataSet))
            {
                form.ShowDialog(this);
            }
        }
    }
}