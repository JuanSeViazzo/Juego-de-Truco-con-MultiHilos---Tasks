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
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            CargarPartidasDataGrid();
        }



        private void CargarPartidasDataGrid()
        {
            List<Partida> partidas = ConexionABaseDeDatos.LeerPartidas();


            DataTable estadisticas = new DataTable();
            estadisticas.Columns.Add("Nombre de partida");
            estadisticas.Columns.Add("id jugador Ganador");
            estadisticas.Columns.Add("Puntos de jugador Ganador");
            estadisticas.Columns.Add("id jugador Perdedor");
            estadisticas.Columns.Add("Puntos de jugador Perdedor");
            estadisticas.Columns.Add("fecha de partida");

            dtgEstadisticas.DataSource = estadisticas;


            foreach (var item in partidas)
            {
                estadisticas.Rows.Add(item.nombreDePartida, item.idJugadorGanador, item.puntajeJugadorUno, item.idJugadorPerdedor
                    , item.puntajeJugadorDos, item.fechaDePartida);
            }


            dtgEstadisticas.DataSource = estadisticas;


            if (dtgEstadisticas.CurrentRow == null)
            {
                return;
            }






        }

    }
}
