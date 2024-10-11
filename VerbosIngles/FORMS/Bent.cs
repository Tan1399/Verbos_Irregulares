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
    public partial class Bent : Form
    {
        private WMPLib.WindowsMediaPlayer Player;

        private WindowsMediaPlayer player;
        public Bent()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        public string Bend()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Bend.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }

        public string bent()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Bent.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }


        public void bind() {

            Bind bd = new Bind();
            bd.Show();
        

        }


        public void volver() {

            Form1 f1 = new Form1();
            f1.Show();
          
        
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bind();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Bent_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            string ruta = Bend();

            player.URL = ruta;
            player.controls.play();

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bent();

            player.URL = ruta;
            player.controls.play();

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bent();

            player.URL = ruta;
            player.controls.play();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Bend();

            player.URL = ruta;
            player.controls.play();

        }
    }
}
