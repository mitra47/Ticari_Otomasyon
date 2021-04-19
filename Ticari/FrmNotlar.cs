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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            TxtId.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtBaslik.Text = "";
            TxtDetay.Text = "";
            RchIcerik.Text = "";
            TxtOlusturan.Text = "";
          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //if (dr ! = null)

            TxtId.Text = dr["ID"].ToString();
            MskTarih.Text = dr["TARIH"].ToString();
            MskSaat.Text = dr["SAAT"].ToString();
            TxtBaslik.Text = dr["BASLIK"].ToString();
            TxtDetay.Text = dr["DETAY"].ToString();
            RchIcerik.Text = dr["ICERIK"].ToString();
            TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
           
        }


        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR(TARIH,SAAT,BASLIK,DETAY,ICERIK,OLUSTURAN) values (@p1,@p2,@p3,@p4,@p5,@p6)",
              bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", TxtDetay.Text);
            komut.Parameters.AddWithValue("@p5", RchIcerik.Text);
            komut.Parameters.AddWithValue("@p6", TxtOlusturan.Text);
           

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Not sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show(TxtBaslik.Text + " " + TxtOlusturan.Text + " " + "Notu" + "  " + "silmeyi Onaylıyor musunuz_?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From  TBL_NOTLAR where ID=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(" " + "Sistemden Silindi...", TxtBaslik.Text + " " + TxtOlusturan.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Secim == DialogResult.No)
                {
                    MessageBox.Show(" " + "Silme işlemi İptal edilmiştir....", TxtBaslik.Text + " " + TxtOlusturan.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();

                listele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,ICERIK=@P5,OLUSTURAN=@P6  where ID=@P7", bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", MskTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", TxtDetay.Text);
            komut.Parameters.AddWithValue("@P5", RchIcerik.Text);
            komut.Parameters.AddWithValue("@P6", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P7", TxtId.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Not Güncenllendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
             FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin = dr["ICERIK"].ToString();
            }
            fr.Show();
        }
    }
}
