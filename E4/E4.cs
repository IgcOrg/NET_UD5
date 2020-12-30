using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E4 {
        public void init() {
            int n = 0;

            Console.WriteLine("Introduce un número para calcular su factorial: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, factorial(n));
        }
        public long factorial(int number) {
            long factorial = number;

            for (int i=number-1; i>=1; i--) {
                factorial *= i;
            }

            return factorial;
        }
    }
}
