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
            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();
            User user = new User(name, surname);
            var questions = QuestionStorage.Get();
            var questionsCount = questions.Count;
            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос № " + (i + 1));
                System.Random random = new System.Random();
                var randomQuestionIndex = random.Next(0, questions.Count);
                Console.WriteLine(questions[randomQuestionIndex].Text);
                var userAnswer = GetUserAnswer();
                var rightAnswer = questions[randomQuestionIndex].Answer;
                if (userAnswer == rightAnswer)
                {
                    user.AcceptRightAnswer();
                }
                questions.RemoveAt(randomQuestionIndex);
            }
            var diagnoses = GetDiagnoses();
            var percentageOfRightAnswers = user.CountRightAnswers * 100 / questionsCount;
            var numberOfDiagnose = GetPointsOfDiagnoses(percentageOfRightAnswers);
            user.Diagnose = diagnoses[numberOfDiagnose];
            Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);
            Console.WriteLine(user.Name + user.Surname + ", Ваш диагноз: " + user.Diagnose);
            var path = @"D:\AllResults.txt";
            FileProvider.Add(path, user);
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            if (answer == "Q" || answer == "q")
            {
                FileProvider.Get(path);
            }
            Console.ReadKey();
        }



        static List<string> GetDiagnoses()
        {
            var diagnoses = new List<string>();
            diagnoses.Add("Идиот");
            diagnoses.Add("Кретин");
            diagnoses.Add("Дурак");
            diagnoses.Add("Нормальный");
            diagnoses.Add("Талант");
            diagnoses.Add("Гений");
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



        static int GetPointsOfDiagnoses(int percentageOfRightAnswers)
        {

            if (percentageOfRightAnswers <= 17)
            {
                return 0;
            }
            else if (percentageOfRightAnswers > 17 && percentageOfRightAnswers <= 34)
            {
                return 1;
            }
            else if (percentageOfRightAnswers > 34 && percentageOfRightAnswers <= 51)
            {
                return 2;
            }
            else if (percentageOfRightAnswers > 51 && percentageOfRightAnswers <= 68)
            {
                return 3;
            }
            else if (percentageOfRightAnswers > 68 && percentageOfRightAnswers <= 85)
            {
                return 4;
            }

            return 5;


        }
    }
}