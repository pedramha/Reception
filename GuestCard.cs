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
    public partial class GuestCard : Form
    {
        public GuestCard()
        {
            InitializeComponent();
            
        }
        DataSet ds = new DataSet();
        string strsql;
        string strCon = "Data Source=.;Initial Catalog=ProjectREC;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataRow newRow;
        SqlCommandBuilder cb;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void GuestCard_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            TxtID.ReadOnly = true;
            if (checkcompany.Checked == false)
            {
                txtCompnum.Enabled = false;
                label5.Enabled = false;
            }
            else
            {
                txtCompnum.Enabled = true;
                label5.Enabled = true;
            }
            strsql = "SELECT * FROM GuestCard";
            con = new SqlConnection(strCon);
            con.Open();
            da = new SqlDataAdapter(strsql, con);
            da.Fill(ds, "GuestCard");
            TxtID.DataBindings.Add(new Binding("Text", ds, "GuestCard.GuestCardID"));
            TxtName.DataBindings.Add(new Binding("Text", ds, "GuestCard.Name"));
            radiofml.DataBindings.Add(new Binding("Checked", ds, "GuestCard.SEX"));
            if (radiofml.Checked == false)
            {
                radioml.Checked = true;
            }
            checkcompany.DataBindings.Add(new Binding("Checked", ds, "GuestCard.Company"));
            txtFather.DataBindings.Add(new Binding("Text", ds, "GuestCard.FatherName"));
            txtNatCode.DataBindings.Add(new Binding("Text", ds, "GuestCard.NationalCode"));
            comboCountry.DataBindings.Add(new Binding("Text", ds, "GuestCard.CountryID"));
            txtPhone.DataBindings.Add(new Binding("Text", ds, "GuestCard.PhoneNumber"));
            txtCompnum.DataBindings.Add(new Binding("Text", ds, "GuestCard.CompanyNumber"));
            txtAddress.DataBindings.Add(new Binding("Text", ds, "GuestCard.HomeAddress"));
            MSKCheckin.DataBindings.Add(new Binding("Text", ds, "GuestCard.CheckInTime"));
            MSKcheckout.DataBindings.Add(new Binding("Text", ds, "GuestCard.CheckOutTime"));
            RoomNumber.DataBindings.Add(new Binding("Text", ds, "GuestCard.RoomNumber"));
            txtres.DataBindings.Add(new Binding("Text", ds, "GuestCard.StayDuration"));
            con.Close();
            txtstadur.Text = txtres.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
            newRow = ds.Tables["GuestCard"].NewRow();
            int ID;
            int countryID;
            int natcode;
            string sex;
            string company;
            int Cmpnumber;
            int rmnumber;
            if (radiofml.Checked == true)
            {
                sex = "True";
            }
            else
            {
                sex = "False";
            }
            if (checkcompany.Checked == true)
            {
                company = "True";

            }
            else
            {
                company = "False";
            }
            SqlCommand cmd;
            txtCompnum.Enabled = true;
            ID = Convert.ToInt32(TxtID.Text);
            countryID = Convert.ToInt32(comboCountry.Text);
            natcode = Convert.ToInt32(txtNatCode.Text);
            rmnumber = Convert.ToInt32(RoomNumber.Text);
            if (checkcompany.Checked == true)
            {
                Cmpnumber = Convert.ToInt32(txtCompnum.Text);
            }
            else
            {
                Cmpnumber = 0;
            }
            string qry;
            qry = "INSERT INTO GuestCard(GuestCardID,Name,SEX,FatherName,CountryID,NationalCode,Company,CompanyNumber,PhoneNumber,HomeAddress,CheckInTime,CheckOutTime,RoomNumber,StayDuration)VALUES('" + ID + "','" + TxtName.Text + "','" + sex + "','"
                + txtFather.Text + "','" + countryID + "','" + natcode + "','" + company + "','" + Cmpnumber + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + Convert.ToDateTime(MSKCheckin.Text) + "','" + Convert.ToDateTime(MSKcheckout.Text) + "','" + rmnumber + "','" + Convert.ToInt32(txtres.Text) + "')";
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds, "GuestCard");
            con.Open();
            ds.Tables["GuestCard"].Rows.Add(newRow);
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            da.Fill(ds, "GuestCard");
            con.Close();
            MessageBox.Show("Successfully Done");
            TxtID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int guid;
            guid = Convert.ToInt32(this.BindingContext[ds, "GuestCard"].Count);
            guid += 1;
            txtres.Text = " ";
            txtAddress.Text = " ";
            txtCompnum.Text = " ";
            txtFather.Text = " ";
            TxtName.Text = " ";
            TxtID.Text = Convert.ToString(guid);
            txtNatCode.Text = " ";
            txtPhone.Text = " ";
            TxtID.ReadOnly = false;
            MSKcheckout.Text = " ";
            comboCountry.Text = " ";
            checkcompany.Checked = false;
            RoomNumber.Text = " ";
            radiofml.Checked = false;
            radioml.Checked = false;
            MSKCheckin.Text = DateTime.Now.ToString(); 
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string QryDel;
                con.Open();
                int GuestID;
                GuestID = Convert.ToInt32(TxtID.Text);
                QryDel = "DELETE FROM GuestCard WHERE GuestCardID=" + GuestID;
                cmd.Connection = con;
                cmd.CommandText = QryDel;
                cmd.ExecuteNonQuery();
                //ds.Clear();
                da.Fill(ds, "GuestCard");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                int countryID;
                int natcode;
                string sex;
                string company;
                int Cmpnumber;
                int rmnumber;
                if (radiofml.Checked == true)
                {
                    sex = "True";
                }
                else
                {
                    sex = "False";
                }
                if (checkcompany.Checked == true)
                {
                    company = "True";
                }
                else
                {
                    company = "False";
                }
                SqlCommand cmd;
                ID = Convert.ToInt32(TxtID.Text);
                natcode = Convert.ToInt32(txtNatCode.Text);
                countryID = Convert.ToInt32(comboCountry.Text);
                Cmpnumber = Convert.ToInt32(txtCompnum.Text);
                rmnumber = Convert.ToInt32(RoomNumber.Text);
                string qry;
                qry = "UPDATE GuestCard SET Name='" + TxtName.Text + "',FatherName='" + txtFather.Text + "',SEX='" + sex + "',CountryID='" + countryID + "',NationalCode='" + natcode + "',Company='" + company + "',CompanyNumber='" + Cmpnumber + "',PhoneNumber='" + txtPhone.Text + "',HomeAddress='" + txtAddress.Text + "',CheckInTime='" + MSKCheckin.Text + "',CheckOutTime='" + MSKcheckout.Text + "',RoomNumber='" + rmnumber + "',StayDuration='" + Convert.ToInt32(txtres.Text) + "'WHERE GuestCardID='" + ID + "'";
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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "GuestCard"].Position = 0;
                MessageBox.Show("First Record!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkcompany_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcompany.Checked == true)
            {
                txtCompnum.Enabled = true;
                label5.Enabled = true;
            }
            else
            {
                txtCompnum.Enabled = false;
                label5.Enabled = false;
                txtCompnum.Text = "0";
            }
        }

        private void radiofml_CheckedChanged(object sender, EventArgs e)
        {
            if (radiofml.Checked == false)
            {
                radioml.Checked = true;
            }
            else
            {
                radiofml.Checked = true;
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[ds, "GuestCard"].Position -= 1;
                if (this.BindingContext[ds, "GuestCard"].Position == 0) MessageBox.Show("First Record!!!");
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
                this.BindingContext[ds, "GuestCard"].Position += 1;
                if (this.BindingContext[ds, "GuestCard"].Position > this.BindingContext[ds, "GuestCard"].Count)
                {
                    MessageBox.Show("Last Record!!!");
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
                this.BindingContext[ds, "GuestCard"].Position = this.BindingContext[ds, "GuestCard"].Count;
                MessageBox.Show("Last Record!!!");

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

        private void btnreciept_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new System.Drawing.Size(1072, 559);
                groupBox4.Visible = true;
                int pos;

                pos = Convert.ToInt32(TxtID.Text);
                strsql = "SELECT  * FROM Reciept WHERE GuestcardID='" + pos + "'";
                con = new SqlConnection(strCon);

                con.Open();
                da = new SqlDataAdapter(strsql, con);
                da.Fill(ds, "Reciept");
                this.BindingContext[ds, "Reciept"].Position = pos;
                txtgcardID.DataBindings.Add(new Binding("Text", ds, "Reciept.GuestCardID"));
                TxtRecieptNu.DataBindings.Add(new Binding("Text", ds, "Reciept.RecieptID"));
                TxtGName.DataBindings.Add(new Binding("Text", ds, "Reciept.GuestName"));
                txtRnumb.DataBindings.Add(new Binding("Text", ds, "Reciept.RoomNumber"));
                comboDisId.DataBindings.Add(new Binding("Text", ds, "Reciept.DiscountsID"));
                comboUsedservId.DataBindings.Add(new Binding("Text", ds, "Reciept.UsedServicesIDreciept"));
                comboUserID.DataBindings.Add(new Binding("Text", ds, "Reciept.UserID"));
                txttax.DataBindings.Add(new Binding("Text", ds, "Reciept.Tax"));
                txttotalp.DataBindings.Add(new Binding("Text", ds, "Reciept.TotalPrice"));
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form objguestcardrep = new GuestCardReport();
            objguestcardrep.Show();
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
                da.Fill(ds, "Prices");
                this.BindingContext[ds, "Prices"].Position = posprice;
                txtpernight.DataBindings.Add(new Binding("Text", ds, "Prices.UsedServicesPrice"));
                txttotalp.Text = (Convert.ToInt32(txtpernight.Text) * stayduration + (Convert.ToInt32(txttax.Text)) - Convert.ToInt32(txtdiscount.Text)).ToString();
                SqlCommand cmd;
                string qry;
                string qry2;
                qry2 = "SELECT * FROM Reciept";
                da = new SqlDataAdapter(qry2,con);
                da.Fill(ds,"Reciept");
                qry = "UPDATE Reciept SET TotalPrice='" + Convert.ToInt32(txttotalp.Text) + "'WHERE RecieptID='" + Convert.ToInt32(TxtRecieptNu.Text) + "'";
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Reciept");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btncloserec_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            this.Size = new System.Drawing.Size(522, 559);
            this.con.Close();
        }

        private void btnnewrec_Click(object sender, EventArgs e)
        {
            txttax.Text = "";
            txtRnumb.Text = "";
            comboDisId.Text = "";
            comboUsedservId.Text = "";
            comboUserID.Text = "";
            TxtRecieptNu.Text = TxtID.Text;
            txtgcardID.Text = TxtID.Text;
            TxtGName.Text = "";
            txttotalp.Text = "";
        }

        private void btnaddrec_Click(object sender, EventArgs e)
        {
            try
            {
                newRow = ds.Tables["Reciept"].NewRow();
                cmd = new SqlCommand();
                con.Open();
                string qry;
                qry = "INSERT INTO Reciept(RecieptID,GuestName,RoomNumber,UserID,UsedServicesIDreciept,DiscountsID,Tax,GuestCardID,StayDuration)VALUES('" + Convert.ToInt32(TxtRecieptNu.Text) + "','" + TxtGName.Text + "','" + Convert.ToInt32(txtRnumb.Text) + "','"
                    + Convert.ToInt32(comboUserID.Text) + "','" + Convert.ToInt32(comboUsedservId.Text) + "','" + Convert.ToInt32(comboDisId.Text) + "','" + Convert.ToInt32(txttax.Text) + "','" + Convert.ToInt32(txtgcardID.Text) + "','" + Convert.ToInt32(txtstadur.Text) + "')";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btneditrec_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                string qry;
                qry = "UPDATE Reciept SET GuestName='" + TxtGName.Text + "',RoomNumber='" + Convert.ToInt32(txtRnumb.Text) + "',UserID='" + Convert.ToInt32(comboUserID.Text) + "',UsedServicesIDreciept='" + Convert.ToInt32(comboUsedservId.Text) + "',DiscountsID='" + Convert.ToInt32(comboDisId.Text) + "',Tax='" + Convert.ToInt32(txttax.Text) + "',GuestCardID='" + Convert.ToInt32(txtgcardID.Text) + "',StayDuration='" + Convert.ToInt32(txtstadur.Text) + "'WHERE RecieptID='" + Convert.ToInt32(TxtRecieptNu.Text) + "'";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                da.Fill(ds, "GuestCard");
                con.Close();
                MessageBox.Show("Successfully Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndelrec_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnreprec_Click(object sender, EventArgs e)
        {
            Form objrecrep = new RecieptReport();
            objrecrep.Show();
        }
    }
}
