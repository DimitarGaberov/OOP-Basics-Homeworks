using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);

                if (age > 30)
                {
                    people.Add(new Person(name, age));
                }
            }

            foreach (var person in people.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
