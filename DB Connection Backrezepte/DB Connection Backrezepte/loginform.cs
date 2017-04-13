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
        static bool dontclose = false;
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*' ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Server=" + textBox3.Text +";Database=testdb;User Id="+ textBox1.Text +";Password=" + textBox2.Text + ";";
            if (contest(connectionstring))
            {
                mainform.connectionstring = connectionstring;
                dontclose = true;
                Close();
            }
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
                MessageBox.Show("Fehler bei der Anmeldung: " + e.Message);


                return false;
            }
        }

        private void loginform_SizeChanged(object sender, EventArgs e)
        {
            Height = 238;
            Width = 214;
        }

        private void loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dontclose == false)
            {
            Application.Exit();
            }
           
        }
    }
}
