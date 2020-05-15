using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Para copiar una línea no es necesario seleccionar toda la sección.
            Persona persona = new Persona { PersonaID = 1, Edad=21, Apellidos = "Torrico", Nombres = "Marquez" };
            Persona persona2 = new Persona { PersonaID = 2,Edad=14, Apellidos = "Torrico2", Nombres = "Marquez2" };
            Persona persona3 = new Persona { PersonaID = 3,Edad=12, Apellidos = "Torrico3", Nombres = "Marquez3" };


            



            List<Persona> personas = new List<Persona>();
            personas.Add(persona);
            personas.Add(persona2);
            personas.Add(persona3);


            //Atajo de comentar código
            //1. Seleccionar texto a comentar
            //2.crtl+K + c



            //Mostrar dentro de un foreach                               
            foreach (var item in personas)
            {
                Console.WriteLine(string.Concat( "PersonaID: " , item.PersonaID));
                Console.WriteLine(string.Concat("Nombres: ", item.Nombres));
                Console.WriteLine(string.Concat("Apellidos: ", item.Apellidos));
                Console.WriteLine(string.Concat("Mensaje: ", item.CalcularMayoriaEdad()));

                //Ejecuta Sentencias
                item.ConcatenarNombresApellidos();
                item.SubirEdad(5);

                Console.WriteLine(string.Concat("NombresCompletos: ", item.NombresCompletos));
                Console.WriteLine(string.Concat("Edad Subida: ", item.Edad));


                Console.WriteLine("=======================");
            }


            //Mostrar objeto por objeto
            Console.WriteLine("Primera Persona");
            Console.WriteLine(string.Concat("Nombres: ", persona.Nombres));
            Console.WriteLine(string.Concat("Apellidos: ", persona.Apellidos));
            Console.WriteLine("=======================");
            Console.WriteLine("Segunda Persona");
            Console.WriteLine(string.Concat("Nombres: ", persona2.Nombres));
            Console.WriteLine(string.Concat("Apellidos: ", persona2.Apellidos));
            Console.WriteLine("=======================");
            Console.WriteLine("Tercera Persona");
            Console.WriteLine(string.Concat("Nombres: ", persona3.Nombres));
            Console.WriteLine(string.Concat("Apellidos: ", persona3.Apellidos));

            Console.WriteLine("Hola mundo");
            Console.Read();

        }
    }
}
