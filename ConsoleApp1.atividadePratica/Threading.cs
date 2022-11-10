using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.atividadePratica
{
    internal class Threading
    {
        public class Threading1
        {
            int divisoes = 0;
            //Método para identificar se um número é primo
            public bool RetornaPrimo(int numero)
            {
                for(int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisoes++;
                    }
                }
                if (divisoes == 2)
                {
                    divisoes = 0;
                    return true;
                } else
                {
                    divisoes = 0;
                    return false;
                }
            }

            public Threading1()
            {
                //RU = dois últimos dígitos do meu RU(3602435)
                int RU = 35;
                //Array de integers onde os números de 0 a RU serão armazenados
                int[] numeros = new int[RU + 1];
                for(int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = i;
                }

                //Thread principal onde os números primos de 0 a 10 serão mostrados no terminal
                Thread threadPrincipal = Thread.CurrentThread;
                threadPrincipal.Name = "Thread Principal - Números Primos: ";
                Console.Write(threadPrincipal.Name);
                foreach(int numero in numeros)
                {
                    if (numero <= 10)
                    {
                        if(RetornaPrimo(numero) == true)
                        {
                            Console.Write(numero + " ");
                        }
                    } 
                }
                Thread.Sleep(10);
                Console.WriteLine("\n");

                //thread1: onde os números primos de 11 a 20 serão mostrados no terminal
                Thread thread1 = new Thread(Worker1);
                thread1.Name = "Thread 1 - Números Primos: ";
                Console.Write(thread1.Name);
                thread1.Start();
                Thread.Sleep(10);
                
                Console.WriteLine("\n");
                
                //thread2: onde os números primos de 21 a 30 serão mostrados no terminal
                Thread thread2 = new Thread(Worker2);
                thread2.Name = "Thread 2 - Números Primos: ";
                Console.Write(thread2.Name);
                thread2.Start();
                Thread.Sleep(10);

                Console.WriteLine("\n");

                //thread3: onde os números primos de 31 a 35 serão mostrados no terminal
                Thread thread3 = new Thread(Worker3);
                thread3.Name = "Thread 3 - Números Primos: ";
                Console.Write(thread3.Name);
                thread3.Start();
                Thread.Sleep(10);
                
                //Função que será executada em thread1 mostrando os números primos de 11 a 20
                void Worker1()
                {
                    foreach(int numero in numeros)
                    {
                        if(numero > 10 && numero <= 20)
                        {
                            if(RetornaPrimo(numero) == true)
                            {
                                Console.Write(numero + " ");
                            } 
                        }
                    }
                 }

                //Função que será executada em thread2 mostrando os números primos de 21 a 30
                void Worker2()
                {
                    foreach(int numero in numeros)
                    {
                        if(numero > 20 && numero <= 30)
                        {
                            if(RetornaPrimo(numero) == true)
                            {
                                Console.Write(numero + " ");
                            } 
                        }
                    }
                 }

                //Função que será executada em thread3 mostrando os números primos de 31 a 35
                 void Worker3()
                {
                    foreach(int numero in numeros)
                    {
                        if(numero > 30 && numero <= 35)
                        {
                            if(RetornaPrimo(numero) == true)
                            {
                                Console.Write(numero + " ");
                            } 
                        }
                    }
                 }
            }
        }
    }
}
