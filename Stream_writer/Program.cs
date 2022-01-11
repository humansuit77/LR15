using System;
using System.IO;

namespace Stream_writer
{
    class Files
    {
        static void Main()
        {
            string path = @"E:\Primer.txt";
            string readPath = @"E:\Primer.txt";
            string writePath = @"E:\Primer2.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();

                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))

                {
                    sw.WriteLine(text);
                }
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
