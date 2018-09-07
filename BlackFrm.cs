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
    public partial class BlackFrm : Form
    {
        public BlackFrm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;
        private void BlackFrm_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.ReadOnly = true;
                strsql = "SELECT * FROM BlackList";
                con = new SqlConnection(strCon);
                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "BlackList");
                txtID.DataBindings.Add(new Binding("Text", ds, "BlackList.GuestID"));
                TXTname.DataBindings.Add(new Binding("Text", ds, "BlackList.GuestName"));
                txtnatID.DataBindings.Add(new Binding("Text", ds, "BlackList.NationalID"));
                txtreason.DataBindings.Add(new Binding("Text", ds, "BlackList.Reason"));
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                ID = this.BindingContext[ds, "BlackList"].Count;
                ID += 1;
                txtreason.Text = "";
                txtnatID.Text = "";
                TXTname.Text = "";
                txtID.Text = Convert.ToString(ID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "BlackList"].Position = 0;
                MessageBox.Show("First Record!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.BindingContext[ds, "Blacklist"].Position == 0)
                {
                    MessageBox.Show("First Record!!!");
                }
                else
                {
                    this.BindingContext[ds, "BlackList"].Position -= 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.BindingContext[ds, "BlackList"].Position == this.BindingContext[ds, "BlackList"].Count)
                {

                    MessageBox.Show("Last Record!!!");
                }
                else
                {
                    this.BindingContext[ds, "BlackList"].Position += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "BlackList"].Position = this.BindingContext[ds, "BlackList"].Count;
                MessageBox.Show("Last Record!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                int NatID;
                ID = Convert.ToInt32(txtID.Text);
                NatID = Convert.ToInt32(txtnatID.Text);
                SqlCommand cmd = new SqlCommand();
                string qry;
                qry = "UPDATE BlackList SET GuestName='" + TXTname.Text + "',NationalID='" + NatID + "',Reason='" + txtreason.Text + "'WHERE GuestID='" + ID + "'";
                con.Open();
                cmd.CommandText = qry;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                da.Fill(ds, "BlackList");
                con.Close();
                MessageBox.Show("SuccessfullyDone");
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
                qry = "DELETE FROM BlackList WHERE GuestID=" + ID;
                cmd.CommandText = qry;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "BlackList");
                con.Close();
                MessageBox.Show("Successfully Done!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["BlackList"].NewRow();
                int ID;
                int natcode;
                ID = Convert.ToInt32(txtID.Text);
                natcode = Convert.ToInt32(txtnatID.Text);
                SqlCommand cmd;
                string qry;
                qry = "INSERT INTO BlackList(GuestID,GuestName,NationalID,Reason)VALUES('" + ID + "','" + TXTname.Text + "','" + natcode + "','" + txtreason.Text + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "BlackList");
                this.BindingContext[ds, "BlackList"].Position = this.BindingContext[ds, "BlackList"].Count;
                con.Close();
                MessageBox.Show("Successfully Done!");
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form objblacksearch = new BlackSrch();
            objblacksearch.Show();
        }

        private void TXTname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
