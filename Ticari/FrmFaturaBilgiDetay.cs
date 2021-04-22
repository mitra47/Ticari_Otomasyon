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
    public partial class FrmFaturaBilgiDetay : Form
    {
        public FrmFaturaBilgiDetay()
        {
            InitializeComponent();
        }
        public string id;
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURADETAY where FATURAID='" + id + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtUrunId.Text = "";
            TxtFaturaId.Text = "";
            TxtMalzeme.Text = "";
            TxtMiktar.Text = "";
            TxtAlici.Text = "";
            TxtGonderen.Text = "";
            MskTarih.Text = "";
            Msksaat.Text = "";
            TxtSevk.Text = "";
            TxtSofur.Text = "";
            TxtPlaka.Text = "";
        }
        private void FrmFaturaBilgiDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtUrunId.Text = dr["FATURAURUNID"].ToString();
                TxtFaturaId.Text = dr["FATURAID"].ToString();
                TxtMalzeme.Text = dr["MALZEME"].ToString();
                TxtMiktar.Text = dr["MIKTAR"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtGonderen.Text = dr["GONDEREN"].ToString();
                MskTarih.Text = dr["TARIHI"].ToString();
                Msksaat.Text = dr["SAAT"].ToString();
                TxtSevk.Text = dr["SEVK"].ToString();
                TxtSofur.Text = dr["SOFUR"].ToString();
                TxtPlaka.Text = dr["PLAKA"].ToString();


            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("insert into TBL_FATURADETAY (FATURAID,MALZEME,MIKTAR,ALICI,GONDEREN,TARIHI,SAAT,SEVK,SOFUR,PLAKA) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtFaturaId.Text);
            komut.Parameters.AddWithValue("@p2", TxtMalzeme.Text);
            komut.Parameters.AddWithValue("@p3", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@p4", TxtAlici.Text);
            komut.Parameters.AddWithValue("@p5", TxtGonderen.Text);
            komut.Parameters.AddWithValue("@p6", MskTarih.Text);
            komut.Parameters.AddWithValue("@p7", Msksaat.Text);
            komut.Parameters.AddWithValue("@p8", TxtSevk.Text);
            komut.Parameters.AddWithValue("@p9", TxtSofur.Text);
            komut.Parameters.AddWithValue("@p10", TxtPlaka.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Faturaya ait Ürün Kaydelildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  TBL_FATURADETAY set FATURAID=@P1,MALZEME=@P2,MIKTAR=@P3,ALICI=@P4,GONDEREN=@P5,TARIHI=@P6,SAAT=@P7,SEVK=@P8,SOFUR=@P9,PLAKA=@P10 where FATURAURUNID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtFaturaId.Text);
            komut.Parameters.AddWithValue("@P2", TxtMalzeme.Text);
            komut.Parameters.AddWithValue("@P3", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P4", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P5", TxtGonderen.Text);
            komut.Parameters.AddWithValue("@P6", MskTarih.Text);
            komut.Parameters.AddWithValue("@P7", Msksaat.Text);
            komut.Parameters.AddWithValue("@P8", TxtSevk.Text);
            komut.Parameters.AddWithValue("@P9", TxtSofur.Text);
            komut.Parameters.AddWithValue("@P10", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@P11", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show("Ürün = " + " " + TxtMalzeme.Text + " " + " Miktar= " + TxtMiktar.Text + " " + "Faturayı" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From  TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtUrunId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtMalzeme.Text + " " + TxtMiktar.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtMalzeme.Text + " " + TxtMiktar.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                listele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            Irsaliye fr = new Irsaliye();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin1 = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
