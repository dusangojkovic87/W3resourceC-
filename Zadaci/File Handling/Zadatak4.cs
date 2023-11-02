using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program in C# Sharp to create a file and add some text.
Expected Output:

 A file created with content name mytest.txt 

*/


public static class CreateandAddText
{
    public static void Add()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var path = Path.Combine(currentDirectory, "Zadaci", "File Handling", "mytest.txt");

        using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Some text2");


            }


        }



    }



}
