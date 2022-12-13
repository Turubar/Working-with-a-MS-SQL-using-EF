using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            DateBirthDTP.MaxDate = DateTime.Now.AddYears(-14);// трудоустройство с 14 лет
        }

        private void AddEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteEmployeeRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddEmployeeRB.Checked)
            {
                AddEmployeeRB.Location = locationRB["right"];
                UpdateEmployeeRB.Location = locationRB["left"];
                DeleteEmployeeRB.Location = locationRB["middle"];

                StateEmployeeLabel.Text = labelText[0];
            }
            else if (UpdateEmployeeRB.Checked)
            {
                UpdateEmployeeRB.Location = locationRB["right"];
                DeleteEmployeeRB.Location = locationRB["left"];
                AddEmployeeRB.Location = new Point(locationRB["middle"].X - 25, locationRB["middle"].Y);

                StateEmployeeLabel.Text = labelText[1];
            }
            else if (DeleteEmployeeRB.Checked)
            {
                DeleteEmployeeRB.Location = new Point(locationRB["right"].X + 25, locationRB["right"].Y);
                AddEmployeeRB.Location = locationRB["left"];
                UpdateEmployeeRB.Location = new Point(locationRB["middle"].X - 3, locationRB["middle"].Y);

                StateEmployeeLabel.Text = labelText[2];
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
    }
}
