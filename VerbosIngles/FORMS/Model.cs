using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace VerbosIngles.FORMS
{
    public class Model
    {


        public void Modelo(){
            string carpeta = "Model";
            string archivo = "command_model.h5";
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



              using (var session = new InferenceSession(rutaDinamica))
        {
            // Preparar datos de entrada (dummy data para ejemplo)
            var inputData = new DenseTensor<float>(new float[] { /* tus datos de entrada aquí */ }, new int[] { 1, 4 });

            // Crear un contenedor de entrada
            var input = new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("input", inputData)
            };

            // Realizar la inferencia
            using (var results = session.Run(input))
            {
                // Obtener el resultado
                var output = results.First().AsEnumerable<float>().ToArray();
                Console.WriteLine("Resultado del modelo: " + string.Join(", ", output));
            }
        }





        }




    }
}
