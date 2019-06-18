using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    class ConversorAMorse
    {
        ///converso de texto a morse
        public static string TextoAMorse(string txt)
        {
            string morse = "";  
            foreach (var car in txt)
            {
                switch (car)
                {
                    case 'a':
                        morse = morse + ".- ";
                        break;
                    case 'b':
                        morse = morse + "-... ";
                        break;
                    case 'c':
                        morse = morse + "-.-. ";
                        break;
                    case 'd':
                        morse = morse + "-.. ";
                        break;
                    case 'e':
                        morse = morse + ". ";
                        break;
                    case 'f':
                        morse = morse + "..-. ";
                        break;
                    case 'g':
                        morse = morse + "--. ";
                        break;
                    case 'h':
                        morse = morse + ".... ";
                        break;
                    case 'i':
                        morse = morse + ".. ";
                        break;
                    case 'j':
                        morse = morse + ".--- ";
                        break;
                    case 'k':
                        morse = morse + "-.- ";
                        break;
                    case 'l':
                        morse = morse + ".-.. ";
                        break;
                    case 'm':
                        morse = morse + "-- ";
                        break;
                    case 'n':
                        morse = morse + "-. ";
                        break;
                    case 'o':
                        morse = morse + "--- ";
                        break;
                    case 'p':
                        morse = morse + ".--. ";
                        break;
                    case 'q':
                        morse = morse + "--.- ";
                        break;
                    case 'r':
                        morse = morse + ".-. ";
                        break;
                    case 's':
                        morse = morse + "... ";
                        break;
                    case 't':
                        morse = morse + "- ";
                        break;
                    case 'u':
                        morse = morse + "..- ";
                        break;
                    case 'v':
                        morse = morse + "...- ";
                        break;
                    case 'w':
                        morse = morse + ".-- ";
                        break;
                    case 'x':
                        morse = morse + "-..- ";
                        break;
                    case 'y':
                        morse = morse + "-.-- ";
                        break;
                    case 'z':
                        morse = morse + "--.. ";
                        break;
                    case ' ':
                        morse = morse + " /// ";
                        break;
                }
            }
            return morse;
        }
        //Conversor de morse a texto
        public static string MorseATexto(string mortxt)
        {
            string txt = "";
            string[] cadena = mortxt.Split(' ');
            foreach (var cad in cadena)
            {
                switch (cad)
                {
                    case ".-":
                        txt = txt + "a";
                        break;
                    case "-...":
                        txt = txt + "b ";
                        break;
                    case "-.-.":
                        txt = txt + "c";
                        break;
                    case "-..":
                        txt = txt + "d";
                        break;
                    case ".":
                        txt = txt + "e";
                        break;
                    case "..-.":
                        txt = txt + "f";
                        break;
                    case "--.":
                        txt = txt + "g";
                        break;
                    case "....":
                        txt = txt + "h";
                        break;
                    case "..":
                        txt = txt + "i";
                        break;
                    case ".---":
                        txt = txt + "j";
                        break;
                    case "-.-":
                        txt = txt + "k";
                        break;
                    case ".-..":
                        txt = txt + "l";
                        break;
                    case "--":
                        txt = txt + "m";
                        break;
                    case "-.":
                        txt = txt + "n";
                        break;
                    case "---":
                        txt = txt + "o";
                        break;
                    case ".--.":
                        txt = txt + "p";
                        break;
                    case "--.-":
                        txt = txt + "q";
                        break;
                    case ".-.":
                        txt = txt + "r";
                        break;
                    case "...":
                        txt = txt + "s";
                        break;
                    case "-":
                        txt = txt + "t";
                        break;
                    case "..-":
                        txt = txt + "u";
                        break;
                    case "...-":
                        txt = txt + "v";
                        break;
                    case ".--":
                        txt = txt + "w";
                        break;
                    case "-..-":
                        txt = txt + "x";
                        break;
                    case "-.--":
                        txt = txt + "y";
                        break;
                    case "--..":
                        txt = txt + "z";
                        break;
                    case "///":
                        txt = txt + " ";
                        break;
                }
            }
            return txt;
        }

    }
}