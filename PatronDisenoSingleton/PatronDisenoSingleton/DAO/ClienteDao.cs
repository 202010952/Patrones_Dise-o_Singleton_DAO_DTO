using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PatronDisenoSingleton.DTO;

namespace PatronDisenoSingleton.DAO
{
    class ClienteDao:ConexionDBSQL
    {
        SqlDataReader LeerFila;
        SqlCommand Comando = new SqlCommand();
        //Metodos CRUD
        public List<ClientesDTO> VerRegistros(string Condicion) {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("Condicion",Condicion);
            //Apertura de conexion a la base de datos
            Conexion.Open();
            LeerFila = Comando.ExecuteReader();
            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();
            while (LeerFila.Read()) {
                ListaGenerica.Add(new ClientesDTO
                {
                    ID = LeerFila.GetInt32(0),
                    Nombre = LeerFila.GetString(1),
                    Apellido = LeerFila.GetString(2),
                    Direccion = LeerFila.GetString(3),
                    Ciudad = LeerFila.GetString(4),
                    Email = LeerFila.GetString(5),
                    Telefono = LeerFila.GetString(6),
                    Ocupacion = LeerFila.GetString(7),
                });
            }
            LeerFila.Close();
            Conexion.Close();
            return ListaGenerica;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}
