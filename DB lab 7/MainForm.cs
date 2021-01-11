using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class MainForm : Form
    {
        private OleDbConnection cn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeGridViews();
            UpdadeDb();
        }


        private void ResizeGridViews()
        {
            var gridWidth = tabControl1.TabPages[tabControl1.SelectedIndex].Width - panel1.Width;
            FacsDataGridView.Width = gridWidth;
            GroupsDataGridView.Width = gridWidth;
            StudentsDataGridView.Width = gridWidth;
            MarksDataGridView.Width = gridWidth;
            SemesterDataGridView.Width = gridWidth;
            SubjectDataGridView.Width = gridWidth;
        }

        private void UpdadeDb()
        {
            try
            {
                факультетTableAdapter.Fill(lab3DataSet.Факультет);
                группаTableAdapter.Fill(lab3DataSet.Группа);
                студентTableAdapter.Fill(lab3DataSet.Студент);
                успеваемостьTableAdapter.Fill(lab3DataSet.Успеваемость);
                семестрTableAdapter.Fill(lab3DataSet.Семестр);
                предметTableAdapter.Fill(lab3DataSet.Предмет);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка загрузки БД",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void SaveDb()
        {
            try
            {
                факультетTableAdapter.Update(lab3DataSet);
                группаTableAdapter.Update(lab3DataSet);
                студентTableAdapter.Update(lab3DataSet);
                успеваемостьTableAdapter.Update(lab3DataSet);
                семестрTableAdapter.Update(lab3DataSet);
                предметTableAdapter.Update(lab3DataSet);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка сохранения БД",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDb();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeGridViews();
        }

        private void DefaultComboBox_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NumberOnlyTextBox_OnKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }
    }
}