using System;
using System.CodeDom.Compiler;
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
            string name = Console.ReadLine();
            int questionsCount = 5;
            string[] questions = GetQuestions(questionsCount);
            int[] answers = GetAnswers(questionsCount);
            List<string> listOfQuestions = new List<string>();
            listOfQuestions.AddRange(questions);
            int countRightAnswers = 0;
            for (int i = 0; i < questionsCount; i++)
            {

                Console.WriteLine("Вопрос № " + (i + 1));
                int randomQuestionIndex = GetRandomQuestionIndex(listOfQuestions);
                Console.WriteLine(listOfQuestions[randomQuestionIndex]);
                listOfQuestions.RemoveAt(randomQuestionIndex);
                int userAnswer = GetUserAnswer();
                int rightAnswer = answers[randomQuestionIndex];
                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
            }
            int diagnosesCount = 6;
            string[] diagnoses = GetDiagnoses(diagnosesCount);
            int pointsOfRightAnswers = 0;
            int numberOfDiagnose = GetPointsOfDiagnoses(countRightAnswers, questionsCount, pointsOfRightAnswers);
            Console.WriteLine("Количество правильных ответов: " + countRightAnswers);
            Console.WriteLine();
            Console.WriteLine(name + ",  Ваш диагноз:  " + diagnoses[NumberOfDiagnose]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            string answer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            if (answer == "Q" || answer == "q")
            {
                Console.WriteLine("{0, 1 } {1,60} {2,38}",
                "Имя", "Количество правильных ответов", "Диагноз:");
                Console.WriteLine();
                String line; 
                try
                {
                    StreamReader sr = new StreamReader("D:\\AllResults.txt");
                    line = sr.ReadLine();
                    while (line != null) 
                    {
                      Console.WriteLine(line);
                        Console.WriteLine();
                        line = sr.ReadLine();
                    }
                   
                    sr.Close();
                    Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }     
            }

            var results = new StreamWriter(@"D:\AllResults.txt", true);
            results.WriteLine("{0, 1 } {1, 40} {2,50}", 
                name,countRightAnswers.ToString(),diagnoses[NumberOfDiagnose]);
            results.Close();



            Console.ReadKey();
        }

        static string[] GetQuestions(int questionsCount)
        {
            string[] questions = new string[questionsCount];
            questions[0] = "Сколько будет два плюс два  умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?";
            questions[4] = "Пять свечей горело, две  потухли. Сколько свечей  осталось?";
            return questions;
        }




        static int[] GetAnswers(int questionsCount)
        {
            int[] answers = new int[questionsCount];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 5;

            return answers;

        }



        static string[] GetDiagnoses(int diagnosesCount)
        {
            string[] diagnoses = new string[diagnosesCount];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            return diagnoses;
        }



        static int GetRandomQuestionIndex(List <string> listOfQuestions)
        {
            System.Random random = new System.Random();
            int randomQuestionIndex;
            int lengthOfList = listOfQuestions.Count;
            randomQuestionIndex = random.Next(0, lengthOfList);
            
            return randomQuestionIndex;
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



        static int GetPointsOfDiagnoses(int countRightAnswers, int questionsCount, int points)
        {
            int percentageOfRightAnswers = countRightAnswers * 100 / questionsCount;
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
