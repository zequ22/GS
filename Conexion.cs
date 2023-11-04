using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GYMSTATS
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=EZE-ASUS\\SQLEXPRESS;DATABASE=GYMSTATS;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
