using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var avengersinfinitywar =
                new Movie("Avengers Infinity War", "Action", "PG 13", 2018, 120, "Russo");
            var trainingday =
                new Movie("Training Day", "Thriller", "R", 2001, 120, "Fuqua");
            var djangounchained =
                new Movie("Django Unchained", "Western", "R", 2012, 120, "Tarantino");
            var pulpfiction =
                new Movie("Pulp Fiction", "Drama", "R", 1994, 120, "Tarantino");
            var diehard =
                new Movie("Die Hard", "Action", "R", 1988, 120, "McTieran");

            Console.WriteLine(avengersinfinitywar.Print());
            Console.WriteLine(trainingday.Print());
            Console.WriteLine(djangounchained.Print());
            Console.WriteLine(pulpfiction.Print());
            Console.WriteLine(diehard.Print());

           
        }
    }
}
