using System;

public class Impresso : Livro
{
    private double Frete { get; set; }
    public int Estoque { get; private set; }

    public Impresso()
    {
    }

    public Impresso(int Id, string Titulo, string Autores, string Editora, double Preco, double Frete, int Estoque)
    {
        this.Id = Id;
        this.Titulo = Titulo;
        this.Autores = Autores;
        this.Editora = Editora;
        this.Preco = Preco;
        this.Frete = Frete;
        this.Estoque = Estoque;
    }

    public void AtualizarEstoque()
    {
        this.Estoque -= 1;
    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "Id: #" + this.Id + Environment.NewLine;
        retorno += "Título: " + this.Titulo + Environment.NewLine;
        retorno += "Autores: " + this.Autores + Environment.NewLine;
        retorno += "Editora: " + this.Editora + Environment.NewLine;
        retorno += "Preco: " + this.Preco + Environment.NewLine;
        retorno += "Frete: " + this.Frete + Environment.NewLine;
        retorno += "Estoque: " + this.Estoque + Environment.NewLine;
        return retorno;
    }
}
