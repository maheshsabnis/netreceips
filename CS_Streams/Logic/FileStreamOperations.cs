using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace CS_Streams.Logic
{
    
    internal class FileStreamOperations
    {
        private string path = @"c:\Coditas\Files"; 

        public void CreateFile(string fileName)
        {
            string filePath = $@"{path}\{fileName}";

            // 1. Check if the File Exist
            if (File.Exists(filePath))
            {
                Console.WriteLine("File is Already Available");
            }
            else
            {
                // 2. Create a FileStream Object
                FileStream fs = new FileStream(filePath,FileMode.Create);
                fs.Close();
                fs.Dispose(); // clean the fs object from Managed Heap
            }
        }

        public void WriteFile(string fileName)
        {
            string filePath = $@"{path}\{fileName}";
            
            // 1. Create a FileStream Object
            // The File will be Open if it exists: FileMode.OpenOrCreate
            // The File is Opened for the Write Operations: FileAccess.Write  
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            // 2. Create an Instance of StreamWriter
            StreamWriter writer = new StreamWriter(fs);
            // 3. Write Data to Stream
            writer.WriteLine("I am the File that is created using the FileStream Object.\n This is great object in .NET Programming to work with Streams");
            // 4. Close Stream to Make sure that the Stream of data is commited to file
            writer.Close();
            // 5. Close Stream to Commit the File
            fs.Close();
            
        }

        public void ReadFile(string fileName)
        {
            string filePath = $@"{path}\{fileName}";

            // 1. Create a FileStream Object
            // The File will be Open if it exists: FileMode.OpenOrCreate
            // The File is Opened for the Write Operations: FileAccess.Write  
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // 2. Create an Instance of StreamReader
            StreamReader reader = new StreamReader(fs);
            // 5. Close Stream to Commit the File
            //  string data = reader.ReadLine();
            string data = reader.ReadToEnd();   
            reader.Close();
            Console.WriteLine($"Data from file = \n {data}");
            fs.Close();

        }


        public void AppendFile(string fileName)
        {
            string filePath = $@"{path}\{fileName}";

            // 1. Create a FileStream Object
            // The File will be Open if it exists: FileMode.OpenOrCreate
            // The File is Opened for the Write Operations: FileAccess.Write  
            FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            // 2. Create an Instance of StreamWriter
            StreamWriter writer = new StreamWriter(fs);
            // 3. Write Data to Stream
            writer.WriteLine("I am the newly Appended data.\n FileStream is great feature in .NET.");
            // 4. Close Stream to Make sure that the Stream of data is commited to file
            writer.Close();
            fs.Close();

        }
    }
}
