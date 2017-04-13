using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;

namespace DB_Connection_Backrezepte
{
    public partial class mainform : Form
    {
        public static string connectionstring;
        private string dgv1item = "rezepte";
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

            loginform lf = new loginform();
            lf.ShowDialog();

        }

        private void fill(string command,DataGridView dgv)
        {
            try
            {
                BindingSource bindingSource1 = new BindingSource();
                dgv.DataSource = bindingSource1;


                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter;
                dataAdapter = new SqlDataAdapter(command, connectionstring);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

               dgv.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }catch(Exception e)
            {
                MessageBox.Show("Fehler beim Abruf der Daten: \n" + e.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fill("select * from "+ dgv1item + " where name like '%" + textBox1.Text + "%'",dataGridView1);
        }

        private void btn_rezepte_Click(object sender, EventArgs e)
        {
            dgv1item = "rezepte";
            fill("select * from " + dgv1item, dataGridView1);
        }

        private void btn_lager_Click(object sender, EventArgs e)
        {
            dgv1item = "zutaten";
            fill("select * from " + dgv1item , dataGridView1);
        }

        private void btn_lieferanten_Click(object sender, EventArgs e)
        {
            dgv1item = "lieferanten";
            fill("select * from " + dgv1item, dataGridView1);
        }
    }
}
