using System;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddStudentForm : Form
    {
        //public int Num, group, fac;
        //public string f, i, o, school, region, sex;
        //public DateTime birth;
        //public bool dorm;
        public lab3DataSet.СтудентRow Student;

        public AddStudentForm()
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
            if (CheckInput())
            {
                Student = lab3DataSet.Студент.NewСтудентRow();
                //student = lab3DataSet.СтудентRow(new DataRowBuilder(,));
                Student.Номер_студенческого_билета = int.Parse(textBoxNum.Text);
                Student.Идентификатор_факультета = (int) comboBoxFac.SelectedValue;
                Student.Номер_группы = (int) comboBoxGroup.SelectedValue;
                Student.Дата_рождения = dateTimePickerBirth.Value;
                Student.Фамилия = textBoxF.Text;
                Student.Имя = textBoxN.Text;
                Student.Отчество = textBoxO.Text;
                Student.Пол = textBoxSex.Text;
                Student.Регион = textBoxRegion.Text;
                Student.Школа = textBoxSchool.Text;
                Student.Проживание_в_общежитии = checkBoxDormitory.Checked;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка при вводе данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInput()
        {
            try
            {
                var t = int.Parse(textBoxNum.Text);
            }
            catch (Exception e)
            {
                return false;
            }

            if (студентTableAdapter1.GetData().Any(st =>
                st.Номер_студенческого_билета.ToString().Equals(textBoxNum.Text))) // LINQ
                return false;

            return textBoxF.Text.Length > 0
                   && textBoxN.Text.Length > 0
                   && textBoxO.Text.Length > 0
                   && textBoxRegion.Text.Length > 0
                   && textBoxSchool.Text.Length > 0
                   && (textBoxSex.Text == "м" || textBoxSex.Text == "ж")
                   && comboBoxFac.Text.Length > 0
                   && comboBoxGroup.Text.Length > 0;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            группаTableAdapter.Fill(lab3DataSet.Группа);
            факультетTableAdapter.Fill(lab3DataSet.Факультет);
            студентTableAdapter1.Fill(lab3DataSet.Студент);
        }

        private void textBoxSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'м' && e.KeyChar != 'ж' && e.KeyChar != (char) Keys.Back)
                e.Handled = true;
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void comboBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}