using System;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System.Linq;

namespace ConsoleApplication
{
    internal class Program
    {
        // Created instance of SamuraiContext. 
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            // This is not best practise to EnsureCreated, just for Demo (normally it uses in testing)
            // This will read the provider and connection string defined on context class 
            // Then it check whether DB exist or not. if not --> it will
            // 1. read the context
            // 2. determine how DB should looks like
            // 3. create the DB for us. 
            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");
            Console.Write("Press Any Key");
            Console.ReadKey();

        }

        private static void AddSamurai()
        {
            // This creates new Samurai Object
            var Samurai = new Samurai { Name = "Julie" };
            // Adds it to the context.Samurais DbSet, 
            // this is in-memory-collection of samurais that context keep track of
            context.Samurais.Add(Samurai);
            // This saves in-memory-collection of context to the DB
            context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            // This is Linq query to get all the Samurais and get List of Objects
            var samuraies = context.Samurais.ToList();
            // First write count of samurais
            Console.WriteLine($"{text}: Samurai count is {samuraies.Count}");
            // Then write all names of samurais
            foreach(var samurai in samuraies)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
