using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Datos
{
    public class Repartidor
    {
        // Identificador único del repartidor
        public int Identificacion { get; set; }

        // Nombre del repartidor
        public string Nombre { get; set; }

        // Primer apellido del repartidor
        public string PrimerApellido { get; set; }

        // Segundo apellido del repartidor
        public string SegundoApellido { get; set; }

        // Fecha de nacimiento del repartidor (solo fecha, sin hora)
        public DateTime FechaNacimiento { get; set; }

        // Fecha de contratación del repartidor (solo fecha, sin hora)
        public DateTime FechaContratacion { get; set; }

        // Constructor vacío
        public Repartidor() { }

        // Constructor con parámetros
        public Repartidor(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            FechaContratacion = fechaContratacion;
        }
    }
}
