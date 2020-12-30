using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E18 {
        private int[] array;
        private Random rnd = new Random();
        public void init() {
            int size = 0;

            Console.WriteLine("Bienvenido, al ejercicio 18, por favor, introduzca el tamaño de su array: ");
            size = int.Parse(Console.ReadLine());

            arrayFill(size);

            showArray();

            showSum();
        }

        public void arrayFill(int length) {
            array = new int[length];

            for (int i = 0; i < length; i++) {
                array[i] = getRandomNumber(1, 10);
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

        public void showSum() {
            Console.WriteLine("La suma de elementos del array es: {0}. ", array.Sum());
        }
    }
}
