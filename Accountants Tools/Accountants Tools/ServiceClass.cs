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
    }
}
