using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Ticari
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public void InitData(string faturaurnid,string malzeme,string miktar,string alici , string gonderen, DateTime tarih, DateTime saat,string sevk , string sofur,string plaka ,List<DboTicariOtomosyonDataSet9> data)
        {
            pId.Value = faturaurnid;
            pMalzeme.Value = malzeme;
            pMiktar.Value = miktar;
            pAlici.Value = alici;
            pGonderen.Value = gonderen;
            pTarih.Value = tarih.Date;
            pSaat.Value = saat.Date;
            pSevk.Value = sevk;
            pSofur.Value = sofur;
            pPlaka.Value = plaka;
            objectDataSource1.DataSource = data;
        }
    }

   
}
