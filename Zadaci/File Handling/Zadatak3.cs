/*
Write a program in C# Sharp to create a blank file in the disk if the same file already exists
*/
public static class CreateIfAlreadyExists
{

    public static void CreateIt()
    {
        string curenntDirectory = Directory.GetCurrentDirectory();
        string path = Path.Combine(curenntDirectory, "Zadaci", "File Handling", "mytest.txt");


        if (File.Exists(path))
        {
            try
            {
                File.Delete(path);
                File.Create(path);
                System.Console.WriteLine("File Created...!");

            }
            catch (System.Exception e)
            {

                System.Console.WriteLine(e.Message);
            }


        }

    }

}
