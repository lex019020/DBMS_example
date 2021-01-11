using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    partial class MainForm
    {
        private void AddStudent_Click(object sender, EventArgs e)
        {
            using (var form = new AddStudentForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    var st = form.Student;
                    lab3DataSet.Студент.AddСтудентRow(st.Номер_студенческого_билета, st.Фамилия, st.Имя,
                        st.Отчество, st.Дата_рождения.Date, st.Пол, st.Регион, st.Проживание_в_общежитии, st.Школа,
                        st.Номер_группы, st.Идентификатор_факультета);
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

        private void DelStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StudentsDataGridView.Rows.RemoveAt(StudentsDataGridView.CurrentCell.RowIndex);
                SaveDb();
            }
        }

        private void StudentQueryButton_Click(object sender, EventArgs e)
        {
            using (var form = new StudentQueryForm(lab3DataSet))
            {
                form.ShowDialog(this);
            }
        }
    }
}