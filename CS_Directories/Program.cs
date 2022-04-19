using System;
using CS_Directories.Logic;
namespace CS_Directories
{
    internal class Program
    {
        static DirectoryOperations dirOp;
            
        static void Main(string[] args)
        {
            dirOp = new DirectoryOperations();  
            Console.WriteLine("USing Directories");
            dirOp.CreateDirectoiry(@"C:\MyDir");
            //  dirOp.ReadAllFileFromDirectory();
            // dirOp.ReadAllFileFromDirectoryWithLINQ();
            dirOp.ReadAllFiles(@"c:\Coditas");
            Console.WriteLine("Done");
            Console.ReadLine(); 
        }
    }
}
