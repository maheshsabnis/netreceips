using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for File IO Operations
using System.IO;
namespace CS_UsingFile.Logic
{
    /// <summary>
    /// This class will contain all Logc for File Operations
    /// </summary>
    internal class FileOperations
    {
        // Hard-Coded File Path 
        string path = @"c:\Coditas\Files";
        public void CreateFile(string fileName)
        {
            // Check if the File Already Exists
            string filePath = $"{path}\\{fileName}";
            if (File.Exists(filePath))
            {
                Console.WriteLine($"Specified File {filePath} is Already exists");
            }
            else
            { 
               // Create a File
               File.Create(filePath);
            }
        }

        public bool WriteDataToFile(string fileName, string contents)
        {
            bool isSuccess = false;

            string filePath = $"{path}\\{fileName}";

            // if file not exists then return false
            if (!File.Exists(filePath))
            {
                isSuccess = false;
            }
            else
            {
                File.WriteAllText(filePath, contents);
                isSuccess = true;
            }

            return isSuccess; 
        }


        public bool AppenDataToFile(string fileName, string [] contents)
        {
            bool isSuccess = false;

            string filePath = $"{path}\\{fileName}";

            // if file not exists then return false
            if (!File.Exists(filePath))
            {
                isSuccess = false;
            }
            else
            {
                File.AppendAllLines(filePath, contents);
                isSuccess = true;
            }

            return isSuccess;
        }

        /// <summary>
        /// Read Entire File At Once into a string
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string ReadFileContentsAtOnce(string fileName)
        {
            string contents = String.Empty;
            string filePath = $"{path}\\{fileName}";
            if (!File.Exists(filePath))
            {
                contents = String.Empty;
            }
            else
            {
                 contents  = File.ReadAllText(filePath);
            }
            return contents;
        }

        /// <summary>
        /// Read Data from File as string Array
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string [] ReadFileContentsToArray(string fileName)
        {
            string [] contents = null;
            string filePath = $"{path}\\{fileName}";
            if (!File.Exists(filePath))
            {
                contents = null;
            }
            else
            {
                contents = File.ReadAllLines(filePath);
            }
            return contents;
        }

        public void CopyFileToDestFile(string sourceFile, string targetFile)
        {
            string sourceFilePath = $"{path}\\{sourceFile}";
            string targetFilePath = $"{path}\\{targetFile}";

            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine($"Sorry Source File {sourceFilePath} does not exist");
            }
            else
            {
                // Copy File
                // If the Target File is already availabe then following method call 
                // will throw an exception
                
                
                // File.Copy(sourceFilePath, targetFilePath);

                // If the file to be Overwritten, then pass the third parameter 
                // as 'true'

                File.Copy(sourceFilePath, targetFilePath, true);
                Console.WriteLine("File copy is successful");
            }
        }

        public bool DeleteFile(string fileName)
        {
            bool isDeleteSuccess = false;

            string filePath = $"{path}\\{fileName}";

            // if file not exists then return false
            if (!File.Exists(filePath))
            {
                isDeleteSuccess = false;
            }
            else
            {
                File.Delete(filePath);
                isDeleteSuccess = true;
            }

            return isDeleteSuccess;
        }

        public bool MoveFile(string fileName)
        {
            bool isFileMoveSuccess = false;

            string filePath = $"{path}\\{fileName}";

            // if file not exists then return false
            if (!File.Exists(filePath))
            {
                isFileMoveSuccess = false;
            }
            else
            {
                // The File will be moved from 'filePath' to ' @"c:\Coditas\MyMovedFile.txt"'
                File.Move(filePath, @"c:\Coditas\MyMovedFile.txt");
                isFileMoveSuccess = true;
            }

            return isFileMoveSuccess;
        }


        public void CreateAndWriteUTF8Data(string fileName)
        {
            // Check if the File Already Exists
            string filePath = $"{path}\\{fileName}";
            if (File.Exists(filePath))
            {
                Console.WriteLine($"Specified File {filePath} is Already exists");
            }
            else
            {
                // 1. Create a Byte Array by using UTF8Encoing class and its GetBytes() method

                Byte[] data = new UTF8Encoding(true).GetBytes("I am an UTF 8 Data");
               
                // Create a File and point it by the FileStream object
                // So that the Byte Array (streamed data) can be written in it
               FileStream fs = File.Create(filePath);
               // fs.Wtite(P1,P2,P3) 
               // P1: The byte array from which data is read so that it can be written as stream
               // P2: The 0 based offset aka the position from which data is read from byte array and written into stream
               // P3: The count of the byte array upto which data is written into the stream
               fs.Write(data,0, data.Length);

               Console.WriteLine("Data is Written Successfully");
               
               // Close the Stream so that the File will be committed and handed over to OS
             fs.Close();

            }
        }


        public void UsingFsForWriteRead()
        {
            string fileName = @"c:\Coditas\Files\One.txt";

            if (!File.Exists(fileName))
            {
                // Write File
                Byte[] data = new UTF8Encoding(true).GetBytes("I am an UTF 8 Data with FileStream");
                FileStream fs = File.Create(fileName);
                fs.Write(data, 0, data.Length);
                Console.WriteLine("Data is Written Successfully");
                // Close the fs, the File is Comiited and Handed over to OS
                // This is Mandatory step so  that the fs will be used for further operations
                fs.Close ();
                // Read File
                fs = File.OpenRead(fileName);
                // Define a Byte array of length matched with the data
                byte[] data1 = new byte[data.Length];
                // create an instance of UTF8Encoding to read data in order  by using true
                UTF8Encoding dataToRead = new UTF8Encoding(true);
                // start reading
                while (fs.Read(data1, 0, data1.Length) > 0)
                {
                    Console.WriteLine(dataToRead.GetString(data1));
                }
            }
        }
    }
}
