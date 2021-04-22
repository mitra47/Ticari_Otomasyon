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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Faturalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void Temizle()
        {
            TxtId.Text = "";
            TxtSeriNo.Text = "";
            TxtSıraNo.Text = "";
            MskTarih.Text = "";
            Msksaat.Text = "";
            TxtVergi.Text = "";
            TxtAlici.Text = "";
            TxtCinsi.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            TxtVKN.Text = "";
            TxtMiktar.Text = "";
            TxtTutar.Text = "";
            TxtFiyat.Text = "";
            TxtToplam.Text = "";
            TxtKdv.Text = "";
            TxtGToplam.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Faturalistele();
            sehirListesi();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,ALICI,IL,ILCE,VERGIDAIRE,VKN,CINSI,MIKTARI,FIYATI,TUTAR,TOPLAM,KDV,GENEL_TOPLAM) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtSeriNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtSıraNo.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", Msksaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtAlici.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p9", TxtVKN.Text);
            komut.Parameters.AddWithValue("@p10", TxtCinsi.Text);
            komut.Parameters.AddWithValue("@p11", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@p12", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p13", TxtTutar.Text);
            komut.Parameters.AddWithValue("@p14", TxtToplam.Text);
            komut.Parameters.AddWithValue("@p15", decimal.Parse(TxtKdv.Text));
            komut.Parameters.AddWithValue("@p16", TxtGToplam.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Fatura Bilgisi sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Faturalistele();
            Temizle();


            //else
            //{
            //    double miktar, tutar, fiyat;
            //    fiyat = Convert.ToDouble(TxtFiyat.Text);
            //    miktar = Convert.ToDouble(TxtMiktar.Text);
            //    tutar = miktar * fiyat;
            //    TxtTutar.Text = tutar.ToString();
            //    SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            //    komut2.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            //    komut2.Parameters.AddWithValue("@p2", TxtMiktar.Text);
            //    komut2.Parameters.AddWithValue("@p3", TxtFiyat.Text);
            //    komut2.Parameters.AddWithValue("@p4", TxtTutar.Text);
            //    komut2.Parameters.AddWithValue("@p5", TxtToplam.Text);

            //    komut2.ExecuteNonQuery();
            //    bgl.baglanti().Close();

            //    MessageBox.Show("Faturaya ait Ürün Kaydelildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Faturalistele();
            //    Temizle();
            //}
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["FATURABILGIID"].ToString();
                TxtSeriNo.Text = dr["SERI"].ToString();
                TxtSıraNo.Text = dr["SIRANO"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                Msksaat.Text = dr["SAAT"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
                TxtVKN.Text = dr["VKN"].ToString();
                TxtCinsi.Text = dr["CINSI"].ToString();
                TxtMiktar.Text = dr["MIKTARI"].ToString();
                TxtFiyat.Text = dr["FIYATI"].ToString();
                TxtTutar.Text = dr["TUTAR"].ToString();
                TxtToplam.Text = dr["TOPLAM"].ToString();
                TxtKdv.Text = dr["KDV"].ToString();
                TxtGToplam.Text = dr["GENEL_TOPLAM"].ToString();

            }

        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaBilgiDetay fr = new FrmFaturaBilgiDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From TBL_ILCELER  where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show(TxtCinsi.Text + " " + TxtAlici.Text + " " + "Faturayı" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From  TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtCinsi.Text + " " + TxtAlici.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtCinsi.Text + " " + TxtAlici.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                Faturalistele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update  TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,ALICI=@P5,IL=@P6,ILCE=@P7,VERGIDAIRE=@P8,VKN=@P9,CINSI=@P10,MIKTARI=@P11,FIYATI=@P12,TUTAR=@P13,TOPLAM=@P14,KDV=@P15,GENEL_TOPLAM=@P16 where FATURABILGIID=@P17", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtSeriNo.Text);
            komut.Parameters.AddWithValue("@P2", TxtSıraNo.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", Msksaat.Text);
            komut.Parameters.AddWithValue("@P5", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P6", Cmbil.Text);
            komut.Parameters.AddWithValue("@P7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@P8", TxtVergi.Text);
            komut.Parameters.AddWithValue("@P9", TxtVKN.Text);
            komut.Parameters.AddWithValue("@P10", TxtCinsi.Text);
            komut.Parameters.AddWithValue("@P11", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P12", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@P13", TxtTutar.Text);
            komut.Parameters.AddWithValue("@P14", TxtToplam.Text);
            komut.Parameters.AddWithValue("@P15", TxtKdv.Text);
            komut.Parameters.AddWithValue("@P16", TxtGToplam.Text);
            komut.Parameters.AddWithValue("@P17", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Faturalistele();
            Temizle();
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
