﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraCharts;


namespace Ticari
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboTicariOtomosyonDataSet7.StokDurumu' table. You can move, or remove it, as needed.
            

            

            SqlDataAdapter da = new SqlDataAdapter(" Select URUNAD,sum(ADET) As 'Miktar' from TBL_URUNLER group by URUNAD", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            SqlCommand komut= new SqlCommand(" Select URUNAD,sum(ADET) As 'Miktar' from TBL_URUNLER group by URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));

            }
            bgl.baglanti().Close();
        }

        
    }
}
