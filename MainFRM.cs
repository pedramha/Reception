using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reception
{
    public partial class MainFRM : Form
    {
        public MainFRM()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objuses = new UserFRM();
            objuses.MdiParent = this;
            objuses.Show();
        }

        private void guestCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objguestcardfrm = new GuestCard();
            objguestcardfrm.MdiParent = this;
            objguestcardfrm.Show();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objusersrch = new UsersSearchFRM();
            objusersrch.MdiParent = this;
            objusersrch.Show();
        }

        private void agenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objage = new AgeFrm();
            objage.MdiParent = this;
            objage.Show();
        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objblack = new BlackFrm();
            objblack.MdiParent = this;
            objblack.Show();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objcash = new CashFrm();
            objcash.MdiParent = this;
            objcash.Show();
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objcountries = new FRMcountIns();
            objcountries.MdiParent = this;
            objcountries.Show();
        }

        private void discountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objdiscount = new DiscountFrm();
            objdiscount.MdiParent = this;
            objdiscount.Show();
        }

        private void recieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objrec = new FrmReciept();
            objrec.MdiParent = this;
            objrec.Show();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objprice = new Pricefrm();
            objprice.MdiParent = this;
            objprice.Show();
        }

        private void roomsConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objroomcond = new RmConfrm();
            objroomcond.MdiParent = this;
            objroomcond.Show();
        }

        private void roomsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objroomlist = new Rmlistfrm();
            objroomlist.MdiParent = this;
            objroomlist.Show();
        }

        private void agenciesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objageserach = new FRMagencysearch();
            objageserach.MdiParent = this;
            objageserach.Show();
        }

        private void blackListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objblacksearch = new BlackSrch();
            objblacksearch.MdiParent = this;
            objblacksearch.Show();
        }

        private void cashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objcashsearch = new FRMCashsearch();
            objcashsearch.MdiParent = this;
            objcashsearch.Show();
        }

        private void countriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objcountsearch = new CountryFrm();
            objcountsearch.MdiParent = this;
            objcountsearch.Show();
        }

        private void discountsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objdissearch = new DisFrmSrch();
            objdissearch.MdiParent = this;
            objdissearch.Show();
        }

        private void guestCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form objguestsearch = new GuestcardSrch();
            objguestsearch.MdiParent = this;
            objguestsearch.Show();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objpricesearch = new PricesFrmSrch();
            objpricesearch.MdiParent = this;
            objpricesearch.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objroomsearch = new RoomSrchFrm();
            objroomsearch.MdiParent = this;
            objroomsearch.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
