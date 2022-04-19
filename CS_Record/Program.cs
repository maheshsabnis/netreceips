// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Lets INstantiate it
var p = new Person();
p.Id = 10001;
p.Name = "Kumar";

Console.WriteLine(p.Id + "  " + p.Name);

// DEfine Record

public record Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}