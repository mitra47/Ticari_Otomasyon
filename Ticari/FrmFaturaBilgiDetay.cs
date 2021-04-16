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
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURADETAY where FATURAID='" + id +"'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
                TxtUrunAdi.Text = dr["URUNAD"].ToString();
                TxtMiktar.Text = dr["MIKTAR"].ToString();
                TxtFiyat.Text = dr["FIYAT"].ToString();
                TxtTutar.Text = dr["TUTAR"].ToString();
                TxtFaturaId.Text = dr["FATURAID"].ToString();
               
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  TBL_FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4,FATURAID=@P5  where FATURAURUNID=@P6", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@P2", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse( TxtFiyat.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse( TxtTutar.Text));
            komut.Parameters.AddWithValue("@P5", TxtFaturaId.Text);
            komut.Parameters.AddWithValue("@P6", TxtUrunId.Text);
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

                Secim = MessageBox.Show("Ürün = " + " " + TxtUrunAdi.Text + " " + " Miktar= " +  TxtMiktar.Text + " "  + "Faturayı" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From  TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtUrunId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtUrunAdi.Text + " " + TxtMiktar.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtUrunAdi.Text + " " + TxtMiktar.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                listele();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
