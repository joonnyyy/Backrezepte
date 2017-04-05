using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;


namespace DB_TEST_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
        String connectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                BindingSource bindingSource1 = new BindingSource();
                dataGridView1.DataSource = bindingSource1;



                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample

                // database accessible to your system.
                connectionString = @"Server=192.168.56.101;Database=testdb;User Id=Admin;Password=12345678;";
                string selectCommand = "Select * From test";
                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter;
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.ShowDialog();
            MessageBox.Show(frm2.uname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
