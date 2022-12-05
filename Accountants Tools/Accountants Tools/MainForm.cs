using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountants_Tools.entity_framework;

namespace Accountants_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CompanyFormButton_Click(object sender, EventArgs e)
        {
            CompanyForm form = new CompanyForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
