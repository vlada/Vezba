using System;
using System.Linq;
using SamuaraiApp.Domain;
using SamuraiApp.Data;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {

            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            var samurai = context.Samurais.Add(new Samurai() {Name = "Julie"});
            context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurayi count is: {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
