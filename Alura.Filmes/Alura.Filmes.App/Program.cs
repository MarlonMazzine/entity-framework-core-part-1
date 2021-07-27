﻿using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using System;

namespace Alura.Filmes.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var ator = new Ator();
                ator.PrimeiroNome = "Tom";
                ator.UltimoNome = "Hanks";
                //contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;
                contexto.Atores.Add(ator);

                contexto.SaveChanges();
            }
        }
    }
}