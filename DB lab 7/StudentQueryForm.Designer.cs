namespace DB_lab_7
{
    partial class StudentQueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new DB_lab_7.lab3DataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sql_студенты_москвы_и_области_2TableAdapter = new DB_lab_7.lab3DataSetTableAdapters.sql_студенты_москвы_и_области_2TableAdapter();
            this.вывести_всех_студентов__живущих__в_общежитииTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.Вывести_всех_студентов__живущих__в_общежитииTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sql_студенты_средний_баллTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.sql_студенты_средний_баллTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.ГруппаTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sql_студенты_москвы_и_областиTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.sql_студенты_москвы_и_областиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(94, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Имя";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(12, 232);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(376, 24);
            this.textBoxN.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фамилия";
            // 
            // textBoxF
            // 
            this.textBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxF.Location = new System.Drawing.Point(12, 185);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(376, 24);
            this.textBoxF.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Поиск по параметрам:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(376, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "Средний балл студентов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Студенты в общежитии";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Студенты Москвы и области";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Готовые запросы:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "sql студенты москвы и области";
            this.bindingSource1.DataSource = this.lab3DataSet;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Вывести всех студентов, живущих  в общежитии";
            this.bindingSource2.DataSource = this.lab3DataSet;
            // 
            // sql_студенты_москвы_и_области_2TableAdapter
            // 
            this.sql_студенты_москвы_и_области_2TableAdapter.ClearBeforeFill = true;
            // 
            // вывести_всех_студентов__живущих__в_общежитииTableAdapter
            // 
            this.вывести_всех_студентов__живущих__в_общежитииTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "sql студенты средний балл";
            this.bindingSource3.DataSource = this.lab3DataSet;
            // 
            // sql_студенты_средний_баллTableAdapter
            // 
            this.sql_студенты_средний_баллTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Отчество";
            // 
            // textBoxSn
            // 
            this.textBoxSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSn.Location = new System.Drawing.Point(12, 279);
            this.textBoxSn.Name = "textBoxSn";
            this.textBoxSn.Size = new System.Drawing.Size(376, 24);
            this.textBoxSn.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Регион";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegion.Location = new System.Drawing.Point(12, 330);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(376, 24);
            this.textBoxRegion.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.группаBindingSource;
            this.comboBox1.DisplayMember = "Номер группы";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(376, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "Номер группы";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.lab3DataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 360);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Группа";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sql_студенты_москвы_и_областиTableAdapter
            // 
            this.sql_студенты_москвы_и_областиTableAdapter.ClearBeforeFill = true;
            // 
            // StudentQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 481);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentQueryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запрос: студенты";
            this.Load += new System.EventHandler(this.StudentQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingSource bindingSource2;
        private lab3DataSetTableAdapters.sql_студенты_москвы_и_области_2TableAdapter sql_студенты_москвы_и_области_2TableAdapter;
        private lab3DataSetTableAdapters.Вывести_всех_студентов__живущих__в_общежитииTableAdapter вывести_всех_студентов__живущих__в_общежитииTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private lab3DataSetTableAdapters.sql_студенты_средний_баллTableAdapter sql_студенты_средний_баллTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private lab3DataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private lab3DataSetTableAdapters.sql_студенты_москвы_и_областиTableAdapter sql_студенты_москвы_и_областиTableAdapter;
    }
}