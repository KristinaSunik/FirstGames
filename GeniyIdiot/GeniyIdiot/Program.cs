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
            string name = Console.ReadLine();
            int questionsCount = 14;
            string[] questions = GetQuestions(questionsCount);
            int[] answers = GetAnswers(questionsCount);
            int countRightAnswers = 0;
            int[] randomQuestionIndex = new int[questionsCount];
            DifferentRandomNumbers(randomQuestionIndex, questionsCount);

            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос № " + (i + 1));
                Console.WriteLine(questions[randomQuestionIndex[i]]);
                int userAnswer = GetUserAnswer();
                int rightAnswer = answers[randomQuestionIndex[i]];
                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
            }
            int points = 0;
            int diagnosesCount = 6;
            string[] diagnoses = GetDiagnoses(diagnosesCount);
            int diagnosNumber = GetPointsOfDiagnoses(countRightAnswers, questionsCount, points);
            Console.WriteLine("Имя:             \tКоличество правильных ответов:\t           Диагноз:");
            Console.WriteLine("{0}\t{1,30}\t{2,34}", name, countRightAnswers, diagnoses[diagnosNumber]);
           
            var results = new StreamWriter(@"D:\Results.txt", true);
            results.WriteLine(name + "\n Количество правильных ответов: " +
                 countRightAnswers + "\n Диагноз:" + diagnoses[diagnosNumber]);
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
            questions[5] = "Сколько будет два плюс два  умноженное на два?";
            questions[6] = "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?";
            questions[7] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[8] = "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?";
            questions[9] = "Пять свечей горело, две  потухли. Сколько свечей  осталось?";
            questions[10] = "Сколько будет два плюс два  умноженное на два?";
            questions[11] = "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?";
            questions[12] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[13] = "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?";

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
            answers[5] = 6;
            answers[6] = 9;
            answers[7] = 25;
            answers[8] = 60;
            answers[9] = 5;
            answers[10] = 6;
            answers[11] = 9;
            answers[12] = 25;
            answers[13] = 60;

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



        static int DifferentRandomNumbers(int[] randomQuestionIndex, int questionsCount)
        {
            System.Random random = new System.Random();

            for (int i = 0; i < questionsCount - 1; i++)
            {
                for (int j = questionsCount - 1; j > 0; j--)
                {
                    while (i != j && randomQuestionIndex[i] == randomQuestionIndex[j])
                    {
                        randomQuestionIndex[j] = random.Next(0, questionsCount);
                    }
                }
            }
            return randomQuestionIndex[questionsCount - 1];
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
