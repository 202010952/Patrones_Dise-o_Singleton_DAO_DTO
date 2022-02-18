using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Data;
using System.Data.SqlClient;

namespace PatronDisenoSingleton.DAO
{
    class ConexionDBSQL
    {
        protected SqlConnection Conexion = new SqlConnection("Server=MSI/MSSQLSERVER19;DataBase=PatronesDiseno;Integrated Security=true");
    }
}
