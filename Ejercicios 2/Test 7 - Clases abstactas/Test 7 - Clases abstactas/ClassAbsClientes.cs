using System;
using System.Collections.Generic;
using System.Text;

namespace Test_7___Clases_abstactas
{
    public abstract class ClassAbsClientes
    {
        public  abstract int Id { get; set; }

        public  abstract string  Nombre { get; set; }

        public abstract string Clave { get; set; }

        public abstract string RFC { get; set; }

        public abstract int TipoRegimen { get; set; }

        public abstract string NombreContacto { get; set; }

    }
}
