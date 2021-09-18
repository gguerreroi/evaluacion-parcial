using System;
using System.Collections.Generic;
using System.Text;


namespace evaluacion_parcial.inciso_2
{
    class Inciso_2
    {

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Inciso 2");
            Console.WriteLine(" ");
            Console.WriteLine(" ** muestre 100 números de uno en uno ** ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escriba el numero inicial: ");
            string snum = Console.ReadLine();
            int num = 0;
            
            try
            {
                num = Convert.ToInt32(snum);
                Console.WriteLine(" ");
                int final = num + 100;

                for (int i = num; i < final; i++)
                    Console.Write(i + ", ");

                Console.ReadLine();

            }catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("** SE PRODUJO UN HORROR **");
                Console.WriteLine("El valor ingresado no es un numero");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }

    }

    
}
