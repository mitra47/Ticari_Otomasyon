using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using System.Data.SqlClient;

namespace Ticari
{
    public partial class FrmPrint : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmPrint()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
       
        private void FrmPrint_Load(object sender, EventArgs e)
        {

        }

       
    }
}