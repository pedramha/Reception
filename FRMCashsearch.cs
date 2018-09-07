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
    public partial class FRMCashsearch : Form
    {
        public FRMCashsearch()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        private void FRMCashsearch_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Cash", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Cash");
            dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Cash"));
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Cash WHERE CashID='" + txtcashID.Text + "' or UserID='" + TXTuserID.Text + "'or Shift='" + ComboShiftId.Text + "'or CashAmount='" + txtamount.Text + "'", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nothing Found!!!");
                dataGridView1.DataSource = "";
                //dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Cash"));

            }
            dataGridView1.DataSource = dt;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
