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
            ///Creo un archivo binario con binary writer
            BinaryWriter bw = new BinaryWriter(File.Open("Config.dat", FileMode.Create));
            ///Escribo dentro del mismo la direccion donde quiero mis archivos
            bw.Write(@"E:\Taller\skere");
            Console.WriteLine("Archivo creado.");
            ///Cierro el archivo
            bw.Close();
        }
        ///leo un archivo de config 
        public static string LeerConfiguracion()
        {
            string Path;
            ///Utilizo un binary reader para abrir el archivo config.dat
            BinaryReader br = new BinaryReader(File.Open("Config.dat", FileMode.Open));
            ///tomo como path la direccion que guarde en el archivo binario
            Path = br.ReadString();
            Console.WriteLine("{0}",Path);
            ///devuelvo el path 
            return Path;
        }       
    }
}
