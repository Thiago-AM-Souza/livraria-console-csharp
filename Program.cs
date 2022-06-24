using LivrariaConsole.Class;
using System;

namespace LivrariaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LivrariaVirtual livraria = new LivrariaVirtual();

            while (true)
            {
                int escolha;

                Console.WriteLine("Menu");
                Console.WriteLine("1 - Cadastrar Livro\n" +
                    "2 - Realizar Venda\n" +
                    "3 - Listar Livros\n" +
                    "4 - Listar Vendas\n" +
                    "5 - Sair");
                escolha = int.Parse(Console.ReadLine());

                if (escolha < 1 || escolha > 5)
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
                else if (escolha == 1)
                {
                    livraria.CadastrarLivro();
                }
                else if (escolha == 2)
                {
                    livraria.RealizarVenda();
                }
                else if (escolha == 3)
                {
                    livraria.ListarLivros();
                }
                else if (escolha == 4)
                {
                    livraria.ListarVendas();
                }
                else if (escolha == 5)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
            }
        }
    }
}
