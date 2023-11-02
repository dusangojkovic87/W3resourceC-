using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Write a program in C# Sharp to create a file and write an array of strings to the file.
Test Data :
Input number of lines to write in the file :2
Input 2 strings below :
Input line 1 : this is 1st line
Input line 2 : this is 2nd line
Expected Output :

 The content of the file is  :                                                                                
----------------------------------                                                                            
 this is 1st line                                                                                             
 this is 2nd line 
 */

namespace W3ResourceC_.Zadaci.File
{
    public class CreateArrayOfStrings
    {

        public static void Create()
        {

            var arr = new string[] { "some text1", "some text2" };
            var currentDirectory = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDirectory, "Zadaci", "File Handling", "arrStrings.txt");

            for (int i = 0; i < arr.Length; i++)
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(arr[i]);

                    }

                }

            }





        }

    }
}