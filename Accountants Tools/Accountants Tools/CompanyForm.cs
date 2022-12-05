using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountants_Tools.entity_framework;

namespace Accountants_Tools
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from company in context.Company
                           select new
                           {
                               ID = company.id,
                               Название_компании = company.company_name,
                               Фамилия_владельца = company.last_name_owner,
                               Имя_владельца = company.first_name_owner,
                               Отчество_владельца = company.middle_name_owner,
                               Дата_создания_компании = company.date_of_creation,
                               Описание_компании = company.company_description
                           };

                CompanyDGV.DataSource = data.ToList();
            }

            #region заменить все символы '_' в заголовках столбцов
            for (int i = 0; i < CompanyDGV.Columns.Count; i++)
            {
                CompanyDGV.Columns[i].HeaderText = CompanyDGV.Columns[i].HeaderText.Replace('_', ' ');
            }
            #endregion

            #region вручную задать ширину столбцам
            CompanyDGV.Columns[0].Width = 50;
            CompanyDGV.Columns[1].Width = 200;
            CompanyDGV.Columns[2].Width = 200;
            CompanyDGV.Columns[3].Width = 160;
            CompanyDGV.Columns[4].Width = 200;
            CompanyDGV.Columns[5].Width = 240;
            #endregion
        }

        private void MainTC_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }
    }
}
