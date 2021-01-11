using System;
using System.Windows.Forms;

namespace DB_lab_7
{
    public partial class QueryForm : Form
    {
        private readonly object source;

        public QueryForm(object source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = source;
                dataGridView1.ResetBindings();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удалось загрузить данные запроса:\n"
                                + exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}