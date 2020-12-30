using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E5 {
        public void init() {
            int n = 0;
            string binario = string.Empty;

            Console.WriteLine("Introduce un número para convertirlo en binario: ");
            n = int.Parse(Console.ReadLine());

            binario = intToBin(n);

            if (binario != "-1") {
                Console.WriteLine("{0} en binario es {1}", n, intToBin(n));
            }

            Console.ReadKey();
        }
        
        public string intToBin(int number) {
            string cadena = string.Empty;

            if (number > 0) {                
                while (number > 0) {
                    if (number % 2 == 0) {
                        cadena = "0" + cadena;
                    } else {
                        cadena = "1" + cadena;
                    }
                    number = (int)(number / 2);
                }
            } else {
                if (number == 0) {
                    cadena = "0";
                } else {
                    Console.WriteLine("Sólo válido para números positivos. Se terminará la aplicación.");
                    cadena = "-1";
                }
            }

            return cadena;
        }
    }
}
