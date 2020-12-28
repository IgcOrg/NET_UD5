using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E1 {
        public void init() {
            int option = 0;
            
            Console.WriteLine("Bienvenido al ejercicio 1: ");
            Console.WriteLine("A continuación selecciona la opción que desees: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. Calcular el área de un círculo. ");
            Console.WriteLine("2. Calcular el área de un triángulo. ");
            Console.WriteLine("3. Calcular el área de un cuadrado. ");

            option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    double r = 0;

                    Console.WriteLine("Introduzca el radio del círculo: ");
                    r = double.Parse(Console.ReadLine());

                    Console.WriteLine("El área del círculo es: {0}", AreaCirculo(r));

                    break;
                case 2:
                    double b = 0, h = 0;

                    Console.WriteLine("Introduzca la base del triángulo: ");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca la altura del triángulo: ");
                    h = double.Parse(Console.ReadLine());

                    Console.WriteLine("El área del triángulo es: {0}", AreaTriangulo(b, h));

                    break;
                case 3:
                    double l = 0;

                    Console.WriteLine("Introduzca el lado del cuadrado: ");
                    l = double.Parse(Console.ReadLine());

                    Console.WriteLine("El área del cuadrado es: {0}", AreaCuadrado(l));

                    break;
                default:
                    Console.WriteLine("La opción seleccionada no es correcta, se cerrará la aplicación.");
                    break;
            }
        }

        public double AreaCirculo(double radio) {
            return 2 * Math.Pow(radio, 2) * Math.PI;
        }

        public double AreaTriangulo(double basse, double altura) {
            return (basse * altura) / 2;
        }

        public double AreaCuadrado(double lado) {
            return Math.Pow(lado, 2);
        }
    }
}
