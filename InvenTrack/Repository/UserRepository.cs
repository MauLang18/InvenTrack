using InvenTrack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InvenTrack.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool Add(UserModel userModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (userModel == null)
                {
                    userModel = new UserModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO ", userModel.PK_TBL_INVE_USUARIO);
                cmd.Parameters.AddWithValue("@P_USERNAME  ", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_CONTRASENA ", userModel.CONTRASENA);
                cmd.Parameters.AddWithValue("@P_NOMBRE ", userModel.NOMBRE);
                cmd.Parameters.AddWithValue("@P_APELLIDO1 ", userModel.APELLIDO1);
                cmd.Parameters.AddWithValue("@P_APELLIDO2 ", userModel.APELLIDO2);

                myConexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                agregado = true;

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return agregado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al agregar el usuario \n" + ex.Message);
            }
        }

        public bool AuthenticateUser(UserModel userModel, SecureString contrasena)
        {
            bool validUser;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (userModel == null)
                {
                    userModel = new UserModel();
                }

                cmd.Parameters.AddWithValue("@P_OPCION", 0);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_USUARIO", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO", 0);
                cmd.Parameters.AddWithValue("@P_USERNAME", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_CONTRASENA", userModel.CONTRASENA);


                myConexion.Open();
                validUser = cmd.ExecuteScalar() == null ? false : true;
                return validUser;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al obtener los usuarios \n" + ex.Message);
            }
        }

        public bool Edit(UserModel userModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (userModel == null)
                {
                    userModel = new UserModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO ", userModel.PK_TBL_INVE_USUARIO);
                cmd.Parameters.AddWithValue("@P_USERNAME  ", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_CONTRASENA ", userModel.CONTRASENA);
                cmd.Parameters.AddWithValue("@P_NOMBRE ", userModel.NOMBRE);
                cmd.Parameters.AddWithValue("@P_APELLIDO1 ", userModel.APELLIDO1);
                cmd.Parameters.AddWithValue("@P_APELLIDO2 ", userModel.APELLIDO2);

                myConexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                agregado = true;

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return agregado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al modificar el usuario \n" + ex.Message);
            }
        }

        public List<UserModel> GetByAll(UserModel userModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_OPCION ", 1);
                cmd.Parameters.AddWithValue("@P_USUARIO", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO", 0);
                cmd.Parameters.AddWithValue("@P_USERNAME", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_CONTRASENA", "");

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<UserModel> lista = new List<UserModel>();

                while (reader.Read())
                {
                    UserModel obj = new UserModel();
                    obj.PK_TBL_INVE_USUARIO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_USUARIO");
                    obj.USUARIO = UtilitarioDatos.ObtieneString(reader, "USUARIO");
                    obj.CONTRASENA = UtilitarioDatos.ObtieneString(reader, "CONTRASENA");
                    obj.NOMBRE = UtilitarioDatos.ObtieneString(reader, "NOMBRE");
                    obj.APELLIDO1 = UtilitarioDatos.ObtieneString(reader, "APELLIDO1");
                    obj.APELLIDO2 = UtilitarioDatos.ObtieneString(reader, "APELLIDO2");

                    lista.Add(obj);
                }
                reader.Dispose();
                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al obtener los usuarios \n" + ex.Message);
            }
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUserUserName(string userName,string Pass)
        {
            UserModel user = null;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_USUARIO", userName);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO", 0);
                cmd.Parameters.AddWithValue("@P_USERNAME", userName);
                cmd.Parameters.AddWithValue("@P_CONTRASENA", Pass);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                UserModel lista = new UserModel();

                while (reader.Read())
                {
                    user = new UserModel() 
                    {
                        PK_TBL_INVE_USUARIO = int.Parse(reader[0].ToString()),
                        USUARIO = reader[1].ToString(),
                        CONTRASENA = reader[2].ToString(),
                        NOMBRE = reader[3].ToString(),
                        APELLIDO1 = reader[4].ToString(),
                        APELLIDO2 = reader[5].ToString()
                    };
                }
                reader.Dispose();
                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return user;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al obtener los usuarios \n" + ex.Message);
            }
        }

        public bool Remove(UserModel userModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_USUARIO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (userModel == null)
                {
                    userModel = new UserModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 1);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_USUARIO ", userModel.PK_TBL_INVE_USUARIO);
                cmd.Parameters.AddWithValue("@P_USERNAME  ", userModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_CONTRASENA ", userModel.CONTRASENA);
                cmd.Parameters.AddWithValue("@P_NOMBRE ", userModel.NOMBRE);
                cmd.Parameters.AddWithValue("@P_APELLIDO1 ", userModel.APELLIDO1);
                cmd.Parameters.AddWithValue("@P_APELLIDO2 ", userModel.APELLIDO2);

                myConexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                agregado = true;

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return agregado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al eliminar el usuario \n" + ex.Message);
            }
        }
    }
}
