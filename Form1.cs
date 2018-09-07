using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reception
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        String strCON;
        SqlConnection con;
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        private void Login_Load(object sender, EventArgs e)
        {
            strCON = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
            con = new SqlConnection(strCON);
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            string QRYLOGIN = "SELECT * FROM USERS WHERE USERNAME='" + txtUser.Text + "'AND PASS='" + txtPass.Text + "'";
            DA = new SqlDataAdapter(QRYLOGIN, strCON);
            DA.Fill(DT);
            if (DT.Rows.Count != 0)
            {
                Form objfrm = new MainFRM();
                objfrm.Show();
                this.Hide();
                MessageBox.Show("Welcome!");
            }
            else
                MessageBox.Show("INVALID USERNAME OR PASSWORD,PLEASE CONTACT YOUR SUPERVISOR!");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
