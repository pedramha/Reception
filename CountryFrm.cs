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
    public partial class CountryFrm : Form
    {
        public CountryFrm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private void CountryFrm_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Country", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Country");
            dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Country"));
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Country WHERE CountryID='" + txtserId.Text + "' or CountryName='" + txtsername.Text + "'", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Nothing Found!!!");
                dataGridView1.Rows.Clear();
            }
            dataGridView1.DataSource = dt;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form objcountryins = new FRMcountIns();
            objcountryins.Show();
        }
    }
}
