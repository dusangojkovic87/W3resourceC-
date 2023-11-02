using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3ResourceC_.Zadaci.File
{

    /* Write a C# Sharp program to create a text file and read it.
Expected Output :

 Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt */
    public static class CreateAndReadFile
    {

        public static void Create()
        {

            var currentDirectory = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDirectory, "Zadaci", "File Handling", "mytest2.txt");

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("Hello and Welcome");
                    sw.WriteLine("It is the first content of the text");

                }


            }

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    var result = sr.ReadToEnd();
                    System.Console.WriteLine(result);

                }
            }



        }



    }
}