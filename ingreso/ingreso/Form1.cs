using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingreso
{
    public partial class Form1 : Form
    {
        public iE_login info = new iE_login();
        public oD_login opr = new oD_login();

        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            info.username = tbUname.Text;
            info.password = tbPass.Text;
            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                menuprincipal mde = new menuprincipal();
                mde.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password !");
            }

        }
    }
}
