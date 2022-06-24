using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaConsole.Class
{
    class Venda
    {
        private static int NumVendas { get; set; }
        private int Numero { get; set; }
        private string Cliente { get; set; }
        private double Valor { get; set; }

        private LivrariaVirtual Livraria { get; set; }

        public Livro[] CarrinhoLivros { get; set; } = new Livro[30];

        public Venda()
        {
        }
        public Venda(int numero, string cliente, double valor)
        {
            Numero = numero;
            Cliente = cliente;
            Valor = valor;
        }

        public void AddLivro(Livro Livro, int Index)
        {
            this.CarrinhoLivros[Index] = Livro;
        }

        public void ListarLivros()
        {
            foreach (var livro in CarrinhoLivros)
            {
                Console.WriteLine(livro);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Número da venda #{Numero}" + Environment.NewLine;
            retorno += $"Cliente: {Cliente}" + Environment.NewLine;
            retorno += $"Valor: R${Valor}" + Environment.NewLine;
            retorno += "Livros adquiridos: " + Environment.NewLine;

            //foreach (var item in CarrinhoLivros)
            //{
            //    if (item != null)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            return retorno;
        }
    }
}
