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
            Person person = new Person();
            person.name = Console.ReadLine();

            var questions = GetQuestions();
            person.countRightAnswers = 0;
            var questionsCount = questions.Count;
            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос № " + (i + 1));
                System.Random random = new System.Random();
                var lengthOfList = questions.Count;
                var randomQuestionIndex = random.Next(0, lengthOfList);
                Console.WriteLine(questions[randomQuestionIndex].Text);
                var userAnswer = GetUserAnswer();
                var rightAnswer = questions[randomQuestionIndex].Answer;
                if (userAnswer == rightAnswer)
                {
                    person.countRightAnswers++;
                }
                questions.RemoveAt(randomQuestionIndex);
            }
            var diagnoses = GetDiagnoses();
            var numberOfDiagnose = GetPointsOfDiagnoses(person.countRightAnswers, questionsCount);
            person.diagnose = diagnoses[numberOfDiagnose];
            Console.WriteLine("Количество правильных ответов: " + person.countRightAnswers);
            Console.WriteLine(person.name + ", Ваш диагноз: " + person.diagnose);
            var path = @"D:\AllResults.txt";
            SaveResults(path, person.name, person.countRightAnswers, person.diagnose);
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            if (answer == "Q" || answer == "q")
            {
                ShowAllResults(path);
            }
            Console.ReadKey();
        }


        static List<Question> GetQuestions()
        {
            Question question1 = new Question("Сколько будет два плюс два  умноженное на два?", 6);
            Question question2 = new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9);
            Question question3 = new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25);
            Question question4 = new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60);
            Question question5 = new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 5);
            var questions = new List<Question> { question1, question2, question3, question4, question5 };
            return questions;
        }



        static void SaveResults(string path, string name, int countRightAnswers, string usersDiagnose)
        {
            var results = new StreamWriter(path, true);
            results.WriteLine("{0, 1 } {1, 50} {2,50}",
                name, countRightAnswers.ToString(), usersDiagnose);
            results.Close();
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