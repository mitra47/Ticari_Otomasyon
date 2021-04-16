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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute KategoriBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Kategorilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,K_AD From TBL_KATEGORI", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "K_AD";
            lookUpEdit1.Properties.DataSource = dt;
        }
        void Temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtMarka.Text = "";
            TxtYil.Text = "";
            TxtAdet.Text = "";
            TxtAlis.Text = "";
            TxtSatis.Text = "";
            RchDetay.Text = "";
            lookUpEdit1.EditValue = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            Kategorilistesi();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,YIL,ADET,ALISFIYAT,SATISFIYATI,DETAY,KATEGORI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtYil.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(TxtAdet.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p7", RchDetay.Text);
            komut.Parameters.AddWithValue("@p8", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
          
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show(TxtAd.Text + " " + TxtAdet.Text + " " + "Ürünü" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From  TBL_URUNLER where ID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtAd.Text + " " + TxtAdet.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtAd.Text + " " + TxtAdet.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                listele();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtYil.Text = dr["YIL"].ToString();
            TxtAdet.Text = dr["ADET"].ToString();
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            TxtSatis.Text = dr["SATISFIYATI"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
            lookUpEdit1.EditValue = dr["K_AD"].ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,YIL=@P3,ADET=@P4,ALISFIYAT=@P5,SATISFIYATI=@P6,DETAY=@P7,KATEGORI=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtYil.Text);
            komut.Parameters.AddWithValue("@P4", int.Parse(TxtAdet.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@P7", RchDetay.Text);
            komut.Parameters.AddWithValue("@P8", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@P9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
            Temizle();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
