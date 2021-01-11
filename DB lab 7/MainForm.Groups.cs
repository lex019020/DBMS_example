using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void DelGroupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GroupsDataGridView.Rows.RemoveAt(GroupsDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            using (var form = new AddGroupForm())
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                try
                {
                    группаTableAdapter.Insert(
                        form.Number,
                        form.SId,
                        form.PId,
                        form.Count,
                        form.Fac);
                    UpdadeDb();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                        "Ошибка добавления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void GroupQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new GroupQueryForm(lab3DataSet))
            {
                form.ShowDialog(this);
            }
        }
    }
}