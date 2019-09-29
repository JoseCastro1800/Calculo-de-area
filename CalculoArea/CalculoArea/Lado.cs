using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Lado
    {
        public void Obtener_Datos()
        {
            //Instanciar la clase operacion 
            Operacion OP = new Operacion();
            OP.Multiplicar();

            //Aqui se le da la opcion de que el usuario ingrese datos
            Console.WriteLine("Sea Bienvenido");
            Console.WriteLine("Calcular area del triangulo");
            Console.WriteLine("favor de ingresar los dos datos del triangulo");

            Console.WriteLine("Ingrese la base");
            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura");
            double cool2 = Convert.ToDouble(Console.ReadLine());
            double cool3 = 2;

            
            double triangulo = OP.Multiplicar(cool, cool2, cool3);

            
            Console.WriteLine("El area del triangulo es:" + triangulo);
            Console.WriteLine("Click en enter para la siguiente figura");
            Console.ReadKey();


            //Calculo del cuadrado
            Console.WriteLine("Calcular area del cuadrado");
            Console.WriteLine("favor de ingresar los dos datos del cuadrado");

            Console.WriteLine("Ingrese el lado");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            double cuadrado = OP.Multiplicar(lado1);

            Console.WriteLine("El area del cuadrado es:" + cuadrado);
            Console.WriteLine("Click en enter para la siguiente figura");
            Console.ReadKey();

            //Calculo del rectangulo
            Console.WriteLine("Calcular area del rectangulo");
            Console.WriteLine("favor de ingresar los dos datos del rectangulo");

            Console.WriteLine("Ingrese la base");
            double r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura");
            double r2 = Convert.ToDouble(Console.ReadLine());
            


            double rectangulo = OP.Multiplicar(r1, r2 );


            Console.WriteLine("El area del rectangulo es :" + rectangulo);
            Console.ReadKey();



        }
    }
}
