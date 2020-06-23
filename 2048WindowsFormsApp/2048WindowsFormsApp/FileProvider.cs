
using System.IO;

namespace _2048WindowsFormsApp
{
    class FileProvider
    {
        public static bool IsExists(string path)
        {
            return File.Exists(path);
        }

        public static void Add(string path, string text)
        {
            var results = new StreamWriter(path, true);
            results.WriteLine(text);
            results.Close();
        }
        public static string Get(string path)
        {
            var reader = new StreamReader(path);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }
        public static void Set(string path, string text)
        {
            var results = new StreamWriter(path, false);
            results.WriteLine(text);
            results.Close();
        }
    }
}
