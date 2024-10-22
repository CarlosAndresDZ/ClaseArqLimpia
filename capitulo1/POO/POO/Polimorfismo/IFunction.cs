using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    public interface IFunction
    {
        void Insertar();
        void Saludar(string mensaje);        
    }

    public class Impl1 : IFunction {
        public void Insertar()
        {
            //throw new NotImplementedException();
            Console.WriteLine("implementacion 1");
        }
        public void Insertar(int dato)
        {
            Console.WriteLine("implementacion 2");
        }

        public void Saludar(string mensaje)
        {
            Console.WriteLine("implementacion 1");
        }
    } 
}
