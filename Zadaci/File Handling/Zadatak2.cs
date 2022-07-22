/*
Write a program in C# Sharp to remove a file from the disk. 
*/
public static class RemoveFileFromDisk
{
    public static void ClearFromDisk()
    {
        string curenntDirectory = Directory.GetCurrentDirectory();
        string path = Path.Combine(curenntDirectory, "Zadaci", "File Handling", "mytest.txt");

        try
        {
            File.Delete(path);
            if (!File.Exists(path))
            {
                System.Console.WriteLine("File Removed");
            }

        }
        catch (System.Exception e)
        {

            System.Console.WriteLine(e.Message);
        }


    }

}
