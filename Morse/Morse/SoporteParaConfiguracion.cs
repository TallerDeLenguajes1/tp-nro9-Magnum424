using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    class SoporteParaConfiguracion
    {
        ///creo un archivo binario para cargar la ruta
        public static void CrearArchivoDeConfiguracion()
        {
            BinaryWriter bw = new BinaryWriter(File.Open("Config.dat", FileMode.Create));
            bw.Write(@"F:\Taller\skere");
            Console.WriteLine("Archivo creado.");
            bw.Close();
        }
        ///leo un archivo de config 
        public static string LeerConfiguracion()
        {
            string Path;
            BinaryReader br = new BinaryReader(File.Open("Config.dat", FileMode.Open));
            Path = br.ReadString();
            Console.WriteLine("{0}",Path);
            return Path;
        }       
    }
}
