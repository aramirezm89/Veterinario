using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Veterinario
{
    class ClsBDDatos
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=LEONOVO-LEGION-\SQLEXPRESS;Initial Catalog=VETERINARIA;
                                                      user id = sa; password = 123;
                                                      Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection AbrirConex()
        {
            cnn.Open();
            return cnn;
        }

        public SqlConnection CerrarConex()
        {
            cnn.Close();
            return cnn;
        }
    }
}
