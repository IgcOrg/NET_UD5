using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E20 {
        private int size;

        private int[] array1;
        private int[] array2;

        private Random rnd = new Random();

        public void init() {           

            Console.WriteLine("Bienvenido, al ejercicio 19, por favor, introduzca el tamaño de su array: ");
            size = int.Parse(Console.ReadLine());

            arrayFill(ref array1, size);

            array2 = array1;

            arrayFill(ref array1, size);

            Console.WriteLine("Array 1: ");
            showArray(array1);
            Console.WriteLine("Array 2: ");
            showArray(array2);
            Console.WriteLine("Array 1 * Array 2: ");
            showArray(mergeArrays(array1,array2));
        }

        public void arrayFill(ref int[] array, int length) {
            array = new int[length];

            for (int i = 0; i < length; i++) {
                array[i] = getRandomNumber(0, 100); ;
            }
        }

        public void showArray(int[] array) {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i]);

                if (i != array.Length - 1) {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }

        private int getRandomNumber(int start, int end) {
            return rnd.Next(start, end);
        }

        private int[] mergeArrays(int[] a1, int[] a2) {
            int[] newArray = new int[size];

            for (int i=0; i<size; i++) {
                newArray[i] = a1[i] * a2[i];
            }

            return newArray;
        }
    }
}
