using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IS
{
    public interface ICommons
    {
        void EntrarAReuniones();
        void Registro();
    }
    public interface IDevelop
    {
        void Desarrollar();
        void EjecutaTest();
    }
    public interface IGerente
    {
        void Gerenciar();
    }
    public interface IFinanzas
    {
        void AdministrarFacturas();
    }
   

    public class Developer : ICommons, IDevelop
    {
        void Desarrollar()
        {
            throw new NotImplementedException();
        }
        void EjecutaTest()
        {
            throw new NotImplementedException();
        }
        void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }
    }

    public class Venta : ICommons
    {
        void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }
        void Registro()
        {
            throw new NotImplementedException();
        }
    }


    public class Developer : IFunciones
    {
        void Desarrollar() {
            throw new NotImplementedException();
        }
        void Gerenciar() {
            throw new NotImplementedException();
        }
        void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }
        void AdministrarFacturas()
        {
            throw new NotImplementedException();
        }
        void Registro()
        {
            throw new NotImplementedException();
        }
    }
    public class Empresa
    {

    }
}
