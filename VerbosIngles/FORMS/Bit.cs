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
    public partial class Bit : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Bit()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public string Bitten()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Bitten.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }

        public string bit()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Bit.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }
        public string Bite()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Bite.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }

        public void Blow()
        {
            Blow bw = new Blow();
            bw.Show();


        }



        public void volver()
        {

            Begin be = new Begin();
            be.Show();

        }

        private void Bit_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Blow();
            this.Close();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Bite();
            player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bit();
            player.URL = ruta;
            player.controls.play();


        }

        private void label7_Click(object sender, EventArgs e)
        {
            string ruta = Bitten();
            player.URL = ruta;
            player.controls.play();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
