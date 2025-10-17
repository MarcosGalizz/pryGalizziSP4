using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Data.OleDb;

using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGalizziSP4
{
    internal class ClaseConexion
    {
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BaseDeDatos/ControlCamiones.accdb";
        
        OleDbConnection coneccionBaseDatos;
        
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD(System.Windows.Forms.ToolStripStatusLabel label)
        {
            try
            {
                
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                label.Text = "Conectado a la Base de Datos";
                label.BackColor = System.Drawing.Color.Green;
            }
            catch (Exception error)
            {
                label.Text = "Error al intentar conectarse a la Base de Datos";
                label.BackColor = System.Drawing.Color.Red;

            }

        }

        public void cargarChartKm(Chart chtCamiones)
        {
            try
            {
                chtCamiones.Series.Add("Camiones");
                chtCamiones.ChartAreas[0].AxisX.Title = "Camiones";
                chtCamiones.ChartAreas[0].AxisY.Title = "Kilometros";
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Kilómetros FROM TablaCamiones";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 kilometros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtCamiones.Series[0].Points.AddY(kilometros);
                    chtCamiones.Series[0].Points[index].AxisLabel = camion;
                }
            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }
        }

        public void cargarChartGasto(Chart chtCamiones)
        {
            try
            {
                chtCamiones.Series.Add("Camiones");
                chtCamiones.ChartAreas[0].AxisX.Title = "Camiones";
                chtCamiones.ChartAreas[0].AxisY.Title = "Gastos";
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Kilómetros FROM TablaCamiones";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 kilometros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtCamiones.Series[0].Points.AddY(kilometros);
                    chtCamiones.Series[0].Points[index].AxisLabel = camion;
                }
            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }
        }
    }
}
