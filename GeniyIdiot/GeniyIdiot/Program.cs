using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var questions = GetQuestions();
            var answers = GetAnswers();
            var countRightAnswers = 0;
            var questionsCount = questions.Count;
            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос № " + (i + 1));
                int randomQuestionIndex;
                randomQuestionIndex = GetRandomQuestionIndex(questions);
                Console.WriteLine(questions[randomQuestionIndex]);
                var userAnswer = GetUserAnswer();
                var rightAnswer = answers[randomQuestionIndex];
                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
                questions.RemoveAt(randomQuestionIndex);
                answers.RemoveAt(randomQuestionIndex);
            }
            var diagnosesCount = 6;
            var diagnoses = GetDiagnoses(diagnosesCount);
            var numberOfDiagnose = GetPointsOfDiagnoses(countRightAnswers, questionsCount);
            Console.WriteLine("Количество правильных ответов: " + countRightAnswers);
            Console.WriteLine(name + ", Ваш диагноз: " + diagnoses[numberOfDiagnose]);
            var path = @"D:\AllResults.txt";
            SaveResults(path, name, countRightAnswers, diagnoses, numberOfDiagnose);
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            if (answer == "Q" || answer == "q")
            {
                ShowAllResults(path);
            }
            Console.ReadKey();
        }

        static List<string> GetQuestions()
        {
            var questions = new List<string>();
            questions.Add("Сколько будет два плюс два  умноженное на два?");
            questions.Add("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?");
            questions.Add("На двух руках 10 пальцев. Сколько пальцев на 5 руках?");
            questions.Add("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?");
            questions.Add("Пять свечей горело, две  потухли. Сколько свечей  осталось?");
            return questions;
        }



        static void SaveResults(string path, string name, int countRightAnswers, string [] diagnoses, int numberOfDiagnose)
        {
            var results = new StreamWriter(path, true);
            results.WriteLine("{0, 1 } {1, 50} {2,50}",
                name, countRightAnswers.ToString(), diagnoses[numberOfDiagnose]);
            results.Close();
        }


        static int GetRandomQuestionIndex(List<string> questions)
        {
            var lengthOfList = questions.Count;
            System.Random random = new System.Random();
            var randomQuestionIndex = random.Next(0, lengthOfList);
            return randomQuestionIndex;
        }


        static void ShowAllResults(string path)
        {
            Console.WriteLine("{0, 1 } {1,50} {2,50}",
               "Имя:", "Количество правильных ответов:", "Диагноз:");
            Console.WriteLine();
            String line;
            try
            {
                using (StreamReader streamReader = new StreamReader(path, true))
                {
                    line = streamReader.ReadLine();
                    while (!streamReader.EndOfStream)
                    {
                        Console.WriteLine(streamReader.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static List<int> GetAnswers()
        {
            var answers = new List<int>();
            answers.Add(6);
            answers.Add(9);
            answers.Add(25);
            answers.Add(60);
            answers.Add(5);
            return answers;
        }



        static string[] GetDiagnoses(int diagnosesCount)
        {
            var diagnoses = new string[diagnosesCount];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            return diagnoses;
        }



        static int GetUserAnswer()
        {
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Введите число: ");
            }
            return userAnswer;
        }



        static int GetPointsOfDiagnoses(int countRightAnswers, int questionsCount)
        {
            var points = 0;
            var percentageOfRightAnswers = countRightAnswers * 100 / questionsCount;
            if (percentageOfRightAnswers <= 17)
            {
                points = 0;
            }
            else if (percentageOfRightAnswers > 17 && percentageOfRightAnswers <= 34)
            {
                points = 1;
            }
            else if (percentageOfRightAnswers > 34 && percentageOfRightAnswers <= 51)
            {
                points = 2;
            }
            else if (percentageOfRightAnswers > 51 && percentageOfRightAnswers <= 68)
            {
                points = 3;
            }
            else if (percentageOfRightAnswers > 68 && percentageOfRightAnswers <= 85)
            {
                points = 4;
            }
            else if (percentageOfRightAnswers > 85 && percentageOfRightAnswers <= 100)
            {
                points = 5;
            }
            return points;
        }
    }
}