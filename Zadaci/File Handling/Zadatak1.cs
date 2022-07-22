using System.IO;
/*
Write a program in C# Sharp to create a blank file in the disk newly
*/
public static class CreateBlankFile
{

    public static void CreateFile()
    {
        string curenntDirectory = Directory.GetCurrentDirectory();
        string path = Path.Combine(curenntDirectory, "Zadaci", "File Handling", "mytest.txt");

        File.Create(path);
        if (File.Exists(path))
        {
            System.Console.WriteLine("File created successfully!");
        }





    }



}
