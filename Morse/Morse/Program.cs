using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Tomo todas las direcciones de los archivos txt y mp3 de la carpeta debug
            string[] archivos_txt;
            string[] archivos_mp3;
            ///Creo un archivo de config
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion();
            ///Leo el archivo
            string path = SoporteParaConfiguracion.LeerConfiguracion();
            ///Tomo todas la direcciones de los archivos txt
            archivos_txt = Directory.GetFiles(".", "*.txt");
            ///Tomo todas la direcciones de los archivos mp3
            archivos_mp3 = Directory.GetFiles(".", "*.mp3");
            ///Muevo los archivos previos a la carpeta de destino
            foreach (string arch in archivos_txt)
            {
                File.Move(arch,path + arch);
            }
            foreach (string arch in archivos_mp3)
            {
                File.Move(arch, path + arch);
            }
            ///Tomo una entrada la convierto a morse y la guardo en un archivo de texto
            Console.WriteLine("Ingrese el texto a traducir");
            string texto = Console.ReadLine();
            ///traduzco el texto
            string txttrad = Helpers.ConversorAMorse.TextoAMorse(texto);
            Console.Write(txttrad);
            Console.ReadKey();
            ///Asigno un nuevo path para guardar los archivos de texto
            string pathm = path + @"\Morse";
            Directory.CreateDirectory(pathm);
            ///tomo la fecha actual y reemplazo los valores que me generan problemas
            string fechaActual = DateTime.Now.ToString().Replace(':', '-');
            fechaActual = fechaActual.Replace('/', '-');
            ///Utilizo un stream writer para crear y abrir un archivo de texto en el path nuevo
            StreamWriter sw = new StreamWriter(File.Open(pathm + @"\morse-"+ fechaActual +".txt",FileMode.Create));
            Console.WriteLine("Archivo creado");
            sw.Write(txttrad);
            Console.WriteLine("Archivo cargado");
            //crierro el sw
            sw.Close();
            ///leo los archivos morse, traduzco el contenido y lo guardo en otro archivo
            int i = 0;
            int direccion;
            string[]files =  Directory.GetFiles(pathm, "*.txt");
            Console.WriteLine("Seleccione el archivo a traducir:");
            foreach (string dir in files)
            {
                Console.WriteLine(i + dir);
                i = i + 1;
            }
            direccion = int.Parse(Console.ReadLine());
            Console.ReadKey();
            StreamReader sr = new StreamReader(File.Open(files[direccion], FileMode.Open));
            string morseAtxt = sr.ReadLine();
            Console.WriteLine(morseAtxt + "\n");
            Console.ReadKey();
            morseAtxt = Helpers.ConversorAMorse.MorseATexto(morseAtxt);
            Console.WriteLine(morseAtxt);
            Console.ReadKey();
            sr.Close();
            StreamWriter stream = new StreamWriter(File.Open(pathm + @"\morset-" + fechaActual + ".txt",FileMode.Create));
            stream.Write(morseAtxt);
            stream.Close();

        }
    }
}
