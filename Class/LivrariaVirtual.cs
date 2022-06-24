using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaConsole.Class
{
    
    class LivrariaVirtual
    {
        private const int MaxImpressos = 10;
        private const int MaxEletronicos = 20;
        private const int MaxVendas = 50;
        private int NumImpressos { get; set; }
        private int NumEletronicos { get; set; }
        private int NumVendas { get; set; } = 0;


        private Impresso[] impressos { get; set; } = new Impresso[MaxImpressos];
        private Eletronico[] eletronicos { get; set; } = new Eletronico[MaxEletronicos];
        public Venda[] vendasArray { get; set; } = new Venda[MaxVendas];

        public LivrariaVirtual()
        {
        }

        public LivrariaVirtual(int numImpressos, int numEletronicos, int numVendas)
        {
            NumImpressos = numImpressos;
            NumEletronicos = numEletronicos;
            NumVendas = numVendas;
        }

        public void CadastrarLivro()
        {
            int escolha;

            while (true)
            {
                Console.WriteLine("1 - Impresso\n" +
                "2 - Eletrônico\n" +
                "3 - Ambos\n" +
                "4 - Voltar ao menu anterior");

                escolha = int.Parse(Console.ReadLine());              

                
                if (escolha == 1)
                {   
                    if (NumImpressos < MaxImpressos)
                    {
                        Console.WriteLine("Qual o título do livro: ");
                        string Titulo = Console.ReadLine();
                        Console.WriteLine("Qual o autor do livro: ");
                        string Autor = Console.ReadLine();
                        Console.WriteLine("Qual a editora do livro: ");
                        string Editora = Console.ReadLine();
                        Console.WriteLine("Qual o valor do livro: ");
                        double Valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o frete do livro: ");
                        double Frete = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade do livro em estoque: ");
                        int Estoque = int.Parse(Console.ReadLine());
                        Impresso livro = new Impresso(NumImpressos, Titulo, Autor, Editora, Valor, Frete, Estoque);
                        impressos[NumImpressos] = livro;
                        Console.WriteLine("Cadastrado com sucesso.");
                        NumImpressos += 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Máximo de livros impressos cadastrados.");
                    }

                }
                else if (escolha == 2)
                {
                    if (NumEletronicos < MaxEletronicos)
                    {
                        Console.WriteLine("Qual o título do livro: ");
                        string Titulo = Console.ReadLine();
                        Console.WriteLine("Qual o autor do livro: ");
                        string Autor = Console.ReadLine();
                        Console.WriteLine("Qual a editora do livro: ");
                        string Editora = Console.ReadLine();
                        Console.WriteLine("Qual o valor do livro: ");
                        double Valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tamanho do livro");
                        int Tamanho = int.Parse(Console.ReadLine());
                        Eletronico livro = new Eletronico(NumEletronicos, Titulo, Autor, Editora, Valor, Tamanho);
                        eletronicos[NumEletronicos] = livro;
                        Console.WriteLine("Cadastrado com sucesso.");
                        Console.WriteLine(livro);
                        NumEletronicos += 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Máximo de livros cadastrados.");
                    }
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Qual o título do livro: ");
                    string Titulo = Console.ReadLine();
                    Console.WriteLine("Qual o autor do livro: ");
                    string Autor = Console.ReadLine();
                    Console.WriteLine("Qual a editora do livro: ");
                    string Editora = Console.ReadLine();
                    Console.WriteLine("Qual o valor do livro: ");
                    double Valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o frete do livro: ");
                    double Frete = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantidade do livro em estoque: ");
                    int Estoque = int.Parse(Console.ReadLine());            
                    Console.WriteLine("Tamanho do livro");
                    int Tamanho = int.Parse(Console.ReadLine());
                    Eletronico eletronico = new Eletronico(NumEletronicos, Titulo, Autor, Editora, Valor, Tamanho);
                    Impresso impresso = new Impresso(NumImpressos, Titulo, Autor, Editora, Valor, Frete, Estoque);
                    eletronicos[NumEletronicos] = eletronico;
                    impressos[NumImpressos] = impresso;
                    NumEletronicos += 1;
                    NumImpressos += 1;
                    break;
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Retornando ao menu anterior...");
                    break;
                }
                else if (escolha < 1 || escolha > 4)
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
        }

        public void RealizarVenda()
        {
            Venda venda = new Venda();
            Impresso impresso = new Impresso();

            Console.WriteLine("Nome do cliente: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Quantidade de livros a serem adquiridos: ");
            int Qtde = int.Parse(Console.ReadLine());
            double valor = 0;
            Livro[] livros = new Livro[MaxImpressos + MaxEletronicos];

            for (int i = 0; i < Qtde; i++){
                while (true)
                {
                    Console.WriteLine("1 - Impresso\n" +
                                      "2 - Eletronico");
                    int tipo = int.Parse(Console.ReadLine());
                    if (tipo == 1)
                    {
                        ListarLivrosImpressos();
                        Console.WriteLine("Escolha por ID o livro que deseja: ");
                        int id = int.Parse(Console.ReadLine());
                        livros[NumVendas] = impressos[id];
                        valor += impressos[id].Preco;
                        livros[i] = impressos[id];
                        impressos[id].AtualizarEstoque();
                        break;
                    }
                    else if (tipo == 2)
                    {
                        ListarLivrosEletronicos();
                        Console.WriteLine("Escolha por ID o livro que deseja: ");
                        int id = int.Parse(Console.ReadLine());
                        livros[NumVendas] = eletronicos[id];
                        valor += eletronicos[id].Preco;
                        livros[i] = eletronicos[id];
                        break;
                    }
                    else if (tipo == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                    }
                }
            }
            vendasArray[NumVendas] = new Venda(NumVendas, Nome, valor);
            vendasArray[NumVendas].CarrinhoLivros = livros;
            NumVendas += 1;
        }

        public void ListarLivrosImpressos()
        {
            Console.WriteLine("Livros Impressos: \n");

            foreach (var item in impressos)
            {
                if (item != null && item.Estoque > 0)
                {
                    Console.WriteLine(item);
                }               
            }

        }
        public void ListarLivrosEletronicos()
        {
            Console.WriteLine("Livros Eletronicos: \n");

            foreach (var item in eletronicos)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ListarLivros()
        {
            ListarLivrosImpressos();
            ListarLivrosEletronicos();
        }

        public void ListarVendas()
        {
            Console.WriteLine("Vendas realizadas: \n");
            foreach (var item in vendasArray)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    foreach (var livro in item.CarrinhoLivros)
                    {
                        if (livro != null)
                        {
                            Console.WriteLine(livro);
                        } 
                    }
                    Console.WriteLine("--------------------------");
                }
            }
        }
}
}
