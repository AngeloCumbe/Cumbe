using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            List<owner> owners = data.Getowners();

            // Filter
            List<owner> filteredOwners = owners.Where(x => x.name == "Enriqueta").ToList();
            Console.WriteLine($"The number of owners with username 'Enriqueta' is {filteredOwners.Count}");
            Console.WriteLine($"==================");
            // Count
            foreach (var owner in filteredOwners)
            {
                Console.WriteLine($"Name: {owner.name} Username: {owner.username}");

            }
            Console.WriteLine($"==================");
            // OrderBy
            List<owner> orderedOwners = owners.OrderBy(x => x.name).ThenBy(x => x.username).ToList();
            foreach (var owner in orderedOwners)
            {
                Console.WriteLine($"Name: {owner.name} Username: {owner.username}");
            }
            Console.WriteLine($"==================");
            // GroupBy
            var groupedOwners = owners.GroupBy(x => x.age);
            foreach (var group in groupedOwners)
            {
                Console.WriteLine($"Age: {group.Key}");   
            }
            Console.WriteLine($"==================");
        }
    }
}