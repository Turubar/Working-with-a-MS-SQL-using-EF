
namespace Accountants_Tools
{
    partial class EmployeeForm
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
            this.EmployeeDGV = new System.Windows.Forms.DataGridView();
            this.DeleteEmployeeRB = new System.Windows.Forms.RadioButton();
            this.UpdateEmployeeRB = new System.Windows.Forms.RadioButton();
            this.AddEmployeeRB = new System.Windows.Forms.RadioButton();
            this.RefreshEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeLabel = new System.Windows.Forms.Label();
            this.SearchEmployeeTB = new System.Windows.Forms.TextBox();
            this.StateEmployeeLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTB = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.GenderEmployeeGB = new System.Windows.Forms.GroupBox();
            this.FemaleGenderRB = new System.Windows.Forms.RadioButton();
            this.MaleGenderRB = new System.Windows.Forms.RadioButton();
            this.DateBirthEmployeeLabel = new System.Windows.Forms.Label();
            this.PasportDetailTB = new System.Windows.Forms.TextBox();
            this.PasportDetailLabel = new System.Windows.Forms.Label();
            this.DateBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.CountryBirthTB = new System.Windows.Forms.TextBox();
            this.CountryBirthLabel = new System.Windows.Forms.Label();
            this.ResidencyEmployeeTB = new System.Windows.Forms.TextBox();
            this.ResidencyEmployeeLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTB = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailEmployeeTB = new System.Windows.Forms.TextBox();
            this.EmailEmployeeLabel = new System.Windows.Forms.Label();
            this.PositionTB = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.CompanyTB = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.PositionDGV = new System.Windows.Forms.DataGridView();
            this.CrudEmployeeButton = new System.Windows.Forms.Button();
            this.RefreshPositionButton = new System.Windows.Forms.Button();
            this.SearchPositionLabel = new System.Windows.Forms.Label();
            this.SearchPositionTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).BeginInit();
            this.GenderEmployeeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDGV
            // 
            this.EmployeeDGV.AllowUserToDeleteRows = false;
            this.EmployeeDGV.AllowUserToResizeColumns = false;
            this.EmployeeDGV.AllowUserToResizeRows = false;
            this.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EmployeeDGV.Location = new System.Drawing.Point(12, 12);
            this.EmployeeDGV.MultiSelect = false;
            this.EmployeeDGV.Name = "EmployeeDGV";
            this.EmployeeDGV.RowHeadersVisible = false;
            this.EmployeeDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDGV.Size = new System.Drawing.Size(1660, 379);
            this.EmployeeDGV.TabIndex = 0;
            this.EmployeeDGV.SelectionChanged += new System.EventHandler(this.EmployeeDGV_SelectionChanged);
            // 
            // DeleteEmployeeRB
            // 
            this.DeleteEmployeeRB.AutoSize = true;
            this.DeleteEmployeeRB.Location = new System.Drawing.Point(144, 409);
            this.DeleteEmployeeRB.Name = "DeleteEmployeeRB";
            this.DeleteEmployeeRB.Size = new System.Drawing.Size(101, 25);
            this.DeleteEmployeeRB.TabIndex = 13;
            this.DeleteEmployeeRB.Text = "Удаление";
            this.DeleteEmployeeRB.UseVisualStyleBackColor = true;
            this.DeleteEmployeeRB.CheckedChanged += new System.EventHandler(this.DeleteEmployeeRB_CheckedChanged);
            // 
            // UpdateEmployeeRB
            // 
            this.UpdateEmployeeRB.AutoSize = true;
            this.UpdateEmployeeRB.Location = new System.Drawing.Point(12, 409);
            this.UpdateEmployeeRB.Name = "UpdateEmployeeRB";
            this.UpdateEmployeeRB.Size = new System.Drawing.Size(126, 25);
            this.UpdateEmployeeRB.TabIndex = 12;
            this.UpdateEmployeeRB.Text = "Обновление";
            this.UpdateEmployeeRB.UseVisualStyleBackColor = true;
            this.UpdateEmployeeRB.CheckedChanged += new System.EventHandler(this.UpdateEmployeeRB_CheckedChanged);
            // 
            // AddEmployeeRB
            // 
            this.AddEmployeeRB.AutoSize = true;
            this.AddEmployeeRB.Checked = true;
            this.AddEmployeeRB.Location = new System.Drawing.Point(250, 409);
            this.AddEmployeeRB.Name = "AddEmployeeRB";
            this.AddEmployeeRB.Size = new System.Drawing.Size(123, 25);
            this.AddEmployeeRB.TabIndex = 11;
            this.AddEmployeeRB.TabStop = true;
            this.AddEmployeeRB.Text = "Добавление";
            this.AddEmployeeRB.UseVisualStyleBackColor = true;
            this.AddEmployeeRB.CheckedChanged += new System.EventHandler(this.AddEmployeeRB_CheckedChanged);
            // 
            // RefreshEmployeeButton
            // 
            this.RefreshEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshEmployeeButton.Location = new System.Drawing.Point(1488, 407);
            this.RefreshEmployeeButton.Name = "RefreshEmployeeButton";
            this.RefreshEmployeeButton.Size = new System.Drawing.Size(184, 29);
            this.RefreshEmployeeButton.TabIndex = 14;
            this.RefreshEmployeeButton.Text = "Обновить таблицу";
            this.RefreshEmployeeButton.UseVisualStyleBackColor = true;
            this.RefreshEmployeeButton.Click += new System.EventHandler(this.RefreshEmployeeButton_Click);
            // 
            // SearchEmployeeLabel
            // 
            this.SearchEmployeeLabel.AutoSize = true;
            this.SearchEmployeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployeeLabel.Location = new System.Drawing.Point(1011, 411);
            this.SearchEmployeeLabel.Name = "SearchEmployeeLabel";
            this.SearchEmployeeLabel.Size = new System.Drawing.Size(151, 21);
            this.SearchEmployeeLabel.TabIndex = 16;
            this.SearchEmployeeLabel.Text = "Найти работника:";
            // 
            // SearchEmployeeTB
            // 
            this.SearchEmployeeTB.Location = new System.Drawing.Point(1168, 408);
            this.SearchEmployeeTB.Name = "SearchEmployeeTB";
            this.SearchEmployeeTB.Size = new System.Drawing.Size(314, 29);
            this.SearchEmployeeTB.TabIndex = 1;
            this.SearchEmployeeTB.TextChanged += new System.EventHandler(this.SearchEmployeeTB_TextChanged);
            // 
            // StateEmployeeLabel
            // 
            this.StateEmployeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StateEmployeeLabel.Location = new System.Drawing.Point(372, 411);
            this.StateEmployeeLabel.Name = "StateEmployeeLabel";
            this.StateEmployeeLabel.Size = new System.Drawing.Size(614, 21);
            this.StateEmployeeLabel.TabIndex = 17;
            this.StateEmployeeLabel.Text = "работника в базу данных, заполните приведенные ниже поля";
            this.StateEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastNameLabel.Location = new System.Drawing.Point(8, 447);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 21);
            this.LastNameLabel.TabIndex = 18;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(12, 471);
            this.LastNameTB.MaxLength = 100;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(246, 29);
            this.LastNameTB.TabIndex = 2;
            this.LastNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTB_KeyPress);
            this.LastNameTB.Leave += new System.EventHandler(this.FullName_Leave);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(12, 546);
            this.FirstNameTB.MaxLength = 100;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(246, 29);
            this.FirstNameTB.TabIndex = 3;
            this.FirstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTB_KeyPress);
            this.FirstNameTB.Leave += new System.EventHandler(this.FullName_Leave);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstNameLabel.Location = new System.Drawing.Point(8, 522);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(48, 21);
            this.FirstNameLabel.TabIndex = 20;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.Location = new System.Drawing.Point(12, 621);
            this.MiddleNameTB.MaxLength = 100;
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(246, 29);
            this.MiddleNameTB.TabIndex = 4;
            this.MiddleNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTB_KeyPress);
            this.MiddleNameTB.Leave += new System.EventHandler(this.FullName_Leave);
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiddleNameLabel.Location = new System.Drawing.Point(8, 597);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(90, 21);
            this.MiddleNameLabel.TabIndex = 22;
            this.MiddleNameLabel.Text = "Отчество:";
            // 
            // GenderEmployeeGB
            // 
            this.GenderEmployeeGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenderEmployeeGB.Controls.Add(this.FemaleGenderRB);
            this.GenderEmployeeGB.Controls.Add(this.MaleGenderRB);
            this.GenderEmployeeGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderEmployeeGB.Location = new System.Drawing.Point(282, 447);
            this.GenderEmployeeGB.Name = "GenderEmployeeGB";
            this.GenderEmployeeGB.Size = new System.Drawing.Size(246, 53);
            this.GenderEmployeeGB.TabIndex = 23;
            this.GenderEmployeeGB.TabStop = false;
            this.GenderEmployeeGB.Text = "Выберите пол:";
            // 
            // FemaleGenderRB
            // 
            this.FemaleGenderRB.AutoSize = true;
            this.FemaleGenderRB.Location = new System.Drawing.Point(136, 25);
            this.FemaleGenderRB.Name = "FemaleGenderRB";
            this.FemaleGenderRB.Size = new System.Drawing.Size(104, 25);
            this.FemaleGenderRB.TabIndex = 25;
            this.FemaleGenderRB.Text = "Женщина";
            this.FemaleGenderRB.UseVisualStyleBackColor = true;
            // 
            // MaleGenderRB
            // 
            this.MaleGenderRB.AutoSize = true;
            this.MaleGenderRB.Checked = true;
            this.MaleGenderRB.Location = new System.Drawing.Point(6, 25);
            this.MaleGenderRB.Name = "MaleGenderRB";
            this.MaleGenderRB.Size = new System.Drawing.Size(104, 25);
            this.MaleGenderRB.TabIndex = 24;
            this.MaleGenderRB.TabStop = true;
            this.MaleGenderRB.Text = "Мужчина";
            this.MaleGenderRB.UseVisualStyleBackColor = true;
            // 
            // DateBirthEmployeeLabel
            // 
            this.DateBirthEmployeeLabel.AutoSize = true;
            this.DateBirthEmployeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateBirthEmployeeLabel.Location = new System.Drawing.Point(278, 522);
            this.DateBirthEmployeeLabel.Name = "DateBirthEmployeeLabel";
            this.DateBirthEmployeeLabel.Size = new System.Drawing.Size(136, 21);
            this.DateBirthEmployeeLabel.TabIndex = 25;
            this.DateBirthEmployeeLabel.Text = "Дата рождения:";
            // 
            // PasportDetailTB
            // 
            this.PasportDetailTB.Location = new System.Drawing.Point(282, 621);
            this.PasportDetailTB.MaxLength = 11;
            this.PasportDetailTB.Name = "PasportDetailTB";
            this.PasportDetailTB.Size = new System.Drawing.Size(246, 29);
            this.PasportDetailTB.TabIndex = 6;
            this.PasportDetailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasportDetailTB_KeyPress);
            this.PasportDetailTB.Leave += new System.EventHandler(this.PasportDetailTB_Leave);
            // 
            // PasportDetailLabel
            // 
            this.PasportDetailLabel.AutoSize = true;
            this.PasportDetailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasportDetailLabel.Location = new System.Drawing.Point(278, 597);
            this.PasportDetailLabel.Name = "PasportDetailLabel";
            this.PasportDetailLabel.Size = new System.Drawing.Size(177, 21);
            this.PasportDetailLabel.TabIndex = 27;
            this.PasportDetailLabel.Text = "Паспортные данные:";
            // 
            // DateBirthDTP
            // 
            this.DateBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirthDTP.Location = new System.Drawing.Point(282, 546);
            this.DateBirthDTP.MaxDate = new System.DateTime(2022, 12, 12, 0, 0, 0, 0);
            this.DateBirthDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateBirthDTP.Name = "DateBirthDTP";
            this.DateBirthDTP.Size = new System.Drawing.Size(246, 29);
            this.DateBirthDTP.TabIndex = 5;
            this.DateBirthDTP.Value = new System.DateTime(2022, 12, 12, 0, 0, 0, 0);
            // 
            // CountryBirthTB
            // 
            this.CountryBirthTB.Location = new System.Drawing.Point(552, 471);
            this.CountryBirthTB.MaxLength = 100;
            this.CountryBirthTB.Name = "CountryBirthTB";
            this.CountryBirthTB.Size = new System.Drawing.Size(246, 29);
            this.CountryBirthTB.TabIndex = 7;
            this.CountryBirthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryBirthTB_KeyPress);
            this.CountryBirthTB.Leave += new System.EventHandler(this.CountryBirthTB_Leave);
            // 
            // CountryBirthLabel
            // 
            this.CountryBirthLabel.AutoSize = true;
            this.CountryBirthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryBirthLabel.Location = new System.Drawing.Point(548, 447);
            this.CountryBirthLabel.Name = "CountryBirthLabel";
            this.CountryBirthLabel.Size = new System.Drawing.Size(71, 21);
            this.CountryBirthLabel.TabIndex = 30;
            this.CountryBirthLabel.Text = "Страна:";
            // 
            // ResidencyEmployeeTB
            // 
            this.ResidencyEmployeeTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidencyEmployeeTB.Location = new System.Drawing.Point(552, 546);
            this.ResidencyEmployeeTB.MaxLength = 150;
            this.ResidencyEmployeeTB.Name = "ResidencyEmployeeTB";
            this.ResidencyEmployeeTB.Size = new System.Drawing.Size(246, 29);
            this.ResidencyEmployeeTB.TabIndex = 8;
            this.ResidencyEmployeeTB.Leave += new System.EventHandler(this.ResidencyEmployeeTB_Leave);
            // 
            // ResidencyEmployeeLabel
            // 
            this.ResidencyEmployeeLabel.AutoSize = true;
            this.ResidencyEmployeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidencyEmployeeLabel.Location = new System.Drawing.Point(548, 522);
            this.ResidencyEmployeeLabel.Name = "ResidencyEmployeeLabel";
            this.ResidencyEmployeeLabel.Size = new System.Drawing.Size(158, 21);
            this.ResidencyEmployeeLabel.TabIndex = 32;
            this.ResidencyEmployeeLabel.Text = "Местожительство:";
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.Location = new System.Drawing.Point(552, 621);
            this.PhoneNumberTB.MaxLength = 12;
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(246, 29);
            this.PhoneNumberTB.TabIndex = 9;
            this.PhoneNumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTB_KeyPress);
            this.PhoneNumberTB.Leave += new System.EventHandler(this.PhoneNumberTB_Leave);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(548, 597);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(145, 21);
            this.PhoneNumberLabel.TabIndex = 34;
            this.PhoneNumberLabel.Text = "Номер телефона:";
            // 
            // EmailEmployeeTB
            // 
            this.EmailEmployeeTB.Location = new System.Drawing.Point(822, 471);
            this.EmailEmployeeTB.MaxLength = 100;
            this.EmailEmployeeTB.Name = "EmailEmployeeTB";
            this.EmailEmployeeTB.Size = new System.Drawing.Size(246, 29);
            this.EmailEmployeeTB.TabIndex = 10;
            this.EmailEmployeeTB.Leave += new System.EventHandler(this.EmailEmployeeTB_Leave);
            // 
            // EmailEmployeeLabel
            // 
            this.EmailEmployeeLabel.AutoSize = true;
            this.EmailEmployeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailEmployeeLabel.Location = new System.Drawing.Point(822, 447);
            this.EmailEmployeeLabel.Name = "EmailEmployeeLabel";
            this.EmailEmployeeLabel.Size = new System.Drawing.Size(55, 21);
            this.EmailEmployeeLabel.TabIndex = 36;
            this.EmailEmployeeLabel.Text = "Email:";
            // 
            // PositionTB
            // 
            this.PositionTB.Enabled = false;
            this.PositionTB.Location = new System.Drawing.Point(822, 546);
            this.PositionTB.MaxLength = 100;
            this.PositionTB.Name = "PositionTB";
            this.PositionTB.Size = new System.Drawing.Size(246, 29);
            this.PositionTB.TabIndex = 37;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionLabel.Location = new System.Drawing.Point(822, 522);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(105, 21);
            this.PositionLabel.TabIndex = 38;
            this.PositionLabel.Text = "Должность:";
            // 
            // CompanyTB
            // 
            this.CompanyTB.Enabled = false;
            this.CompanyTB.Location = new System.Drawing.Point(822, 621);
            this.CompanyTB.MaxLength = 150;
            this.CompanyTB.Name = "CompanyTB";
            this.CompanyTB.Size = new System.Drawing.Size(246, 29);
            this.CompanyTB.TabIndex = 39;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyLabel.Location = new System.Drawing.Point(822, 597);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(95, 21);
            this.CompanyLabel.TabIndex = 40;
            this.CompanyLabel.Text = "Компания:";
            // 
            // PositionDGV
            // 
            this.PositionDGV.AllowUserToDeleteRows = false;
            this.PositionDGV.AllowUserToResizeColumns = false;
            this.PositionDGV.AllowUserToResizeRows = false;
            this.PositionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PositionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PositionDGV.Location = new System.Drawing.Point(1092, 447);
            this.PositionDGV.MultiSelect = false;
            this.PositionDGV.Name = "PositionDGV";
            this.PositionDGV.RowHeadersVisible = false;
            this.PositionDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PositionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PositionDGV.Size = new System.Drawing.Size(580, 128);
            this.PositionDGV.TabIndex = 41;
            this.PositionDGV.SelectionChanged += new System.EventHandler(this.PositionDGV_SelectionChanged);
            // 
            // CrudEmployeeButton
            // 
            this.CrudEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrudEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrudEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrudEmployeeButton.Location = new System.Drawing.Point(1455, 581);
            this.CrudEmployeeButton.Name = "CrudEmployeeButton";
            this.CrudEmployeeButton.Size = new System.Drawing.Size(217, 69);
            this.CrudEmployeeButton.TabIndex = 12;
            this.CrudEmployeeButton.Text = "Добавить";
            this.CrudEmployeeButton.UseVisualStyleBackColor = true;
            this.CrudEmployeeButton.Click += new System.EventHandler(this.CrudEmployeeButton_Click);
            // 
            // RefreshPositionButton
            // 
            this.RefreshPositionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshPositionButton.Location = new System.Drawing.Point(1262, 585);
            this.RefreshPositionButton.Name = "RefreshPositionButton";
            this.RefreshPositionButton.Size = new System.Drawing.Size(184, 29);
            this.RefreshPositionButton.TabIndex = 43;
            this.RefreshPositionButton.Text = "Обновить таблицу";
            this.RefreshPositionButton.UseVisualStyleBackColor = true;
            this.RefreshPositionButton.Click += new System.EventHandler(this.RefreshPositionButton_Click);
            // 
            // SearchPositionLabel
            // 
            this.SearchPositionLabel.AutoSize = true;
            this.SearchPositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPositionLabel.Location = new System.Drawing.Point(1088, 589);
            this.SearchPositionLabel.Name = "SearchPositionLabel";
            this.SearchPositionLabel.Size = new System.Drawing.Size(156, 21);
            this.SearchPositionLabel.TabIndex = 44;
            this.SearchPositionLabel.Text = "Найти должность:";
            // 
            // SearchPositionTB
            // 
            this.SearchPositionTB.Location = new System.Drawing.Point(1092, 620);
            this.SearchPositionTB.Name = "SearchPositionTB";
            this.SearchPositionTB.Size = new System.Drawing.Size(354, 29);
            this.SearchPositionTB.TabIndex = 11;
            this.SearchPositionTB.TextChanged += new System.EventHandler(this.SearchPositionTB_TextChanged);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1684, 661);
            this.Controls.Add(this.SearchPositionTB);
            this.Controls.Add(this.SearchPositionLabel);
            this.Controls.Add(this.RefreshPositionButton);
            this.Controls.Add(this.CrudEmployeeButton);
            this.Controls.Add(this.PositionDGV);
            this.Controls.Add(this.CompanyTB);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.PositionTB);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.EmailEmployeeTB);
            this.Controls.Add(this.EmailEmployeeLabel);
            this.Controls.Add(this.PhoneNumberTB);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.ResidencyEmployeeTB);
            this.Controls.Add(this.ResidencyEmployeeLabel);
            this.Controls.Add(this.CountryBirthTB);
            this.Controls.Add(this.CountryBirthLabel);
            this.Controls.Add(this.DateBirthDTP);
            this.Controls.Add(this.PasportDetailTB);
            this.Controls.Add(this.PasportDetailLabel);
            this.Controls.Add(this.DateBirthEmployeeLabel);
            this.Controls.Add(this.GenderEmployeeGB);
            this.Controls.Add(this.MiddleNameTB);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.StateEmployeeLabel);
            this.Controls.Add(this.SearchEmployeeLabel);
            this.Controls.Add(this.SearchEmployeeTB);
            this.Controls.Add(this.RefreshEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeRB);
            this.Controls.Add(this.UpdateEmployeeRB);
            this.Controls.Add(this.AddEmployeeRB);
            this.Controls.Add(this.EmployeeDGV);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работники";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).EndInit();
            this.GenderEmployeeGB.ResumeLayout(false);
            this.GenderEmployeeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDGV;
        private System.Windows.Forms.RadioButton DeleteEmployeeRB;
        private System.Windows.Forms.RadioButton UpdateEmployeeRB;
        private System.Windows.Forms.RadioButton AddEmployeeRB;
        private System.Windows.Forms.Button RefreshEmployeeButton;
        private System.Windows.Forms.Label SearchEmployeeLabel;
        private System.Windows.Forms.TextBox SearchEmployeeTB;
        private System.Windows.Forms.Label StateEmployeeLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.GroupBox GenderEmployeeGB;
        private System.Windows.Forms.RadioButton FemaleGenderRB;
        private System.Windows.Forms.RadioButton MaleGenderRB;
        private System.Windows.Forms.Label DateBirthEmployeeLabel;
        private System.Windows.Forms.TextBox PasportDetailTB;
        private System.Windows.Forms.Label PasportDetailLabel;
        private System.Windows.Forms.DateTimePicker DateBirthDTP;
        private System.Windows.Forms.TextBox CountryBirthTB;
        private System.Windows.Forms.Label CountryBirthLabel;
        private System.Windows.Forms.TextBox ResidencyEmployeeTB;
        private System.Windows.Forms.Label ResidencyEmployeeLabel;
        private System.Windows.Forms.TextBox PhoneNumberTB;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailEmployeeTB;
        private System.Windows.Forms.Label EmailEmployeeLabel;
        private System.Windows.Forms.TextBox PositionTB;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox CompanyTB;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.DataGridView PositionDGV;
        private System.Windows.Forms.Button CrudEmployeeButton;
        private System.Windows.Forms.Button RefreshPositionButton;
        private System.Windows.Forms.Label SearchPositionLabel;
        private System.Windows.Forms.TextBox SearchPositionTB;
    }
}