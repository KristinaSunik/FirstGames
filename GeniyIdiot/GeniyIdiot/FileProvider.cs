using System;
using System.IO;


namespace GeniyIdiot
{
    class FileProvider
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
                    var line = streamReader.ReadToEnd().Split('\n');
                    Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        "Имя:", "Фамилия:", "Количество правильных ответов:", "Диагноз:");
                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        var world = line[i].Split(' ');
                        Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n", world[0], world[1], world[2], world[3]);
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
