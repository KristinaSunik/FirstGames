using GeniyIdiotCommon;
using System;



namespace GeniyIdiot
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Ваша фамилия?");
            var surname = Console.ReadLine();
            Console.WriteLine("Ваше имя?");
            var name = Console.ReadLine();
            User user = new User(name, surname);
            var game = new Game(user);
            var questionsCount = game.GetQuestionsCount();
            while (!game.IsEnd())
            {
                Console.WriteLine(game.GetCurrentQuestionNumberInfo());
                var question = game.PopRandomeQuestion();
                Console.WriteLine(question.Text);
                var userAnswer = GetUserAnswer();
                game.AcceptUserAnswer(userAnswer);
            }
            user.PercentageOfRightAnswers = game.GetPercentageOfRightAnswers();
            var diagnose = Diagnose.Calculate(user);
            user.SetDiagnose(diagnose);
            Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);
            Console.WriteLine(user.Name + user.Surname + ", Ваш диагноз: " + user.Diagnose);
            game.SaveResult();
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            string path = "userResults.txt";
            if (answer == "Q" || answer == "q")
            {
                Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        "Имя:", "Фамилия:", "Количество правильных ответов:", "Диагноз:");
                string lines = FileProvider.Get(path);
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