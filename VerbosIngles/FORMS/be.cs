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
    public partial class be : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public be()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public string Be()
        {





            try
            {
                string carpeta = "Audios";
                string archivo = "Be.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }


        public string was()
        {


            try
            {
                string carpeta = "Audios";
                string archivo = "Was_Were.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }



        public string been()
        {

            try
            {
                string carpeta = "Audios";
                string archivo = "Been.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }

        public void Bear()
        {
            Bear be = new Bear();
            be.Show();


        }



        public void volver()
        {

            Awake aw = new Awake();
            aw.Show();

        }

        private void be_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Bear();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Be();
            player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = was();
            player.URL = ruta;
            player.controls.play();


        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = been();
            player.URL = ruta;
            player.controls.play();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
