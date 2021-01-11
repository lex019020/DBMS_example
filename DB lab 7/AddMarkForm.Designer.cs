namespace DB_lab_7
{
    partial class AddMarkForm
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
            this.comboBoxSem = new System.Windows.Forms.ComboBox();
            this.семестрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new DB_lab_7.lab3DataSet();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBoxSubj = new System.Windows.Forms.ComboBox();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.студентTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.СтудентTableAdapter();
            this.предметTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.ПредметTableAdapter();
            this.семестрTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.СеместрTableAdapter();
            this.успеваемостьTableAdapter1 = new DB_lab_7.lab3DataSetTableAdapters.УспеваемостьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.семестрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSem
            // 
            this.comboBoxSem.DataSource = this.семестрBindingSource;
            this.comboBoxSem.DisplayMember = "Номер семестра";
            this.comboBoxSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSem.FormattingEnabled = true;
            this.comboBoxSem.Location = new System.Drawing.Point(12, 229);
            this.comboBoxSem.Name = "comboBoxSem";
            this.comboBoxSem.Size = new System.Drawing.Size(361, 26);
            this.comboBoxSem.TabIndex = 31;
            this.comboBoxSem.ValueMember = "Номер семестра";
            this.comboBoxSem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // семестрBindingSource
            // 
            this.семестрBindingSource.DataMember = "Семестр";
            this.семестрBindingSource.DataSource = this.lab3DataSet;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 209);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 17);
            this.label32.TabIndex = 30;
            this.label32.Text = "Семестр";
            // 
            // comboBoxSubj
            // 
            this.comboBoxSubj.DataSource = this.предметBindingSource;
            this.comboBoxSubj.DisplayMember = "Краткое название";
            this.comboBoxSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubj.FormattingEnabled = true;
            this.comboBoxSubj.Location = new System.Drawing.Point(12, 180);
            this.comboBoxSubj.Name = "comboBoxSubj";
            this.comboBoxSubj.Size = new System.Drawing.Size(361, 26);
            this.comboBoxSubj.TabIndex = 29;
            this.comboBoxSubj.ValueMember = "Идентификатор предмета";
            this.comboBoxSubj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this.lab3DataSet;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 160);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 17);
            this.label31.TabIndex = 28;
            this.label31.Text = "Предмет";
            // 
            // comboBoxNum
            // 
            this.comboBoxNum.DataSource = this.студентBindingSource;
            this.comboBoxNum.DisplayMember = "Номер студенческого билета";
            this.comboBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNum.FormattingEnabled = true;
            this.comboBoxNum.Location = new System.Drawing.Point(12, 131);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(361, 26);
            this.comboBoxNum.TabIndex = 27;
            this.comboBoxNum.ValueMember = "Номер студенческого билета";
            this.comboBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.lab3DataSet;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(139, 17);
            this.label30.TabIndex = 26;
            this.label30.Text = "Номер студ. билета";
            // 
            // textBoxMark
            // 
            this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMark.Location = new System.Drawing.Point(12, 80);
            this.textBoxMark.MaxLength = 1;
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(361, 27);
            this.textBoxMark.TabIndex = 25;
            this.textBoxMark.TextChanged += new System.EventHandler(this.textBoxMark_TextChanged);
            this.textBoxMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMark_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 17);
            this.label25.TabIndex = 24;
            this.label25.Text = "Оценка";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "Дата проведения";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker4.Location = new System.Drawing.Point(12, 33);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(361, 24);
            this.dateTimePicker4.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(239, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // семестрTableAdapter
            // 
            this.семестрTableAdapter.ClearBeforeFill = true;
            // 
            // успеваемостьTableAdapter1
            // 
            this.успеваемостьTableAdapter1.ClearBeforeFill = true;
            // 
            // AddMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSem);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.comboBoxSubj);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBoxNum);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dateTimePicker4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMarkForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая оценка";
            this.Load += new System.EventHandler(this.AddMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.семестрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSem;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBoxSubj;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private lab3DataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private lab3DataSetTableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.BindingSource семестрBindingSource;
        private lab3DataSetTableAdapters.СеместрTableAdapter семестрTableAdapter;
        private lab3DataSetTableAdapters.УспеваемостьTableAdapter успеваемостьTableAdapter1;
    }
}