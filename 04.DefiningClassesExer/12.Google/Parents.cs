public class Parents
{
    private string name;
    private string birthday;

    public Parents(string name, string birthday)
    {
        this.Name = name;
        this.BirthDay = birthday;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public string BirthDay
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.BirthDay}";
    }
}

