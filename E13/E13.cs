using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E13 {
        public void init() {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i=0; i<array.Length; i++) {
                array[i] = rnd.Next(1, 10);
            }

            Console.WriteLine("El array de números aleatorios es: ");
            showArray(array);
        }

        public void showArray(int[] array) {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i]);
                if (i != array.Length - 1) {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
    }
}
