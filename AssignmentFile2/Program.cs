using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentFile2
{
    class Program
    {
         

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the text in file");
            readwritetext();

        }
        public static async void readwritetext()
        {   
            
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var file = Path.Combine(dir, "A.txt");
            string text = await File.ReadAllTextAsync(file);
           

            var dir1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var file2 = Path.Combine(dir1, "B.txt");
            
            try
            {
                using(StreamWriter output = new StreamWriter(file2, true))
                {
                    await output.WriteAsync(text);
                    System.Console.WriteLine("\nSuccessfully copied from A to B.");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(Environment.NewLine + ex.Message);
            }
        }
      
        
    }    
}