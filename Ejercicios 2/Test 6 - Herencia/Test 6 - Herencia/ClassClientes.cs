using System;
using System.Collections.Generic;
using System.Text;

namespace Test_6___Herencia
{
    class ClassClientes
    {

        //se declaran las propiedrades de la clase cliente

        //el id del cliente para identificarlo con un numero
        private int idCliente;
        // el nombre
        private string _Nombres;
        // los apellidos
        private string _Apellidos;
        // su cedula
        private string _CC;
        // su dirección
        private string _Direccion;
        //su municipio
        private string _Municipio;
        //si tiene crédito o no
        private bool _EsCredito;

        //se declara el tipo de dato y su devolución
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string CC { get => _CC; set => _CC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}
