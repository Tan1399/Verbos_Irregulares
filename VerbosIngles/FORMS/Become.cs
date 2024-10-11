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
    public partial class Become : Form
    {
        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Become()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public void inicio()
        {

            Form1 f1 = new Form1();
            f1.Show();

        }

        public void volver()
        {

            Form1 f1 = new Form1();
            f1.Show();

        }
        public string become()
        {





            try
            {
                string carpeta = "Audios";
                string archivo = "Become.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }


        public string Became()
        {


            try
            {
                string carpeta = "Audios";
                string archivo = "Became.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }



      


        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            inicio();
            this.Hide();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = become();
            player.URL = ruta;
            player.controls.play();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Became();
            player.URL = ruta;
            player.controls.play();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = become();
            player.URL = ruta;
            player.controls.play();
        }

        private void Become_Load(object sender, EventArgs e)
        {

        }
    }
}
