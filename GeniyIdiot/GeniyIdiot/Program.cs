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
            var numberOfQuestions = game.GetNumberOfQuestions();
            while (!game.IsEnd())
            {
                Console.WriteLine(game.GetCurrentQuestionNumberInfo());
                var question = game.PopRandomeQuestion();
                Console.WriteLine(question.Text);
                var userAnswer = GetUserAnswer();
                game.AcceptUserAnswer(userAnswer);
            }
            game.CalculateDiagnose(game.GetPercentageOfRightAnswers(numberOfQuestions));
            Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);
            Console.WriteLine(user.Name + user.Surname + ", Ваш диагноз: " + user.Diagnose);
            game.SaveResult();
            Console.WriteLine("Если вы хотите посмотреть результаты других участников нажмите 'Q'");
            var answer = Console.ReadLine();
            if (answer == "Q" || answer == "q")
            {
                Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        "Имя:", "Фамилия:", "Количество правильных ответов:", "Диагноз:");
                var userResults = game.GetUserResults();
                for (int i = 0; i < userResults.Count; i++)
                {
                    Console.WriteLine("{0,-25} {1,-25} {2,-35} {3, 20}\n",
                        userResults[i].Name, userResults[i].Surname, 
                        userResults[i].CountRightAnswers, userResults[i].Diagnose);
                    Console.WriteLine();
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