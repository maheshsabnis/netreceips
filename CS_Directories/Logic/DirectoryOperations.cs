using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_Directories.Logic
{
    internal class DirectoryOperations
    {
        public void CreateDirectoiry(string dirName)
        {
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            else
            {
                Console.WriteLine($"Directory {dirName} is already present");
            }
        }

        public void ReadAllFileFromDirectory()
        { 
           // 3 Parameters
           // p1: The Directory Name
           // p2: The Pattern to Read files
           // p3: The Current Directory File or files from all of its Subdirectories
           var files =  Directory.GetFiles(@"c:\Coditas", "*.cs", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
        public void ReadAllFileFromDirectoryWithLINQ()
        {
            // 3 Parameters
            // p1: The Directory Name
            // p2: The Pattern to Read files
            // p3: The Current Directory File or files from all of its Subdirectories
            // Change in .NET Frwk 4.0+
            var files = from file in Directory.GetFiles(@"c:\Coditas", "*.cs", SearchOption.AllDirectories)
                        select file;

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        public void ReadAllFiles(string dirName)
        {
            
            var files = from file in Directory.GetFiles(dirName, "*.cs", SearchOption.AllDirectories)
                        select file.Substring(22);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
