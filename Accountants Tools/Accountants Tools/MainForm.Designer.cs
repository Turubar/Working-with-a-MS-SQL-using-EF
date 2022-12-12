
namespace Accountants_Tools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeFormButton = new System.Windows.Forms.Button();
            this.CompanyFormButton = new System.Windows.Forms.Button();
            this.AccountingFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeFormButton
            // 
            this.EmployeeFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.EmployeeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeFormButton.Location = new System.Drawing.Point(125, 193);
            this.EmployeeFormButton.Name = "EmployeeFormButton";
            this.EmployeeFormButton.Size = new System.Drawing.Size(250, 60);
            this.EmployeeFormButton.TabIndex = 0;
            this.EmployeeFormButton.Text = "Сотрудники";
            this.EmployeeFormButton.UseVisualStyleBackColor = true;
            this.EmployeeFormButton.Click += new System.EventHandler(this.EmployeeFormButton_Click);
            // 
            // CompanyFormButton
            // 
            this.CompanyFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompanyFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.CompanyFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyFormButton.Location = new System.Drawing.Point(125, 94);
            this.CompanyFormButton.Name = "CompanyFormButton";
            this.CompanyFormButton.Size = new System.Drawing.Size(250, 60);
            this.CompanyFormButton.TabIndex = 0;
            this.CompanyFormButton.Text = "Компании и должности";
            this.CompanyFormButton.UseVisualStyleBackColor = true;
            this.CompanyFormButton.Click += new System.EventHandler(this.CompanyFormButton_Click);
            // 
            // AccountingFormButton
            // 
            this.AccountingFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountingFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.AccountingFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountingFormButton.Location = new System.Drawing.Point(125, 293);
            this.AccountingFormButton.Name = "AccountingFormButton";
            this.AccountingFormButton.Size = new System.Drawing.Size(250, 60);
            this.AccountingFormButton.TabIndex = 0;
            this.AccountingFormButton.Text = "Бухгалтерский учет";
            this.AccountingFormButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.AccountingFormButton);
            this.Controls.Add(this.CompanyFormButton);
            this.Controls.Add(this.EmployeeFormButton);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный бухгалтер";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeFormButton;
        private System.Windows.Forms.Button CompanyFormButton;
        private System.Windows.Forms.Button AccountingFormButton;
    }
}

