using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E19 {
        private int[] array;
        private Random rnd = new Random();
        public void init() {
            int size = 0;

            Console.WriteLine("Bienvenido, al ejercicio 19, por favor, introduzca el tamaño de su array: ");
            size = int.Parse(Console.ReadLine());

            arrayFill(size);

            showArray();

            Console.WriteLine("El elemento de mayor valor es {0}.", array.Max());
        }

        public void arrayFill(int length) {
            array = new int[length];

            for (int i = 0; i < length; i++) {
                int num;

                do {
                    num = getRandomNumber(0, 100);
                    
                } while (!isPrimo(num));

                array[i] = num;
            }
        }

        public int getRandomNumber(int start, int end) {
            return rnd.Next(start, end);
        }

        public void showArray() {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i]);

                if (i != array.Length - 1) {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
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
