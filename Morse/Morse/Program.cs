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
            string[] archivos_txt;
            string[] archivos_mp3;
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion();
            string path = SoporteParaConfiguracion.LeerConfiguracion();
            archivos_txt = Directory.GetFiles(".", "*.txt");
            archivos_mp3 = Directory.GetFiles(".", "*.mp3");

            foreach (string arch in archivos_txt)
            {
                File.Move(arch,path + arch);
            }
            foreach (string arch in archivos_mp3)
            {
                File.Move(arch, path + arch);
            }




        }
    }
}
