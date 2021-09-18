using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace evaluacion_parcial.inciso_3
{
    class Inciso_3
    {
        static dynamic dynamic;
        static HttpClient http = new HttpClient();

        private async void getData()
        {
            var response = await http.GetStringAsync("http://data.fixer.io/api/latest?access_key=d6ff7db7b2f799ab314d7d1ca08e945f");
            dynamic = JsonConvert.DeserializeObject(response);
        }

        public void Mostrar()
        {
            try
            {
                getData();                       
                Double GTQ = 0;
                Double Conversion = 0;

                Console.Clear();
                Console.WriteLine("Inciso 3");
                Console.WriteLine(" ");
                Console.WriteLine(" ** Calcule conversiones de quetzales a las siguientes divisas según elija el usuario: dólares, dólares canadienses, reales (brasileños), soles (peruanos) y lempiras (hondureños) ** al dia de hoy ");
                Console.WriteLine(" ");
                Console.Write(" Ingrese el valor a convertir en quetzales (320 GTQ): ");
                string sgtq = Console.ReadLine();
                GTQ = Convert.ToDouble(sgtq);
                Console.WriteLine(" ");
                Console.WriteLine(" Indique la moneda Destino (ISO 4217)");
                Console.WriteLine(" ");
                Console.WriteLine(" 840) USD Dolar Estaunidense");
                Console.WriteLine(" 124) CAD Dolar Canadiense");
                Console.WriteLine(" 986) BRL Real brasileño");
                Console.WriteLine(" 604) PEN Sol");
                Console.WriteLine(" 340) HNL Lempira");
                Console.WriteLine(" ");
                Console.Write(" Codigo de Moneda: ");
                
                string sdestino = Console.ReadLine();                                          
                
                switch (sdestino)
                {
                    case "840":                                                                        
                        Conversion = ( (GTQ / Convert.ToDouble(dynamic.rates.GTQ)) * Convert.ToDouble(dynamic.rates.USD));
                        Console.WriteLine("El valor Ingresado en Dolar Estadounidense es:  " + Conversion.ToString()) ;
                        break;
                    case "124":
                        Conversion = ((GTQ / Convert.ToDouble(dynamic.rates.GTQ)) * Convert.ToDouble(dynamic.rates.CAD));
                        Console.WriteLine("El valor Ingresado en Dolar Canadiense es:  " + Conversion.ToString());
                        break;
                    case "986":
                        Conversion = ((GTQ / Convert.ToDouble(dynamic.rates.GTQ)) * Convert.ToDouble(dynamic.rates.BRL));
                        Console.WriteLine("El valor Ingresado en Real brasiñeo es:  " + Conversion.ToString());
                        break;
                    case "604":
                        Conversion = ((GTQ / Convert.ToDouble(dynamic.rates.GTQ)) * Convert.ToDouble(dynamic.rates.PEN));
                        Console.WriteLine("El valor Ingresado en Soles Peruanos es:  " + Conversion.ToString());
                        break;
                    case "340":
                        Conversion = ((GTQ / Convert.ToDouble(dynamic.rates.GTQ)) * Convert.ToDouble(dynamic.rates.HNL));
                        Console.WriteLine("El valor Ingresado en Lempiras hondureñas es:  " + Conversion.ToString());
                        break;
                    default:
                        Console.Clear();

                        Console.WriteLine("NO se selecciono un destino valido Presione [ENTER] para continuar |" + sdestino + "|");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine(" Presione [ENTER] para continuar");
                Console.ReadLine();

            } catch (Exception e)
            {
                Console.WriteLine("Error en Inciso 3");
                Console.WriteLine(e.Message);
                Console.ReadKey();

            }
            
            


        }
    }
}
