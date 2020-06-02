using GeniyIdiotCommon;
using System;



namespace GeniyIdiot
{
    public class Program
    {

        public static void Main(string[] args)
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
            user.PercentageOfRightAnswers = user.CountRightAnswers * 100 / questionsCount;
            var diagnoses = Diagnose.Get();
            var numberOfDiagnose = Diagnose.CalculateNumberOfDiagnose(user);
            user.Diagnose = diagnoses[numberOfDiagnose];
            Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);
            Console.WriteLine(user.Name + user.Surname + ", Ваш диагноз: " + user.Diagnose);
            var path = @"D:\AllResults.txt";
            var text = user.Name + Environment.NewLine + user.Surname + Environment.NewLine +
                user.CountRightAnswers.ToString() + Environment.NewLine + user.Diagnose;
            FileProvider.Add(path, text);
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            if (answer == "Q" || answer == "q")
            {
                Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        "Имя:", "Фамилия:", "Количество правильных ответов:", "Диагноз:");
                string[] lines = FileProvider.Get(path);
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    var userName = lines[i];
                    var userSurname = lines[i + 1];
                    var userRightAnswer = lines[i + 2];
                    var userDiagnose = lines[i + 3];
                    Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n", userName, userSurname, userRightAnswer, userDiagnose);
                    Console.WriteLine();
                    i += 3;
                }
            }
            Console.ReadKey();
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
    }
}