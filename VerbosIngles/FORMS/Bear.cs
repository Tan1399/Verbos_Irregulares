using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace VerbosIngles.FORMS
{
    public partial class Bear : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Bear()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public void Begin()
        {
            Begin begin = new Begin();
            begin.Show();


        }

        public string bear()
        {





            try
            {
                string carpeta = "Audios";
                string archivo = "Bear.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }


        public string Bore()
        {


            try
            {
                string carpeta = "Audios";
                string archivo = "Bore.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }



        public string Born()
        {

            try
            {
                string carpeta = "Audios";
                string archivo = "Born.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }



        public void volver()
        {

            be be = new be();
            be.Show();

        }

        private void Bear_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Begin();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bear();

            player.URL = ruta;
            player.controls.play();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Bore();

            player.URL = ruta;
            player.controls.play();

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Born();

            player.URL = ruta;
            player.controls.play();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
