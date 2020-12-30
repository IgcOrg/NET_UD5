using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E21 {
        private int size = 0;

        private int[] array;
        private Random rnd = new Random();
        public void init() {
            int num = 0;

            Console.WriteLine("Bienvenido al ejercicio 20, por favor, introduzca el tamaño de su array: ");
            size = int.Parse(Console.ReadLine());

            arrayFill();

            Console.WriteLine("Indique ahora el número que desea filtrar su array: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Array original: ");
            showArray(array);

            Console.WriteLine("Array filtrada: ");
            showArray(arrayFilter(num));
        }

        public void arrayFill() {
            array = new int[size];

            for (int i = 0; i < size; i++) {
                array[i] = getRandomNumber(0, 300); ;
            }
        }

        public void showArray(int [] array) {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i]);

                if (i != array.Length - 1) {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }        

        public int[] arrayFilter(int number) {
            List<int> filteredList = new List<int>();

            for (int i=0; i<size; i++) {
                if (getLastDigit(array[i])==number) {
                    filteredList.Add(array[i]);
                }
            }

            return filteredList.ToArray();
        }

        private int getRandomNumber(int start, int end) {
            return rnd.Next(start, end);
        }

        private int getLastDigit(int number) {
            return number % 10;
        }
    }
}
