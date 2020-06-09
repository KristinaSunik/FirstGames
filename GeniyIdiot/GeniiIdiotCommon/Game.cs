using System;
using System.Collections.Generic;
using System.Text;

namespace GeniyIdiotCommon
{
    public class Game
    {
        private string userResultsPath = "userResults.txt";
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int currentQuestionNumber = 0;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionStorage.Get();
        }

        public string GetCurrentQuestionNumberInfo()
        {
            currentQuestionNumber++;
            return "Вопрос № " + currentQuestionNumber;
        }

        public bool IsEnd()
        {
            return GetQuestionsCount() == 0;
        }


        public Question PopRandomeQuestion()
        {
            Random random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questions.Remove(currentQuestion);
            return currentQuestion;

        }
        public void AcceptUserAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
        }
        public void SaveResult()
        {
            var data = $"{user.Name}${ user.Surname}${ user.CountRightAnswers}${user.Diagnose}";
            FileProvider.Add(userResultsPath, data);
        }

        public int GetQuestionsCount()
        {
            return questions.Count;
        }
    }
}
