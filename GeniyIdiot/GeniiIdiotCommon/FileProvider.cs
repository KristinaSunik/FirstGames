using System;
using System.IO;
using System.Linq;

namespace GeniyIdiotCommon
{
    public class FileProvider
    {
        public static void Add(string path, string text)
        {
            var results = new StreamWriter(path, true);
            results.WriteLine(text);
            results.Close();
        }

        public static string[] Get(string path)
        {
                using (StreamReader streamReader = new StreamReader(path, true))
                {
                    string[] lines = File.ReadAllLines(path);
                    return lines;
                }
        }  
    }
}
