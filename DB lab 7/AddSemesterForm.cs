using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddSemesterForm : Form
    {
        public lab3DataSet.СеместрRow Semester;

        public AddSemesterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Semester = lab3DataSet1.Семестр.NewСеместрRow();
                Semester.Количество_недель = int.Parse(textBoxLength.Text);
                Semester.Начало = dateTimePickerStart.Value.Date;
                Semester.Окончание = dateTimePickerEnd.Value.Date;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка при вводе данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckData()
        {
            return textBoxLength.Text.Length >= 1
                   && dateTimePickerStart.Value < dateTimePickerEnd.Value;
        }

        private void AddSemesterForm_Load(object sender, EventArgs e)
        {
            семестрTableAdapter1.Fill(lab3DataSet1.Семестр);
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }
    }
}