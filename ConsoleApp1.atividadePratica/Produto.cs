using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.atividadePratica
{
    public class Produto
    {
        //Elementos a serem usados na classe produto
        private string nome;
        private double preco;
        private int quantidade ;
        

        //Método criado para inicializar o estoque via teclado
        //Como se pede no exercício:< Nome do produto: TV | Preço do produto: R$900.00 | Quantidade em estóque = 10 >
        public void inicializaEstoque()
        {
            Console.WriteLine("Digite os valores para iniciar o estoque");
            //Inserção do nome do produto
            Console.Write("Nome do produto: ");
            nome = Console.ReadLine();

            //Inserção do preço unitário do produto
            Console.Write("Preço unitário do produto: ");
            preco = Convert.ToDouble(Console.ReadLine());

            //Inserção da quantidade em estoque
            Console.Write("Quantidade em estoque: ");
            quantidade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Estoque atualizado!\n");
            Console.WriteLine($" - Produto: {nome}\n - Preço unitário: {preco}\n - Total em estoque: {quantidade}\n - Valor total: R${ValorTotalEmEstoque()}\n");
        }
        
        //Método que trata o valor total em R$ do estoque
        public double ValorTotalEmEstoque() 
        {
            double total = quantidade * preco;
            return total;
        }

        //Metodo para adicionar produto ao estoque
        public void AdicionarProduto(int quantidade = 0)
        {
            //Adição de produto no estoque via teclado
            Console.Write("\nQuantidade de produtos a ser adicionada ao estoque(ÚLTIMO DÍGITO DO RU:3602435): ");
            int entrada = Int32.Parse(Console.ReadLine());

            this.quantidade += entrada;
         
            //String que mostra no console a atualização no estoque
            Console.WriteLine("Estoque atualizado!\n");
            Console.WriteLine($" - Produto: {nome}\n - Preço unitário: {preco}\n - Total em estoque: {this.quantidade}\n - Valor total: R${ValorTotalEmEstoque()}\n");
        }


        //Metodo para remoção de produto do estoque
        public void RemoverProduto(int quantidade = 0)
        {
            //Remoção de produto no estoque via teclado
            Console.Write("Quantidade de produtos a ser removida do estoque: ");
            int saida = Int32.Parse(Console.ReadLine());

            this.quantidade -= saida;

            //String que mostra no console a atualização no estoque
            Console.WriteLine("Estoque atualizado!");
            Console.WriteLine($" - Produto: {nome}\n - Preço unitário: {preco}\n - Total em estoque: {this.quantidade}\n - Valor total: R${ValorTotalEmEstoque()}\n");
        }
    }
}
