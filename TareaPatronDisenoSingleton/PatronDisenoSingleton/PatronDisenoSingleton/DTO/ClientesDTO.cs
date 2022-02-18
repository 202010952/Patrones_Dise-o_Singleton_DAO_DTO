using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDisenoSingleton.DTO
{
    class ClientesDTO
    {
        //Atributos
        int _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;
        //Propiedades
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
        
    }
}
