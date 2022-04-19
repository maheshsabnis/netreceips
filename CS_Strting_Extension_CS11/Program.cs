// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


const string password = "mahesh_sabnis";
// Standalone function
string ToPassword(string str) => new('*', str.Length);

Console.WriteLine(ToPassword(password));

// Older way of extension method
Console.WriteLine($"Older Way of Extension Method:   {password.ToPassword()}");
static class StringExtension
{
    public static string ToPassword(this string str)
    {
        return new('*', str.Length);
    }
}