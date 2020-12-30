using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E6 {
        public void init() {
            int n = 0;

            Console.WriteLine("Introduce un número para saber el número de cifras que lo componen: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("El número de cifras de {0} es {1}.", n, numCifras(n));
        
        }

        public int numCifras(int number) {
            int contador = 0;

            while (number > 0) {
                number = number / 10;

                contador = contador + 1;
            }

            return contador;
        }
    }
}
