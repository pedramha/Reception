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
    public partial class DisFrmSrch : Form
    {
        public DisFrmSrch()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private void DisFrmSrch_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Discounts", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "Discounts");
                dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Discounts"));
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Discounts WHERE DiscountID='" + txtdisId.Text + "' or Amount='" + txtamount.Text + "'or Discript='" + txtdesc.Text + "'", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(dt);


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nothing Found!!!");
                    dataGridView1.DataSource = "";
                }
                else if (dt.Rows.Count != 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
