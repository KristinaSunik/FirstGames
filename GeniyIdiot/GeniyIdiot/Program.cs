using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot
{
    class Program
    {
        // Получение вопросов
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
            answers[4] = 2;
            return answers;
        }
        static void Main(string[] args)
        {
            int questionsCount = 5;
            string[] questions = GetQuestions(questionsCount);

            int[] answers = GetAnswers(questionsCount);

            int countRigthAnswers = 0;
            Random random = new Random();
            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));

                int randomQuestionIndex = random.Next(0, questionsCount);
                Console.WriteLine(questions[randomQuestionIndex]);
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                int rightAnswer = answers[randomQuestionIndex];

                if (userAnswer == rightAnswer)
                {
                    countRigthAnswers++;
                }
            }
            Console.WriteLine("Количество правильных ответов: " + countRigthAnswers);
            
            string[] diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            Console.WriteLine("Ваш диагноз: " + diagnoses[countRigthAnswers]);

            Console.ReadKey();
        }
    }
}
