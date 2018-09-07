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
    public partial class BlackSrch : Form
    {
        
        public BlackSrch()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private void BlackSrch_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM BlackList", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "BlackList");
                dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "BlackList"));
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
                da = new SqlDataAdapter("SELECT * FROM BlackList WHERE GuestID='" + txtId.Text + "' or NationalID='" + txtnatcode.Text + "'", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nothing Found!!!");
                }
                else if (dt.Rows.Count != 0)
                {
                    dataGridView1.DataSource = dt;
                }
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM BlackList", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds);
                string Filter;

                int Rows;

                string trimtext;

                trimtext = txtname.Text.Trim();

                if ((trimtext.Equals("")))

                    Filter = "";

                else

                    Filter = "GuestName Like '%" + txtname.Text.ToString() + "%'";
                ds.Tables["BlackList"].DefaultView.RowFilter = Filter;
                Rows = ds.Tables["BlackList"].DefaultView.Count;
                dataGridView1.DataSource = ds.Tables["BlackList"].DefaultView;
            }
            catch (Exception) { }
         
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    da = new SqlDataAdapter("SELECT * FROM BlackList", con);
            //    cb = new SqlCommandBuilder(da);
            //    da.Fill(ds);
            //    string Filter;

            //    int Rows;

            //    string trimtext;

            //    trimtext = txtId.Text.Trim();

            //    if ((trimtext.Equals("")))

            //        Filter = "";

            //    else

            //        Filter = "GuestID I '%" + txtId.Text.ToString() + "%'";

            //    ds.Tables["BlackList"].DefaultView.RowFilter = Filter;

            //    Rows = ds.Tables["BlackList"].DefaultView.Count;

            //    //Label1.Text = Rows.ToString();

            //    dataGridView1.DataSource = ds.Tables["BlackList"].DefaultView;

            //    //dataGridView1.DataBind();
            //}
            //catch (Exception) { }
        }

        private void txtnatcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
