// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Pattern Matching");
int v = 10;
ProcessValuesUponTypeOlder(v);
string str = "C# is Great";
ProcessValuesUponTypeOlder(str);
Console.WriteLine();
Console.WriteLine("Pattern Maaching");
ProcessValuesUponTypeNew(v);
ProcessValuesUponTypeNew(str);

// Lets declare a COmplex List
List<object> objectist = new List<object>()
{
    10,20,30,40,10.5,20.3,30,5,40.7,
    'A', 'B', 'C', 'D', "Mahesh", "Tejas",
    new List<int> {90,80,70,60 },
    null, -9,-7,-5, 
    new List<string>{ "Amitabh","Rushi","Sashi","Raj" }
};
Console.WriteLine();
ProcessCollection(objectist);

Console.ReadLine(); 


static void ProcessValuesUponTypeOlder(object val)
{
    // OLder way
    if (val.GetType() == typeof(int))
    {
        Console.WriteLine($"Interger Process  = {Convert.ToInt32(val) * Convert.ToInt32(val)}");
    }
    if (val.GetType() == typeof(string))
    {
        Console.WriteLine($"Processed = {val.ToString().ToUpper()}");
    }
}


static void ProcessValuesUponTypeNew(object val)
{
    if (val is int v)
    {
        v = Convert.ToInt32(val);
        Console.WriteLine($"Interger Process  = {v * v}");
    }
    if (val is string s)
    {
        s = Convert.ToString(val);
        Console.WriteLine($"Processed = {s.ToUpper()}");
    }
}


static void ProcessCollection(List<object> values)
{
    Console.WriteLine("Pocessing a collection");
    int sumIntList = 0;
    string concatStringList = string.Empty;
    int justSum = 0;
    foreach (object val in values)
    {
        switch (val)
        {
            case IEnumerable<int> intList:
                foreach (var item in intList)
                {
                    sumIntList+=item;
                }
                Console.WriteLine($"SUm of all numbers in LIst is = {sumIntList}");
                break;
            case IEnumerable<string> strList:
                foreach (var item in strList)
                {
                    concatStringList += $"{item} ";
                }
                Console.WriteLine($"Concatination {concatStringList}");
                break;
            case string s:
                Console.WriteLine($"SIngle String {s}");
                break;
            case int x when x < 0:
                Console.WriteLine($"Negative INtegers {x}");
                break;
            case int v:
                Console.WriteLine($"Positive INtegers {v}");
                break;
            case null:
                Console.WriteLine("How come a value be null");
                break;
            case double d:
                Console.WriteLine($"Double {d}");
                break;
            default:
                Console.WriteLine("Finally.....");
                break;
        }
    }
}
