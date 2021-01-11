namespace DB_lab_7
{
    partial class AddStudentForm
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
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.группаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new DB_lab_7.lab3DataSet();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxDormitory = new System.Windows.Forms.CheckBox();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxFac = new System.Windows.Forms.ComboBox();
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.ФакультетTableAdapter();
            this.студентTableAdapter1 = new DB_lab_7.lab3DataSetTableAdapters.СтудентTableAdapter();
            this.группаTableAdapter = new DB_lab_7.lab3DataSetTableAdapters.ГруппаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(12, 235);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimePickerBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(174, 24);
            this.dateTimePickerBirth.TabIndex = 33;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.группаBindingSource1;
            this.comboBoxGroup.DisplayMember = "Номер группы";
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 384);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(361, 28);
            this.comboBoxGroup.TabIndex = 45;
            this.comboBoxGroup.ValueMember = "Номер группы";
            this.comboBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGroup_KeyPress);
            // 
            // группаBindingSource1
            // 
            this.группаBindingSource1.DataMember = "Группа";
            this.группаBindingSource1.DataSource = this.lab3DataSet;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 44;
            this.label19.Text = "Группа";
            // 
            // checkBoxDormitory
            // 
            this.checkBoxDormitory.AutoSize = true;
            this.checkBoxDormitory.Location = new System.Drawing.Point(12, 335);
            this.checkBoxDormitory.Name = "checkBoxDormitory";
            this.checkBoxDormitory.Size = new System.Drawing.Size(174, 21);
            this.checkBoxDormitory.TabIndex = 43;
            this.checkBoxDormitory.Text = "Прожив. в общежитии";
            this.checkBoxDormitory.UseVisualStyleBackColor = true;
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSchool.Location = new System.Drawing.Point(197, 335);
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(176, 27);
            this.textBoxSchool.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(197, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "Школа";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegion.Location = new System.Drawing.Point(12, 285);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(361, 27);
            this.textBoxRegion.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Регион";
            // 
            // textBoxSex
            // 
            this.textBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSex.Location = new System.Drawing.Point(197, 234);
            this.textBoxSex.MaxLength = 1;
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(176, 27);
            this.textBoxSex.TabIndex = 38;
            this.textBoxSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSex_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(197, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Пол";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Дата рождения";
            // 
            // comboBoxFac
            // 
            this.comboBoxFac.DataSource = this.факультетBindingSource;
            this.comboBoxFac.DisplayMember = "Краткое название";
            this.comboBoxFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFac.FormattingEnabled = true;
            this.comboBoxFac.Location = new System.Drawing.Point(12, 435);
            this.comboBoxFac.Name = "comboBoxFac";
            this.comboBoxFac.Size = new System.Drawing.Size(361, 28);
            this.comboBoxFac.TabIndex = 35;
            this.comboBoxFac.ValueMember = "Идентификатор факультета";
            this.comboBoxFac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFac_KeyPress);
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this.lab3DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Факультет";
            // 
            // textBoxO
            // 
            this.textBoxO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxO.Location = new System.Drawing.Point(12, 180);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(361, 27);
            this.textBoxO.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Отчество";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(12, 131);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(361, 27);
            this.textBoxN.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Имя";
            // 
            // textBoxF
            // 
            this.textBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxF.Location = new System.Drawing.Point(12, 78);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(361, 27);
            this.textBoxF.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Фамилия";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Номер студ. билета";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum.Location = new System.Drawing.Point(12, 27);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(361, 27);
            this.textBoxNum.TabIndex = 25;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(239, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 47;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.lab3DataSet;
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // студентTableAdapter1
            // 
            this.студентTableAdapter1.ClearBeforeFill = true;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBoxDormitory);
            this.Controls.Add(this.textBoxSchool);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxFac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxDormitory;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxFac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private lab3DataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private lab3DataSetTableAdapters.СтудентTableAdapter студентTableAdapter1;
        private System.Windows.Forms.BindingSource группаBindingSource1;
        private lab3DataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
    }
}