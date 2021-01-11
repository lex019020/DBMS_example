using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class AddSubjectForm : Form
    {
        public lab3DataSet.ПредметRow subject;

        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                subject = lab3DataSet1.Предмет.NewПредметRow();
                subject.Количество_часов = int.Parse(textBoxHours.Text);
                subject.Название_предмета = textBoxName.Text;
                subject.Краткое_название = textBoxShortName.Text;
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
            return textBoxName.Text.Length > 0
                   && textBoxHours.Text.Length > 0
                   && textBoxShortName.Text.Length > 0;
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            предметTableAdapter1.Fill(lab3DataSet1.Предмет);
        }
    }
}