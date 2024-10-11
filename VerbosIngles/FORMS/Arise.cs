
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
using System.Speech.Recognition;



namespace VerbosIngles.FORMS
{
    public partial class Arise : Form
    {

        private WMPLib.WindowsMediaPlayer Player;

        private WindowsMediaPlayer player;
        public Arise()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
      



        }



        public void intento() {
            string carpeta = "Audios";
            string archivo = "Arise.mp3";
            string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);
            if (File.Exists(rutaDinamica))
            {
                Console.WriteLine("El archivo existe en la ruta: " + rutaDinamica);
                // Aquí puedes realizar la acción deseada si el archivo existe.
            }
            else
            {
                Console.WriteLine("El archivo no se encontró en la ruta: " + rutaDinamica);
                // Aquí puedes manejar el caso donde el archivo no existe.
            }

            player.URL = rutaDinamica;
            player.controls.play();




        }


        public string Audio_arise() 
       
        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Arise.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch 
            
            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

         







        }

        public string Audio_arose()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Arose.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }
        public string Audio_arosen()

        {



            try
            {
                string carpeta = "Audios";
                string archivo = "Arosen.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }









        }

        public void detector() {
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();


            // string ruta = "../";

            recognizer.SetInputToDefaultAudioDevice();

          


            Choices commands = new Choices();

            commands.Add(new string[] { "comando uno", "comando dos", "comando tres" });

            Grammar grammar = new Grammar(new GrammarBuilder(commands));
            recognizer.LoadGrammar(grammar);

            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(RecognizeSpeech);


            // Inicia el reconocimiento asincrónico
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            /* int? eleccion = null;




             switch (eleccion) {

                 case 1:

                     MessageBox.Show("a");

                     return;


             }
            */





        }

        public void RecognizeSpeech(object sender, SpeechRecognizedEventArgs e)
        {
            // Obtén el texto reconocido
            string recognizedText = e.Result.Text;

            // Maneja el comando basado en el texto reconocido
            switch (recognizedText)
            {
                case "comando uno":

                    Awake();
                    // Agrega tu lógica aquí
                    break;

                case "comando dos":
                    MessageBox.Show("Ejecutando comando dos");
                    // Agrega tu lógica aquí
                    break;

                case "comando tres":
                    MessageBox.Show("Ejecutando comando tres");
                    // Agrega tu lógica aquí
                    break;

                default:
                    MessageBox.Show("Comando no reconocido");
                    break;
            }
        }






        public void Awake()
        {
            Awake aw = new Awake();
            aw.Show();


        }



        public void volver()
        {

            Form1 f1 = new Form1();
            f1.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {


         


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Awake();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        

            


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void Arise_Load(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            string ruta = Audio_arise();
            player.URL = ruta;
            player.controls.play();





        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Audio_arose();


            player.URL = ruta;
            player.controls.play();


        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {

            string ruta = Audio_arosen();
            player.URL = ruta;
            player.controls.play();
        }
    }
}
