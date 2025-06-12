using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Datos
{

        public class Cliente
        {
            // Identificador único del cliente
            public int Identificacion { get; set; }

            // Nombre del cliente
            public string Nombre { get; set; }

            // Primer apellido del cliente
            public string PrimerApellido { get; set; }

            // Segundo apellido del cliente
            public string SegundoApellido { get; set; }

            // Fecha de nacimiento del cliente (solo fecha, sin hora)
            public DateTime FechaNacimiento { get; set; }

            // Estado del cliente: true = activo, false = inactivo
            public bool Activo { get; set; }

            // Constructor vacío
            public Cliente() { }

            // Constructor con parámetros
            public Cliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool activo)
            {
                Identificacion = identificacion;
                Nombre = nombre;
                PrimerApellido = primerApellido;
                SegundoApellido = segundoApellido;
                FechaNacimiento = fechaNacimiento;
                Activo = activo;
            }

        }
}
