// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Tuples");
// Roslyn COmpiler will internally define variables with Types
// unNamed Tupes with De-COnstructions
var (firstName,lastName) = ("Mahesh", "Sabnis");


Console.WriteLine($"First Name {firstName} Last Name {lastName}");

// NAmed objet
Tuple<int, string, int> emp = new Tuple<int, string, int>(101, "Mahesh", 230000);

Print(emp);


static void Print( Tuple<int, string,int> tuple)
{
    Console.WriteLine($"Value in Tuple {tuple.Item1} {tuple.Item2} {tuple.Item3}");
}


Console.ReadLine();
