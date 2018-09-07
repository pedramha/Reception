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
    public partial class FRMcountIns : Form
    {
        public FRMcountIns()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        DataRow newRow;
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private void FRMcountIns_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Country", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Country");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            newRow = ds.Tables["Country"].NewRow();
            //int ID;
            //int natcode;
            //ID = Convert.ToInt32(txtID.Text);
            //natcode = Convert.ToInt32(txtnatID.Text);
            SqlCommand cmd;
            string qry;
            qry = "INSERT INTO Country(CountryID,CountryName)VALUES('" + txtinscountid.Text + "','" + txtinsname.Text + "')";
            con.Open();
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Country");
            con.Close();
            MessageBox.Show("Successfully Done!");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
