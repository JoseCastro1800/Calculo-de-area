using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Llamamos a la clase lado y la instanciamos
            Lado L = new Lado();
            L.Obtener_Datos();
            Console.ReadKey();
        }
    }
}
