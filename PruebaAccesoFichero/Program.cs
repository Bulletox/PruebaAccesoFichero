// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

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
                Console.WriteLine("3-");
                Console.WriteLine("4-");
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

                    //Guardamos leer en binario 25 47 83 29 208
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
            }
        }
    }
}
