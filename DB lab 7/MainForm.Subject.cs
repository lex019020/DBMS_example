using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void AddSubject_Click(object sender, EventArgs e)
        {
            using (var form = new AddSubjectForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;
                var subj = form.subject;
                try
                {
                    lab3DataSet.Предмет.AddПредметRow(subj.Название_предмета,
                        subj.Краткое_название, subj.Количество_часов);
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

        private void DelSubject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SubjectDataGridView.Rows.RemoveAt(SubjectDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void SubjectQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new SubjectQueryForm(lab3DataSet))
            {
                form.ShowDialog(this);
            }
        }
    }
}