using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5 {
    class E7 {
        public void init() {
            double euros = 0;
            string currency = string.Empty;

            Console.WriteLine("Introduzca la cantidad de euros que quiera convertir: ");
            euros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la moneda a la cual quiere convertir sus euros, los valores válidos son 'libras', 'dolares', 'yenes'");
            currency = Console.ReadLine();

            ShowExchange(euros, currency);
        }
        public void ShowExchange(double qty, string currency) {
            switch (currency) {
                case "libras":
                    Console.WriteLine("{0} euros = {1} libras", qty, Math.Round(qty*0.86, 2));
                    break;
                case "dolares":
                    Console.WriteLine("{0} euros = {1} dolares", qty, Math.Round(qty * 1.28611, 2));
                    break;
                case "yenes":
                    Console.WriteLine("{0} euros = {1} yenes", qty, Math.Round(qty * 129.852, 2));
                    break;
            }
        }
    }
}
