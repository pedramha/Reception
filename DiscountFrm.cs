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
    public partial class DiscountFrm : Form
    {
        public DiscountFrm()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;

        private void DiscountFrm_Load(object sender, EventArgs e)
        {
            try
            {
                TXTID.ReadOnly = true;
                strsql = "SELECT * FROM Discounts";
                con = new SqlConnection(strCon);
                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "Discounts");
                txtdesc.DataBindings.Add(new Binding("Text", ds, "Discounts.Discript"));
                TXTID.DataBindings.Add(new Binding("Text", ds, "Discounts.DiscountID"));
                txtdisamnt.DataBindings.Add(new Binding("Text", ds, "Discounts.Amount"));
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(this.BindingContext[ds, "Discounts"].Count);
            id += 1;
            txtdesc.Text = "";
            txtdisamnt.Text = "";
            TXTID.Text = id.ToString();
            TXTID.ReadOnly = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                newRow = ds.Tables["Discounts"].NewRow();
                int id;
                int amount;
                id = Convert.ToInt32(TXTID.Text);
                amount = Convert.ToInt32(txtdisamnt.Text);
                SqlCommand cmd;
                string qry;
                qry = "INSERT INTO Discounts(DiscountID,Amount,Discript)VALUES('" + id + "','" + amount + "','" + txtdesc.Text + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Discounts");
                con.Close();
                MessageBox.Show("Successfully Done!");
                TXTID.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand();
                string qry;
                con.Open();
                int ID;
                ID = Convert.ToInt32(TXTID.Text);
                qry = "DELETE FROM Discounts WHERE DiscountID=" + ID;
                cmd.CommandText = qry;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "Discounts");
                con.Close();
                MessageBox.Show("Successfully Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Discounts"].Position = 0;
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds, "Discounts"].Position == 0)
            {
                MessageBox.Show("Last Record!!!");

            }
            else
            {
                this.BindingContext[ds, "Discounts"].Position -= 1;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds, "Discounts"].Position == this.BindingContext[ds, "Discounts"].Count)
            {
                MessageBox.Show("Last Record!!!");
            }
            else
            {
                this.BindingContext[ds, "Discounts"].Position += 1;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Discounts"].Position = this.BindingContext[ds, "Discounts"].Count;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                SqlCommand cmd;
                string qry;
                int a;
                int b;
                string c;
                c = Convert.ToString(txtdesc.Text);
                a = Convert.ToInt32(TXTID.Text);
                b = Convert.ToInt32(txtdisamnt.Text);
                qry = "UPDATE Discounts SET Amount='" + b + "',Discript='" + c + "'  WHERE DiscountID='" + a + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Discounts");
                con.Close();
                MessageBox.Show("SuccessfullyDone");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form objdissearch = new DisFrmSrch();
            objdissearch.Show();
        }
    }
}
