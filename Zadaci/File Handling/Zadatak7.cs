using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3ResourceC_.Zadaci.File
{
    /*Write a program in C# Sharp to create and copy the file to another name and display the content.
Expected Output :

 Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt                                                                                  

 The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.                     
 Here is the content of the file mynewtest.txt :                                                              
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt*/


    public static class CopyTextFromAnotherFile
    {
        public static void BeginCopy()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var path1 = Path.Combine(currentDirectory, "Zadaci", "File Handling", "mytest.txt");
            var path2 = Path.Combine(currentDirectory, "Zadaci", "File Handling", "copied.txt");

            using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    var text = sr.ReadToEnd();

                    using (FileStream f = new FileStream(path2, FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(f))
                        {
                            sw.Write(text);

                        }

                    }



                }

            }




        }

    }
}