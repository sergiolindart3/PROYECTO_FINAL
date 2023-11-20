using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDALBD : ConexionDB
    {
        public string GuardarUser(Usuario usuario)
        {
            OracleConnection sqlConexion = new OracleConnection();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarUser", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("name", OracleDbType.Varchar2).Value = usuario.name;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = usuario.correo;
                comando.Parameters.Add("clave", OracleDbType.Varchar2).Value = usuario.clave;
                comando.Parameters.Add("saldo", OracleDbType.Decimal).Value = usuario.saldo;
                sqlConexion.Open();
                comando.ExecuteReader();
                return $"--> Usuario {usuario.name} Registrado Correctamente <--";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public List<Usuario> ConsultarUsers()
        {
            OracleDataReader reader;
            OracleConnection sqlConexion = new OracleConnection();
            List<Usuario> listaUsers = new List<Usuario>();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_ConsultarUsers", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlConexion.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaUsers.Add(Map(reader));
                }
                return listaUsers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        //public List<Ingreso> ConsultarIngresos(int pos)
        //{
            
        //}

        //public List<Egreso> ConsultarEgresos(int pos)
        //{

        //}

        public void ActualizarSaldo(string correo, double nuevoSaldo)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_ActualizarSaldo", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("u_correo", OracleDbType.Varchar2).Value = correo;
                comando.Parameters.Add("u_nuevoSaldo", OracleDbType.Double).Value = nuevoSaldo;

                sqlCon.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public bool CambiarContraseña(string correo, string nuevaContraseña)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_CambiarEstadoTarea", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("u_correo", OracleDbType.Int32).Value = correo;
                comando.Parameters.Add("u_nuevaContraseña", OracleDbType.Varchar2).Value = nuevaContraseña;

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        private Usuario Map(OracleDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.name = Convert.ToString(reader["name"]);
            usuario.correo = Convert.ToString(reader["correo"]);
            usuario.clave = Convert.ToString(reader["clave"]);
            usuario.saldo = Convert.ToDouble(reader["saldo"]);

            return usuario;
        }

        private Ingreso MapIngresos(OracleDataReader reader)
        {
            Ingreso ingreso = new Ingreso();

            usuario.name = Convert.ToString(reader["name"]);
            usuario.correo = Convert.ToString(reader["correo"]);
            usuario.clave = Convert.ToString(reader["clave"]);
            usuario.saldo = Convert.ToDouble(reader["saldo"]);

            return usuario;
        }
    }
}
