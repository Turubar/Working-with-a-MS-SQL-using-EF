
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
            this.CompanyDGV = new System.Windows.Forms.DataGridView();
            this.PositionPage = new System.Windows.Forms.TabPage();
            this.MainTC.SuspendLayout();
            this.CompanyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDGV)).BeginInit();
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
            this.MainTC.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainTC_Selecting);
            // 
            // CompanyPage
            // 
            this.CompanyPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyPage.Controls.Add(this.CompanyDGV);
            this.CompanyPage.Location = new System.Drawing.Point(4, 30);
            this.CompanyPage.Name = "CompanyPage";
            this.CompanyPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompanyPage.Size = new System.Drawing.Size(1371, 620);
            this.CompanyPage.TabIndex = 0;
            this.CompanyPage.Text = "Компании";
            this.CompanyPage.UseVisualStyleBackColor = true;
            // 
            // CompanyDGV
            // 
            this.CompanyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CompanyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDGV.Location = new System.Drawing.Point(6, 6);
            this.CompanyDGV.Name = "CompanyDGV";
            this.CompanyDGV.RowHeadersVisible = false;
            this.CompanyDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompanyDGV.Size = new System.Drawing.Size(1357, 396);
            this.CompanyDGV.TabIndex = 0;
            // 
            // PositionPage
            // 
            this.PositionPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionPage.Location = new System.Drawing.Point(4, 30);
            this.PositionPage.Name = "PositionPage";
            this.PositionPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionPage.Size = new System.Drawing.Size(1371, 620);
            this.PositionPage.TabIndex = 1;
            this.PositionPage.Text = "Должности";
            this.PositionPage.UseVisualStyleBackColor = true;
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
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компании и должности";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.MainTC.ResumeLayout(false);
            this.CompanyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTC;
        private System.Windows.Forms.TabPage CompanyPage;
        private System.Windows.Forms.TabPage PositionPage;
        private System.Windows.Forms.DataGridView CompanyDGV;
    }
}