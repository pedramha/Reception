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
    public partial class FrmReciept : Form
    {
        public FrmReciept()
        {
            InitializeComponent();
           
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataRow newRow;
        DataTable dt = new DataTable();
        SqlCommandBuilder cb;
        private void FrmReciept_Load(object sender, EventArgs e)
        {
            strsql = "SELECT  * FROM Reciept";
            con = new SqlConnection(strCon);
            txtgcardID.Text = "";
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "Reciept");
          
            con.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
            int pos;
           
            pos = Convert.ToInt32(txtgcardID.Text);
            //this.BindingContext[ds, "Reciept"].Position = pos;
            strsql = "SELECT * FROM Reciept WHERE GuestCardID='"+pos+"'";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            //da.Fill(dt);
            da.Fill(ds,"Reciept");
            //TxtGName.Text = dt.Rows[pos]["GuestName"].ToString();
            ////txtprice.Text = dt.Rows[pos]["TotalPrice"].ToString();
            //txttax.Text = dt.Rows[pos]["Tax"].ToString();
            //txtRnumb.Text = dt.Rows[pos]["RoomNumber"].ToString();
            //comboDisId.Text = dt.Rows[pos]["DiscountsID"].ToString();
            //comboUsedservId.Text = dt.Rows[pos]["UsedServicesIDreciept"].ToString();
            //comboUserID.Text = dt.Rows[pos]["UserID"].ToString();
            //TxtRecieptNu.Text = dt.Rows[pos]["RecieptID"].ToString();
            //txtstadur.Text = dt.Rows[pos]["StayDuration"].ToString();
            ////TxtRecieptNu.DataBindings.Add(new Binding("Text", ds, "Reciept.RecieptID"));
            ////TxtGName.DataBindings.Add(new Binding("Text", ds, "Reciept.GuestName"));
            ////txtRnumb.DataBindings.Add(new Binding("Text", ds, "Reciept.RoomNumber"));
            ////comboDisId.DataBindings.Add(new Binding("Text", ds, "Reciept.DiscountID"));
            ////comboUsedservId.DataBindings.Add(new Binding("Text", ds, "Reciept.UsedServicesID"));
            ////comboUserID.DataBindings.Add(new Binding("Text", ds, "Reciept.UserID"));
            ////txttax.DataBindings.Add(new Binding("Text", ds, "Reciept.Tax"));
            ////txtprice.DataBindings.Add(new Binding("Text", ds, "Reciept.TotalPrice"));
            ////txtgcardID.DataBindings.Add(new Binding("Text", ds, "Reciept.GuestCardID"));
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            TxtGName.Text = "";
            //txtprice.Text = "";
            txttax.Text = "";
            txtRnumb.Text = "";
            comboDisId.Text = "";
            comboUsedservId.Text = "";
            comboUserID.Text = "";
            TxtRecieptNu.Text = "";
            txtgcardID.Text = "";
            //strsql = "SELECT     dbo.Prices.UsedServicesPrice, dbo.Discounts.Amount, dbo.Reciept.* FROM         dbo.Discounts INNER JOIN dbo.Reciept ON dbo.Discounts.DiscountID = dbo.Reciept.DiscountsID INNER JOIN dbo.Prices ON dbo.Reciept.UsedServicesID = dbo.Prices.UsedServicesID";
            //con = new SqlConnection(strCon);
            //con.Open();
            //da = new SqlDataAdapter(strsql, con);
            //da.Fill(ds, "Discounts");
            //this.BindingContext[ds,"Discounts"].Position=1;
            //txtdiscount.DataBindings.Add(new Binding("Text", ds, "Discounts.DiscountsID"));
            //strqry2 = "SELECT * FROM Discounts";
            //da1 = new SqlDataAdapter(strqry2,con);
            //da1.Fill(dt); 
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Reciept"].NewRow();
                cmd = new SqlCommand();
                con.Open();
                string qry;
                qry = "INSERT INTO Reciept(RecieptID,GuestName,RoomNumber,UserID,UsedServicesIDreciept,DiscountsID,Tax,GuestCardID,StayDuration)VALUES('" + Convert.ToInt32(TxtRecieptNu.Text) + "','" + TxtGName.Text + "','" + Convert.ToInt32(txtRnumb.Text) + "','"
                    + Convert.ToInt32(comboUserID.Text) + "','" + Convert.ToInt32(comboUsedservId.Text) + "','" + Convert.ToInt32(comboDisId.Text) + "','" + Convert.ToInt32(txttax.Text) + "','" + Convert.ToInt32(txtgcardID.Text) +"','"+Convert.ToInt32(txtstadur.Text)+ "')";
                cb = new SqlCommandBuilder(da);
                da = cb.DataAdapter;
                da.Update(ds, "Reciept");
                ds.Tables["Reciept"].Rows.Add(newRow);
                cmd.Connection = con;
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Reciept");
                con.Close();
                MessageBox.Show("Successfully Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                string qry;
                qry = "UPDATE Reciept SET GuestName='" + TxtGName.Text + "',RoomNumber='" + Convert.ToInt32(txtRnumb.Text) + "',UserID='" + Convert.ToInt32(comboUserID.Text) + "',UsedServicesIDreciept='" + Convert.ToInt32(comboUsedservId.Text) + "',DiscountsID='" + Convert.ToInt32(comboDisId.Text) + "',Tax='" + Convert.ToInt32(txttax.Text) + "',GuestCardID='" + Convert.ToInt32(txtgcardID.Text) + "',StayDuration='"+Convert.ToInt32(txtstadur.Text)+"'WHERE RecieptID='" + Convert.ToInt32(TxtRecieptNu.Text) + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "GuestCard");
                con.Close();
                MessageBox.Show("Successfully Done");
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
                cmd = new SqlCommand();
                string qrydel;
                con.Open();
                qrydel = "DELETE FROM Reciept WHERE RecieptID=" + Convert.ToInt32(TxtRecieptNu.Text);
                cmd.Connection = con;
                cmd.CommandText = qrydel;
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Reciept");
                con.Close();
                MessageBox.Show("Successfully Done!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = Convert.ToInt32(comboDisId.Text);
                int posprice = Convert.ToInt32(comboUsedservId.Text);
                int stayduration = Convert.ToInt32(txtstadur.Text);
                strsql = "SELECT     dbo.Reciept.DiscountsID, dbo.Reciept.Tax, dbo.Prices.UsedServicesID, dbo.Prices.UsedServicesPrice, dbo.Discounts.DiscountID, dbo.Discounts.Amount,  dbo.Reciept.UsedServicesIDreciept FROM         dbo.Discounts INNER JOIN dbo.Reciept ON dbo.Discounts.DiscountID = dbo.Reciept.DiscountsID INNER JOIN dbo.Prices ON dbo.Reciept.UsedServicesIDreciept = dbo.Prices.UsedServicesID WHERE UsedServicesID='" + posprice + "'";
                con = new SqlConnection(strCon);
                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "Discounts");
                this.BindingContext[ds, "Discounts"].Position = pos;
                txtdiscount.DataBindings.Add(new Binding("Text", ds, "Discounts.Amount"));
                //txttotalp.Text = (Convert.ToInt32(txtdiscount.Text) * stayduration).ToString();
                da.Fill(ds, "Prices");
                this.BindingContext[ds, "Prices"].Position = posprice;
                txtpernight.DataBindings.Add(new Binding("Text", ds, "Prices.UsedServicesPrice"));
                txttotalp.Text = (Convert.ToInt32(txtpernight.Text) * stayduration + (Convert.ToInt32(txttax.Text)) - Convert.ToInt32(txtdiscount.Text)).ToString();
                SqlCommand cmd;
                string qry;
                qry = "UPDATE Reciept SET TotalPrice='" + Convert.ToInt32(txttotalp.Text) + "'WHERE RecieptID='" + Convert.ToInt32(TxtRecieptNu.Text) + "'";
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "GuestCard");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnrep_Click(object sender, EventArgs e)
        {
            Form objrecrep = new RecieptReport();
            objrecrep.Show();
        }

    }
}
