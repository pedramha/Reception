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
    public partial class AgeFrm : Form
    {
        public AgeFrm()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;

        private void AgeFrm_Load(object sender, EventArgs e)
        {
            try
            {
                strsql = "SELECT * FROM Agency";
                con = new SqlConnection(strCon);
                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "Agency");
                txtID.DataBindings.Add(new Binding("Text", ds, "Agency.AgencyID"));
                TXTname.DataBindings.Add(new Binding("Text", ds, "Agency.AgencyName"));
                chcont.DataBindings.Add(new Binding("Checked", ds, "Agency.Contraction"));
                txtyear.DataBindings.Add(new Binding("Text", ds, "Agency.Years"));
                txtadress.DataBindings.Add(new Binding("Text", ds, "Agency.AgencyAdress"));
                con.Close();
                txtID.ReadOnly = true;
                btnInsert.Enabled = false;
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
                ID = Convert.ToInt32(this.BindingContext[ds, "Agency"].Count);
                ID += 1;
                txtID.Text = Convert.ToString(ID); ;
                txtadress.Text = "";
                TXTname.Text = "";
                txtyear.Text = "";
                chcont.Checked = false;
                BtnEdit.Enabled = false;
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                btnprev.Enabled = false;
                btndel.Enabled = false;
                btnnext.Enabled = false;
                btnInsert.Enabled = true;
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
                newRow = ds.Tables["Agency"].NewRow();
                int ID;
                int Years;
                string Contract;
                if (chcont.Checked == true)
                {
                    Contract = "true";
                    Years = Convert.ToInt32(txtyear.Text);
                }
                else
                {
                    Contract = "false";
                    Years = 0;
                }
                SqlCommand cmd;
                ID = Convert.ToInt32(txtID.Text);
                string qry;
                qry = "INSERT INTO Agency(AgencyID,AgencyName,Contraction,Years,AgencyAdress)VALUES('" + ID + "','" + TXTname.Text + "','"
                    + Contract + "','" + Years + "','" + txtadress.Text + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Agency");
                con.Close();
                this.BindingContext[ds, "Agency"].Position = this.BindingContext[ds, "Agency"].Count;
                MessageBox.Show("Successfully Done");

                BtnEdit.Enabled = true;
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
                btnprev.Enabled = true;
                btndel.Enabled = true;
                btnnext.Enabled = true;
                btnInsert.Enabled = false;
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
                string QryDel;
                con.Open();
                int AgencyID;
                AgencyID = Convert.ToInt32(txtID.Text);
                QryDel = "DELETE FROM Agency WHERE AgencyID=" + AgencyID;
                cmd.CommandText = QryDel;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "Agency");
                con.Close();
                MessageBox.Show("Successfully Done");
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
                int AgencyID;
                string Contract;
                int years;
                years = Convert.ToInt32(txtyear.Text);
                if (chcont.Checked == true)
                {
                    Contract = "true";
                }
                else
                {
                    Contract = "false";
                }
                SqlCommand cmd;
                AgencyID = Convert.ToInt32(txtID.Text);
                string qry;
                qry = "UPDATE Agency SET AgencyName='" + TXTname.Text + "',Contraction='" + Contract + "',Years='" + years + "',AgencyAdress='" + txtadress.Text + "'WHERE AgencyID='" + AgencyID + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Agency");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Agency"].Position = this.BindingContext[ds, "Agency"].Count;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            //int a;
            //int b;
            //a = Convert.ToInt32(this.BindingContext[ds, "Agency"].Position.ToString());
            //b = Convert.ToInt32(this.BindingContext[ds,"Agency"].Count.ToString());
            //Baraye inke be akharin record residim eror nemidahad
            this.BindingContext[ds, "Agency"].Position += 1;
            if (this.BindingContext[ds, "Agency"].Position == this.BindingContext[ds, "Agency"].Count)
            //if(a==b)
            {
                MessageBox.Show("Last Record!!!");
            }

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "Agency"].Position -= 1;
                if (this.BindingContext[ds, "Agency"].Position == 0)
                {
                    MessageBox.Show("First Record!!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "Agency"].Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form objagesearch = new FRMagencysearch();
            objagesearch.Show();
        }

        private void chcont_CheckedChanged(object sender, EventArgs e)
        {
            if (chcont.Checked == true)
            {
                txtyear.Enabled = true;

            }
            else
            {
                txtyear.Enabled = false;

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
