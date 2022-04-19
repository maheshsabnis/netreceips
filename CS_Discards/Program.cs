// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Add = {Add(40,50)}");
Console.ReadLine(); 
static int Add(int x,int y)
{ 
    // The discard
    var _ = x + y;
    return _;
}


