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

namespace DB_Connection_Backrezepte
{
    public partial class loginform : Form
    {
        private static bool dontclose = false;
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*' ;
            label4.Text = "";
            textBox1.Text = "admin";
            textBox2.Text = "12345678";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }


        private void login()
        {
            label4.Text = "verbinde...";
            Application.DoEvents();
            string connectionstring = @"Server=" + textBox3.Text + ";Database=backrezepte;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            if (contest(connectionstring))
            {
                mainform.connectionstring = connectionstring;
                dontclose = true;
                Close();
            }
            label4.Text = "";
        }
        
        static bool contest(string connectstring)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectstring))
                {
                    connection.Open();
                    connection.Close();
                }
                return true;
            }catch(Exception e)
            {
                MessageBox.Show("Fehler bei der Anmeldung: \n" + e.Message);
                return false;
            }
        }

        private void loginform_SizeChanged(object sender, EventArgs e)
        {

        }

        private void loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dontclose == false)
            {
            Application.Exit();
            }
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
