
namespace Ticari
{
    partial class Irsaliye
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Irsaliye));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.BtnYazdır = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLFATURADETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboTicariOtomosyonDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboTicariOtomosyonDataSet9 = new Ticari.DboTicariOtomosyonDataSet9();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFATURAURUNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALZEME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGONDEREN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEVK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOFUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbL_FATURADETAYTableAdapter1 = new Ticari.DboTicariOtomosyonDataSet8TableAdapters.TBL_FATURADETAYTableAdapter();
            this.tBL_FATURADETAYTableAdapter = new Ticari.DboTicariOtomosyonDataSet9TableAdapters.TBL_FATURADETAYTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomosyonDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomosyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BtnYazdır);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gridControl1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(799, 461);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(799, 461);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // BtnYazdır
            // 
            this.BtnYazdır.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYazdır.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnYazdır.Appearance.Options.UseFont = true;
            this.BtnYazdır.Appearance.Options.UseForeColor = true;
            this.BtnYazdır.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYazdır.ImageOptions.Image")));
            this.BtnYazdır.Location = new System.Drawing.Point(671, 420);
            this.BtnYazdır.Name = "BtnYazdır";
            this.BtnYazdır.Size = new System.Drawing.Size(128, 41);
            this.BtnYazdır.TabIndex = 2;
            this.BtnYazdır.Text = "YAZDIR";
            this.BtnYazdır.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLFATURADETAYBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(799, 423);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLFATURADETAYBindingSource
            // 
            this.tBLFATURADETAYBindingSource.DataMember = "TBL_FATURADETAY";
            this.tBLFATURADETAYBindingSource.DataSource = this.dboTicariOtomosyonDataSet9BindingSource;
            // 
            // dboTicariOtomosyonDataSet9BindingSource
            // 
            this.dboTicariOtomosyonDataSet9BindingSource.DataSource = this.dboTicariOtomosyonDataSet9;
            this.dboTicariOtomosyonDataSet9BindingSource.Position = 0;
            // 
            // dboTicariOtomosyonDataSet9
            // 
            this.dboTicariOtomosyonDataSet9.DataSetName = "DboTicariOtomosyonDataSet9";
            this.dboTicariOtomosyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFATURAURUNID,
            this.colFATURAID,
            this.colMALZEME,
            this.colMIKTAR,
            this.colALICI,
            this.colGONDEREN,
            this.colTARIHI,
            this.colSAAT,
            this.colSEVK,
            this.colSOFUR,
            this.colPLAKA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colFATURAURUNID
            // 
            this.colFATURAURUNID.FieldName = "FATURAURUNID";
            this.colFATURAURUNID.Name = "colFATURAURUNID";
            this.colFATURAURUNID.Visible = true;
            this.colFATURAURUNID.VisibleIndex = 0;
            // 
            // colFATURAID
            // 
            this.colFATURAID.FieldName = "FATURAID";
            this.colFATURAID.Name = "colFATURAID";
            this.colFATURAID.Visible = true;
            this.colFATURAID.VisibleIndex = 1;
            // 
            // colMALZEME
            // 
            this.colMALZEME.FieldName = "MALZEME";
            this.colMALZEME.Name = "colMALZEME";
            this.colMALZEME.Visible = true;
            this.colMALZEME.VisibleIndex = 2;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 3;
            // 
            // colALICI
            // 
            this.colALICI.FieldName = "ALICI";
            this.colALICI.Name = "colALICI";
            this.colALICI.Visible = true;
            this.colALICI.VisibleIndex = 4;
            // 
            // colGONDEREN
            // 
            this.colGONDEREN.FieldName = "GONDEREN";
            this.colGONDEREN.Name = "colGONDEREN";
            this.colGONDEREN.Visible = true;
            this.colGONDEREN.VisibleIndex = 5;
            // 
            // colTARIHI
            // 
            this.colTARIHI.FieldName = "TARIHI";
            this.colTARIHI.Name = "colTARIHI";
            this.colTARIHI.Visible = true;
            this.colTARIHI.VisibleIndex = 6;
            // 
            // colSAAT
            // 
            this.colSAAT.FieldName = "SAAT";
            this.colSAAT.Name = "colSAAT";
            this.colSAAT.Visible = true;
            this.colSAAT.VisibleIndex = 7;
            // 
            // colSEVK
            // 
            this.colSEVK.FieldName = "SEVK";
            this.colSEVK.Name = "colSEVK";
            this.colSEVK.Visible = true;
            this.colSEVK.VisibleIndex = 8;
            // 
            // colSOFUR
            // 
            this.colSOFUR.FieldName = "SOFUR";
            this.colSOFUR.Name = "colSOFUR";
            this.colSOFUR.Visible = true;
            this.colSOFUR.VisibleIndex = 9;
            // 
            // colPLAKA
            // 
            this.colPLAKA.FieldName = "PLAKA";
            this.colPLAKA.Name = "colPLAKA";
            this.colPLAKA.Visible = true;
            this.colPLAKA.VisibleIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbL_FATURADETAYTableAdapter1
            // 
            this.tbL_FATURADETAYTableAdapter1.ClearBeforeFill = true;
            // 
            // tBL_FATURADETAYTableAdapter
            // 
            this.tBL_FATURADETAYTableAdapter.ClearBeforeFill = true;
            // 
            // Irsaliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Irsaliye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irsaliye";
            this.Load += new System.EventHandler(this.Irsaliye_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomosyonDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomosyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DboTicariOtomosyonDataSet8TableAdapters.TBL_FATURADETAYTableAdapter tbL_FATURADETAYTableAdapter1;
        private System.Windows.Forms.BindingSource dboTicariOtomosyonDataSet9BindingSource;
        private DboTicariOtomosyonDataSet9 dboTicariOtomosyonDataSet9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tBLFATURADETAYBindingSource;
        private DboTicariOtomosyonDataSet9TableAdapters.TBL_FATURADETAYTableAdapter tBL_FATURADETAYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAURUNID;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAID;
        private DevExpress.XtraGrid.Columns.GridColumn colMALZEME;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colALICI;
        private DevExpress.XtraGrid.Columns.GridColumn colGONDEREN;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSAAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSEVK;
        private DevExpress.XtraGrid.Columns.GridColumn colSOFUR;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAKA;
        private DevExpress.XtraEditors.SimpleButton BtnYazdır;
    }
}