using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        FrmUrunler fr;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }

        }
        FrmMusteriler frm;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null)
            {
                frm = new FrmMusteriler();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        FrmFirmalar frf;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frf == null)
            {
                frf = new FrmFirmalar();
                frf.MdiParent = this;
                frf.Show();
            }
        }
        FrmPersoneller frp;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frp == null)
            {
                frp = new FrmPersoneller();
                frp.MdiParent = this;
                frp.Show();
            }
        }
        FrmRehber frr;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr == null)
            {
                frr = new FrmRehber();
                frr.MdiParent = this;
                frr.Show();
            }
        }
        FrmGiderler Frmg;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frmg == null)
            {
                Frmg = new FrmGiderler();
                Frmg.MdiParent = this;
                Frmg.Show();
            }
        }
        FrmBankalar Frmb;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frmb == null)
            {
                Frmb = new FrmBankalar();
                Frmb.MdiParent = this;
                Frmb.Show();
            }
        }
        FrmFaturalar FrmF;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmF == null)
            {
                FrmF = new FrmFaturalar();
                FrmF.MdiParent = this;
                FrmF.Show();
            }
        }
    }
}
