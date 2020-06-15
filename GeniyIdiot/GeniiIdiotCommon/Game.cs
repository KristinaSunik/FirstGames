using System;
using System.Collections.Generic;

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
            Init();
            questions = QuestionStorage.GetQuestionsFromFile();
        }

        private void Init()
        {
            QuestionStorage.CreateFileIfNotExists();
        }

        public string GetCurrentQuestionNumberInfo()
        {
            currentQuestionNumber++;
            return "Вопрос  № " + currentQuestionNumber;
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

        public void AddNewQuestion(Question newQuestion)
        {
            var allQuestions = QuestionStorage.GetQuestionsFromFile();
            allQuestions.Add(newQuestion);
            QuestionStorage.SaveQuestions(allQuestions);
        }


        public List<UserResult> GetUserResults()
        {
            var userResults = new List<UserResult>();
            var data = FileProvider.Get(userResultsPath);
            var lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var lineData = line.Split('$');
                var userResult = new UserResult();
                userResult.Name = lineData[0];
                userResult.Surname = lineData[1];
                userResult.CountRightAnswers = Convert.ToInt32(lineData[2]);
                userResult.Diagnose = lineData[3];

                userResults.Add(userResult);
            }
            return userResults;
        }

        public int GetNumberOfQuestions()
        {
            var numberOfQuestions = GetQuestionsCount();
            return numberOfQuestions;

        }


        public string CalculateDiagnose(int numberOfQuestions)
        {
            var percentageOfRightAnswers = user.CountRightAnswers * 100 / numberOfQuestions;
            var diagnose = Diagnose.Calculate(percentageOfRightAnswers);
            user.SetDiagnose(diagnose);
            return diagnose;
        }

        private int GetQuestionsCount()
        {
            return questions.Count;
        }
    }
}
