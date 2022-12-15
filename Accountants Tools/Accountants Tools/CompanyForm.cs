using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        List<string> updateDataCompany = new List<string>();
        TextBox[] dataTB;
        string oldNamePosition;

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            //page Company
            ServiceClass.UploadCompanyInDGV(ref CompanyDGV);

            #region заменить все символы '_' в заголовках столбцов
            for (int i = 0; i < CompanyDGV.Columns.Count; i++)
            {
                if (i != 0)
                {
                    CrudDGV.Columns.Add((DataGridViewColumn)CompanyDGV.Columns[i].Clone());
                    CrudDGV.Columns[i-1].ReadOnly = false;

                    CrudDGV.Columns[i-1].HeaderText = CompanyDGV.Columns[i].HeaderText.Replace('_', ' ');
                    CrudDGV.Columns[i-1].Resizable = DataGridViewTriState.False;
                }

                CompanyDGV.Columns[i].HeaderText = CompanyDGV.Columns[i].HeaderText.Replace('_', ' ');
                CompanyDGV.Columns[i].Resizable = DataGridViewTriState.False;
            }
            #endregion

            #region вручную задать ширину столбцам
            CompanyDGV.Columns[0].Width = 50;
            CompanyDGV.Columns[1].Width = 200;
            CompanyDGV.Columns[2].Width = 200;
            CompanyDGV.Columns[3].Width = 160;
            CompanyDGV.Columns[4].Width = 200;
            CompanyDGV.Columns[5].Width = 240;
            CompanyDGV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CrudDGV.Columns[0].Width = 200;
            CrudDGV.Columns[1].Width = 200;
            CrudDGV.Columns[2].Width = 160;
            CrudDGV.Columns[3].Width = 200;
            CrudDGV.Columns[4].Width = 240;
            CrudDGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            #region ограничение на ввод кол-ва символов в столбцы
            (CrudDGV.Columns[0] as DataGridViewTextBoxColumn).MaxInputLength = 100;
            (CrudDGV.Columns[1] as DataGridViewTextBoxColumn).MaxInputLength = 100;
            (CrudDGV.Columns[2] as DataGridViewTextBoxColumn).MaxInputLength = 100;
            (CrudDGV.Columns[3] as DataGridViewTextBoxColumn).MaxInputLength = 100;
            (CrudDGV.Columns[4] as DataGridViewTextBoxColumn).MaxInputLength = 10;
            #endregion 

            CrudDGV.Rows[0].Cells[5].Value = "Not defined";

            //page Positions
            
            ServiceClass.UploadPositionsInDGV(ref PositionDGV);

            #region заменить все символы '_' в заголовках столбцов
            for (int i = 0; i < PositionDGV.Columns.Count; i++)
            {
                PositionDGV.Columns[i].HeaderText = PositionDGV.Columns[i].HeaderText.Replace('_', ' ');
                PositionDGV.Columns[i].Resizable = DataGridViewTriState.False;
            }
            #endregion

            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from company in context.Company where company.company_name.Contains(CompanyPositionTB.Text) select company.company_name;
                CompanyNameCB.Items.AddRange(data.ToArray());
            }
            dataTB = new TextBox[4] { NamePositionTB, SalaryPositionTB, DescriptionPositionTB, CompanyPositionTB };
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            ServiceClass.UploadCompanyInDGV(ref CompanyDGV);
            SearchTB.Text = "";
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from company in context.Company where 
                           company.company_name.Contains(SearchTB.Text) || 
                           company.last_name_owner.Contains(SearchTB.Text) ||
                           company.first_name_owner.Contains(SearchTB.Text) ||
                           company.middle_name_owner.Contains(SearchTB.Text) ||
                           company.date_of_creation.ToString().Contains(SearchTB.Text) ||
                           company.company_description.Contains(SearchTB.Text) 
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

                if (UpdateRB.Checked || DeleteRB.Checked)
                {
                    if (CompanyDGV.Rows.Count < 1)
                    {
                        SearchTB.Text = "";
                    }
                }
            }
        }

        private void AddRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRB.Checked)
            {
                StateLabel.Text = "Для добавления компании заполните поля";
                CrudButton.Text = "Добавить";

                CrudDGV.Enabled = true;
                CrudDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void UpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateRB.Checked)
            {
                StateLabel.Text = "Для обновления данных компании выберите нужную компанию и отредактируйте ее поля";
                CrudButton.Text = "Обновить";

                CrudDGV.Enabled = true;
                CrudDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;

                if (CompanyDGV.SelectedRows.Count > 0)
                {
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }
                else
                {
                    SearchTB.Text = "";
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }

            }
        }

        private void DeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteRB.Checked)
            {
                StateLabel.Text = "Для удаления компании выберите ее из списка";
                CrudButton.Text = "Удалить";

                if (CompanyDGV.SelectedRows.Count > 0)
                {
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }
                else
                {
                    SearchTB.Text = "";
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }

                CrudDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                CrudDGV.Enabled = false;
            }
        }

        private void CrudButton_Click(object sender, EventArgs e)
        {
            if(AddRB.Checked)
            {
                for(int i = 0; i < CrudDGV.Rows[0].Cells.Count - 1; i++)
                {
                    if(CrudDGV.Rows[0].Cells[i].Value == null)
                    {
                        MessageBox.Show("Не все поля заполнены!");
                        return;
                    }    
                }

                bool date = DateTime.TryParse(CrudDGV.Rows[0].Cells[4].Value.ToString(), out DateTime dt);
                if(!date)
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }

                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    string newCompanyName = CrudDGV.Rows[0].Cells[0].Value.ToString();
                    var data = from company in context.Company where company.company_name == newCompanyName select company;

                    if(data.ToList().Count > 0)
                    {
                        MessageBox.Show("Такая компания уже существует, попробуйте другое название!");
                        return;
                    }

                    Company newCompany = new Company
                    {
                        company_name = CrudDGV.Rows[0].Cells[0].Value.ToString(),
                        last_name_owner = CrudDGV.Rows[0].Cells[1].Value.ToString(),
                        first_name_owner = CrudDGV.Rows[0].Cells[2].Value.ToString(),
                        middle_name_owner = CrudDGV.Rows[0].Cells[3].Value.ToString(),
                        date_of_creation = Convert.ToDateTime(CrudDGV.Rows[0].Cells[4].Value.ToString()),
                        company_description = CrudDGV.Rows[0].Cells[5].Value.ToString()
                    };

                    context.Company.Add(newCompany);
                    context.SaveChanges();

                    MessageBox.Show("Компания добавлена!");
                    CrudDGV.Rows.Remove(CrudDGV.Rows[0]);

                    RefreshDataButton_Click(null, null);
                }
            }
            else if(UpdateRB.Checked)
            {
                for (int i = 0; i < CrudDGV.Rows[0].Cells.Count - 1; i++)
                {
                    if (CrudDGV.Rows[0].Cells[i].Value == null)
                    {
                        MessageBox.Show("Не все поля заполнены!");
                        return;
                    }
                }

                bool date = DateTime.TryParse(CrudDGV.Rows[0].Cells[4].Value.ToString(), out DateTime dt);
                if (!date)
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }

                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    string newCompanyName = CrudDGV.Rows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(CompanyDGV.SelectedRows[0].Cells[0].Value);

                    var data = from company in context.Company where company.company_name == newCompanyName && company.id != id select company;

                    if (data.ToList().Count > 0)
                    {
                        MessageBox.Show("Такая компания уже существует, попробуйте другое название!");
                        return;
                    }

                    Company updateCompany = context.Company.Find(id);

                    updateCompany.id = id;
                    updateCompany.company_name = CrudDGV.Rows[0].Cells[0].Value.ToString();
                    updateCompany.last_name_owner = CrudDGV.Rows[0].Cells[1].Value.ToString();
                    updateCompany.first_name_owner = CrudDGV.Rows[0].Cells[2].Value.ToString();
                    updateCompany.middle_name_owner = CrudDGV.Rows[0].Cells[3].Value.ToString();
                    updateCompany.date_of_creation = Convert.ToDateTime(CrudDGV.Rows[0].Cells[4].Value.ToString());
                    updateCompany.company_description = CrudDGV.Rows[0].Cells[5].Value.ToString();

                    context.SaveChanges();

                    MessageBox.Show("Данные компании обновлены!");
                    RefreshDataButton_Click(null, null);
                }
            }
            else if(DeleteRB.Checked)
            {
                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    if (CompanyDGV.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(CompanyDGV.SelectedRows[0].Cells[0].Value);

                        Company deleteCompany = context.Company.Find(id);
                        context.Company.Remove(deleteCompany);

                        context.SaveChanges();

                        MessageBox.Show("Выбранная компания удалена!");
                        RefreshDataButton_Click(null, null);
                    }
                }
            }
        }

        private void CrudDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CrudDGV.CurrentCell.ColumnIndex != 4 && CrudDGV.CurrentCell.Value != null)
            {
                CrudDGV.CurrentCell.Value = ServiceClass.RemoveSpaces(CrudDGV.CurrentCell.Value.ToString());
            }

            if (CrudDGV.CurrentCell.ColumnIndex == 4 && CrudDGV.CurrentCell.Value != null)
            {
                bool result = DateTime.TryParse(CrudDGV.CurrentCell.Value.ToString(), out DateTime dt);

                if (result)
                    CrudDGV.CurrentCell.Value = dt.ToShortDateString();
                else
                    CrudDGV.CurrentCell.Value = "";
            }

            if (CrudDGV.CurrentCell.ColumnIndex == 5 && CrudDGV.Rows[0].Cells[5].Value == null)
            {
                CrudDGV.Rows[0].Cells[5].Value = "Not defined";
            }

            if(UpdateRB.Checked)
            {
                if (CrudDGV.CurrentCell.Value != null)
                    updateDataCompany[CrudDGV.CurrentCell.ColumnIndex] = CrudDGV.CurrentCell.Value.ToString();
                else
                    updateDataCompany[CrudDGV.CurrentCell.ColumnIndex] = "";
            }
        }

        private void CrudDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CrudDGV.AllowUserToAddRows = true;
        }

        private void CrudDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            CrudDGV.AllowUserToAddRows = false;
        }

        private void CrudDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(CrudDGV.RowCount == 0)
            {
                CrudDGV.AllowUserToAddRows = true;
                CrudDGV.Rows[0].Cells[5].Value = "Not defined";
            }

            if(UpdateRB.Checked)
            {
                for(int i = 0; i < CrudDGV.Columns.Count; i++)
                {
                    CrudDGV.Rows[0].Cells[i].Value = updateDataCompany[i];
                }
            }
        }

        private void CompanyDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (UpdateRB.Checked)
            {
                if (CompanyDGV.SelectedRows.Count > 0)
                {
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }
            }
            else if (DeleteRB.Checked)
            {
                CrudDGV.Enabled = true;

                if (CompanyDGV.SelectedRows.Count > 0)
                {
                    updateDataCompany = ServiceClass.SelectedData(CompanyDGV, CrudDGV);
                }

                CrudDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                CrudDGV.Enabled = false;
            }
        }

        private void MainTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region вручную задать ширину столбцам
            PositionDGV.Columns[0].Width = 30;
            PositionDGV.Columns[1].Width = 275;
            PositionDGV.Columns[2].Width = 75;
            PositionDGV.Columns[3].Width = 350;
            PositionDGV.Columns[4].Width = 300;
            //PositionDGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //PositionDGV.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from company in context.Company where company.company_name.Contains(CompanyPositionTB.Text) select company.company_name;
                CompanyNameCB.Items.AddRange(data.ToArray());
            }
        }

        private void RefreshPositionButton_Click(object sender, EventArgs e)
        {
            ServiceClass.UploadPositionsInDGV(ref PositionDGV);
            SearchPositionTB.Text = "";
        }

        private void SearchPositionTB_TextChanged(object sender, EventArgs e)
        {
            using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
            {
                var data = from position in context.Company_positions
                           where
                           position.name_position.Contains(SearchPositionTB.Text) ||
                           position.salary_for_position.ToString().Contains(SearchPositionTB.Text) ||
                           position.description_position.Contains(SearchPositionTB.Text) ||
                           position.Company.company_name.Contains(SearchPositionTB.Text)
                           select new
                           {
                               ID = position.id,
                               Должность = position.name_position,
                               Зарплата = position.salary_for_position,
                               Описание_должности = position.description_position,
                               Компания = position.Company.company_name
                           };

                PositionDGV.DataSource = data.ToList();
            }

            if (UpdatePositionRB.Checked || DeletePositionRB.Checked)
            {
                if (PositionDGV.Rows.Count < 1)
                {
                    SearchPositionTB.Text = "";
                }
            }
        }

        private void AddPositionRB_CheckedChanged(object sender, EventArgs e)
        {
            if(AddPositionRB.Checked)
            {
                StatePositionLabel.Text = "Для добавления должности заполните поля";
                CrudPositionButton.Text = "Добавить";

                CompanyNameCB.Enabled = true;
                CompanyPositionTB.Enabled = true;
            }
        }

        private void UpdatePositionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatePositionRB.Checked)
            {
                StatePositionLabel.Text = "Для обновления данных должности выберите нужную должность и отредактируйте ее поля";
                CrudPositionButton.Text = "Обновить";

                CompanyNameCB.Enabled = false;
                CompanyPositionTB.Enabled = false;

                if(PositionDGV.SelectedRows.Count > 0)
                {
                    ServiceClass.SelectedDataTB(ref PositionDGV, ref dataTB);
                    oldNamePosition = NamePositionTB.Text;
                }
                else
                {
                    SearchPositionTB.Text = "";
                    ServiceClass.SelectedDataTB(ref PositionDGV, ref dataTB);
                    oldNamePosition = NamePositionTB.Text;
                }
            }
        }

        private void DeletePositionRB_CheckedChanged(object sender, EventArgs e)
        {
            if(DeletePositionRB.Checked)
            {
                StatePositionLabel.Text = "Для удаления должности выберите ее";
                CrudPositionButton.Text = "Удалить";

                CompanyNameCB.Enabled = false;
                CompanyPositionTB.Enabled = false;

                if (PositionDGV.SelectedRows.Count > 0)
                {
                    ServiceClass.SelectedDataTB(ref PositionDGV, ref dataTB);
                    oldNamePosition = NamePositionTB.Text;
                }
                else
                {
                    SearchPositionTB.Text = "";
                    ServiceClass.SelectedDataTB(ref PositionDGV, ref dataTB);
                }
            }
        }

        private void SalaryPositionTB_TextChanged(object sender, EventArgs e)
        {
            foreach(char c in SalaryPositionTB.Text)
            {
                if(!char.IsDigit(c) && c != ',')
                {
                    SalaryPositionTB.Text = SalaryPositionTB.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void SalaryPositionTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;
            }

            if(SalaryPositionTB.Text.Contains(',') && e.KeyChar == ',')
            {
                e.Handled = true;
            }

            if(!SalaryPositionTB.Text.Contains(',') && SalaryPositionTB.Text.Length == 8)
            {
                if (e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }

            if (SalaryPositionTB.Text.Contains(','))
            {
                int indexComma = SalaryPositionTB.Text.IndexOf(',');

                if(SalaryPositionTB.Text.Length - (indexComma + 1) == 2)
                {
                    if(e.KeyChar != (char) Keys.Back && SalaryPositionTB.SelectionStart > indexComma)
                    {
                        e.Handled = true;
                    }
                }
            }

            if(e.KeyChar == ',' && (SalaryPositionTB.SelectionStart + 1 <= SalaryPositionTB.Text.Length - 2))
            {
                e.Handled = true;
            }
        }

        private void CompanyNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CompanyNameCB.SelectedIndex >= 0)
            {
                CompanyPositionTB.Text = CompanyNameCB.SelectedItem.ToString();
                CrudPositionButton.Focus();
            }
        }

        private void CrudPositionButton_Click(object sender, EventArgs e)
        {
            if (AddPositionRB.Checked)
            {
                foreach (TextBox tb in dataTB)
                {
                    if (tb.Text == "")
                    {
                        MessageBox.Show("Не все поля заполнены!");
                        return;
                    }
                }

                bool salaryResult = decimal.TryParse(SalaryPositionTB.Text, out decimal salary);
                if (!salaryResult)
                {
                    MessageBox.Show("Поле с зарплатой заполнено неверно!");
                    return;
                }

                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    var positionRecurring = from position in context.Company_positions where (position.name_position == NamePositionTB.Text) && (position.Company.company_name == CompanyPositionTB.Text) select position;
                    if (positionRecurring.Count() > 0)
                    {
                        MessageBox.Show($"У компании [{CompanyPositionTB.Text}] уже есть должность [{NamePositionTB.Text}]");
                        return;
                    }

                    var idCompany = from company in context.Company where company.company_name == CompanyPositionTB.Text select company.id;
                    if (idCompany.Count() < 1)
                    {
                        MessageBox.Show($"Компания [{CompanyPositionTB.Text}] не существует!");
                        return;
                    }

                    Company_positions newPosition = new Company_positions
                    {
                        name_position = NamePositionTB.Text,
                        salary_for_position = salary,
                        description_position = DescriptionPositionTB.Text,
                        id_company = idCompany.First()
                    };

                    context.Company_positions.Add(newPosition);
                    context.SaveChanges();

                    MessageBox.Show($"Должность [{NamePositionTB.Text}] компании [{CompanyPositionTB.Text}] добавлена!");
                }
            }
            else if (UpdatePositionRB.Checked)
            {
                foreach (TextBox tb in dataTB)
                {
                    if (tb.Text == "")
                    {
                        MessageBox.Show("Не все поля заполнены!");
                        return;
                    }
                }

                bool salaryResult = decimal.TryParse(SalaryPositionTB.Text, out decimal salary);
                if (!salaryResult)
                {
                    MessageBox.Show("Поле с зарплатой заполнено неверно!");
                    return;
                }

                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    var positionRecurring = from position in context.Company_positions where (position.name_position == NamePositionTB.Text && position.name_position != oldNamePosition) && (position.Company.company_name == CompanyPositionTB.Text) select position;
                    if (positionRecurring.Count() > 0)
                    {
                        MessageBox.Show($"У компании [{CompanyPositionTB.Text}] уже есть должность [{NamePositionTB.Text}]");
                        return;
                    }

                    var idCompany = from company in context.Company where company.company_name == CompanyPositionTB.Text select company.id;
                    if (idCompany.Count() < 1)
                    {
                        MessageBox.Show($"Компания [{CompanyPositionTB.Text}] не существует!");
                        return;
                    }

                    Company_positions updatePosition = context.Company_positions.Find(PositionDGV.Rows[PositionDGV.SelectedRows[0].Index].Cells[0].Value);

                    updatePosition.name_position = NamePositionTB.Text;
                    updatePosition.salary_for_position = salary;
                    updatePosition.description_position = DescriptionPositionTB.Text;

                    context.SaveChanges();

                    MessageBox.Show("Данные должности обновлены!");
                }
            }
            else if (DeletePositionRB.Checked)
            {
                using (EmployeeDatabaseEntities context = new EmployeeDatabaseEntities())
                {
                    if (PositionDGV.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(PositionDGV.SelectedRows[0].Cells[0].Value);

                        Company_positions deletePosition = context.Company_positions.Find(id);
                        context.Company_positions.Remove(deletePosition);

                        context.SaveChanges();

                        MessageBox.Show("Выбранная должность удалена!");
                    }
                }
            }

            if (SearchPositionTB.Text != "")
            {
                string search = SearchPositionTB.Text;
                RefreshPositionButton_Click(null, null);
                SearchPositionTB.Text = search;
            }
            else
            {
                RefreshPositionButton_Click(null, null);
            }
        }

        private void NamePositionTB_Leave(object sender, EventArgs e)
        {
            NamePositionTB.Text = ServiceClass.RemoveSpaces(NamePositionTB.Text);
        }

        private void DescriptionPositionTB_Leave(object sender, EventArgs e)
        {
            NamePositionTB.Text = ServiceClass.RemoveSpaces(NamePositionTB.Text);
        }

        private void PositionDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(UpdatePositionRB.Checked || DeletePositionRB.Checked)
            {
                if(PositionDGV.SelectedRows.Count > 0)
                {
                    ServiceClass.SelectedDataTB(ref PositionDGV, ref dataTB);
                    oldNamePosition = NamePositionTB.Text;
                }
            }
        }

        private void CompanyPositionTB_Leave(object sender, EventArgs e)
        {
            CompanyPositionTB.Text = ServiceClass.RemoveSpaces(CompanyPositionTB.Text);
        }
    }
    
}
