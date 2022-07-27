using System;

public class Libro
{

    private int isbn;
    private string titulo;
    private string autor;
    private int numPaginas;

    public int Isbn { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumPaginas { get; set; }

    public int getNumPaginas()
    {
        return this.numPaginas;
    }


    public Libro() { }

    public Libro(int _isbn, string _titulo, string _autor, int _numPaginas)
    {
        this.isbn = _isbn;
        this.titulo = _titulo;
        this.autor = _autor;
        this.numPaginas = _numPaginas;
    }

    public override string ToString()
    {
        return "El libro " + titulo + " con ISBN " + isbn + " creado por el autor " + autor + " tiene " + numPaginas + " páginas";
    }
}