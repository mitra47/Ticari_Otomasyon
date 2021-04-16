using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ticari
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=DboTicariOtomosyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
