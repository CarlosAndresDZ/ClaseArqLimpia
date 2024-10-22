using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OC
{
    public interface IArea
    {
        double Area();
    }
    public class Square : IArea
    {
        public double lado { get; set; }

        public double Area() { return lado * lado; }
    }

    public class Tringle : IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area() { return (Base * Height) / 2; }
    }

    public class Rectangule : IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area() { return (Base * Height); }
    }
    public class Calculadora
    {
        public double Area (IArea obj)
        {            
            return obj.Area();
        } 


    }
}
