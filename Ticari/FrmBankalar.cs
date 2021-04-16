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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Bankalarlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Execute BankaBilgileri", bgl.baglanti());
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
        void Firmalarilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }
        void Temizle()
        {
            TxtId.Text = "";
            TxtBankaAdi.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            TxtSube.Text = "";
            TxtIban.Text = "";
            TxtHesapNo.Text = "";
            TxtYetkili.Text = "";
            Msktel.Text = "";
            MskTarih.Text = "";
            TxtTuru.Text = "";
            lookUpEdit1.EditValue = "";
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Bankalarlistele();
            sehirListesi();
            Firmalarilistesi();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtBankaAdi.Text = dr["BANKADI"].ToString();
            Cmbil.Text = dr["IL"].ToString();
            Cmbilce.Text = dr["ILCE"].ToString();
            TxtSube.Text = dr["SUBE"].ToString();
            TxtIban.Text = dr["IBAN"].ToString();
            TxtHesapNo.Text = dr["HESAPNO"].ToString();
            TxtYetkili.Text = dr["YETKILI"].ToString();
            Msktel.Text = dr["TELEFON"].ToString();
            MskTarih.Text = dr["TARIH"].ToString();
            TxtTuru.Text = dr["HESAPTURU"].ToString();
            lookUpEdit1.EditValue = dr["ID"].ToString();
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKA (BANKADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", TxtIban.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", Msktel.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Banka sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bankalarlistele();
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show(TxtBankaAdi.Text + " " + TxtTuru.Text + " " + "Banka'yı" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From TBL_BANKA  where ID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtBankaAdi.Text + " " + TxtTuru.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtBankaAdi.Text + " " + TxtTuru.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                Bankalarlistele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKA set BANKADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8 ,TARIH=@P9 ,HESAPTURU=@P10 ,FIRMAID=@P11  where ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankaAdi.Text);
            komut.Parameters.AddWithValue("@P2", Cmbil.Text);
            komut.Parameters.AddWithValue("@P3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", TxtIban.Text);
            komut.Parameters.AddWithValue("@P6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P8", Msktel.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@P12", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Bankalarlistele();
            Temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
