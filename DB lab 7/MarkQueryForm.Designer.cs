namespace DB_lab_7
{
    partial class MarkQueryForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new DB_lab_7.lab3DataSet();
            this.вывести_все_двойкиTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.Вывести_все_двойкиTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.средняя_успеваемость_студентовTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.Средняя_успеваемость_студентовTableAdapter();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxNum = new System.Windows.Forms.CheckBox();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.lab3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.СтудентTableAdapter();
            this.comboBoxSubj = new System.Windows.Forms.ComboBox();
            this.checkBoxSubj = new System.Windows.Forms.CheckBox();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.ПредметTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(107, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Оценка";
            // 
            // textBoxMark
            // 
            this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMark.Location = new System.Drawing.Point(12, 161);
            this.textBoxMark.MaxLength = 1;
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(376, 24);
            this.textBoxMark.TabIndex = 15;
            this.textBoxMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_OnKeyPressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Поиск по параметрам:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Средняя успеваемость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Двойки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Готовые запросы:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Вывести все двойки";
            this.bindingSource1.DataSource = this.lab3DataSet;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вывести_все_двойкиTableAdapter
            // 
            this.вывести_все_двойкиTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Средняя успеваемость студентов";
            this.bindingSource2.DataSource = this.lab3DataSet;
            // 
            // средняя_успеваемость_студентовTableAdapter
            // 
            this.средняя_успеваемость_студентовTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(20, 191);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(147, 21);
            this.checkBoxDate.TabIndex = 20;
            this.checkBoxDate.Text = "Дата проведения";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(376, 24);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // checkBoxNum
            // 
            this.checkBoxNum.AutoSize = true;
            this.checkBoxNum.Location = new System.Drawing.Point(20, 248);
            this.checkBoxNum.Name = "checkBoxNum";
            this.checkBoxNum.Size = new System.Drawing.Size(224, 21);
            this.checkBoxNum.TabIndex = 22;
            this.checkBoxNum.Text = "Номер студенческого билета";
            this.checkBoxNum.UseVisualStyleBackColor = true;
            // 
            // comboBoxNum
            // 
            this.comboBoxNum.DataSource = this.студентBindingSource;
            this.comboBoxNum.DisplayMember = "Номер студенческого билета";
            this.comboBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNum.FormattingEnabled = true;
            this.comboBoxNum.Location = new System.Drawing.Point(12, 275);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(376, 26);
            this.comboBoxNum.TabIndex = 23;
            this.comboBoxNum.ValueMember = "Номер студенческого билета";
            this.comboBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lab3DataSetBindingSource
            // 
            this.lab3DataSetBindingSource.DataSource = this.lab3DataSet;
            this.lab3DataSetBindingSource.Position = 0;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.lab3DataSetBindingSource;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxSubj
            // 
            this.comboBoxSubj.DataSource = this.предметBindingSource;
            this.comboBoxSubj.DisplayMember = "Название предмета";
            this.comboBoxSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubj.FormattingEnabled = true;
            this.comboBoxSubj.Location = new System.Drawing.Point(12, 331);
            this.comboBoxSubj.Name = "comboBoxSubj";
            this.comboBoxSubj.Size = new System.Drawing.Size(376, 26);
            this.comboBoxSubj.TabIndex = 25;
            this.comboBoxSubj.ValueMember = "Идентификатор предмета";
            this.comboBoxSubj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSubj_KeyPress);
            // 
            // checkBoxSubj
            // 
            this.checkBoxSubj.AutoSize = true;
            this.checkBoxSubj.Location = new System.Drawing.Point(20, 304);
            this.checkBoxSubj.Name = "checkBoxSubj";
            this.checkBoxSubj.Size = new System.Drawing.Size(88, 21);
            this.checkBoxSubj.TabIndex = 24;
            this.checkBoxSubj.Text = "Предмет";
            this.checkBoxSubj.UseVisualStyleBackColor = true;
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this.lab3DataSet;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // MarkQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 422);
            this.Controls.Add(this.comboBoxSubj);
            this.Controls.Add(this.checkBoxSubj);
            this.Controls.Add(this.comboBoxNum);
            this.Controls.Add(this.checkBoxNum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkQueryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запрос: успеваемость";
            this.Load += new System.EventHandler(this.MarkQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private lab3DataSet lab3DataSet;
        private lab3DataSetTableAdapters.Вывести_все_двойкиTableAdapter вывести_все_двойкиTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private lab3DataSetTableAdapters.Средняя_успеваемость_студентовTableAdapter средняя_успеваемость_студентовTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxNum;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.BindingSource lab3DataSetBindingSource;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private lab3DataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSubj;
        private System.Windows.Forms.CheckBox checkBoxSubj;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private lab3DataSetTableAdapters.ПредметTableAdapter предметTableAdapter;
    }
}