using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    class Persona
    {
        public int PersonaID { get; set; }

        public string Apellidos { get; set; }

        public string Nombres { get; set; }

        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        public string CalcularMayoriaEdad()
        {
            string mensaje = "Menor Edad";
            if (Edad>=18)
                mensaje = "Mayor Edad";
            return mensaje;
        }

        public void ConcatenarNombresApellidos()
        {
            NombresCompletos = string.Concat(Nombres, " ", Apellidos);
        }

        public void SubirEdad(int anios)
        {
            Edad = Edad + anios;
        }


    }
}
