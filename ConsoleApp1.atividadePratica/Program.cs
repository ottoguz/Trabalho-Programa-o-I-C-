using System;
using static ConsoleApp1.atividadePratica.Threading;

namespace ConsoleApp1.atividadePratica
{
    class Program
    {
        static void Main(string[] args)
        {  
              /*EXERCÍCIO 3) A partir dos estudos realizados até a Aula 4, faça um algoritmo utilizado THREADS que imprima 
              números primos existentes entre 0 até N, onde “N” terá tamanho igual aos dois últimos dígitos do RU aluno. 
              Caso for zero, insira um comando para digitar outro valor. Dica: para cada faixa de dez valores crie um thread 
              e dispare o processo para cada uma delas.*/

            Console.WriteLine("Resolução do exercício 3) Números primos:\n"); 
             //Instanciação do exercício 3
            Threading1 t1 = new Threading1();
            Console.WriteLine("\n------------------------------------------------------\n");
        }
    }
}
