// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Globalization;
using System.Text;

namespace PrebaAccesoFichero
{
    class progam
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            string texto;
            while(opcion != 0)
            {
                Console.WriteLine("1-Escribri binario");
                Console.WriteLine("2-Leer binario");
                Console.WriteLine("3-Escribir Texto");
                Console.WriteLine("4-Leer Texto");
                Console.WriteLine("0-Cerrar");

                texto = Console.ReadLine();
                opcion = Int32.Parse(texto);
                Console.WriteLine(">");
                if (opcion == 1)
                {
                    BinaryWriter writer;
                    FileStream fichero;

                    fichero = new FileStream("DatosBinarios.bin", FileMode.Create, FileAccess.Write);
                    
                    writer = new BinaryWriter(fichero); 
                    //Guardamos datos en binario 25 47 83 29 208

                    writer.Write(25);
                    writer.Write(47);
                    writer.Write(83);
                    writer.Write(29);
                    writer.Write(208);

                    writer.Close();
                }
                else if (opcion == 2)
                {
                    BinaryReader reader;
                    FileStream fichero;

                    int dato;

                    fichero = new FileStream("DatosBinarios.bin", FileMode.Open, FileAccess.Read);

                    reader = new BinaryReader(fichero);

                    // leer en binario 25 47 83 29 208
                    dato = reader.ReadInt32();
                    Console.WriteLine(dato);
                    dato = reader.ReadInt32();
                    Console.WriteLine(dato);
                    dato = reader.ReadInt32();
                    Console.WriteLine(dato);
                    dato = reader.ReadInt32();
                    Console.WriteLine(dato);
                    dato = reader.ReadInt32();
                    Console.WriteLine(dato);
                    reader.Close();
                }
                else if(opcion == 3)
                {
                    StreamWriter writer;
                    FileStream fichero;

                    fichero = new FileStream("DatosTexto.txt", FileMode.Create, FileAccess.Write);

                    writer = new StreamWriter(fichero, Encoding.UTF8);
                    //Guardamos datos en Texto 25 47 83 29 208

                    writer.WriteLine("Guardamos datos en Texto " + 25 +", " + 47 + ", " + 83 + ", " + 29 + ", " + 208);

                    writer.Close();
                }
                else if(opcion == 4)
                {
                    StreamReader reader;
                    FileStream fichero;

                    string dato;

                    fichero = new FileStream("DatosTexto.txt", FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(fichero, Encoding.UTF8);

                    dato = reader.ReadLine();
                    Console.WriteLine(dato);
                    reader.Close();


                }
            }
        }
    }
}
