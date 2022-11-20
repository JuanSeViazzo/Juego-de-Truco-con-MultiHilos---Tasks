using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{
    public partial class FrmEstadisticasJugadores : Form
    {
        public FrmEstadisticasJugadores()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasJugadores_Load(object sender, EventArgs e)
        {
            CargarPartidasDataGrid();
        }



        private void CargarPartidasDataGrid()
        {
            List<MostrarEstadisticasJugador> datosjugadores= ConexionABaseDeDatos.leerEstadisticasDeJugadores();


            DataTable estadisticas = new DataTable();
            estadisticas.Columns.Add("Nombre de jugador");
            estadisticas.Columns.Add("carta preferida");
            estadisticas.Columns.Add("edad");
            estadisticas.Columns.Add("puntos totales");
            estadisticas.Columns.Add("cantidad de partidas ganadas");
            

            dtgEstadisticas.DataSource = estadisticas;


            foreach (var item in datosjugadores)
            {
                estadisticas.Rows.Add(item.nombreDeJugador, item.cartaPreferida, item.edad, item.puntostotales
                    , item.partidasganadas);
            }


            dtgEstadisticas.DataSource = estadisticas;


            if (dtgEstadisticas.CurrentRow == null)
            {
                return;
            }






        }
    }
}
