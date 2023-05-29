using InvenTrack.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace InvenTrack.Repository
{
    class EquipoRepository : IEquipoRepository
    {
        public bool Add(EquipoModel equipoModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_EQUIPO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (equipoModel == null)
                {
                    equipoModel = new EquipoModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", equipoModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_EQUIPO ", equipoModel.PK_TBL_INVE_EQUIPO);
                cmd.Parameters.AddWithValue("@P_ID_SISTEMA  ", equipoModel.ID_SISTEMA);
                cmd.Parameters.AddWithValue("@P_TIPO_EQUIPO ", equipoModel.TIPO_EQUIPO);
                cmd.Parameters.AddWithValue("@P_MARCA ", equipoModel.MARCA);
                cmd.Parameters.AddWithValue("@P_SERIE ", equipoModel.SERIE);
                cmd.Parameters.AddWithValue("@P_MODELO ", equipoModel.MODELO);
                cmd.Parameters.AddWithValue("@P_ESTADO ", equipoModel.ESTADO);
                cmd.Parameters.AddWithValue("@P_DETALLES ", equipoModel.DETALLES);
                cmd.Parameters.AddWithValue("@P_ACTIVO ", equipoModel.ACTIVO);

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
                if (ex.Message.Contains("UNIQUE KEY"))
                {
                    // Manejar el error de UNIQUE constraint aquí
                    Console.WriteLine("No se puede agregar el equipo debido a una restricción UNIQUE.");
                    Console.WriteLine("Por favor, verifique los datos ingresados.");

                    // Puedes mostrar un mensaje de error al usuario en la interfaz de usuario, 
                    // o realizar cualquier otra acción necesaria para manejar el error.

                    // Opcionalmente, puedes registrar el error en un archivo de registro o notificar al administrador del sistema.
                }
                else
                {
                    // Otros errores de base de datos que no son relacionados con UNIQUE constraint
                    throw new ApplicationException("Error en Base de Datos al agregar el equipo \n" + ex.Message);
                }
                return agregado = false;
            }
        }

        public bool Edit(EquipoModel equipoModel)
        {
            bool modificado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_EQUIPO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (equipoModel == null)
                {
                    equipoModel = new EquipoModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", equipoModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_EQUIPO ", equipoModel.PK_TBL_INVE_EQUIPO);
                cmd.Parameters.AddWithValue("@P_ID_SISTEMA  ", equipoModel.ID_SISTEMA);
                cmd.Parameters.AddWithValue("@P_TIPO_EQUIPO ", equipoModel.TIPO_EQUIPO);
                cmd.Parameters.AddWithValue("@P_MARCA ", equipoModel.MARCA);
                cmd.Parameters.AddWithValue("@P_SERIE ", equipoModel.SERIE);
                cmd.Parameters.AddWithValue("@P_MODELO ", equipoModel.MODELO);
                cmd.Parameters.AddWithValue("@P_ESTADO ", equipoModel.ESTADO);
                cmd.Parameters.AddWithValue("@P_DETALLES ", equipoModel.DETALLES);
                cmd.Parameters.AddWithValue("@P_ACTIVO ", equipoModel.ACTIVO);

                myConexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                modificado = true;

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return modificado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al modificar el equipo \n" + ex.Message);
            }
        }

        public List<EquipoModel> GetByAll(EquipoModel equipoModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_EQUIPO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", equipoModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_EQUIPO ", equipoModel.PK_TBL_INVE_EQUIPO);
                cmd.Parameters.AddWithValue("@P_ID_SISTEMA  ", equipoModel.ID_SISTEMA);
                cmd.Parameters.AddWithValue("@P_MARCA ", equipoModel.MARCA);
                cmd.Parameters.AddWithValue("@P_SERIE ", equipoModel.SERIE);
                cmd.Parameters.AddWithValue("@P_ESTADO ", equipoModel.ESTADO);
                cmd.Parameters.AddWithValue("@P_ACTIVO ", equipoModel.ACTIVO);
                cmd.Parameters.AddWithValue("@P_DATOS", equipoModel.DATOS);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EquipoModel> lista = new List<EquipoModel>();

                while (reader.Read())
                {
                    EquipoModel obj = new EquipoModel();
                    obj.PK_TBL_INVE_EQUIPO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_EQUIPO");
                    obj.ID_SISTEMA = UtilitarioDatos.ObtieneString(reader, "ID_SISTEMA");
                    obj.TIPO_EQUIPO = UtilitarioDatos.ObtieneString(reader, "TIPO_EQUIPO");
                    obj.MARCA = UtilitarioDatos.ObtieneString(reader, "MARCA");
                    obj.SERIE = UtilitarioDatos.ObtieneString(reader, "SERIE");
                    obj.MODELO = UtilitarioDatos.ObtieneString(reader, "MODELO");
                    obj.ESTADO = UtilitarioDatos.ObtieneString(reader, "ESTADO");
                    obj.DETALLES = UtilitarioDatos.ObtieneString(reader, "DETALLES");
                    obj.ACTIVO = UtilitarioDatos.ObtieneString(reader, "ACTIVO");

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
                throw new ApplicationException("Error en Base de Datos al obtener los equipo \n" + ex.Message);
            }
        }

        public List<EquipoModel> GetByDatos(EquipoModel equipoModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_EQUIPO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", equipoModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 2);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_EQUIPO ", equipoModel.PK_TBL_INVE_EQUIPO);
                cmd.Parameters.AddWithValue("@P_ID_SISTEMA  ", equipoModel.ID_SISTEMA);
                cmd.Parameters.AddWithValue("@P_MARCA ", equipoModel.MARCA);
                cmd.Parameters.AddWithValue("@P_SERIE ", equipoModel.SERIE);
                cmd.Parameters.AddWithValue("@P_ESTADO ", equipoModel.ESTADO);
                cmd.Parameters.AddWithValue("@P_ACTIVO ", equipoModel.ACTIVO);
                cmd.Parameters.AddWithValue("@P_DATOS", equipoModel.DATOS);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EquipoModel> lista = new List<EquipoModel>();

                while (reader.Read())
                {
                    EquipoModel obj = new EquipoModel();
                    obj.PK_TBL_INVE_EQUIPO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_EQUIPO");
                    obj.ID_SISTEMA = UtilitarioDatos.ObtieneString(reader, "ID_SISTEMA");
                    obj.TIPO_EQUIPO = UtilitarioDatos.ObtieneString(reader, "TIPO_EQUIPO");
                    obj.MARCA = UtilitarioDatos.ObtieneString(reader, "MARCA");
                    obj.SERIE = UtilitarioDatos.ObtieneString(reader, "SERIE");
                    obj.MODELO = UtilitarioDatos.ObtieneString(reader, "MODELO");
                    obj.ESTADO = UtilitarioDatos.ObtieneString(reader, "ESTADO");
                    obj.DETALLES = UtilitarioDatos.ObtieneString(reader, "DETALLES");
                    obj.ACTIVO = UtilitarioDatos.ObtieneString(reader, "ACTIVO");

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
                throw new ApplicationException("Error en Base de Datos al obtener los equipo \n" + ex.Message);
            }
        }

        public bool Remove(EquipoModel equipoModel)
        {
            bool eliminado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_EQUIPO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (equipoModel == null)
                {
                    equipoModel = new EquipoModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", equipoModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 1);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 1);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_EQUIPO ", equipoModel.PK_TBL_INVE_EQUIPO);
                cmd.Parameters.AddWithValue("@P_ID_SISTEMA  ", equipoModel.ID_SISTEMA);
                cmd.Parameters.AddWithValue("@P_TIPO_EQUIPO ", equipoModel.TIPO_EQUIPO);
                cmd.Parameters.AddWithValue("@P_MARCA ", equipoModel.MARCA);
                cmd.Parameters.AddWithValue("@P_SERIE ", equipoModel.SERIE);
                cmd.Parameters.AddWithValue("@P_MODELO ", equipoModel.MODELO);
                cmd.Parameters.AddWithValue("@P_ESTADO ", equipoModel.ESTADO);
                cmd.Parameters.AddWithValue("@P_DETALLES ", equipoModel.DETALLES);
                cmd.Parameters.AddWithValue("@P_ACTIVO ", equipoModel.ACTIVO);

                myConexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                eliminado = true;

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return eliminado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos al eliminar el equipo \n" + ex.Message);
            }
        }
    }
}
