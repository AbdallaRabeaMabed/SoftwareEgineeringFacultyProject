namespace EmployeeApplication
{
    partial class FormSignUp
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
            System.Windows.Forms.Label nationalIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label salaryLabel;
            this.labelNationalID = new System.Windows.Forms.Label();
            this.textBoxNationalID = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDataOfBirth = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.databaseEmployeeAppDataSet = new EmployeeApplication.DatabaseEmployeeAppDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeApplication.DatabaseEmployeeAppDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EmployeeApplication.DatabaseEmployeeAppDataSetTableAdapters.TableAdapterManager();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMinSalary = new System.Windows.Forms.Button();
            this.buttonBigSalary = new System.Windows.Forms.Button();
            this.buttonGetMales = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.nationalIDTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelMinSalaryValue = new System.Windows.Forms.Label();
            nationalIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEmployeeAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalIDLabel
            // 
            nationalIDLabel.AutoSize = true;
            nationalIDLabel.Location = new System.Drawing.Point(746, 54);
            nationalIDLabel.Name = "nationalIDLabel";
            nationalIDLabel.Size = new System.Drawing.Size(73, 16);
            nationalIDLabel.TabIndex = 25;
            nationalIDLabel.Text = "national ID:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(746, 82);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(66, 16);
            fullNameLabel.TabIndex = 27;
            fullNameLabel.Text = "full Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(746, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 16);
            genderLabel.TabIndex = 29;
            genderLabel.Text = "gender:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(746, 139);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(82, 16);
            dateOfBirthLabel.TabIndex = 31;
            dateOfBirthLabel.Text = "date Of Birth:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(746, 166);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(29, 16);
            jobLabel.TabIndex = 33;
            jobLabel.Text = "job:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(746, 194);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(69, 16);
            passwordLabel.TabIndex = 35;
            passwordLabel.Text = "password:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(746, 222);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(49, 16);
            salaryLabel.TabIndex = 37;
            salaryLabel.Text = "Salary:";
            // 
            // labelNationalID
            // 
            this.labelNationalID.AutoSize = true;
            this.labelNationalID.Location = new System.Drawing.Point(120, 50);
            this.labelNationalID.Name = "labelNationalID";
            this.labelNationalID.Size = new System.Drawing.Size(79, 16);
            this.labelNationalID.TabIndex = 0;
            this.labelNationalID.Text = "National ID: ";
            // 
            // textBoxNationalID
            // 
            this.textBoxNationalID.Location = new System.Drawing.Point(258, 50);
            this.textBoxNationalID.Name = "textBoxNationalID";
            this.textBoxNationalID.Size = new System.Drawing.Size(247, 22);
            this.textBoxNationalID.TabIndex = 1;
            this.textBoxNationalID.TextChanged += new System.EventHandler(this.textBoxNationalID_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Cyan;
            this.buttonSubmit.Location = new System.Drawing.Point(325, 336);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 41);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(120, 80);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(74, 16);
            this.labelFullName.TabIndex = 3;
            this.labelFullName.Text = "Full Name: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(120, 126);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(58, 16);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender: ";
            // 
            // labelDataOfBirth
            // 
            this.labelDataOfBirth.AutoSize = true;
            this.labelDataOfBirth.Location = new System.Drawing.Point(120, 173);
            this.labelDataOfBirth.Name = "labelDataOfBirth";
            this.labelDataOfBirth.Size = new System.Drawing.Size(87, 16);
            this.labelDataOfBirth.TabIndex = 5;
            this.labelDataOfBirth.Text = "Date Of Birth: ";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(120, 210);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(30, 16);
            this.labelJob.TabIndex = 6;
            this.labelJob.Text = "Job";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(120, 256);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 16);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password: ";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(258, 80);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(247, 22);
            this.textBoxFullName.TabIndex = 8;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(258, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(247, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(258, 126);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(58, 20);
            this.radioMale.TabIndex = 10;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(396, 126);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(74, 20);
            this.radioFemale.TabIndex = 11;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Programmer",
            "Manager"});
            this.comboBoxJob.Location = new System.Drawing.Point(272, 201);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(233, 24);
            this.comboBoxJob.TabIndex = 13;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(133, 300);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(52, 16);
            this.labelSalary.TabIndex = 14;
            this.labelSalary.Text = "Salary: ";
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSalary.Location = new System.Drawing.Point(258, 293);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownSalary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(247, 22);
            this.numericUpDownSalary.TabIndex = 15;
            this.numericUpDownSalary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalary.ValueChanged += new System.EventHandler(this.numericUpDownSalary_ValueChanged);
            // 
            // databaseEmployeeAppDataSet
            // 
            this.databaseEmployeeAppDataSet.DataSetName = "DatabaseEmployeeAppDataSet";
            this.databaseEmployeeAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseEmployeeAppDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeApplication.DatabaseEmployeeAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 394);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(924, 160);
            this.employeeDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nationalID";
            this.dataGridViewTextBoxColumn1.HeaderText = "nationalID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "fullName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "gender";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateOfBirth";
            this.dataGridViewTextBoxColumn4.HeaderText = "dateOfBirth";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "job";
            this.dataGridViewTextBoxColumn5.HeaderText = "job";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn6.HeaderText = "password";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // buttonMinSalary
            // 
            this.buttonMinSalary.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonMinSalary.Location = new System.Drawing.Point(581, 207);
            this.buttonMinSalary.Name = "buttonMinSalary";
            this.buttonMinSalary.Size = new System.Drawing.Size(148, 31);
            this.buttonMinSalary.TabIndex = 19;
            this.buttonMinSalary.Text = "Minimum Salary";
            this.buttonMinSalary.UseVisualStyleBackColor = false;
            this.buttonMinSalary.Click += new System.EventHandler(this.buttonMinSalary_Click);
            // 
            // buttonBigSalary
            // 
            this.buttonBigSalary.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBigSalary.Location = new System.Drawing.Point(581, 173);
            this.buttonBigSalary.Name = "buttonBigSalary";
            this.buttonBigSalary.Size = new System.Drawing.Size(148, 28);
            this.buttonBigSalary.TabIndex = 20;
            this.buttonBigSalary.Text = "Salary > 20000";
            this.buttonBigSalary.UseVisualStyleBackColor = false;
            this.buttonBigSalary.Click += new System.EventHandler(this.buttonBigSalary_Click);
            // 
            // buttonGetMales
            // 
            this.buttonGetMales.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGetMales.Location = new System.Drawing.Point(581, 132);
            this.buttonGetMales.Name = "buttonGetMales";
            this.buttonGetMales.Size = new System.Drawing.Size(148, 31);
            this.buttonGetMales.TabIndex = 21;
            this.buttonGetMales.Text = "Get Males";
            this.buttonGetMales.UseVisualStyleBackColor = false;
            this.buttonGetMales.Click += new System.EventHandler(this.buttonGetMales_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSort.Location = new System.Drawing.Point(581, 89);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(148, 31);
            this.buttonSort.TabIndex = 22;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.Location = new System.Drawing.Point(581, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 33);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSearch.Location = new System.Drawing.Point(824, 336);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 41);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(556, 345);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(247, 22);
            this.textBoxSearch.TabIndex = 25;
            // 
            // nationalIDTextBox
            // 
            this.nationalIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "nationalID", true));
            this.nationalIDTextBox.Location = new System.Drawing.Point(834, 51);
            this.nationalIDTextBox.Name = "nationalIDTextBox";
            this.nationalIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.nationalIDTextBox.TabIndex = 26;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(834, 79);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.fullNameTextBox.TabIndex = 28;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(834, 107);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 22);
            this.genderTextBox.TabIndex = 30;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "dateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(834, 135);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 32;
            // 
            // jobTextBox
            // 
            this.jobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "job", true));
            this.jobTextBox.Location = new System.Drawing.Point(834, 163);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(200, 22);
            this.jobTextBox.TabIndex = 34;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(834, 191);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 36;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(834, 219);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 22);
            this.salaryTextBox.TabIndex = 38;
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.AutoSize = true;
            this.labelMinSalary.Location = new System.Drawing.Point(572, 284);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(108, 16);
            this.labelMinSalary.TabIndex = 39;
            this.labelMinSalary.Text = "Minimum Salary: ";
            // 
            // labelMinSalaryValue
            // 
            this.labelMinSalaryValue.AutoSize = true;
            this.labelMinSalaryValue.Location = new System.Drawing.Point(704, 284);
            this.labelMinSalaryValue.Name = "labelMinSalaryValue";
            this.labelMinSalaryValue.Size = new System.Drawing.Size(0, 16);
            this.labelMinSalaryValue.TabIndex = 40;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 585);
            this.Controls.Add(this.labelMinSalaryValue);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(nationalIDLabel);
            this.Controls.Add(this.nationalIDTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonGetMales);
            this.Controls.Add(this.buttonBigSalary);
            this.Controls.Add(this.buttonMinSalary);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.comboBoxJob);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelDataOfBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNationalID);
            this.Controls.Add(this.labelNationalID);
            this.Name = "FormSignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEmployeeAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNationalID;
        private System.Windows.Forms.TextBox textBoxNationalID;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDataOfBirth;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private DatabaseEmployeeAppDataSet databaseEmployeeAppDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseEmployeeAppDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DatabaseEmployeeAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button buttonMinSalary;
        private System.Windows.Forms.Button buttonBigSalary;
        private System.Windows.Forms.Button buttonGetMales;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox nationalIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelMinSalaryValue;
    }
}