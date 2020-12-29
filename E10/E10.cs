using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E10 {
        public void init() {
            int number = 0;

            Console.WriteLine("Introduzca un número para mostrar su tabla de multiplicar: ");
            number = int.Parse(Console.ReadLine());

            showTable(number);
        }

        public void showTable(int number) {
            for (int i=0; i<=10; i++) {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
    }
}
