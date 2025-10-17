using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGalizziSP4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ClaseConexion claseConexion = new ClaseConexion();
            claseConexion.ConectarBD(toolStripStatusLabelConexion);
        }

        private void btnKmCamion_Click(object sender, EventArgs e)
        {
            chtCamiones.Series.Clear();
            ClaseConexion claseConexion = new ClaseConexion();
            claseConexion.cargarChartKm(chtCamiones);
        }
    }
}
