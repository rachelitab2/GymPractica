using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.Login
{
   public class ServicioLogin
    {
        private readonly AccesoUsuario _accesoUsuario;

        public ServicioLogin()
        {
            _accesoUsuario = new AccesoUsuario();
        }

        public UsuariosActivos ValidarUsuarios(string usuario, string contrasena, string rol)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("El nombre de usuario es Obligatorio");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("La Contrasena es Obligatoria. ");
            }

            if (string.IsNullOrWhiteSpace(rol))
            {
                throw new ArgumentException(" El Rol es Obligatorio. ");
            }

            string rolValidado = _accesoUsuario.ValidarUsuario(usuario, contrasena, rol);

            if (rolValidado == null)
            {

                throw new UnauthorizedAccessException("Credenciales Incorrectas o rol No Autorizado.");
            }

            return new UsuariosActivos
            {
                Usuario = usuario,
                Rol = rolValidado
            };
        }
    }
}
