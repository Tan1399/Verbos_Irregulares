using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Numerics;
using WMPLib;
using System.IO;

namespace VerbosIngles.FORMS
{
    public partial class Awake : Form
    {
        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Awake()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }


        public string awake() {





            try
            {
                string carpeta = "Audios";
                string archivo = "Awake.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }


        public string Awoke() {


            try
            {
                string carpeta = "Audios";
                string archivo = "Awoke.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }



        public string Awoken() {

            try
            {
                string carpeta = "Audios";
                string archivo = "Awoken.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }



        public void be()
        {
            be b = new be();
            b.Show();


        }



        public void volver()
        {

            Arise ar = new Arise();
            ar.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            be();
            this.Hide();
        }

        private void Awake_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            string ruta = awake();

            player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Awoke();
            player.URL = ruta;
            player.controls.play();

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Awoken();
            player.URL = ruta;
            player.controls.play();
        }
    }
}
