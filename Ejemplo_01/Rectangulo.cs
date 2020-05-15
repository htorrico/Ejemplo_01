using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    class Rectangulo
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
        public Punto punto4 { get; set; }
        
        public double CalcularArea()
        {
            double base_,altura;
            base_ = CalcularBase();
            altura = CalcularAltura();
            return base_ * altura;
        }
        public double CalcularPerimetro()
        {
            double base_, altura;
            base_ = CalcularBase();
            altura = CalcularAltura();
            return (base_ + altura) * 2;
        }

        private double CalcularBase()
        {            
            return CalcularDistancia(punto1,punto2);
        }
        private double CalcularAltura()
        {
            return CalcularDistancia(punto2,punto3);
        }
        private double CalcularDistancia(Punto punto1,Punto punto2)
        {
            return Math.Sqrt(Math.Pow((double)(punto2.Y - punto1.Y), 2) + 
                            Math.Pow((double)(punto2.X - punto1.X), 2));
        }

    }
}
