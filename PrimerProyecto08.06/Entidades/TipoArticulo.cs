using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Datos
{
    public class TipoArticulo
    {
        // Identificador único del tipo de artículo
        public int Id { get; set; }

        // Nombre del tipo de artículo
        public string Nombre { get; set; }

        // Descripción del tipo de artículo
        public string Descripcion { get; set; }

        // Constructor vacío
        public TipoArticulo() { }

        // Constructor con parámetros
        public TipoArticulo(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }

}

