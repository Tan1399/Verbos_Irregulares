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
    public partial class Begin : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Begin()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }


        public string begin()
        {





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


        public string Began()
        {


            try
            {
                string carpeta = "Audios";
                string archivo = "Began.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }



        public string Begun()
        {

            try
            {
                string carpeta = "Audios";
                string archivo = "Begun.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }

        public void Bite()
        {
            Bit bi = new Bit();
            bi.Show();


        }



        public void volver()
        {

            Bear br = new Bear();
            br.Show();

        }

        private void Begin_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Bite();
            this.Hide();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = begin();
            player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Began();
            player.URL = ruta;
            player.controls.play();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Begun();
            player.URL = ruta;
            player.controls.play();

        }
    }
}
