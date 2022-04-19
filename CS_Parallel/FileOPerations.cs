using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_Parallel
{
    internal class FileOPerations
    {
        public void ReadFileJB()
        {
            try
            {
                string contents = String.Empty;
                contents = File.ReadAllText(@"C:\Coditas\JB1.txt");
                Console.WriteLine($" JB Info {contents}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hay Error {ex.Message}");
            }
        }

        public void ReadFileIJ()
        {
            try
            {
                string contents = String.Empty;
                contents = File.ReadAllText(@"C:\Coditas\IJ.txt");
                Console.WriteLine($" IJ = Info {contents}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hay Error {ex.Message}");
            }
        }
    }
}
