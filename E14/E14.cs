using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E14 {
        public void init() {
            int[] array = new int[10];
            int userNumber = 0;

            array = arrayFill(array);

            Console.WriteLine("Intente adivinar un número del array: ");
            userNumber = int.Parse(Console.ReadLine());

            if (array.Contains(userNumber)) {
                Console.WriteLine("Has acertado.");
            } else {
                Console.WriteLine("Has fallado.");
            }

            showArray(array);
        }        

        public int[] arrayFill(int[] array) {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++) {
                array[i] = rnd.Next(1, 10);
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
