using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E9 {
        public void init() {
            int[] array = new int[6];

            for (int i=1; i<=array.Length; i++) {
                Console.WriteLine("Introduzca el elemento {0} de su array: ", i);
                array[i - 1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El contenido de su array es: ");
            Console.Write("[");
            for (int i = 1; i <= array.Length; i++) {
                Console.Write(array[i-1]);
                if (i != array.Length) {
                    Console.Write(" ");
                }
            }
            Console.Write("]");
        }
    }
}
