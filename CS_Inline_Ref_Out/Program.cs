// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Inline Ref and Out");

// OLder way of using out

int x1;

GetChangedData(out x1);
Console.WriteLine(x1);

Console.WriteLine();
Console.WriteLine("ew Way of using Inline Out");
GetChangedData(out int x2);
Console.WriteLine(x2);
Console.ReadLine();

static void GetChangedData(out int x)
{
    x = 10;
}