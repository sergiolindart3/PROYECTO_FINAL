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
    public class UsuarioDAL : ConexionDB
    {

        //METODO GUARDAR USUARIO EN LA BASE DE DATOS
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
                comando.Parameters.Add("saldo", OracleDbType.Double).Value = usuario.saldo;
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

        //METODO CONSULTAR USUARIO EN LA BASE DE DATOS
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

        //METODO GUARDAR INGRESO EN LA BASE DE DATOS
        public bool GuardarIngreso(Ingreso ingreso, string FK)
        {
            OracleConnection sqlConexion = new OracleConnection();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarIngreso", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("ingreso", OracleDbType.Double).Value = ingreso.ingreso;
                comando.Parameters.Add("asunto", OracleDbType.Varchar2).Value = ingreso.asunto;
                comando.Parameters.Add("frecuencia", OracleDbType.Double).Value = ingreso.frecuencia;
                comando.Parameters.Add("fecha", OracleDbType.Date).Value = ingreso.fechaInicio;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = FK;
                sqlConexion.Open();
                comando.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        //METODO CONSULTAR INGRESOS EN LA BASE DE DATOS
        public List<Ingreso> ConsultarIngresos(string FK)
        {
            OracleDataReader reader;
            OracleConnection sqlConexion = new OracleConnection();
            List<Ingreso> listIngresos = new List<Ingreso>();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_ConsultarIngresos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("FK", OracleDbType.Varchar2)).Value = FK;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlConexion.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listIngresos.Add(MapIngreso(reader));
                }
                return listIngresos;
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

        //METODO GUARDAR EGRESO EN LA BASE DE DATOS
        public bool GuardarEgreso(Egreso egreso, string FK)
        {
            OracleConnection sqlConexion = new OracleConnection();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarEgreso", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("egreso", OracleDbType.Double).Value = egreso.egreso;
                comando.Parameters.Add("asunto", OracleDbType.Varchar2).Value = egreso.asunto;
                comando.Parameters.Add("frecuencia", OracleDbType.Double).Value = egreso.frecuencia;
                comando.Parameters.Add("fecha", OracleDbType.Date).Value = egreso.fechaInicio;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = FK;
                sqlConexion.Open();
                comando.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        //METODO CONSULTAR EGRESOS EN LA BASE DE DATOS
        public List<Egreso> ConsultarEgresos(string FK)
        {
            OracleDataReader reader;
            OracleConnection sqlConexion = new OracleConnection();
            List<Egreso> listEgresos = new List<Egreso>();
            try
            {
                sqlConexion = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_ConsultarEgresos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("FK", OracleDbType.Varchar2)).Value = FK;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlConexion.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEgresos.Add(MapEgreso(reader));
                }
                return listEgresos;
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

        //ACTUALIZA EL SALDO DEL USUARIO AL MOMENTO DE INSERTAR INGRESOS Y EGRESOS EN LA BASE DE DATOS
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

        //METODO PARA CAMBIAR LA CONTRASEÑA DEL USUARIO 
        public bool CambiarContraseña(string correo, string nuevaContraseña)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_CambiarContraseña", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("u_correo", OracleDbType.Varchar2).Value = correo;
                comando.Parameters.Add("u_nuevaClave", OracleDbType.Varchar2).Value = nuevaContraseña;

                sqlCon.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        //METODOS PARA TRANSFORMAR LOS DATOS DE UNA LECTURA DE BASE DE DATOS ORACLE EN ATRIBUTOS ESPECIFICOS DE LOS OBJETOS
        public Usuario Map(OracleDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.name = Convert.ToString(reader["name"]);
            usuario.correo = Convert.ToString(reader["correo"]);
            usuario.clave = Convert.ToString(reader["clave"]);
            usuario.saldo = Convert.ToDouble(reader["saldo"]);

            return usuario;
        }

        public Ingreso MapIngreso(OracleDataReader reader)
        {
            Ingreso ingreso = new Ingreso();

            ingreso.ingreso = Convert.ToDouble(reader["ingreso"]);
            ingreso.asunto = Convert.ToString(reader["asunto"]);
            ingreso.frecuencia = Convert.ToInt32(reader["frecuencia"]);
            ingreso.fechaInicio = Convert.ToDateTime(reader["fecha"]);

            return ingreso;
        }

        public Egreso MapEgreso(OracleDataReader reader)
        {
            Egreso egreso = new Egreso();

            egreso.egreso = Convert.ToDouble(reader["egreso"]);
            egreso.asunto = Convert.ToString(reader["asunto"]);
            egreso.frecuencia = Convert.ToInt32(reader["frecuencia"]);
            egreso.fechaInicio = Convert.ToDateTime(reader["fecha"]);

            return egreso;
        }
    }
}