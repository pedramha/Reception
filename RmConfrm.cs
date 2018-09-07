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
    public partial class RmConfrm : Form
    {
        public RmConfrm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;
        private void RmConfrm_Load(object sender, EventArgs e)
        {
            strsql = "SELECT * FROM RoomCondition";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "RoomCondition");
            TxtromID.DataBindings.Add(new Binding("Text", ds, "RoomCondition.RoomNumber"));
            Txtrmcon.DataBindings.Add(new Binding("Text", ds, "RoomCondition.Condition"));
            con.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Txtrmcon.Text = "";
            TxtromID.Text = "";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "RoomCondition"].Position = 0;
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds, "RoomCondition"].Position != 0)
            {
                this.BindingContext[ds, "RoomCondition"].Position -= 1;

            }
            else
            {
                MessageBox.Show("First Record!!!");
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds, "RoomCondition"].Position == this.BindingContext[ds, "RoomCondition"].Count)
            {
                MessageBox.Show("Last Record!!!");

            }
            else
            {
                this.BindingContext[ds, "RoomCondition"].Position += 1;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "RoomCondition"].Position = this.BindingContext[ds, "RoomCondition"].Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newRow = ds.Tables["RoomCondition"].NewRow();
            int ID;

            ID = Convert.ToInt32(TxtromID.Text);

            SqlCommand cmd;
            string qry;
            qry = "INSERT INTO RoomCondition(RoomNumber,Condition)VALUES('" + ID + "','" + Txtrmcon.Text + "')";
            con.Open();
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            da.Fill(ds, "RoomCondition");
            con.Close();
            MessageBox.Show("Successfully Done!");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string qry;
            con.Open();
            int ID;
            ID = Convert.ToInt32(TxtromID.Text);
            qry = "DELETE FROM RoomCondition WHERE RoomNumber=" + ID;
            cmd.CommandText = qry;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            ds.Clear();
            da.Fill(ds, "RoomCondition");
            con.Close();
            MessageBox.Show("Successfully Done!");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int ID;

            ID = Convert.ToInt32(TxtromID.Text);
            SqlCommand cmd = new SqlCommand();
            string qry;
            qry = "UPDATE RoomCondition SET Condition='" + Txtrmcon.Text + "'WHERE RoomNumber='" + ID + "'";
            con.Open();
            cmd.CommandText = qry;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            da.Fill(ds, "RoomCondition");
            con.Close();
            MessageBox.Show("SuccessfullyDone");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
