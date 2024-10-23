using Xunit;
using UserManagement.Models;
using UserManagement.Services;
using System.Security.Cryptography.X509Certificates;

namespace UserManagement.Tests
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void InserUserTest() { 
            //Arranque
            var servicio = new UsuarioService();
            var usuario = new Usuario(1, "edgar", "ed@gmail.com");
            //Accion
            servicio.CrearUsuario(usuario);
            var result=servicio.ObtenerUsuarioPorId(usuario.Id);
            //Asercion
            Assert.NotNull(result);
            Assert.Equal(usuario, result);

        }
    }
}