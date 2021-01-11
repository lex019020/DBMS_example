using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void tabPage1_SizeChanged(object sender, EventArgs e)
        {
            ResizeGridViews();
        }

        private void buttonDelFac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FacsDataGridView.Rows.RemoveAt(FacsDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void buttonAddFac_Click(object sender, EventArgs e)
        {
            using (var addFacForm = new AddFacForm())
            {
                if (addFacForm.ShowDialog() != DialogResult.OK) return;

                try
                {
                    факультетTableAdapter.Insert(
                        addFacForm.FullName,
                        addFacForm.ShortName,
                        addFacForm.DecanName);
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

        private void FacsQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new FacsQueriesForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}