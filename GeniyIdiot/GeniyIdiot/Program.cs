using System;


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
            var numberOfDiagnose = Diagnos.Calculate(user, questionsCount);
            var diagnoses = Diagnos.Get();
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