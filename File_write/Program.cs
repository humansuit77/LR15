using System.IO;
using System;
namespace File_write
{
    class Files
    {
        static void Main(string[] args)
        {
            string str = "My text";
            File.WriteAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", str);
            Console.WriteLine();
            File.AppendAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", " текст метода AppendAllText ()");
        }
    }
}
