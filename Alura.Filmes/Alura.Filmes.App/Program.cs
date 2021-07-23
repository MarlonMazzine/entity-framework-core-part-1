using Alura.Filmes.App.Dados;

namespace Alura.Filmes.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                foreach (var ator in contexto.Atores)
                {
                    System.Console.WriteLine(ator);
                }

            }
        }
    }
}