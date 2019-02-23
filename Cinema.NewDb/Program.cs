using System;

namespace CinemaApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CinemaContext())
            {
                Console.WriteLine("Enter Title of Cinema:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter Year of Cinema:");
                string year = Console.ReadLine();
                Console.WriteLine("Enter Category of Cinema:");
                string category = Console.ReadLine();
                db.Cinemas.Add(new Cinematbl { title = title });
                db.Cinemas.Add(new Cinematbl { year = year });
                db.Cinemas.Add(new Cinematbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Cinema in database:");
                foreach (var Cinematbl in db.Cinemas)
                {
                    Console.WriteLine(" - {0} {1} {2}", Cinematbl.title, Cinematbl.year, Cinematbl.category_name);
                }
            }
        }
    }
}