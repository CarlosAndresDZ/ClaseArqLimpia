using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LS
{
    public interface IVolar
    {
        void volar();
    }
    public interface INadar
    {
        void nadar();
    }
    public interface ICorrer
    {
        void correr();
    }



    public class Pinguino() : ICorrer, INadar
    {
        public void correr()
        {
            Console.WriteLine("corre chistoso!!");
        }
        public void nadar()
        {
            Console.WriteLine("si nada muy rapido!!");
        }
    }
    public class Paloma : IVolar, ICorrer
    {
        public void correr()
        {
            Console.WriteLine("si corre !!");
        }
        public void volar()
        {
            Console.WriteLine("si vuela!!");
        }
    }

    public class Eagle : IVolar, ICorrer
    {
        public void correr()
        {
            Console.WriteLine("si corre !!");
        }
        public void volar()
        {
            Console.WriteLine("si vuela!!");
        }
    }

    public class AdminAve
    {
        private List<IVolar> voladores = new List<IVolar>();

        public bool InsertVolador(IVolar ave)
        {
           voladores.Add(ave);
            return true;
        }

    }
}
