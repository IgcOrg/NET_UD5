using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E16 {
        public void init() {
            string number = string.Empty;

            Console.WriteLine("Introduzca un número para saber si es capicua: ");
            number = Console.ReadLine();

            Console.WriteLine(isCapicua(number) ? "Es capicua" : "No es capicua");
        }

        public bool isCapicua(string number) {
            bool capicua = true;
            
            for (int i = 0; i < number.Length; i++) {
                if (number[i] != number[number.Length - i - 1])
                    capicua = false;
            }

            return capicua;
        }
    }
}
