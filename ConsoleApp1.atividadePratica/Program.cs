﻿using System;
using static ConsoleApp1.atividadePratica.Threading;

namespace ConsoleApp1.atividadePratica
{
    class Program
    {
        static void Main(string[] args)
        {  
             /*
            EXERCÍCIO 1) Ler os valores dos três coeficientes "a", "b" e "c" de uma equação 
            do segundo grau (????2+????+??=0). Em seguida, mostrar os valores das 
            raízes da equação, usando a fórmula de Bhaskara (veja abaixo). 
            Se a equação não possuir raízes fazer um comparativo de delta 
            menor que zero (o valor de “a” não pode ser zero, e o valor de “delta” 
            não pode ser negativo), mostrar uma mensagem “Impossível calcular”.
           */

            Console.WriteLine("Resolução do exercício 1) Baskara:\n ");
            //Instanciação do exercício 1
            Baskara baskara = new Baskara();
            Console.WriteLine("------------------------------------------------------\n");        


            /*
            EXERCÍCIO 2) Digite o número de produtos a ser adicionado ao estoque: 
            O último dígito do RU do aluno. Se o estoque for zero, faça um comando para inserir outro digito.
            Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00
            Digite o número de produtos a ser removido do estoque: 3 Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00
            • Realizar uma entrada no estoque e mostrar novamente os dados do produto
            • Realizar uma saída no estoque e mostrar novamente os dados do produto.
            */

            Console.WriteLine("Resolução do exercício 2) Estoque:\n ");
            //Instanciação do exercício 2
            Produto produto = new Produto();

            //Invocando o método que inicializa o estoque
            produto.inicializaEstoque();

            //Invocando o método para adicionar produtos ao estoque
            produto.AdicionarProduto();

            //Invocando o método para remover produtos do estoque
            produto.RemoverProduto(); 
            Console.WriteLine("------------------------------------------------------\n");


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
