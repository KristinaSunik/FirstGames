
using System.IO;

namespace _2048WindowsFormsApp
{
    class FileProvider
    {
        public static bool IsExists(string path)
        {
            return File.Exists(path);
        }
    }
}
