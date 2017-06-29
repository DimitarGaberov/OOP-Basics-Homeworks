using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public void GetOldestMember()
    {
        var oldest = people.OrderByDescending(p => p.Age).FirstOrDefault();
        System.Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

