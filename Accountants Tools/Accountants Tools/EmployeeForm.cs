using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Accountants_Tools.entity_framework;

namespace Accountants_Tools
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        Dictionary<string, Point> locationRB;
        string[] labelText;

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            #region Заполнение массивов данными о элементах формы, подписка на нужные события

            locationRB = new Dictionary<string, Point>();
            locationRB.Add("right", new Point(AddEmployeeRB.Location.X, AddEmployeeRB.Location.Y));
            locationRB.Add("left", new Point(UpdateEmployeeRB.Location.X, UpdateEmployeeRB.Location.Y));
            locationRB.Add("middle", new Point(DeleteEmployeeRB.Location.X, DeleteEmployeeRB.Location.Y));

            labelText = new string[3] 
            { 
                "работника в базу данных, заполните приведенные ниже поля", 
                "данных о выбранном работнике, отредактируйте приведенные ниже поля", 
                "выбранного работника из базы данных" 
            };

            AddEmployeeRB.CheckedChanged += new System.EventHandler(RB_CheckedChanged);
            UpdateEmployeeRB.CheckedChanged += new System.EventHandler(RB_CheckedChanged);
            DeleteEmployeeRB.CheckedChanged += new System.EventHandler(RB_CheckedChanged);

            #endregion

            #region настройка сетки должностей

            ServiceClass.UploadPositionsDataShortInDGV(ref PositionDGV);
            PositionDGV.Columns[0].Width = 40;
            PositionDGV.Columns[1].Width = 225;
            PositionDGV.Columns[2].Width = 105;
            PositionDGV.Columns[3].Width = 180;

            #endregion

            #region настройка сетки работников

            ServiceClass.UploadEmployeeDataInDGV(ref EmployeeDGV);
            ServiceClass.RemoveUnderlinesInColumns(ref EmployeeDGV);

            EmployeeDGV.Columns[0].Width = 40;
            EmployeeDGV.Columns[1].Width = 300;
            EmployeeDGV.Columns[2].Width = 400;
            EmployeeDGV.Columns[3].Width = 150;
            EmployeeDGV.Columns[4].Width = 350;
            EmployeeDGV.Columns[5].Width = 450;
            EmployeeDGV.Columns[6].Width = 150;
            #endregion

            DateBirthDTP.MaxDate = DateTime.Now.AddYears(-14);// трудоустройство с 14 лет
        }

        private void AddEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            if(AddEmployeeRB.Checked)
            {
                PositionDGV.Enabled = true; RefreshPositionButton.Enabled = true; SearchPositionTB.Enabled = true;
            }
        }

        private void UpdateEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateEmployeeRB.Checked || DeleteEmployeeRB.Checked)
            {
                if (EmployeeDGV.SelectedRows.Count > 0)
                {
                    SelectedEmployeeData();
                    PositionDGV.Enabled = false; RefreshPositionButton.Enabled = false; SearchPositionTB.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Не выбран работник!");
                    AddEmployeeRB.Checked = true;
                }
            }
        }

        private void DeleteEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            if(DeleteEmployeeRB.Checked)
            {
                UpdateEmployeeRB_CheckedChanged(null, null);
            }
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddEmployeeRB.Checked)
            {
                AddEmployeeRB.Location = locationRB["right"];
                UpdateEmployeeRB.Location = locationRB["left"];
                DeleteEmployeeRB.Location = locationRB["middle"];

                StateEmployeeLabel.Text = labelText[0];
                CrudEmployeeButton.Text = "Добавить";
            }
            else if (UpdateEmployeeRB.Checked)
            {
                UpdateEmployeeRB.Location = locationRB["right"];
                DeleteEmployeeRB.Location = locationRB["left"];
                AddEmployeeRB.Location = new Point(locationRB["middle"].X - 25, locationRB["middle"].Y);

                StateEmployeeLabel.Text = labelText[1];
                CrudEmployeeButton.Text = "Обновить";
            }
            else if (DeleteEmployeeRB.Checked)
            {
                DeleteEmployeeRB.Location = new Point(locationRB["right"].X + 25, locationRB["right"].Y);
                AddEmployeeRB.Location = locationRB["left"];
                UpdateEmployeeRB.Location = new Point(locationRB["middle"].X - 3, locationRB["middle"].Y);

                StateEmployeeLabel.Text = labelText[2];
                CrudEmployeeButton.Text = "Удалить";
            }
        }

        private void FullNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FullName_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = ServiceClass.RemoveAllExceptLetters(tb.Text);

            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.ToLower();
                char[] array = tb.Text.ToArray();
                array[0] = char.ToUpper(array[0]);
                tb.Text = new string(array);
            }

            tb.Select(0, 0);
        }

        private void PasportDetailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PasportDetailTB.Text.Length < 4 || PasportDetailTB.Text.Length >= 5)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void PasportDetailTB_Leave(object sender, EventArgs e)
        {
            if(PasportDetailTB.Text.Length != 11)
            {
                PasportDetailTB.Text = "";
            }

            PasportDetailTB.Select(0, 0);
        }

        private void CountryBirthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void CountryBirthTB_Leave(object sender, EventArgs e)
        {
            CountryBirthTB.Text = ServiceClass.RemoveSpaces(CountryBirthTB.Text);
            CountryBirthTB.Select(0, 0);
        }

        private void ResidencyEmployeeTB_Leave(object sender, EventArgs e)
        {
            ResidencyEmployeeTB.Text = ServiceClass.RemoveSpaces(ResidencyEmployeeTB.Text);
            ResidencyEmployeeTB.Select(0, 0);
        }

        private void PhoneNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            
            if(PhoneNumberTB.Text.Length == 0 && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;
                PhoneNumberTB.Text = "+7" + e.KeyChar.ToString();
                PhoneNumberTB.SelectionStart = PhoneNumberTB.Text.Length;
            }

            if(PhoneNumberTB.Text.Length == 3 && e.KeyChar == (char) Keys.Back && PhoneNumberTB.SelectionStart >= 3)
            {
                PhoneNumberTB.Text = "";
                return;
            }

            if (PhoneNumberTB.Text.Length >=3 && PhoneNumberTB.SelectionStart <= 2)
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTB_Leave(object sender, EventArgs e)
        {
            Regex example = new Regex("[+7][0-9]{11}", RegexOptions.Compiled);
            MatchCollection matchs = example.Matches(PhoneNumberTB.Text);

            if(matchs.Count < 1)
            {
                PhoneNumberTB.Text = "";
            }
        }

        private void EmailEmployeeTB_Leave(object sender, EventArgs e)
        {
            try
            {
                MailAddress email = new MailAddress(EmailEmployeeTB.Text);
            }
            catch
            {
                EmailEmployeeTB.Text = "";
            }
        }

        private void RefreshPositionButton_Click(object sender, EventArgs e)
        {
            ServiceClass.UploadPositionsDataShortInDGV(ref PositionDGV);
            SearchPositionTB.Text = "";
        }

        private void SearchPositionTB_TextChanged(object sender, EventArgs e)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from position in context.Company_positions
                           where
                           position.id.ToString().Contains(SearchPositionTB.Text) ||
                           position.name_position.Contains(SearchPositionTB.Text) ||
                           position.salary_for_position.ToString().Contains(SearchPositionTB.Text) ||
                           position.Company.company_name.Contains(SearchPositionTB.Text) orderby position.id
                           select new
                           {
                               ID = position.id,
                               Должность = position.name_position,
                               Зарплата = position.salary_for_position,
                               Компания = position.Company.company_name
                           };

                PositionDGV.DataSource = data.ToList();
            }

            if (PositionDGV.Rows.Count < 1)
            {
                SearchPositionTB.Text = "";
            }
        }

        private void PositionDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(PositionDGV.SelectedRows.Count > 0)
            {
                if(AddEmployeeRB.Checked)
                {
                    PositionTB.Text = PositionDGV.Rows[PositionDGV.SelectedRows[0].Index].Cells[1].Value.ToString();
                    CompanyTB.Text = PositionDGV.Rows[PositionDGV.SelectedRows[0].Index].Cells[3].Value.ToString();
                }
            }
        }

        private void CrudEmployeeButton_Click(object sender, EventArgs e)
        {
            if(AddEmployeeRB.Checked || UpdateEmployeeRB.Checked)
            {
                if (LastNameTB.Text == "" || FirstNameTB.Text == "" || MiddleNameTB.Text == "" || LastNameTB.Text == "" || PasportDetailTB.Text == "" || CountryBirthTB.Text == "")
                {
                    MessageBox.Show("Не все обязательные поля заполнены!");
                    return;
                }
            }

            if(AddEmployeeRB.Checked)
            {
                string gender = "";
                if (MaleGenderRB.Checked) gender = "Мужчина"; else gender = "Женщина";

                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    var validEmployeePosition = from employee in context.Employment_contracts where 
                                        employee.Employee.details_passport == PasportDetailTB.Text && 
                                        employee.Company_positions.name_position == PositionTB.Text &&
                                        employee.Company_positions.Company.company_name == CompanyTB.Text 
                                        select employee;

                    if(validEmployeePosition.ToList().Count > 0)
                    {
                        MessageBox.Show("Данный работник уже работает на этой должности!");
                        return;
                    }

                    var validEmployee = from employee in context.Employee where 
                                        employee.details_passport == PasportDetailTB.Text && 
                                        (employee.last_name != LastNameTB.Text ||
                                        employee.first_name != FirstNameTB.Text ||
                                        employee.middle_name != MiddleNameTB.Text)
                                        select employee;

                    if(validEmployee.ToList().Count > 0)
                    {
                        MessageBox.Show("Работник с такими пасспортными данными уже существует!");
                        return;
                    }

                    #region Создание newEmployee

                    Employee newEmployee = new Employee()
                    {
                        last_name = LastNameTB.Text,
                        first_name = FirstNameTB.Text,
                        middle_name = MiddleNameTB.Text,
                        gender = gender,
                        details_passport = PasportDetailTB.Text,
                        date_of_birth = Convert.ToDateTime(DateBirthDTP.Value.ToShortDateString()),
                        country_of_birth = CountryBirthTB.Text
                    };

                    if(ResidencyEmployeeTB.Text != "") newEmployee.residency = ResidencyEmployeeTB.Text; else newEmployee.residency = "Not defined";

                    if (PhoneNumberTB.Text != "") newEmployee.number_phone = PhoneNumberTB.Text; else newEmployee.number_phone = "Not defined";

                    if (EmailEmployeeTB.Text != "") newEmployee.email = EmailEmployeeTB.Text; else newEmployee.email = "Not defined";

                    context.Employee.Add(newEmployee);

                    #endregion

                    int idNewEmployee = (int) newEmployee.id;
                    int idPosition = Convert.ToInt32(PositionDGV.Rows[PositionDGV.SelectedRows[0].Index].Cells[0].Value);

                    #region Создание Contract
                    Employment_contracts contract = new Employment_contracts()
                    {
                        date_of_conclusion = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                        id_employee = idNewEmployee,
                        id_position = idPosition
                    };

                    context.Employment_contracts.Add(contract);
                    #endregion

                    context.SaveChanges();
                }

                MessageBox.Show("Трудовой договор успешно заключен!");
                RefreshEmployeeButton_Click(null, null);
            }
            else if (UpdateEmployeeRB.Checked)
            {
                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    Employment_contracts contract = context.Employment_contracts.Find(EmployeeDGV.Rows[EmployeeDGV.SelectedRows[0].Index].Cells[0].Value);

                    var validDetailsPassport = from employee in context.Employee where employee.id == contract.id_employee select employee.details_passport;
                    string passport = validDetailsPassport.First();
                    var validEmployee = from employee in context.Employee where employee.details_passport == passport select employee;

                    foreach (Employee employee in validEmployee)
                    {
                        employee.last_name = LastNameTB.Text; employee.first_name = FirstNameTB.Text; employee.middle_name = MiddleNameTB.Text;
                        if (MaleGenderRB.Checked) employee.gender = "Мужчина"; else employee.gender = "Женщина";
                        employee.date_of_birth = DateBirthDTP.Value; employee.details_passport = PasportDetailTB.Text; employee.country_of_birth = CountryBirthTB.Text;
                        if (ResidencyEmployeeTB.Text != "") employee.residency = ResidencyEmployeeTB.Text; else employee.residency = "Not defined";
                        if (PhoneNumberTB.Text != "") employee.number_phone = PhoneNumberTB.Text; else employee.number_phone = "Not defined";
                        if (EmailEmployeeTB.Text != "") employee.email = EmailEmployeeTB.Text; else employee.email = "Not defined";
                    }

                    context.SaveChanges();
                    MessageBox.Show("Данные о работнике успешно обновлены!");
                    RefreshEmployeeButton_Click(null, null);
                }
            }
            else if (DeleteEmployeeRB.Checked)
            {
                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    if (EmployeeDGV.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value);

                        Employment_contracts deleteContract = context.Employment_contracts.Find(id);
                        context.Employment_contracts.Remove(deleteContract);

                        context.SaveChanges();
                        MessageBox.Show("Трудовой договор расторгнут!");
                        RefreshEmployeeButton_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Не выбран работник!");
                    }
                }
            }
        }

        private void RefreshEmployeeButton_Click(object sender, EventArgs e)
        {
            ServiceClass.UploadEmployeeDataInDGV(ref EmployeeDGV);
            SearchEmployeeTB.Text = "";
        }

        private void SearchEmployeeTB_TextChanged(object sender, EventArgs e)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from contract in context.Employment_contracts 
                           where contract.id.ToString().Contains(SearchEmployeeTB.Text) ||
                           contract.Employee.last_name.Contains(SearchEmployeeTB.Text) ||
                           contract.Employee.first_name.Contains(SearchEmployeeTB.Text) ||
                           contract.Employee.middle_name.Contains(SearchEmployeeTB.Text) ||
                           contract.Company_positions.name_position.Contains(SearchEmployeeTB.Text) ||
                           contract.Company_positions.Company.company_name.Contains(SearchEmployeeTB.Text) ||
                           contract.Employee.number_phone.Contains(SearchEmployeeTB.Text) ||
                           contract.Employee.email.Contains(SearchEmployeeTB.Text) ||
                           contract.date_of_conclusion.ToString().Contains(SearchEmployeeTB.Text)
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

                EmployeeDGV.DataSource = data.ToList();
            }

            if (EmployeeDGV.Rows.Count < 1)
            {
                SearchEmployeeTB.Text = "";
            }
        }

        private void EmployeeDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (UpdateEmployeeRB.Checked || DeleteEmployeeRB.Checked)
            {
                if (EmployeeDGV.SelectedRows.Count > 0)
                {
                    SelectedEmployeeData();
                }
            }
        }

        private void SelectedEmployeeData()
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                Employment_contracts contract = context.Employment_contracts.Find(EmployeeDGV.Rows[EmployeeDGV.SelectedRows[0].Index].Cells[0].Value);

                LastNameTB.Text = contract.Employee.last_name; FirstNameTB.Text = contract.Employee.first_name; MiddleNameTB.Text = contract.Employee.middle_name;

                if (contract.Employee.gender == "Мужчина") MaleGenderRB.Checked = true; else FemaleGenderRB.Checked = true;

                DateBirthDTP.Value = contract.Employee.date_of_birth; PasportDetailTB.Text = contract.Employee.details_passport; CountryBirthTB.Text = contract.Employee.country_of_birth;

                ResidencyEmployeeTB.Text = contract.Employee.residency; PhoneNumberTB.Text = contract.Employee.number_phone; EmailEmployeeTB.Text = contract.Employee.email;

                PositionTB.Text = EmployeeDGV.Rows[EmployeeDGV.SelectedRows[0].Index].Cells[2].Value.ToString();

                CompanyTB.Text = EmployeeDGV.Rows[EmployeeDGV.SelectedRows[0].Index].Cells[4].Value.ToString();
            }
        }
    }
}
