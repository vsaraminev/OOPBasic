public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        private set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        private set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        private set { age = value; }
    }


    public decimal Salary
    {
        get { return salary; }
        private set { salary = value; }
    }

    public decimal IncreaseSalary(decimal bonus)
    {
        var percentage = bonus / 100;

        if (this.Age < 30)
        {
            return this.Salary *= 1 + (percentage / 2);
        }
        else
        {
            return this.Salary *= 1 + percentage;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
    }
}

