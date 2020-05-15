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
            return 10;
        }

        private double CalcularBase()
        {            
            return 1;
        }
        private double CalcularAltura()
        {
            return 1;
        }

    }
}
