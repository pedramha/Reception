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
    public partial class Rmlistfrm : Form
    {
        public Rmlistfrm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;
        private void Rmlistfrm_Load(object sender, EventArgs e)
        {
            txtroomnumber.ReadOnly = true;
            strsql = "SELECT * FROM Rooms";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "Rooms");
            txtroomnumber.DataBindings.Add(new Binding("Text", ds, "Rooms.RoomNumber"));
            txtsitnum.DataBindings.Add(new Binding("Text", ds, "Rooms.SituationNumber"));
            txttype.DataBindings.Add(new Binding("Text", ds, "Rooms.RoomType"));
            txtprice.DataBindings.Add(new Binding("Text", ds, "Rooms.RoomPrice"));
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Rooms"].NewRow();
                int ID;
                SqlCommand cmd;
                ID = Convert.ToInt32(txtroomnumber.Text);
                string qry;
                qry = "INSERT INTO Rooms(RoomNumber,RoomType,SituationNumber,RoomPrice)VALUES('" + ID + "','" + txttype.Text + "','"
                    + txtsitnum.Text + "','" + txtprice.Text + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Rooms");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Rooms"].Position += 1;
            //Baraye inke be akharin record residim eror nemidahad
            if (this.BindingContext[ds, "Rooms"].Position == this.BindingContext[ds, "Rooms"].Count)
            {
                MessageBox.Show("Last Record!!!");
            }
        }

        private void LastBTN_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Rooms"].Position = this.BindingContext[ds, "Rooms"].Count;
            MessageBox.Show("Last Record!!!");
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Rooms"].Position -= 1;
            if (this.BindingContext[ds, "Rooms"].Position == 0)
            {
                MessageBox.Show("First Record!!!");
            }
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Rooms"].Position = 0;
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                SqlCommand cmd;
                ID = Convert.ToInt32(txtroomnumber.Text);
                string qry;
                qry = "UPDATE Rooms SET RoomType='" + txttype.Text + "',SituationNumber='" + txtsitnum.Text + "',Price='" + txtprice.Text + "'WHERE RoomNumber='" + ID + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Rooms");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch(Exception ex)
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
                UserID = Convert.ToInt32(txtroomnumber.Text);
                QryDel = "DELETE FROM Rooms WHERE RoomNumber=" + UserID;
                cmd.CommandText = QryDel;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds, "Rooms");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(this.BindingContext[ds, "Rooms"].Count);
            ID += 1;
            txtroomnumber.Text = ID.ToString();
            txtprice.Text = "";
            txtsitnum.Text = "";
            txttype.Text = "";
            txtroomnumber.ReadOnly = false;
        }

        private void rmcondition_Click(object sender, EventArgs e)
        {
            Form objrmcondition = new RmConfrm();
            objrmcondition.Show();
        }
    }
}
