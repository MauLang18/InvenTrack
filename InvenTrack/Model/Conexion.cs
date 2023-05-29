using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InvenTrack.Model
{
    public class Conexion
    {
        public static ArrayList CargarPreferencias()
        {
            ArrayList datos = new ArrayList();
            string direccion = ConfigurationManager.AppSettings["Ruta_conexion"];
            try
            {
                if (File.Exists(direccion))
                {
                    XmlDocument Conexiones = new XmlDocument();

                    Conexiones.Load(direccion);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/SERVER").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/DATABASE").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/USER").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/PASSWORD").InnerText);
                }
                else
                {

                }
            }
            catch
            {

            }
            return datos;
        }

        public string conexion()
        {
            ArrayList Conexion = new ArrayList();
            Console.WriteLine(CargarPreferencias().ToString());
            Conexion = CargarPreferencias();

            return "Data Source=" + "192.168.201.16" +
            ";Initial Catalog=" + "BD_INVENTRACK" +
            ";User ID=" + "sa" +
            ";Password=" + "S0port3";
        }
    }
}
