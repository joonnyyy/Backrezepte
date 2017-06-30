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
            btn_test_1.Visible = false;
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
                string nr = dataGridView1.SelectedCells[0].Value.ToString();
                fill("select zutaten.znr,zutaten.name,CEILING((bestehtaus.menge100  / 100) * " + stk + ")  as 'Menge pro 100 Stk.' from zutaten join bestehtaus on zutaten.znr = bestehtaus.znr where bestehtaus.rnr = " + nr, dataGridView2);
                if ((MessageBox.Show("Möchten Sie die brechneten Zutaten aus dem Lager entnemen ?","", MessageBoxButtons.YesNo) == DialogResult.Yes) && (MessageBox.Show("Sind Sie sicher, dass sie die Zutaten entnehmen wollen?","",MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    string str = "BEGIN TRAN\r\n";
                    
                    for(int i =0; i < dataGridView2.RowCount; i++){

                      // MessageBox.Show( dataGridView2.Rows[i].Cells[0].Value.ToString());
                        string id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        string value = dataGridView2.Rows[i].Cells[2].Value.ToString();
                       str += "update zutaten set bestand = bestand - " + value + " where znr = "+ id + "\r\n";
                    }
                    str += "COMMIT TRAN";
                   runcmd(str);

                }
            }
         catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_zutatenzurezepthinzu_Click(object sender, EventArgs e)
        {
            fill("select * from zutaten",dataGridView2);
            string nr = dataGridView1.SelectedCells[0].Value.ToString();
            string zutat = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die Nummer der zutat ein:");
            string anz = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die Menge pro 100 Stk :");
            if (zutat != "" && anz != "")
            {
            runcmd("insert into bestehtaus values (" + nr + "," + zutat + "," + anz + ")");
            }
         
        }

        private void btn_zutatausrezeptentf_Click(object sender, EventArgs e)
        {
            showzutaten();
            string nr = dataGridView1.SelectedCells[0].Value.ToString();
            string zutat = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die Nummer der zutat ein:");

            if (zutat != "")
            {
                runcmd("delete from bestehtaus where rnr = " + nr + " and znr = " +zutat);
            }

        }

        private void btn_zutathinzu_Click(object sender, EventArgs e)
        {
            string nr = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie eine Nummer für die zutat ein:");
            string name = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie den Namen der Zutat ein:");
            string mbestand = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie den Gewünschten Meldebestand ein:");
            if (nr != null && name != null && mbestand != null){
                runcmd("insert into zutaten values (" + nr + " ,'" + name +  "',0," + mbestand + ")");
            }
        }

        private void btn_lieferung_Click(object sender, EventArgs e)
        {
            string nr = dataGridView1.SelectedCells[0].Value.ToString();
            string plusbestand = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie den zusätzlichen Bestand ein:");

            runcmd("update zutaten set bestand = bestand + " + plusbestand + "where znr = " + nr);

        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            fill("select * from zutaten where bestand < meldebestand",dataGridView2);
        }

        private void btn_lieferanthinzu_Click(object sender, EventArgs e)
        {
            string nr = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie eine Nummer für den Lieferanten ein:");
            string name = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie den Namen des Lieferanten ein:");
            string tel = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die Telefonnummer des Lieferanten ein:");
            string mail = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die E-Mail Adresse des Lieferanten ein(wenn vorhanden):");
            string plz = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die PLZ Adresse des Lieferanten ein:");
            string strasse = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die Strasse des Lieferanten ein(wenn vorhanden):");

            if (nr != "" && name != "" )
            {

                    runcmd("insert into lieferanten values (" + nr + ",'" + name + "'," + tel + ",'" + mail + " '," + plz + ",'" + strasse + " ')");
            }
        }

        private void btn_lieferantenentf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind sie sicher, dass sie den ausgewählten Lieferanten und alle damit verbundenen daten löschen wollen?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string nr = dataGridView1.SelectedCells[0].Value.ToString();
                runcmd("BEGIN TRAN \r\ndelete from liefert where lnr = " + nr + "\r\ndelete from lieferanten where lnr = " + nr + "\r\n COMMIT TRAN");
            }

        }

        private void btn_werliefertwas_Click(object sender, EventArgs e)
        {
            fill("select * from zutaten", dataGridView2);
            string nr = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie eine Nummer für die Zutat ein:");
            if (nr != "")
            {
                fill("select lieferanten.lnr,lieferanten.name,lieferanten.tel,lieferanten.email,lieferanten.plz,lieferanten.strasse from lieferanten join liefert on lieferanten.lnr = liefert.lnr where znr = " + nr, dataGridView2);
            }
        }
    }
}
