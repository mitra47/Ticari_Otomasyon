using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ticari
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet8.TBL_FATURADETAY' table. You can move, or remove it, as needed.
            this.TBL_FATURADETAYTableAdapter.Fill(this.DboTicariOtomosyonDataSet8.TBL_FATURADETAY);
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet6.TBL_FATURABILGI' table. You can move, or remove it, as needed.
            this.TBL_FATURABILGITableAdapter.Fill(this.DboTicariOtomosyonDataSet6.TBL_FATURABILGI);
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet6.TBL_FATURABILGI' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet4.TBL_BANKA' table. You can move, or remove it, as needed.
            this.BankaBilgileriTableAdapter.Fill(this.DboTicariOtomosyonDataSet5.BankaBilgileri);
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet3.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtomosyonDataSet3.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet2.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtomosyonDataSet2.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DboTicariOtomosyonDataSet1.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtomosyonDataSet1.TBL_FIRMALAR);


            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
