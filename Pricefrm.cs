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
    public partial class Pricefrm : Form
    {
        public Pricefrm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;
        private void Pricefrm_Load(object sender, EventArgs e)
        {
            strsql = "SELECT * FROM Prices";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "Prices");
            txtID.DataBindings.Add(new Binding("Text", ds, "Prices.UsedServicesID"));
            TXTservname.DataBindings.Add(new Binding("Text", ds, "Prices.UsedServicesName"));
            txtprice.DataBindings.Add(new Binding("Text", ds, "Prices.UsedServicesPrice"));
            con.Close();
            txtID.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Prices"].NewRow();
                int ID;
                int price;
                ID = Convert.ToInt32(txtID.Text);
                price = Convert.ToInt32(txtprice.Text);
                SqlCommand cmd;
                string qry;
                qry = "INSERT INTO Prices(UsedServicesID,UsedServicesName,UsedServicesPrice)VALUES('" + ID + "','" + TXTservname.Text + "','" + price + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Prices");
                this.BindingContext[ds, "Prices"].Position = this.BindingContext[ds, "Prices"].Count;
                con.Close();
                txtID.ReadOnly = true;
                MessageBox.Show("Successfully Done!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string qry;
                con.Open();
                int ID;
                ID = Convert.ToInt32(txtID.Text);
                qry = "DELETE FROM Prices WHERE UsedServicesID=" + ID;
                cmd.CommandText = qry;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "Prices");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Successfully Done!");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                int price;
                ID = Convert.ToInt32(txtID.Text);
                price = Convert.ToInt32(txtprice.Text);
                SqlCommand cmd = new SqlCommand();
                string qry;
                qry = "UPDATE Prices SET UsedServicesName='" + TXTservname.Text + "',UsedServicesPrice='" + price + "'WHERE UsedServicesID='" + ID + "'";
                con.Open();
                cmd.CommandText = qry;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Prices");
                con.Close();
                MessageBox.Show("SuccessfullyDone");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds, "Prices"].Position == 0)
            {
                MessageBox.Show("First Record!!!");
            }
            else
            {
                this.BindingContext[ds, "Prices"].Position -= 1;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Prices"].Position = 0;
            MessageBox.Show("First Record!!!");
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.BindingContext[ds, "Prices"].Position == this.BindingContext[ds, "Prices"].Count)
                {

                    MessageBox.Show("Last Record!!!");
                }
                else
                {
                    this.BindingContext[ds, "Prices"].Position += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Prices"].Position = this.BindingContext[ds, "Prices"].Count;
            MessageBox.Show("Last Record!!!");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(this.BindingContext[ds, "Prices"].Count);
                id += 1;
                txtID.Text = id.ToString();
                txtprice.Text = "";
                TXTservname.Text = "";
                txtID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form objpricesearch = new PricesFrmSrch();
            objpricesearch.Show();
        }
    }
}
