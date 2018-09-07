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
    public partial class RoomSrchFrm : Form
    {
        public RoomSrchFrm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=PEDRAM-PC;Initial Catalog=ProjectREC;Integrated Security=True");
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private void RoomSrchFrm_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Rooms", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Rooms");
            dataGridView1.DataBindings.Add(new Binding("DataSource", ds, "Rooms"));
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Rooms WHERE  RoomNumber='" + Convert.ToInt32(txtrmnumb.Text) + "'or RoomType='" + txttype.Text + "' or SituationNumber='" + txtsitnmb.Text + "'or RoomPrice='" + txtprice.Text + "'", con);
                cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nothing Found!!!");
                    dataGridView1.DataSource = "";
                }
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
