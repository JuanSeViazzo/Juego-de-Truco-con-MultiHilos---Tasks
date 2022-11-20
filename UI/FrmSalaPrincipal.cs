using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{



    public partial class FrmSalaPrincipal : Form
    {
        Action<List<Sala>> partidasEnJuego;
        List<Sala> listaDeSalas;
        FrmPartida frmPartidaUno;
        List<Jugador> listaJugador;
        Mazo mazo;
        List<Jugador> listaUnicaDeJugadores;
        XmlSerializadora<Mazo> serializadoraMazoXML;


        public FrmSalaPrincipal()
        {
            InitializeComponent();
            listaDeSalas = new List<Sala>();
        }

        private void FrmSalaPrincipal_Load(object sender, EventArgs e)
        {
            listaJugador = new List<Jugador>();
            listaJugador = ConexionABaseDeDatos.LeerJugadores();


            listaJugador.ForEach(item =>
            {
                cmbJugadorUno.DisplayMember = "nombreDeUsuario";
                cmbJugadorUno.Items.Add(item);
            });

            listaJugador.ForEach(item =>
            {
                cmbJugadorDos.DisplayMember = "nombreDeUsuario";
                cmbJugadorDos.Items.Add(item);
            });


            serializadoraMazoXML = new XmlSerializadora<Mazo>();


        }



        private void btn_crearNuevaSala_Click(object sender, EventArgs e)
        {

           CrearNuevaPartida();

        }


        public void MostrarPartidasEnJuego(List<Sala> listaDePartidas)
        {
            DataTable partidas = new DataTable();
            partidas.Columns.Add("ID De SALA");
            partidas.Columns.Add("Nombre de Sala");
            partidas.Columns.Add("Fecha de partido");
            partidas.Columns.Add("Nombre de jugador Uno");
            partidas.Columns.Add("Nombre de jugador Dos");



            foreach (var item in listaDePartidas)
            {
                partidas.Rows.Add(item.partida.numeroDePartida,item.partida.nombreDePartida,item.partida.fechaDePartida,
                  item.partida.jugadorUno.nombreDeUsuario,
                  item.partida.jugadorDos.nombreDeUsuario);
            }

           
            if (dtgv_Partidas.InvokeRequired)
            {
                this.BeginInvoke(partidasEnJuego, listaDePartidas);
            }
            else
            {

            dtgv_Partidas.DataSource = partidas;
            }


            if (dtgv_Partidas.CurrentRow == null)
            {
                return;
            }

        }

        private void CrearNuevaPartida()
        {
            Jugador? jugadorUno = cmbJugadorUno.SelectedItem as Jugador;
            Jugador? jugadorDos = cmbJugadorDos.SelectedItem as Jugador;
            if (jugadorUno?.nombreDeUsuario == jugadorDos?.nombreDeUsuario)
            {
                jugadorUno = null;
                jugadorDos = null;
                lblError.Text = "No puede ser el mismo Jugador";
                return;
            }
            if (jugadorUno?.estaJugando == true)
            {
                jugadorUno = null;
                lblError.Text = "El jugador Uno esta actualmente en una partida";
                return;
            }
            if (jugadorDos?.estaJugando == true)
            {
                jugadorDos = null;
                lblError.Text = "El jugador Dos esta actualmente en una partida";
                return;

            }
            validarMazoYJugar(jugadorUno, jugadorDos);

        }

        private void validarMazoYJugar(Jugador? jugadorUno, Jugador? jugadorDos)
        {
            if (mazo is null)
            {
                lblError.Text = "Falta mazo para jugar Partida";
                btn_CargarMazo_Click(new object(), null);
            }
            else
            {
                partidasEnJuego += MostrarPartidasEnJuego;
                Sala salaNueva = new Sala("Jugate un Truco", mazo);
                salaNueva.CrearPartida(jugadorUno, jugadorDos);
                listaDeSalas.Add(salaNueva);
                partidasEnJuego.Invoke(listaDeSalas);
            }
        }

        private void dtgv_Partidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPartida;

            try
            {
                int row = e.RowIndex;
                
           
                idPartida = int.Parse(dtgv_Partidas.Rows[row].Cells[0].Value.ToString());

                Sala salita = listaDeSalas[idPartida];

                frmPartidaUno = new FrmPartida(salita);
                frmPartidaUno.Text = $"Sala {salita.partida.numeroDePartida}";
                frmPartidaUno.ShowDialog();


            }
            catch (Exception)
            {
                return;
            }
        }

        private void btn_GuardarMazo_Click(object sender, EventArgs e)
        {

           serializadoraMazoXML.EscribirSerializadora(mazo);

        }

        private void btn_CargarMazo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Users\\juans\\source\\JuanSViazzo2DLabo2-TPTruco\\TrucoConTruco\\UI\\bin\\Debug\\net5.0-windows\\/Archivos-Serializacion";
            ofd.ShowDialog();
            string ruta;
            ruta = ofd.FileName;
            if (File.Exists(ruta))
            {
               mazo= serializadoraMazoXML.LeerSerializadora(ruta);
                
            }
            else
            {
                return;
            }

        }

        private void btn_NuevoJugador_Click(object sender, EventArgs e)
        {
            FrmNuevoJugador frmNuevoJugador = new FrmNuevoJugador();
            frmNuevoJugador.ShowDialog();   
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();    
            frmEstadisticas.ShowDialog();   
        }

        private void btnEstadisticasJugadores_Click(object sender, EventArgs e)
        {
            FrmEstadisticasJugadores frmEstadisticasJugadores = new FrmEstadisticasJugadores();
            frmEstadisticasJugadores.ShowDialog();  
        }
    }
}
 