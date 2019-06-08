using System.IO;

namespace _6._Folder_Size
{
    class Program
    {
        static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
