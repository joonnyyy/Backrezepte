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
        public static bool verwaltung = true;
        public static string connectionstring;
        private string dgv1item = "rezepte";
        public mainform()
        {
            InitializeComponent();

        }

        static bool IsNumeric(object Expression)
        {
            // Variable to collect the Return value of the TryParse method.
            bool isNum;
            // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
            double retNum;
            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes,
            // True is returned. If it does not, False is returned.
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void mainform_Load(object sender, EventArgs e)
        {
     
            loginform lf = new loginform();
            lf.ShowDialog();
            removealltp();
            //verwaltung = false;
            if (verwaltung == false) {
                btn_lager.Enabled = false;
                btn_lager.Visible = false;
                btn_rezepte.Enabled = false;
                btn_rezepte.Visible = false;
                btn_lieferanten.Enabled = false;
                btn_lieferanten.Visible = false;
                tabControl1.TabPages.Add(tabPagebk);
                showrzepte();
            }
        }

        private void removealltp()
        {
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tp);
            }
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

        public static void runcmd(string command)
        {
            try
            {
                using (SqlConnection openCon = new SqlConnection(connectionstring))
                {
                    //string saveStaff = "INSERT into tbl_staff (staffName,userID,idDepartment) VALUES (@staffName,@userID,@idDepartment)";

                    using (SqlCommand cmd = new SqlCommand(command))
                    {
                        cmd.Connection = openCon;
                        //querySaveStaff.Parameters.Add("@staffName", SqlDbType.VarChar, 30).Value = name;
                        openCon.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }catch (Exception e)
            {
                MessageBox.Show("Fehler beim Ausführen des Befehles: \n" + e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fill("select * from "+ dgv1item + " where name like '%" + textBox1.Text + "%'",dataGridView1);
        }

        private void btn_rezepte_Click(object sender, EventArgs e)
        {
            showrzepte();
            removealltp();
            tabControl1.TabPages.Add(tabPage_rezepte);
        }

        private void showrzepte()
        {
            dgv1item = "rezepte";
            fill("select * from " + dgv1item, dataGridView1);
        }
        
        private void btn_lager_Click(object sender, EventArgs e)
        {
            dgv1item = "zutaten";
            fill("select * from " + dgv1item , dataGridView1);
            removealltp();
            tabControl1.TabPages.Add(tabPage_lager);
        }

        private void btn_lieferanten_Click(object sender, EventArgs e)
        {
            dgv1item = "lieferanten";
            fill("select * from " + dgv1item, dataGridView1);
            removealltp();
            tabControl1.TabPages.Add(tabPage_lieferanten);
        }

        private void btn_test_1_Click(object sender, EventArgs e)
        {
            dgv1item = "rezepte3";
            fill("select * from " + dgv1item, dataGridView1);
            //    runcmd("insert into rezepte (rnr,name) values (5,'test2')");
        }

        private void btn_rezepthinzu_Click(object sender, EventArgs e)
        {
            
            fill("select * from rezepte order by rnr desc", dataGridView2);
            try
            {
                string nr = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie eine gültige Nummer für das zu erstellende Rezept ein:");
                if (nr != "" && IsNumeric(nr) && (Convert.ToInt32(nr) >= 0))
                {
                    string name = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie einen gültigen Namen für das zu erstellende Rezept ein:");
                    if (nr != "" && name != "")
                    {
                        runcmd("insert into rezepte (rnr,name) values (" + nr + ",'" + name + "')");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler : \n" + ex.Message);
            }
           

        }

        private void btn_rezeptentf_Click(object sender, EventArgs e)
        {
            string nr = dataGridView1.SelectedCells[0].Value.ToString();
                if (MessageBox.Show("Sind sie sicher,dass sie das Rezept und alle davon abhängigen Informationen löschen wollen?","",MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    runcmd("BEGIN TRAN \r\ndelete from bestehtaus where rnr = " + nr + "\r\ndelete from rezepte where rnr = " + nr + "\r\n COMMIT TRAN");
                    //runcmd("delete from rezepte where rnr = " + nr);
                }
         }

        private void btn_zutatenfurrezept_Click(object sender, EventArgs e)
        {
            showzutaten();
        }

        private void showzutaten()
        {
            string nr = dataGridView1.SelectedCells[0].Value.ToString();
            fill("select zutaten.znr,zutaten.name,bestehtaus.menge100 as 'Menge pro 100 Stk.' from zutaten join bestehtaus on zutaten.znr = bestehtaus.znr where bestehtaus.rnr = " + nr, dataGridView2);

        }

        private void btn_b_rezepteanz_Click(object sender, EventArgs e)
        {
            showrzepte();
        }

        private void btn_b_showzutaten_Click(object sender, EventArgs e)
        {
            showzutaten();
        }

        private void btn_b_mengebrechnen_Click(object sender, EventArgs e)
        {
            try
            {
                int stk = Convert.ToInt32( Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die gewünschte Anzahl an Stk. ein:"));
                fill("",dataGridView2);
            }
         catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
