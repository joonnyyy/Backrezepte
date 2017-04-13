using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Connection_Backrezepte
{
    public partial class mainform : Form
    {
        public static string connectionstring;
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

            loginform lf = new loginform();
            lf.ShowDialog();

        }

        private void fill1(string command)
        {


        }

        private void fill2(string command)
        {

        }
    }
}
