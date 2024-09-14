using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadesProductos
    {
        public EntidadesProductos(string Nombre, string Descripcion, double Precio)
        {
            Nombre = Nombre;
            Descripcion = Descripcion;
            Precio = Precio;
        }

        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
