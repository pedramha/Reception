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
    public partial class CashFrm : Form
    {
        public CashFrm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string strsql;
        //string strusers;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        //SqlDataAdapter da1;
        SqlCommand cmd;
        SqlConnection con;
        DataRow newRow;
        private void btnrec_Click(object sender, EventArgs e)
        {
            Form objcorrection = new FRMCashsearch();
            objcorrection.Show();
        }

        private void CashFrm_Load(object sender, EventArgs e)
        {
            txtcashID.ReadOnly = true;
            int cashID;
            //int userid;
            strsql = "SELECT CashID FROM Cash";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "Cash");
            cashID = Convert.ToInt32(BindingContext[ds, "Cash"].Count);
            cashID += 1;
            txtcashID.Text = Convert.ToString(cashID);
            //txtcashID.DataBindings.Add(new Binding("Text", ds, "Cash.CashID"));
            //cashID=Convert.ToInt32(txtcashID.Text);
            //strusers = "SELECT * FROM Users WHERE UserID=" ;
            //da1 = new SqlDataAdapter(strusers,con);
            //da1.Fill(ds,"Users");
            //TXTuserID.DataBindings.Add(new Binding("Text",ds,"Users.Name"));
            //cashID += 1;
            //TXTuserID.Text =Convert.ToString (cashID);
            //TXTuserID.DataBindings.Add(new Binding("Text", ds, "Cash.UserID"));
            //txtamount.DataBindings.Add(new Binding("Text", ds, "Cash.CashAmount"));
            //ComboShiftId.DataBindings.Add(new Binding("Text",ds,"Cash.CashShift"));
            //txtDiscript.DataBindings.Add(new Binding("Text",ds,"Cash.Discription"));
            //this.BindingContext[ds, "Cash"].Position = this.BindingContext[ds, "Cash"].Count;
            con.Close();
        }

        private void btnendShidt_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Cash"].NewRow();
                int CashID;
                int userid;
                CashID = Convert.ToInt32(txtcashID.Text);
                userid = Convert.ToInt32(TXTuserID.Text);
                string qry;
                qry = "INSERT INTO Cash(CashID,UserID,CashAmount,Shift,Discription)VALUES('" + CashID + "','" + userid + "','" + txtamount.Text + "','" + ComboShiftId.Text + "','" + txtDiscript.Text + "')";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "BlackList");
                con.Close();
                MessageBox.Show("Successfully Done!");
                txtamount.Text = "";
                txtcashID.Text = "";
                txtDiscript.Text = "";
                TXTuserID.Text = "";
                ComboShiftId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncorrect_Click(object sender, EventArgs e)
        {
            Form objcorrection = new CorrectioncashFRM();
            objcorrection.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form objcashrep = new CashReport2();
            objcashrep.Show();
        }
    }
}
