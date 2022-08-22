using System;
using System.Collections.Generic;
using System.Text;

namespace Test_7___Clases_abstactas
{
    class ClassClientesConContacto: ClassClientesBase
    {

        public ClassClientesConContacto()
        {
            _Direccion = new ClassDirecciones();
        }

        public ClassClientesConContacto(int pId, String pNombre, String pClave, string pRFC
            , int pTipoRegimen, string pNombreContacto, string pTelefono1, string pTelefono2,
            string pEmail, string pCalle, string pNumeroExterior, string pNumeroInterior, string pColonia,
            string pMunicipio, string pEstado, string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Estado = pEstado;
            Direccion.CP = pCP;
        }


        public string Telefono1 { get; set;  }

        public string Telefono2 { get; set; }

        public string Email { get; set;  }

        public ClassDirecciones Direccion { get => _Direccion; set => _Direccion = value; }

        private ClassDirecciones _Direccion;


    }
}
