using Accountants_Tools.entity_framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountants_Tools
{
    static class ServiceClass
    {
        public static string RemoveSpaces(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            do
            {
                sb = sb.Replace("  ", " ");
            }
            while (sb.ToString().Contains("  "));

            if (sb.Length > 0)
            {
                if (sb[0].ToString() == " ")
                    sb.Remove(0, 1);
            }

            if (sb.Length > 0)
            {
                if (sb[sb.Length - 1].ToString() == " ")
                    sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }

        public static string RemoveAllSpaces(string str)
        {
            do
            {
                str = str.Replace(" ", "");
            }
            while (str.Contains(" "));

            return str;
        }

        public static string RemoveAllExceptLetters(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length); 
            foreach(char c in str)
            {
                if(char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            
            return sb.ToString();
        }

        public static List<string> SelectedData(DataGridView dgvCompany, DataGridView dgvUpdateCompany)
        {
            List<string> array = new List<string>();

            for (int i = 0; i < dgvCompany.Columns.Count - 1; i++)
            {
                if (i == 4)
                {
                    bool result = DateTime.TryParse(dgvCompany.Rows[dgvCompany.SelectedRows[0].Index].Cells[i + 1].Value.ToString(), out DateTime dt);

                    if (result)
                        dgvUpdateCompany.Rows[0].Cells[i].Value = dt.ToShortDateString();
                    else
                        dgvUpdateCompany.Rows[0].Cells[i].Value = "";
                }
                else
                {
                    dgvUpdateCompany.Rows[0].Cells[i].Value = dgvCompany.Rows[dgvCompany.SelectedRows[0].Index].Cells[i + 1].Value.ToString();
                }

                array.Add(dgvUpdateCompany.Rows[0].Cells[i].Value.ToString());
            }

            return array;
        }

        public static void SelectedDataTB(ref DataGridView dgv , ref TextBox[] tb)
        {
            for (int i = 0; i < tb.Count(); i++)
            {
                tb[i].Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[i + 1].Value.ToString();
            }
        }

        public static void UploadCompanyInDGV(ref DataGridView dgv)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from company in context.Company orderby company.id
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

                dgv.DataSource = data.ToList();
            }
        }

        public static void UploadPositionsInDGV(ref DataGridView dgv)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from position in context.Company_positions orderby position.id
                           select new
                           {
                               ID = position.id,
                               Должность = position.name_position,
                               Зарплата = position.salary_for_position,
                               Описание_должности = position.description_position,
                               Компания = position.Company.company_name
                           };

                dgv.DataSource = data.ToList();
            }
        }

        public static void UploadPositionsShortInDGV(ref DataGridView dgv)
        {
            using(EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from position in context.Company_positions orderby position.id
                           select new
                           {
                               ID = position.id,
                               Должность = position.name_position,
                               Зарплата = position.salary_for_position,
                               Компания = position.Company.company_name
                           };

                dgv.DataSource = data.ToList();
            }
        }

        public static void UploadEmployeeInDGV(ref DataGridView dgv)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from contract in context.Employment_contracts
                           orderby contract.id
                           select new
                           {
                               ID = contract.id,
                               Имя_сотрудника = contract.Employee.last_name + " " + contract.Employee.first_name + " " + contract.Employee.middle_name,
                               Должность = contract.Company_positions.name_position,
                               Зарплата = contract.Company_positions.salary_for_position,
                               Компания = contract.Company_positions.Company.company_name,
                               Контактные_данные = contract.Employee.number_phone + ", " + contract.Employee.email,
                               Нанят = contract.date_of_conclusion
                           };

                dgv.DataSource = data.ToList();
            }
        }
    }
}
