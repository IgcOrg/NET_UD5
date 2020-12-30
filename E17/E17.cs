using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E17 {
        public void init() {
            int[] array = new int[10];

            Console.WriteLine("Rellenar el array: ");
            array = arrayUserFill(array);

            showArray(array);
        }

        public int[] arrayUserFill(int[] array) {        
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Posicion {0}", i + 1);

                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
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
