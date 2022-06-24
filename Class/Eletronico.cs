using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaConsole.Class
{
    class Eletronico : Livro
    {
        private int Tamanho { get; set; }

        public Eletronico()
        {
        }

        public Eletronico(int Id, string Titulo, string Autores, string Editora, double Preco, int Tamanho)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Autores = Autores;
            this.Editora = Editora;
            this.Preco = Preco;
            this.Tamanho = Tamanho;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id: #" + this.Id + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Autores: " + this.Autores + Environment.NewLine;
            retorno += "Editora: " + this.Editora + Environment.NewLine;
            retorno += "Preco: " + this.Preco + Environment.NewLine;
            retorno += "Tamanho: " + this.Tamanho + Environment.NewLine;
            return retorno;
        }
    }
}
