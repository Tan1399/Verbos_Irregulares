using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace VerbosIngles.FORMS
{
    public partial class bet : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public bet()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public string bet_audio() {
            try
            {
                string carpeta = "Audios";
                string archivo = "Bet.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }








        }


        public void Broadcast() {


            Broadcast bro = new Broadcast();
            bro.Show();

        }

        public void volver(){

            Form1 inicio = new Form1();
            inicio.Show();
        
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            Broadcast();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void bet_Load(object sender, EventArgs e)
        {

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bet_audio();
           player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bet_audio();
            player.URL = ruta;
            player.controls.play();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bet_audio();
            player.URL = ruta;
            player.controls.play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
