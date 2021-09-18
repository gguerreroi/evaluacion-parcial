using System;
using System.Collections.Generic;
using System.Text;

namespace evaluacion_parcial.inciso_1
{
    /// <summary>
    /// Solicita un numero y define si es primo o no
    /// </summary>
    class Inciso_1
    {
        public Inciso_1()
        {
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Inciso 1");
            Console.WriteLine(" ");
            Console.WriteLine(" ** solicite un número y defina si es un número ingresado es primo ** ");
            Console.WriteLine(" ");
            Console.WriteLine(" Ingrese un numero: ");
            string num = Console.ReadLine();
            int n = 0;
            try
            {
                n = Convert.ToInt32(num);
                if (CheckNumber(n))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" El numero ingresado es PRIMO!! ");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" El numero ingresado es NO es primo :-( ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Presione [Enter] para continuar ");
                Console.ReadLine();

            }catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(" Se produjo un error en la conversion, solamente se puede ingresar numeros");
                Console.WriteLine(e.Message);
            }

        }

        public Boolean CheckNumber(int num)
        {
            for (int i=(num -1); i > 1; i--)           
                if (num % i == 0)
                    return false;
                           
            return true;
        }

    }
}
