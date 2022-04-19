using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace CS_DynamicLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load Assembly Dnamically");
            // 1. Loading Assemby
            Assembly assembly = Assembly.LoadFrom(@"C:\Coditas\Elpt_Net\CS_MathLib\bin\Debug\CS_MathLib.dll");

            // 2.Read all Types from the Assembly
            Type [] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                // Namespace.ClassName
                Console.WriteLine($"Current Type = {type.FullName}");
                // 3. Create an instance of the Class
                object instance = assembly.CreateInstance(type.FullName);
                // 4. REad all methods of the current TYpe
                // MAke sure that you read only Pubiec,Instane, Declared only Methods
                // 
                MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (MethodInfo method in methods)
                {
                    // 5. Read method names
                    Console.WriteLine($"Method = {method.Name}");
                    // 6. Read method parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo param in parameters)
                    {
                        Console.WriteLine($"Name {param.Name} DataType {param.ParameterType}" +
                            $"Parameter Postion {param.Position}");
                    }
                            // Method Name, Method Acessibility, Overloaded Binder, Class Instace, MAthod Arguments
                    var res = type.InvokeMember(method.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.InvokeMethod, null, instance, new object[] { 100, 20 });
                    Console.WriteLine($"Result = {res}");
                }
            }

            Console.ReadLine();
        }
    }
}
