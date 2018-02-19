using System.Collections.Generic;

public class Family
{
    public List<Person> family = new List<Person>();
    
    public void AddMember(Person member)
    {
        family.Add(member);
    } 
    
    public Person GetOldestMember()
    {
        var maxAge = int.MinValue;
        var oldestPerson = new Person();

        foreach (var member in family)
        {
            if (member.Age > maxAge )
            {
                maxAge = member.Age;
                oldestPerson = member;
            }
        }

        return oldestPerson;
    }    
}

