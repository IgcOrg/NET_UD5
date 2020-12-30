using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E3 {
        public void init() {
            int n = 0;

            Console.WriteLine("Introduce un número para saber si es primo: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("El número {0}.", isPrimo(n) ? "es primo." : "no es primo.");
        }
        bool isPrimo(int number) {
            for (int i = 2; i < number; i++) {
                if ((number % i) == 0) {
                    return false;
                }
            }
            
            return true;
        }
    }
}
