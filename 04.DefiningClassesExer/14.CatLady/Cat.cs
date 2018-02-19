public class Cat
{
    private string breed;
    private string name;

    public Cat(string breed, string name)
    {
        this.Breed = breed;
        this.Name = name;
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name}";
    }

}

