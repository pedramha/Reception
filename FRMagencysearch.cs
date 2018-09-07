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
    public partial class FRMagencysearch : Form
    {
        public FRMagencysearch()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        private void FRMagencysearch_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Agency", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Agency");
            dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Agency"));
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Agency WHERE AgencyID='" + txtID.Text + "' or AgencyName='" + TXTName.Text + "'", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nothing Found!!!");
                dataGridView1.DataSource = "";
                //dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Cash"));

            }
            dataGridView1.DataSource = dt;
            Form obj = new FRMagencysearch();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Agency", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds);
                string Filter;

                int Rows;

                string trimtext;

                trimtext = TXTName.Text.Trim();

                if ((trimtext.Equals("")))

                    Filter = "";

                else

                    Filter = "AgencyName Like '%" + TXTName.Text.ToString() + "%'";
                ds.Tables["Agency"].DefaultView.RowFilter = Filter;
                Rows = ds.Tables["Agency"].DefaultView.Count;
                dataGridView1.DataSource = ds.Tables["Agency"].DefaultView;
            }
            catch (Exception) { }
        }
    }
}
