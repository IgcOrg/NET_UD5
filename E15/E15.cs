using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E15 {
        public void init() {
            int[] array = { 2, 34, 22, 4, 43, 82, 17, 90, 9, 13 };
            int[] array2 = new int[10];

            showArray(array);

            for (int i=array.Length; i>0; i--) {
                array2[array.Length - i] = array[i - 1];
            }

            showArray(array2);
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
