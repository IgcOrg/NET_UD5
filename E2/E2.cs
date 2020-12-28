using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E2 {
        public void init() {
            int inicio = 0;
            int final = 0;

            int totalRandoms = 0;
            
            Console.WriteLine("Generador de números aleatorios: ");
            
            Console.WriteLine("Introduzca el inicio del rango de números: ");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el final del rango de números: ");
            final = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca cuántos números se van a generar: ");
            totalRandoms = int.Parse(Console.ReadLine());

            for (int i=1; i<=totalRandoms; i++) {
                Console.WriteLine("- {0}", GetRandom(inicio, final));
            }
        }

        public int GetRandom(int start, int end) {
            Random rnd = new Random();

            return rnd.Next(start, end);
        }
    }
}
