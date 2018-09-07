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
    public partial class UserFRM : Form
    {
        public UserFRM()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;

        private void UserFRM_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.ReadOnly = true;
                strsql = "SELECT * FROM Users";
                con = new SqlConnection(strCon);
                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "Users");
                textBox1.DataBindings.Add(new Binding("Text", ds, "Users.UserID"));
                textBox2.DataBindings.Add(new Binding("Text", ds, "Users.Name"));
                textBox3.DataBindings.Add(new Binding("Text", ds, "Users.UserName"));
                textBox4.DataBindings.Add(new Binding("Text", ds, "Users.Pass"));
                ComboShift.DataBindings.Add(new Binding("Text", ds, "Users.ShiftID"));
                con.Close();
                btnInsert.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                ID = Convert.ToInt32(this.BindingContext[ds, "Users"].Count);
                ID += 1;
                textBox1.ReadOnly = false;
                textBox1.Text = ID.ToString();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                ComboShift.Text = "";
                BtnRep.Enabled = false;
                editBTN.Enabled = false;
                nextbtn.Enabled = false;
                FirstBtn.Enabled = false;
                LastBTN.Enabled = false;
                deletebtn.Enabled = false;
                nextbtn.Enabled = false;
                prevbtn.Enabled = false;
                btnInsert.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Users"].NewRow();
                int ID;
                int shift;
                SqlCommand cmd;
                ID = Convert.ToInt32(textBox1.Text);
                shift = Convert.ToInt32(ComboShift.Text);
                string qry;
                qry = "INSERT INTO Users(UserID,Name,UserName,Pass,ShiftID)VALUES('" + ID + "','" + textBox2.Text + "','"
                    + textBox3.Text + "','" + textBox4.Text + "','" + shift + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Users");
                con.Close();
                MessageBox.Show("Successfully Done");
                textBox1.ReadOnly = true;
                BtnRep.Enabled = true;
                editBTN.Enabled = true;
                nextbtn.Enabled = true;
                FirstBtn.Enabled = true;
                LastBTN.Enabled = true;
                deletebtn.Enabled = true;
                nextbtn.Enabled = true;
                prevbtn.Enabled = true;
                btnInsert.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                int shift;
                SqlCommand cmd;
                ID = Convert.ToInt32(textBox1.Text);
                shift = Convert.ToInt32(ComboShift.Text);
                string qry;
                qry = "UPDATE Users SET Name='" + textBox2.Text + "',UserName='" + textBox3.Text + "',Pass='" + textBox4.Text + "',ShiftID='" + ComboShift.Text + "'WHERE UserID='" + ID + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Users");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string QryDel;
                con.Open();
                int UserID;
                UserID = Convert.ToInt32(textBox1.Text);
                QryDel = "DELETE FROM Users WHERE UserID=" + UserID;
                cmd.CommandText = QryDel;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "Users");
                con.Close();
                MessageBox.Show("Successfully Done");
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

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "Users"].Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "Users"].Position -= 1;
                if (this.BindingContext[ds, "Users"].Position == 0)
                {
                    MessageBox.Show("First Record!!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "Users"].Position += 1;
                //Baraye inke be akharin record residim eror nemidahad
                if (this.BindingContext[ds, "Users"].Position > this.BindingContext[ds, "Users"].Count)
                {
                    MessageBox.Show("Last Record!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LastBTN_Click(object sender, EventArgs e)
        {
            try
            {

                this.BindingContext[ds, "Users"].Position = this.BindingContext[ds, "Users"].Count;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void BtnRep_Click(object sender, EventArgs e)
        {
            Form objuserreport = new UserReport();
            objuserreport.Show();
        }
    }
}
