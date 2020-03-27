using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = JsonConvert.DeserializeObject<Movie[]>(File.ReadAllText(@"movies.json"));

            var castNameFilter = "Arnold Schwarzenegger";

            //var erste = movies
            //.Select(e => e.Title)
            //.ToList();
            //foreach (var item in erste)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            // Sucht alle Filme in denen Arnold Schwarzenegger mitspielte
            var moviesList = movies.ToList();

            ////var castFilter = movies
            //    .FindAll(x => x.Cast.Contains(castNameFilter))
            //    .ToList();

            var castFilter2 = movies
            .Select(x => x.Cast)
            .Where(x => x.Contains("Arnold Schwarzenegger"))
            .ToList();

            //var castFilter3 = movies
            //.Select(typ => new { vTitle = typ.Title, vCast = typ.Cast })
            //.Where(typ => typ.vCast.Contains(castNameFilter))
            //.ToList();

            //foreach (var item in castFilter3)
            //{
            //    Console.WriteLine(item);
            //}

            // Sucht alle Filme in denen Dustin Hoffman mitgespielt hat die in das Genre Comedy fallen
            string genreFilterOption = "Comedy";
            castNameFilter = "Dustin Hoffman";

            var genreFilter = moviesList
                .FindAll(x => x.Genres.Contains(genreFilterOption))
                .Where(x => x.Cast.Contains(castNameFilter))
                .ToList();

            // ALternativer Filter länger und weniger gut lesbar
            var genreFilter2 = moviesList
                .Select(typ => new { typGenre = typ.Genres, typCast = typ.Cast })
                .Where(typ => typ.typCast.Contains(castNameFilter))
                .Where(typ => typ.typGenre.Contains(genreFilterOption))
                .ToList();



            // Erstelle List alle Schauspieler einmal
            var uniqueSchauspieler = movies
                .SelectMany(x => x.Cast)
                .Distinct();

            // Erstelle ein Liste der Top 100 Schauspieler aus allen Filmen sortiert nach der Anzahl ihrer Auftritte in Filmen
            var schauspieler = movies
                .SelectMany(x => x.Cast)
                .GroupBy(m => m)
                .Select(g => new { cast = g.Key, count = g.Count() })
                .OrderByDescending(e => e.count)
                .Take(100);

            // Liste jedes Filmgenre auf, dabei soll jedes Genre nur einmal auftauchen
            var uniqueGenre = movies
                .SelectMany(x => x.Genres)
                .Distinct();

            // Liste die Anzahl Filme für jedes Genre auf
            var genreCounter = movies
                .SelectMany(e => e.Genres)
                .GroupBy(g => g)
                .Select(o => new { genre = o.Key, count = o.Count() });

            // Liste die Anzahl Filme für jedes einzelne Jahr auf
            var yearCounter = movies
                .Select(x => x.Year)
                .GroupBy(y => y)
                .Select(g => new { year = g.Key, count = g.Count() });

        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string[] Cast { get; set; }
        public string[] Genres { get; set; }
    }
}
