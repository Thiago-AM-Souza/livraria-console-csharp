using System;

public abstract class Livro
{
    public int Id { get; protected set; }
    public string Titulo { get; set; }
    public string Autores { get; set; }
    public string Editora { get; set; }
    public double Preco { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }

}
