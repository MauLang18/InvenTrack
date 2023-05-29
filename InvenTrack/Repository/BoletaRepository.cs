using InvenTrack.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Repository
{
    class BoletaRepository : IBoletaRepository
    {
        public bool Add(BoletaModel boletaModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (boletaModel == null)
                {
                    boletaModel = new BoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_UBICACION  ", boletaModel.UBICACION);
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", boletaModel.DEPARTAMENTO);
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", boletaModel.ASIGNADO);
                cmd.Parameters.AddWithValue("@P_FECHA ", boletaModel.FECHA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR ", boletaModel.ENTREGADO_POR);
                cmd.Parameters.AddWithValue("@P_RECIBIDO_POR ", boletaModel.RECIBIDO_POR);
                cmd.Parameters.AddWithValue("@P_DETALLE_MOVIMIENTO ", boletaModel.DETALLE_MOVIMIENTO);

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
                throw new ApplicationException("Error en Base de Datos al agregar la boleta \n" + ex.Message);
            }
        }

        public bool Edit(BoletaModel boletaModel)
        {
            bool modificado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (boletaModel == null)
                {
                    boletaModel = new BoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_UBICACION  ", boletaModel.UBICACION);
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", boletaModel.DEPARTAMENTO);
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", boletaModel.ASIGNADO);
                cmd.Parameters.AddWithValue("@P_FECHA ", boletaModel.FECHA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR ", boletaModel.ENTREGADO_POR);
                cmd.Parameters.AddWithValue("@P_RECIBIDO_POR ", boletaModel.RECIBIDO_POR);
                cmd.Parameters.AddWithValue("@P_DETALLE_MOVIMIENTO ", boletaModel.DETALLE_MOVIMIENTO);

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
                throw new ApplicationException("Error en Base de Datos al modificar la boleta \n" + ex.Message);
            }
        }

        public List<BoletaModel> GetByAll(BoletaModel boletaModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR  ", boletaModel.ENTREGADO_POR);
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", boletaModel.DEPARTAMENTO);
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", boletaModel.ASIGNADO);
                cmd.Parameters.AddWithValue("@P_DATOS ", boletaModel.DATOS);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<BoletaModel> lista = new List<BoletaModel>();

                while (reader.Read())
                {
                    BoletaModel obj = new BoletaModel();
                    obj.PK_TBL_INVE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_BOLETA");
                    obj.UBICACION = UtilitarioDatos.ObtieneString(reader, "UBICACION");
                    obj.DEPARTAMENTO = UtilitarioDatos.ObtieneString(reader, "DEPARTAMENTO");
                    obj.ASIGNADO = UtilitarioDatos.ObtieneString(reader, "ASIGNADO");
                    obj.FECHA = UtilitarioDatos.ObtieneDateTime(reader, "FECHA");
                    obj.ENTREGADO_POR = UtilitarioDatos.ObtieneString(reader, "ENTREGADO_POR");
                    obj.RECIBIDO_POR = UtilitarioDatos.ObtieneString(reader, "RECIBIDO_POR");
                    obj.DETALLE_MOVIMIENTO = UtilitarioDatos.ObtieneString(reader, "DETALLE_MOVIMIENTO");

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

        public List<BoletaModel> GetByDatos(BoletaModel boletaModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 3);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR  ", boletaModel.ENTREGADO_POR);
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", boletaModel.DEPARTAMENTO);
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", boletaModel.ASIGNADO);
                cmd.Parameters.AddWithValue("@P_DATOS ", boletaModel.DATOS);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<BoletaModel> lista = new List<BoletaModel>();

                while (reader.Read())
                {
                    BoletaModel obj = new BoletaModel();
                    obj.PK_TBL_INVE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_BOLETA");
                    obj.UBICACION = UtilitarioDatos.ObtieneString(reader, "UBICACION");
                    obj.DEPARTAMENTO = UtilitarioDatos.ObtieneString(reader, "DEPARTAMENTO");
                    obj.ASIGNADO = UtilitarioDatos.ObtieneString(reader, "ASIGNADO");
                    obj.FECHA = UtilitarioDatos.ObtieneDateTime(reader, "FECHA");
                    obj.ENTREGADO_POR = UtilitarioDatos.ObtieneString(reader, "ENTREGADO_POR");
                    obj.RECIBIDO_POR = UtilitarioDatos.ObtieneString(reader, "RECIBIDO_POR");
                    obj.DETALLE_MOVIMIENTO = UtilitarioDatos.ObtieneString(reader, "DETALLE_MOVIMIENTO");

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

        public BoletaModel GetById(BoletaModel boletaModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 2);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", 0);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR  ", "");
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", "");
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", "");
                cmd.Parameters.AddWithValue("@P_DATOS ", "");

                myConexion.Open();
                reader = cmd.ExecuteReader();

                BoletaModel lista = new BoletaModel();

                while (reader.Read())
                {
                    lista.PK_TBL_INVE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_BOLETA");
                    lista.UBICACION = UtilitarioDatos.ObtieneString(reader, "UBICACION");
                    lista.DEPARTAMENTO = UtilitarioDatos.ObtieneString(reader, "DEPARTAMENTO");
                    lista.ASIGNADO = UtilitarioDatos.ObtieneString(reader, "ASIGNADO");
                    lista.FECHA = UtilitarioDatos.ObtieneDateTime(reader, "FECHA");
                    lista.ENTREGADO_POR = UtilitarioDatos.ObtieneString(reader, "ENTREGADO_POR");
                    lista.RECIBIDO_POR = UtilitarioDatos.ObtieneString(reader, "RECIBIDO_POR");
                    lista.DETALLE_MOVIMIENTO = UtilitarioDatos.ObtieneString(reader, "DETALLE_MOVIMIENTO");
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

        public BoletaModel GetById2(BoletaModel boletaModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR  ", "");
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", "");
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", "");
                cmd.Parameters.AddWithValue("@P_DATOS ", "");

                myConexion.Open();
                reader = cmd.ExecuteReader();

                BoletaModel lista = new BoletaModel();

                while (reader.Read())
                {
                    lista.PK_TBL_INVE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_BOLETA");
                    lista.UBICACION = UtilitarioDatos.ObtieneString(reader, "UBICACION");
                    lista.DEPARTAMENTO = UtilitarioDatos.ObtieneString(reader, "DEPARTAMENTO");
                    lista.ASIGNADO = UtilitarioDatos.ObtieneString(reader, "ASIGNADO");
                    lista.FECHA = UtilitarioDatos.ObtieneDateTime(reader, "FECHA");
                    lista.ENTREGADO_POR = UtilitarioDatos.ObtieneString(reader, "ENTREGADO_POR");
                    lista.RECIBIDO_POR = UtilitarioDatos.ObtieneString(reader, "RECIBIDO_POR");
                    lista.DETALLE_MOVIMIENTO = UtilitarioDatos.ObtieneString(reader, "DETALLE_MOVIMIENTO");
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

        public bool Remove(BoletaModel boletaModel)
        {
            bool eliminado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (boletaModel == null)
                {
                    boletaModel = new BoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", boletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 1);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 1);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_BOLETA ", boletaModel.PK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_UBICACION  ", boletaModel.UBICACION);
                cmd.Parameters.AddWithValue("@P_DEPARTAMENTO ", boletaModel.DEPARTAMENTO);
                cmd.Parameters.AddWithValue("@P_ASIGNADO ", boletaModel.ASIGNADO);
                cmd.Parameters.AddWithValue("@P_FECHA ", boletaModel.FECHA);
                cmd.Parameters.AddWithValue("@P_ENTREGADO_POR ", boletaModel.ENTREGADO_POR);
                cmd.Parameters.AddWithValue("@P_RECIBIDO_POR ", boletaModel.RECIBIDO_POR);
                cmd.Parameters.AddWithValue("@P_DETALLE_MOVIMIENTO ", boletaModel.DETALLE_MOVIMIENTO);

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
                throw new ApplicationException("Error en Base de Datos al eliminar la boleta \n" + ex.Message);
            }
        }
    }
}
