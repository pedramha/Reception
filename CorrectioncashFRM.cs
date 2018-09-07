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
    public partial class CorrectioncashFRM : Form
    {
        public CorrectioncashFRM()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        //string strusers;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        //SqlDataAdapter da1;
        //SqlCommand cmd;
        SqlConnection con;
        //DataRow newRow;
        private void CorrectioncashFRM_Load(object sender, EventArgs e)
        {
            strsql = "SELECT * FROM Cash";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "Cash");
            txtcashID.DataBindings.Add(new Binding("Text", ds, "Cash.CashID"));
            //cashID=Convert.ToInt32(txtcashID.Text);
            //strusers = "SELECT * FROM Users WHERE UserID=" ;
            //da1 = new SqlDataAdapter(strusers,con);
            //da1.Fill(ds,"Users");
            //TXTuserID.DataBindings.Add(new Binding("Text",ds,"Users.Name"));
            //cashID += 1;
            //TXTuserID.Text =Convert.ToString (cashID);
            ComboShiftId.DataBindings.Add(new Binding("Text", ds, "Cash.Shift"));
            TXTuserID.DataBindings.Add(new Binding("Text", ds, "Cash.UserID"));
            txtamount.DataBindings.Add(new Binding("Text", ds, "Cash.CashAmount"));
            txtDiscript.DataBindings.Add(new Binding("Text", ds, "Cash.Discription"));
            //this.BindingContext[ds, "Cash"].Position = this.BindingContext[ds, "Cash"].Count;
            con.Close();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Cash"].Position -= 1;
            if (this.BindingContext[ds, "Cash"].Position == 0) MessageBox.Show("First Record!!!");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Cash"].Position = 0;
            MessageBox.Show("First Record!!!");
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Cash"].Position += 1;
            //Baraye inke be akharin record residim eror nemidahad
            if (this.BindingContext[ds, "Cash"].Position > this.BindingContext[ds, "Cash"].Count)
            {
                MessageBox.Show("Last Record!!!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Cash"].Position = this.BindingContext[ds, "Cash"].Count;
            MessageBox.Show("Last Record!!!");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string QryDel;
            con.Open();
            int ID;
            ID = Convert.ToInt32(txtcashID.Text);
            QryDel = "DELETE FROM Cash WHERE CashID=" + ID;
            cmd.CommandText = QryDel;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            ds.Clear();
            da.Fill(ds, "Cash");
            con.Close();
            MessageBox.Show("Successfully Done");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(txtcashID.Text);
            SqlCommand cmd = new SqlCommand();
            string qry;
            qry = "UPDATE Cash SET UserID='" + TXTuserID.Text + "',Cashamount='" + txtamount.Text + "',Shift='" + ComboShiftId.Text + "',Discription='" + txtDiscript.Text + "'WHERE CashID='" + ID + "'";
            con.Open();
            cmd.CommandText = qry;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Cash");
            con.Close();
            MessageBox.Show("SuccessfullyDone");
        }
    }
}
