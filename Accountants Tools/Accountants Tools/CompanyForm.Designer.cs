
namespace Accountants_Tools
{
    partial class CompanyForm
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
            this.MainTC = new System.Windows.Forms.TabControl();
            this.CompanyPage = new System.Windows.Forms.TabPage();
            this.nameColumnLabel = new System.Windows.Forms.Label();
            this.CrudButton = new System.Windows.Forms.Button();
            this.StateLabel = new System.Windows.Forms.Label();
            this.DeleteRB = new System.Windows.Forms.RadioButton();
            this.UpdateRB = new System.Windows.Forms.RadioButton();
            this.AddRB = new System.Windows.Forms.RadioButton();
            this.CrudDGV = new System.Windows.Forms.DataGridView();
            this.RefreshCompanyButton = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.CompanyDGV = new System.Windows.Forms.DataGridView();
            this.PositionPage = new System.Windows.Forms.TabPage();
            this.CompanyNameCB = new System.Windows.Forms.ComboBox();
            this.CrudPositionButton = new System.Windows.Forms.Button();
            this.CompanyPositionLabel = new System.Windows.Forms.Label();
            this.DescriptionPositionLabel = new System.Windows.Forms.Label();
            this.SalaryPositionLabel = new System.Windows.Forms.Label();
            this.NamePositionLabel = new System.Windows.Forms.Label();
            this.CompanyPositionTB = new System.Windows.Forms.TextBox();
            this.DescriptionPositionTB = new System.Windows.Forms.TextBox();
            this.SalaryPositionTB = new System.Windows.Forms.TextBox();
            this.NamePositionTB = new System.Windows.Forms.TextBox();
            this.StatePositionLabel = new System.Windows.Forms.Label();
            this.DeletePositionRB = new System.Windows.Forms.RadioButton();
            this.UpdatePositionRB = new System.Windows.Forms.RadioButton();
            this.AddPositionRB = new System.Windows.Forms.RadioButton();
            this.SearchPositionLabel = new System.Windows.Forms.Label();
            this.SearchPositionTB = new System.Windows.Forms.TextBox();
            this.RefreshPositionButton = new System.Windows.Forms.Button();
            this.PositionDGV = new System.Windows.Forms.DataGridView();
            this.MainTC.SuspendLayout();
            this.CompanyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrudDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDGV)).BeginInit();
            this.PositionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTC
            // 
            this.MainTC.Controls.Add(this.CompanyPage);
            this.MainTC.Controls.Add(this.PositionPage);
            this.MainTC.Location = new System.Drawing.Point(3, 3);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.Size = new System.Drawing.Size(1379, 654);
            this.MainTC.TabIndex = 0;
            this.MainTC.SelectedIndexChanged += new System.EventHandler(this.MainTC_SelectedIndexChanged);
            // 
            // CompanyPage
            // 
            this.CompanyPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyPage.Controls.Add(this.nameColumnLabel);
            this.CompanyPage.Controls.Add(this.CrudButton);
            this.CompanyPage.Controls.Add(this.StateLabel);
            this.CompanyPage.Controls.Add(this.DeleteRB);
            this.CompanyPage.Controls.Add(this.UpdateRB);
            this.CompanyPage.Controls.Add(this.AddRB);
            this.CompanyPage.Controls.Add(this.CrudDGV);
            this.CompanyPage.Controls.Add(this.RefreshCompanyButton);
            this.CompanyPage.Controls.Add(this.SearchTB);
            this.CompanyPage.Controls.Add(this.SearchLabel);
            this.CompanyPage.Controls.Add(this.CompanyDGV);
            this.CompanyPage.Location = new System.Drawing.Point(4, 30);
            this.CompanyPage.Name = "CompanyPage";
            this.CompanyPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompanyPage.Size = new System.Drawing.Size(1371, 620);
            this.CompanyPage.TabIndex = 0;
            this.CompanyPage.Text = "Компании";
            this.CompanyPage.UseVisualStyleBackColor = true;
            // 
            // nameColumnLabel
            // 
            this.nameColumnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameColumnLabel.Location = new System.Drawing.Point(6, 493);
            this.nameColumnLabel.Name = "nameColumnLabel";
            this.nameColumnLabel.Size = new System.Drawing.Size(1357, 21);
            this.nameColumnLabel.TabIndex = 10;
            this.nameColumnLabel.Text = "Название компании       Фамилия владельца        Имя владельца       Отчество вла" +
    "дельца       Дата создания                        Описание компании";
            this.nameColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CrudButton
            // 
            this.CrudButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrudButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrudButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrudButton.Location = new System.Drawing.Point(1122, 547);
            this.CrudButton.Name = "CrudButton";
            this.CrudButton.Size = new System.Drawing.Size(241, 65);
            this.CrudButton.TabIndex = 9;
            this.CrudButton.Text = "Добавить";
            this.CrudButton.UseVisualStyleBackColor = true;
            this.CrudButton.Click += new System.EventHandler(this.CrudButton_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StateLabel.Location = new System.Drawing.Point(388, 456);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(975, 21);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "Для добавления компании заполните поля";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeleteRB
            // 
            this.DeleteRB.AutoSize = true;
            this.DeleteRB.Location = new System.Drawing.Point(267, 454);
            this.DeleteRB.Name = "DeleteRB";
            this.DeleteRB.Size = new System.Drawing.Size(101, 25);
            this.DeleteRB.TabIndex = 7;
            this.DeleteRB.TabStop = true;
            this.DeleteRB.Text = "Удаление";
            this.DeleteRB.UseVisualStyleBackColor = true;
            this.DeleteRB.CheckedChanged += new System.EventHandler(this.DeleteRB_CheckedChanged);
            // 
            // UpdateRB
            // 
            this.UpdateRB.AutoSize = true;
            this.UpdateRB.Location = new System.Drawing.Point(135, 454);
            this.UpdateRB.Name = "UpdateRB";
            this.UpdateRB.Size = new System.Drawing.Size(126, 25);
            this.UpdateRB.TabIndex = 6;
            this.UpdateRB.TabStop = true;
            this.UpdateRB.Text = "Обновление";
            this.UpdateRB.UseVisualStyleBackColor = true;
            this.UpdateRB.CheckedChanged += new System.EventHandler(this.UpdateRB_CheckedChanged);
            // 
            // AddRB
            // 
            this.AddRB.AutoSize = true;
            this.AddRB.Checked = true;
            this.AddRB.Location = new System.Drawing.Point(6, 454);
            this.AddRB.Name = "AddRB";
            this.AddRB.Size = new System.Drawing.Size(123, 25);
            this.AddRB.TabIndex = 5;
            this.AddRB.TabStop = true;
            this.AddRB.Text = "Добавление";
            this.AddRB.UseVisualStyleBackColor = true;
            this.AddRB.CheckedChanged += new System.EventHandler(this.AddRB_CheckedChanged);
            // 
            // CrudDGV
            // 
            this.CrudDGV.AllowUserToDeleteRows = false;
            this.CrudDGV.AllowUserToResizeColumns = false;
            this.CrudDGV.AllowUserToResizeRows = false;
            this.CrudDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CrudDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrudDGV.ColumnHeadersVisible = false;
            this.CrudDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.CrudDGV.Location = new System.Drawing.Point(6, 517);
            this.CrudDGV.MultiSelect = false;
            this.CrudDGV.Name = "CrudDGV";
            this.CrudDGV.RowHeadersVisible = false;
            this.CrudDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CrudDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CrudDGV.Size = new System.Drawing.Size(1357, 24);
            this.CrudDGV.TabIndex = 4;
            this.CrudDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CrudDGV_CellEndEdit);
            this.CrudDGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CrudDGV_CellEnter);
            this.CrudDGV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CrudDGV_CellLeave);
            this.CrudDGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.CrudDGV_RowsRemoved);
            // 
            // RefreshCompanyButton
            // 
            this.RefreshCompanyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshCompanyButton.Location = new System.Drawing.Point(6, 6);
            this.RefreshCompanyButton.Name = "RefreshCompanyButton";
            this.RefreshCompanyButton.Size = new System.Drawing.Size(184, 29);
            this.RefreshCompanyButton.TabIndex = 3;
            this.RefreshCompanyButton.Text = "Обновить таблицу";
            this.RefreshCompanyButton.UseVisualStyleBackColor = true;
            this.RefreshCompanyButton.Click += new System.EventHandler(this.RefreshCompanyButton_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(983, 6);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(380, 29);
            this.SearchTB.TabIndex = 2;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.Location = new System.Drawing.Point(827, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(150, 21);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Найти компанию:";
            // 
            // CompanyDGV
            // 
            this.CompanyDGV.AllowUserToDeleteRows = false;
            this.CompanyDGV.AllowUserToResizeColumns = false;
            this.CompanyDGV.AllowUserToResizeRows = false;
            this.CompanyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CompanyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDGV.Location = new System.Drawing.Point(6, 41);
            this.CompanyDGV.MultiSelect = false;
            this.CompanyDGV.Name = "CompanyDGV";
            this.CompanyDGV.ReadOnly = true;
            this.CompanyDGV.RowHeadersVisible = false;
            this.CompanyDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompanyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDGV.Size = new System.Drawing.Size(1357, 399);
            this.CompanyDGV.TabIndex = 0;
            this.CompanyDGV.SelectionChanged += new System.EventHandler(this.CompanyDGV_SelectionChanged);
            // 
            // PositionPage
            // 
            this.PositionPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionPage.Controls.Add(this.CompanyNameCB);
            this.PositionPage.Controls.Add(this.CrudPositionButton);
            this.PositionPage.Controls.Add(this.CompanyPositionLabel);
            this.PositionPage.Controls.Add(this.DescriptionPositionLabel);
            this.PositionPage.Controls.Add(this.SalaryPositionLabel);
            this.PositionPage.Controls.Add(this.NamePositionLabel);
            this.PositionPage.Controls.Add(this.CompanyPositionTB);
            this.PositionPage.Controls.Add(this.DescriptionPositionTB);
            this.PositionPage.Controls.Add(this.SalaryPositionTB);
            this.PositionPage.Controls.Add(this.NamePositionTB);
            this.PositionPage.Controls.Add(this.StatePositionLabel);
            this.PositionPage.Controls.Add(this.DeletePositionRB);
            this.PositionPage.Controls.Add(this.UpdatePositionRB);
            this.PositionPage.Controls.Add(this.AddPositionRB);
            this.PositionPage.Controls.Add(this.SearchPositionLabel);
            this.PositionPage.Controls.Add(this.SearchPositionTB);
            this.PositionPage.Controls.Add(this.RefreshPositionButton);
            this.PositionPage.Controls.Add(this.PositionDGV);
            this.PositionPage.Location = new System.Drawing.Point(4, 30);
            this.PositionPage.Name = "PositionPage";
            this.PositionPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionPage.Size = new System.Drawing.Size(1371, 620);
            this.PositionPage.TabIndex = 1;
            this.PositionPage.Text = "Должности";
            this.PositionPage.UseVisualStyleBackColor = true;
            // 
            // CompanyNameCB
            // 
            this.CompanyNameCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CompanyNameCB.FormattingEnabled = true;
            this.CompanyNameCB.Location = new System.Drawing.Point(1108, 493);
            this.CompanyNameCB.Name = "CompanyNameCB";
            this.CompanyNameCB.Size = new System.Drawing.Size(255, 29);
            this.CompanyNameCB.TabIndex = 21;
            this.CompanyNameCB.SelectedIndexChanged += new System.EventHandler(this.CompanyNameCB_SelectedIndexChanged);
            // 
            // CrudPositionButton
            // 
            this.CrudPositionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrudPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrudPositionButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrudPositionButton.Location = new System.Drawing.Point(1122, 559);
            this.CrudPositionButton.Name = "CrudPositionButton";
            this.CrudPositionButton.Size = new System.Drawing.Size(241, 53);
            this.CrudPositionButton.TabIndex = 20;
            this.CrudPositionButton.Text = "Добавить";
            this.CrudPositionButton.UseVisualStyleBackColor = true;
            this.CrudPositionButton.Click += new System.EventHandler(this.CrudPositionButton_Click);
            // 
            // CompanyPositionLabel
            // 
            this.CompanyPositionLabel.AutoSize = true;
            this.CompanyPositionLabel.Location = new System.Drawing.Point(1011, 496);
            this.CompanyPositionLabel.Name = "CompanyPositionLabel";
            this.CompanyPositionLabel.Size = new System.Drawing.Size(91, 21);
            this.CompanyPositionLabel.TabIndex = 19;
            this.CompanyPositionLabel.Text = "Компания";
            // 
            // DescriptionPositionLabel
            // 
            this.DescriptionPositionLabel.AutoSize = true;
            this.DescriptionPositionLabel.Location = new System.Drawing.Point(547, 496);
            this.DescriptionPositionLabel.Name = "DescriptionPositionLabel";
            this.DescriptionPositionLabel.Size = new System.Drawing.Size(183, 21);
            this.DescriptionPositionLabel.TabIndex = 18;
            this.DescriptionPositionLabel.Text = "Описание должности";
            // 
            // SalaryPositionLabel
            // 
            this.SalaryPositionLabel.AutoSize = true;
            this.SalaryPositionLabel.Location = new System.Drawing.Point(406, 496);
            this.SalaryPositionLabel.Name = "SalaryPositionLabel";
            this.SalaryPositionLabel.Size = new System.Drawing.Size(81, 21);
            this.SalaryPositionLabel.TabIndex = 17;
            this.SalaryPositionLabel.Text = "Зарплата";
            // 
            // NamePositionLabel
            // 
            this.NamePositionLabel.AutoSize = true;
            this.NamePositionLabel.Location = new System.Drawing.Point(2, 496);
            this.NamePositionLabel.Name = "NamePositionLabel";
            this.NamePositionLabel.Size = new System.Drawing.Size(178, 21);
            this.NamePositionLabel.TabIndex = 16;
            this.NamePositionLabel.Text = "Название должности";
            // 
            // CompanyPositionTB
            // 
            this.CompanyPositionTB.Location = new System.Drawing.Point(1015, 524);
            this.CompanyPositionTB.Name = "CompanyPositionTB";
            this.CompanyPositionTB.Size = new System.Drawing.Size(348, 29);
            this.CompanyPositionTB.TabIndex = 15;
            this.CompanyPositionTB.Leave += new System.EventHandler(this.CompanyPositionTB_Leave);
            // 
            // DescriptionPositionTB
            // 
            this.DescriptionPositionTB.Location = new System.Drawing.Point(551, 524);
            this.DescriptionPositionTB.Name = "DescriptionPositionTB";
            this.DescriptionPositionTB.Size = new System.Drawing.Size(458, 29);
            this.DescriptionPositionTB.TabIndex = 14;
            this.DescriptionPositionTB.Leave += new System.EventHandler(this.DescriptionPositionTB_Leave);
            // 
            // SalaryPositionTB
            // 
            this.SalaryPositionTB.Location = new System.Drawing.Point(410, 524);
            this.SalaryPositionTB.MaxLength = 11;
            this.SalaryPositionTB.Name = "SalaryPositionTB";
            this.SalaryPositionTB.Size = new System.Drawing.Size(135, 29);
            this.SalaryPositionTB.TabIndex = 13;
            this.SalaryPositionTB.TextChanged += new System.EventHandler(this.SalaryPositionTB_TextChanged);
            this.SalaryPositionTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryPositionTB_KeyPress);
            // 
            // NamePositionTB
            // 
            this.NamePositionTB.Location = new System.Drawing.Point(6, 524);
            this.NamePositionTB.MaxLength = 100;
            this.NamePositionTB.Name = "NamePositionTB";
            this.NamePositionTB.Size = new System.Drawing.Size(398, 29);
            this.NamePositionTB.TabIndex = 12;
            this.NamePositionTB.Leave += new System.EventHandler(this.NamePositionTB_Leave);
            // 
            // StatePositionLabel
            // 
            this.StatePositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatePositionLabel.Location = new System.Drawing.Point(413, 456);
            this.StatePositionLabel.Name = "StatePositionLabel";
            this.StatePositionLabel.Size = new System.Drawing.Size(950, 21);
            this.StatePositionLabel.TabIndex = 11;
            this.StatePositionLabel.Text = "Для добавления должности заполните поля";
            this.StatePositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeletePositionRB
            // 
            this.DeletePositionRB.AutoSize = true;
            this.DeletePositionRB.Location = new System.Drawing.Point(267, 454);
            this.DeletePositionRB.Name = "DeletePositionRB";
            this.DeletePositionRB.Size = new System.Drawing.Size(101, 25);
            this.DeletePositionRB.TabIndex = 10;
            this.DeletePositionRB.TabStop = true;
            this.DeletePositionRB.Text = "Удаление";
            this.DeletePositionRB.UseVisualStyleBackColor = true;
            this.DeletePositionRB.CheckedChanged += new System.EventHandler(this.DeletePositionRB_CheckedChanged);
            // 
            // UpdatePositionRB
            // 
            this.UpdatePositionRB.AutoSize = true;
            this.UpdatePositionRB.Location = new System.Drawing.Point(135, 454);
            this.UpdatePositionRB.Name = "UpdatePositionRB";
            this.UpdatePositionRB.Size = new System.Drawing.Size(126, 25);
            this.UpdatePositionRB.TabIndex = 9;
            this.UpdatePositionRB.TabStop = true;
            this.UpdatePositionRB.Text = "Обновление";
            this.UpdatePositionRB.UseVisualStyleBackColor = true;
            this.UpdatePositionRB.CheckedChanged += new System.EventHandler(this.UpdatePositionRB_CheckedChanged);
            // 
            // AddPositionRB
            // 
            this.AddPositionRB.AutoSize = true;
            this.AddPositionRB.Checked = true;
            this.AddPositionRB.Location = new System.Drawing.Point(6, 454);
            this.AddPositionRB.Name = "AddPositionRB";
            this.AddPositionRB.Size = new System.Drawing.Size(123, 25);
            this.AddPositionRB.TabIndex = 8;
            this.AddPositionRB.TabStop = true;
            this.AddPositionRB.Text = "Добавление";
            this.AddPositionRB.UseVisualStyleBackColor = true;
            this.AddPositionRB.CheckedChanged += new System.EventHandler(this.AddPositionRB_CheckedChanged);
            // 
            // SearchPositionLabel
            // 
            this.SearchPositionLabel.AutoSize = true;
            this.SearchPositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPositionLabel.Location = new System.Drawing.Point(821, 9);
            this.SearchPositionLabel.Name = "SearchPositionLabel";
            this.SearchPositionLabel.Size = new System.Drawing.Size(156, 21);
            this.SearchPositionLabel.TabIndex = 6;
            this.SearchPositionLabel.Text = "Найти должность:";
            // 
            // SearchPositionTB
            // 
            this.SearchPositionTB.Location = new System.Drawing.Point(983, 6);
            this.SearchPositionTB.Name = "SearchPositionTB";
            this.SearchPositionTB.Size = new System.Drawing.Size(380, 29);
            this.SearchPositionTB.TabIndex = 5;
            this.SearchPositionTB.TextChanged += new System.EventHandler(this.SearchPositionTB_TextChanged);
            // 
            // RefreshPositionButton
            // 
            this.RefreshPositionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshPositionButton.Location = new System.Drawing.Point(6, 6);
            this.RefreshPositionButton.Name = "RefreshPositionButton";
            this.RefreshPositionButton.Size = new System.Drawing.Size(184, 29);
            this.RefreshPositionButton.TabIndex = 4;
            this.RefreshPositionButton.Text = "Обновить таблицу";
            this.RefreshPositionButton.UseVisualStyleBackColor = true;
            this.RefreshPositionButton.Click += new System.EventHandler(this.RefreshPositionButton_Click);
            // 
            // PositionDGV
            // 
            this.PositionDGV.AllowUserToDeleteRows = false;
            this.PositionDGV.AllowUserToResizeColumns = false;
            this.PositionDGV.AllowUserToResizeRows = false;
            this.PositionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PositionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PositionDGV.Location = new System.Drawing.Point(6, 41);
            this.PositionDGV.MultiSelect = false;
            this.PositionDGV.Name = "PositionDGV";
            this.PositionDGV.RowHeadersVisible = false;
            this.PositionDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PositionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PositionDGV.Size = new System.Drawing.Size(1357, 399);
            this.PositionDGV.TabIndex = 0;
            this.PositionDGV.SelectionChanged += new System.EventHandler(this.PositionDGV_SelectionChanged);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.MainTC);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компании и должности";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.MainTC.ResumeLayout(false);
            this.CompanyPage.ResumeLayout(false);
            this.CompanyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrudDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDGV)).EndInit();
            this.PositionPage.ResumeLayout(false);
            this.PositionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTC;
        private System.Windows.Forms.TabPage CompanyPage;
        private System.Windows.Forms.TabPage PositionPage;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button RefreshCompanyButton;
        private System.Windows.Forms.DataGridView CrudDGV;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.RadioButton DeleteRB;
        private System.Windows.Forms.RadioButton UpdateRB;
        private System.Windows.Forms.RadioButton AddRB;
        private System.Windows.Forms.Button CrudButton;
        public System.Windows.Forms.DataGridView CompanyDGV;
        private System.Windows.Forms.Label nameColumnLabel;
        private System.Windows.Forms.DataGridView PositionDGV;
        private System.Windows.Forms.Label SearchPositionLabel;
        private System.Windows.Forms.TextBox SearchPositionTB;
        private System.Windows.Forms.Button RefreshPositionButton;
        private System.Windows.Forms.Label StatePositionLabel;
        private System.Windows.Forms.RadioButton DeletePositionRB;
        private System.Windows.Forms.RadioButton UpdatePositionRB;
        private System.Windows.Forms.RadioButton AddPositionRB;
        private System.Windows.Forms.TextBox CompanyPositionTB;
        private System.Windows.Forms.TextBox DescriptionPositionTB;
        private System.Windows.Forms.TextBox SalaryPositionTB;
        private System.Windows.Forms.TextBox NamePositionTB;
        private System.Windows.Forms.Label NamePositionLabel;
        private System.Windows.Forms.Label CompanyPositionLabel;
        private System.Windows.Forms.Label DescriptionPositionLabel;
        private System.Windows.Forms.Label SalaryPositionLabel;
        private System.Windows.Forms.Button CrudPositionButton;
        private System.Windows.Forms.ComboBox CompanyNameCB;
    }
}