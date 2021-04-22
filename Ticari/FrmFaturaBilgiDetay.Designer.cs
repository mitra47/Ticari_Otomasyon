
namespace Ticari
{
    partial class FrmFaturaBilgiDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaBilgiDetay));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.TxtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Msksaat = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSofur = new DevExpress.XtraEditors.TextEdit();
            this.TxtSevk = new DevExpress.XtraEditors.TextEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.TxtGonderen = new DevExpress.XtraEditors.TextEdit();
            this.TxtAlici = new DevExpress.XtraEditors.TextEdit();
            this.TxtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.TxtMalzeme = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrunId = new DevExpress.XtraEditors.TextEdit();
            this.TxtAt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSofur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSevk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGonderen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalzeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(933, 560);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.TxtPlaka);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Controls.Add(this.MskTarih);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.Msksaat);
            this.groupControl5.Controls.Add(this.labelControl2);
            this.groupControl5.Controls.Add(this.labelControl8);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.TxtSofur);
            this.groupControl5.Controls.Add(this.TxtSevk);
            this.groupControl5.Controls.Add(this.BtnKaydet);
            this.groupControl5.Controls.Add(this.BtnSil);
            this.groupControl5.Controls.Add(this.BtnGuncelle);
            this.groupControl5.Controls.Add(this.TxtFaturaId);
            this.groupControl5.Controls.Add(this.TxtGonderen);
            this.groupControl5.Controls.Add(this.TxtAlici);
            this.groupControl5.Controls.Add(this.TxtMiktar);
            this.groupControl5.Controls.Add(this.TxtMalzeme);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Controls.Add(this.TxtUrunId);
            this.groupControl5.Controls.Add(this.TxtAt);
            this.groupControl5.Controls.Add(this.labelControl3);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Location = new System.Drawing.Point(939, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(340, 560);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "groupControl5";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(133, 288);
            this.TxtPlaka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(134, 20);
            this.TxtPlaka.TabIndex = 59;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(70, 291);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 19);
            this.labelControl9.TabIndex = 58;
            this.labelControl9.Text = "PLAKA:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(133, 179);
            this.MskTarih.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(134, 21);
            this.MskTarih.TabIndex = 57;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(76, 179);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 19);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "TARİH:";
            // 
            // Msksaat
            // 
            this.Msksaat.Location = new System.Drawing.Point(133, 206);
            this.Msksaat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Msksaat.Mask = "00:00";
            this.Msksaat.Name = "Msksaat";
            this.Msksaat.Size = new System.Drawing.Size(134, 21);
            this.Msksaat.TabIndex = 56;
            this.Msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 208);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 19);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "SAAT:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(71, 261);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 19);
            this.labelControl8.TabIndex = 53;
            this.labelControl8.Text = "ŞOFÜR:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(81, 236);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 19);
            this.labelControl6.TabIndex = 52;
            this.labelControl6.Text = "SEVK:";
            // 
            // TxtSofur
            // 
            this.TxtSofur.Location = new System.Drawing.Point(133, 259);
            this.TxtSofur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSofur.Name = "TxtSofur";
            this.TxtSofur.Size = new System.Drawing.Size(134, 20);
            this.TxtSofur.TabIndex = 49;
            // 
            // TxtSevk
            // 
            this.TxtSevk.Location = new System.Drawing.Point(133, 233);
            this.TxtSevk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSevk.Name = "TxtSevk";
            this.TxtSevk.Size = new System.Drawing.Size(134, 20);
            this.TxtSevk.TabIndex = 48;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(133, 332);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(134, 37);
            this.BtnKaydet.TabIndex = 45;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(133, 418);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(134, 37);
            this.BtnSil.TabIndex = 44;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(133, 375);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(134, 37);
            this.BtnGuncelle.TabIndex = 43;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.Location = new System.Drawing.Point(133, 46);
            this.TxtFaturaId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Size = new System.Drawing.Size(134, 20);
            this.TxtFaturaId.TabIndex = 42;
            // 
            // TxtGonderen
            // 
            this.TxtGonderen.Location = new System.Drawing.Point(133, 153);
            this.TxtGonderen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtGonderen.Name = "TxtGonderen";
            this.TxtGonderen.Size = new System.Drawing.Size(134, 20);
            this.TxtGonderen.TabIndex = 41;
            // 
            // TxtAlici
            // 
            this.TxtAlici.Location = new System.Drawing.Point(133, 127);
            this.TxtAlici.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAlici.Name = "TxtAlici";
            this.TxtAlici.Size = new System.Drawing.Size(134, 20);
            this.TxtAlici.TabIndex = 40;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(133, 101);
            this.TxtMiktar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(134, 20);
            this.TxtMiktar.TabIndex = 39;
            // 
            // TxtMalzeme
            // 
            this.TxtMalzeme.Location = new System.Drawing.Point(133, 74);
            this.TxtMalzeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMalzeme.Name = "TxtMalzeme";
            this.TxtMalzeme.Size = new System.Drawing.Size(134, 20);
            this.TxtMalzeme.TabIndex = 38;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(41, 49);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 19);
            this.labelControl10.TabIndex = 37;
            this.labelControl10.Text = "FATURA ID:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(36, 153);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 19);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "GONDEREN:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 126);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ALICI:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(133, 20);
            this.TxtUrunId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(134, 20);
            this.TxtUrunId.TabIndex = 10;
            // 
            // TxtAt
            // 
            this.TxtAt.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAt.Appearance.Options.UseFont = true;
            this.TxtAt.Location = new System.Drawing.Point(61, 98);
            this.TxtAt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAt.Name = "TxtAt";
            this.TxtAt.Size = new System.Drawing.Size(64, 19);
            this.TxtAt.TabIndex = 4;
            this.TxtAt.Text = "MİKTAR:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(106, 23);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 19);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(47, 73);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 19);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "MALZEME:";
            // 
            // FrmFaturaBilgiDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 564);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturaBilgiDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgi Detay";
            this.Load += new System.EventHandler(this.FrmFaturaBilgiDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSofur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSevk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGonderen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalzeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.TextEdit TxtFaturaId;
        private DevExpress.XtraEditors.TextEdit TxtGonderen;
        private DevExpress.XtraEditors.TextEdit TxtAlici;
        private DevExpress.XtraEditors.TextEdit TxtMiktar;
        private DevExpress.XtraEditors.TextEdit TxtMalzeme;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtUrunId;
        private DevExpress.XtraEditors.LabelControl TxtAt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSofur;
        private DevExpress.XtraEditors.TextEdit TxtSevk;
        private DevExpress.XtraEditors.TextEdit TxtPlaka;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox Msksaat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}