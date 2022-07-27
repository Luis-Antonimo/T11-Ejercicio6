using System;

namespace T11_Ejerciocio6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Libro quijote = new Libro(9568686, "El Quijote", "Cervantes", 2000);
            Console.WriteLine(quijote.ToString());
            Libro diaPerfecto = new Libro(90989786, "Un día perfecto", "Ira Levin", 300);
            Console.WriteLine(diaPerfecto.ToString());

            if (quijote.getNumPaginas() > diaPerfecto.getNumPaginas())
            {
                Console.WriteLine("El quijote tiene más páginas");
            }
            else
            {
                Console.WriteLine("Un día perfecto tiene más páginas");
            }
        }
    }
}