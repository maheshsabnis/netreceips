using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_UsingFile.Logic;

namespace CS_UsingFile
{
    internal class Program
    {
        static FileOperations fileOp;
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Files");
            fileOp = new FileOperations();

            // fileOp.CreateFile("MyFile.txt");


            //string[] strData = new string[] { "I Am First Entry",
            //       "I AM Second Entry",  "I am Third Entry"};

            //bool isFileWritten = fileOp.AppenDataToFile("MyFile.txt", strData);
            //if (isFileWritten)
            //    Console.WriteLine("File is Written Successfully");
            //else
            //    Console.WriteLine("File Write Failed");


            // Read Contents of the file as string

            //string contents = fileOp.ReadFileContentsAtOnce("MyFile.txt");
            //Console.WriteLine($"Contents from File \n {contents}");

            //Console.WriteLine();
            //Console.WriteLine("Reading File Contents as string Array");

            //string[] dataFromFile = fileOp.ReadFileContentsToArray("MyFile.txt");

            //foreach (var item in dataFromFile)
            //{
            //    Console.WriteLine($"Data = {item}");
            //}


            //  fileOp.CopyFileToDestFile("MyFile.txt", "MyNewFile.txt");

            //bool isFileDeleteSuccess = fileOp.DeleteFile("MyNewFile.txt");
            //if (isFileDeleteSuccess) Console.WriteLine("File is deleted");
            //else Console.WriteLine("File Delete Failed");

            //bool isFileMoveSuccess = fileOp.MoveFile("MyFile.txt");
            //if (isFileMoveSuccess) Console.WriteLine("File is Moved");
            //else Console.WriteLine("File Move Failed");

            //    fileOp.CreateAndWriteUTF8Data("MyFile.txt");

            fileOp.UsingFsForWriteRead();  

            Console.ReadLine();
        }
    }
}
