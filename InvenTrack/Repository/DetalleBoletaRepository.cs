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
    class DetalleBoletaRepository : IDetalleBoletaRepository
    {
        public bool Add(DetalleBoletaModel detalleBoletaModel)
        {
            bool agregado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_DETALLE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (detalleBoletaModel == null)
                {
                    detalleBoletaModel = new DetalleBoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", detalleBoletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_DETALLE_BOLETA ", detalleBoletaModel.PK_TBL_INVE_DETALLE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_BOLETA  ", detalleBoletaModel.FK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_EQUIPO ", detalleBoletaModel.FK_TBL_INVE_EQUIPO);

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

        public bool Edit(DetalleBoletaModel detalleBoletaModel)
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

                if (detalleBoletaModel == null)
                {
                    detalleBoletaModel = new DetalleBoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", detalleBoletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_DETALLE_BOLETA ", detalleBoletaModel.PK_TBL_INVE_DETALLE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_BOLETA  ", detalleBoletaModel.FK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_EQUIPO ", detalleBoletaModel.FK_TBL_INVE_EQUIPO);

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

        public List<DetalleBoletaModel> GetByAll(DetalleBoletaModel detalleBoletaModel)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_CON_TBL_INVE_DETALLE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_USUARIO", detalleBoletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_DETALLE_BOLETA ", 0);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_BOLETA  ", detalleBoletaModel.FK_TBL_INVE_BOLETA);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<DetalleBoletaModel> lista = new List<DetalleBoletaModel>();

                while (reader.Read())
                {
                    DetalleBoletaModel obj = new DetalleBoletaModel();
                    obj.PK_TBL_INVE_DETALLE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_INVE_DETALLE_BOLETA");
                    obj.FK_TBL_INVE_EQUIPO = UtilitarioDatos.ObtieneInt(reader, "FK_TBL_INVE_EQUIPO");
                    obj.FK_TBL_INVE_BOLETA = UtilitarioDatos.ObtieneInt(reader, "FK_TBL_INVE_BOLETA");
                    obj.ID_SISTEMA = UtilitarioDatos.ObtieneString(reader, "ID_SISTEMA");
                    obj.TIPO_EQUIPO = UtilitarioDatos.ObtieneString(reader, "TIPO_EQUIPO");
                    obj.MARCA = UtilitarioDatos.ObtieneString(reader, "MARCA");
                    obj.SERIE = UtilitarioDatos.ObtieneString(reader, "SERIE");
                    obj.MODELO = UtilitarioDatos.ObtieneString(reader, "MODELO");
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

        public bool Remove(DetalleBoletaModel detalleBoletaModel)
        {
            bool eliminado = false;
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "GSTEDI.PA_MAN_TBL_INVE_DETALLE_BOLETA";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (detalleBoletaModel == null)
                {
                    detalleBoletaModel = new DetalleBoletaModel();
                }

                cmd.Parameters.AddWithValue("@P_USUARIO", detalleBoletaModel.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", 1);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_INVE_DETALLE_BOLETA ", detalleBoletaModel.PK_TBL_INVE_DETALLE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_BOLETA  ", detalleBoletaModel.FK_TBL_INVE_BOLETA);
                cmd.Parameters.AddWithValue("@P_FK_TBL_INVE_EQUIPO ", detalleBoletaModel.FK_TBL_INVE_EQUIPO);

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
