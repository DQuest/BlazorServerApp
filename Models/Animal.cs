namespace BlazorServerApp.Models;

public class Animal
{
    public Animal()
    {
    }

    public Animal(string? name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Breed { get; set; }
}