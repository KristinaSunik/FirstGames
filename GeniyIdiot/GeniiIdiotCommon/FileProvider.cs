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

        public static void Get(string path)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path, true))
                {
                    string[] lines = File.ReadAllLines(path);
                    Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        "Имя:", "Фамилия:", "Количество правильных ответов:", "Диагноз:");
                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        var name = lines[i];
                        var surname = lines[i + 1];
                        var rightAnswer = lines[i + 2];
                        var diagnose = lines[i + 3];
                        Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n", name, surname, rightAnswer, diagnose);
                        Console.WriteLine();
                        i = i + 3;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
