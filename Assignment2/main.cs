using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        double[] numbers = { 645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25 };
        List<Person> people = new List<Person>
        {
            new Person { Name = "Hal", Age = 20 },
            new Person { Name = "Susann", Age = 31 },
            new Person { Name = "Dwight", Age = 19 },
            new Person { Name = "Kassandra", Age = 21 },
            new Person { Name = "Lawrence", Age = 25 },
            new Person { Name = "Cindy", Age = 22 },
            new Person { Name = "Cory", Age = 27 },
            new Person { Name = "Mac", Age = 19 },
            new Person { Name = "Romana", Age = 27 },
            new Person { Name = "Doretha", Age = 32 },
            new Person { Name = "Danna", Age = 20 },
            new Person { Name = "Zara", Age = 23 },
            new Person { Name = "Rosalyn", Age = 26 },
            new Person { Name = "Risa", Age = 24 },
            new Person { Name = "Benny", Age = 28 },
            new Person { Name = "Juan", Age = 33 },
            new Person { Name = "Natalie", Age = 25 }
        };

        // Sort numbers
        Array.Sort(numbers);

        // Sort people by name
        var sortedByName = people.OrderBy(p => p.Name).ToList();

        // Sort people by age descending, then by name
        var sortedByAge = people.OrderByDescending(p => p.Age)
                                 .ThenBy(p => p.Name)
                                 .ToList();

        // Output results
        Console.WriteLine("Sorted numbers:");
        foreach (var num in numbers) {
            Console.WriteLine(num + " ");
        }

        Console.WriteLine("\n\nSorted people by name:");
        foreach (var person in sortedByName) {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }

        Console.WriteLine("\nSorted people by age:");
        foreach (var person in sortedByAge) {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }
    }
}
