using System;
using System.Collections.Generic;
using System.Text;

namespace evaluacion_parcial.inciso_4
{
    class Inciso_4
    {
        public void Mostrar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Inciso 4");
                Console.WriteLine(" ");
                Console.WriteLine(" ** ingresado un número, calcule su número factorial ** ");
                Console.WriteLine(" ");
                Console.Write(" Ingrese un numero para calcular el factorial: ");
                string snum = Console.ReadLine();
                int n = 0;
                int fac = 1;
                n = Convert.ToInt32(snum);
                for(int i=1; i<=n; i++)
                {
                    fac = fac * i;
                }
                Console.WriteLine(" ");
                Console.WriteLine("El factorial es: " + fac.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Presione [ENTER] para continuar ");
                Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine("se produjo un error en inciso 4");
                Console.WriteLine(e.Message);
            }
        }
    }
}
