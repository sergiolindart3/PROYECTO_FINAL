using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = null;
        public List<Usuario> listUsers = null;

        public UsuarioBLL()
        {
            usuarioDAL = new UsuarioDAL();
            listUsers = usuarioDAL.ConsultarUsers();
        }

        public string GuardarUser(Usuario usuario)
        {
            if (usuario == null)
            {
                return "ERROR... No se puede Agregar Personas Nulas o sin Informacion";
            }
            var msg = usuarioDAL.GuardarUser(usuario);
            listUsers = usuarioDAL.ConsultarUsers();
            return msg;
        }

        public List<Usuario> ConsultarUsers()
        {
            return usuarioDAL.ConsultarUsers();
        }

        public bool GuardarIngreso(Ingreso ingreso, string FK)
        {
            return usuarioDAL.GuardarIngreso(ingreso, FK);
        }

        public List<Ingreso> ConsultarIngresos(string FK)
        {
            return usuarioDAL.ConsultarIngresos(FK);
        }

        public bool GuardarEgreso(Egreso egreso, string FK)
        {
            return usuarioDAL.GuardarEgreso(egreso, FK);
        }

        public List<Egreso> ConsultarEgresos(string FK)
        {
            return usuarioDAL.ConsultarEgresos(FK);
        }

        //METODO PARA VALIDAR QUE EL CORREO NO SE REPITA AL MOMENTO DE REGISTRAR
        public bool ValidarRegistroUser(string correo)
        {
            listUsers = usuarioDAL.ConsultarUsers();
            if (listUsers != null)
            {
                foreach (var usuario in listUsers)
                {
                    if (correo.Equals(usuario.correo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ActualizarSaldo(string correo, double nuevoSaldo)
        {
            usuarioDAL.ActualizarSaldo(correo, nuevoSaldo);
        }
        
        //METODO PARA VALIDAR QUE EL USUARIO EXISTA Y LE PERMITA INICIAR SESION
        public int ValidarAcceso(string correo, string clave)
        {
            listUsers = usuarioDAL.ConsultarUsers();
            if (listUsers.Count != 0)
            {
                for (int i = 0; i < listUsers.Count; i++)
                {
                    if (listUsers[i].correo.Equals(correo) && listUsers[i].clave.Equals(clave))
                    {
                        Console.WriteLine("--> USUARIO ENCONTRADO, BIENVENIDO A LA APP <--");
                        return i;
                    }
                }
            }
            return -1;
        }

        public bool CambiarContraseña(string correo, string nuevaContraseña)
        {
            return usuarioDAL.CambiarContraseña(correo, nuevaContraseña);
        }
    }
}
