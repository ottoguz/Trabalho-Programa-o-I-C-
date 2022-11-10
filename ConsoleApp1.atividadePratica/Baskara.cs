using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.atividadePratica
{
    internal class Baskara
    {        
        //Declaração dos valores para:
        //a(primeiro digito RU), b(segundo dígito RU),  c(Terceiro dígito RU)
        private double a = 3;
        private double b = 6;
        private double c = 0;

        public Baskara()
        {   //Declaração do delta
            double delta = (Math.Pow(b, 2)) - (4 * a * c);

            //Condicional para que a operação seja calculada apenas 
            //se o valor de delta for maior que 0 com "a" diferente de zero
            if (delta < 0 && a == 0)
            {
                Console.WriteLine("Impossivel calcular!");
            } else
            {   //Variaveis que armazenam as raizes
                double x1 = (- b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (- b - Math.Sqrt(delta)) / (2 * a);

                //Escrita dos resultados no terminal
                Console.WriteLine($"Para a equação {a}x² + {b}x + {c} = 0 as raízes são:\n");
                Console.WriteLine($"x1 = {x1} | x2 = {x2}");
            }
        }
    }
}
