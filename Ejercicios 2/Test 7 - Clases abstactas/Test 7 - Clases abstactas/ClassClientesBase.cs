using System;
using System.Collections.Generic;
using System.Text;

namespace Test_7___Clases_abstactas
{
    public class ClassClientesBase : ClassAbsClientes

    {

        public ClassClientesBase()
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty; 
        }

        public ClassClientesBase(int pId, string pNombre, string pClave, string pRFC, int PTipoRegimen, String pNombreContacto)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = PTipoRegimen;
            NombreContacto = pNombreContacto;

        }

        public override int Id { get; set; }

        public override string Nombre { get; set; }

        public override string Clave { get; set; }

        public override string RFC { get; set; }

        public override int TipoRegimen { get; set; }

        public override string NombreContacto { get; set; }

    }
}
