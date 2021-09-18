using System;

namespace evaluacion_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "";
            string exit = "6";
            while ( !exit.Equals(key) )
            {
                Console.Clear();
                Console.WriteLine("** Menu Principal **");
                Console.WriteLine(" ");
                Console.WriteLine(" 1- Numero Primo (inciso 1)");
                Console.WriteLine(" 2- Mostrar 100 Numeros (inciso 2)");
                Console.WriteLine(" 3- Conversiones de Moneda (inciso 3)");
                Console.WriteLine(" 4- Factorial (inciso 4)");
                Console.WriteLine(" 5- Leer un archivo de texto (inciso 5)");
                Console.WriteLine(" 6- SALIR");
                Console.WriteLine(" Opcion: ");
                key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        inciso_1.Inciso_1 inciso = new inciso_1.Inciso_1();
                        inciso.Mostrar();
                        break;
                    case "2":
                        inciso_2.Inciso_2 inciso2 = new inciso_2.Inciso_2();
                        inciso2.Mostrar();
                        break;
                    case "3":
                        inciso_3.Inciso_3 inciso3 = new inciso_3.Inciso_3();
                        inciso3.Mostrar();
                        break;
                    case "4":
                        inciso_4.Inciso_4 inciso4 = new inciso_4.Inciso_4();
                        inciso4.Mostrar();
                        break;
                    case "5":
                        inciso_5.Inciso_5 inciso5 = new inciso_5.Inciso_5();
                        inciso5.Mostrar();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("** MUCHAS GRACIAS **");
                        Console.WriteLine("** Nos vemos en un proximo examen **");
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("** OPCION NO VALIDA**");
                        Console.WriteLine(" ");
                        Console.ReadLine();
                        break;
                }
            } 
        }
    }
}
