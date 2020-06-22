using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GeniyIdiotCommon
{
    public class Game
    {
        private static string userResultsPath = "userResults.json";
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int currentQuestionNumber = 0;
        public List<UserResult> userResults;

        public Game(User user)
        {
            this.user = user;
            Init();
            questions = QuestionStorage.GetQuestionsFromFile();
        }


        public void Init()
        {
            QuestionStorage.CreateFileIfNotExists();

            if (!FileProvider.IsExists(userResultsPath))
            {
                var results = new List<UserResult>();
                SaveResult(results);
            }
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

        public void AddNewQuestion(Question newQuestion)
        {
            var allQuestions = QuestionStorage.GetQuestionsFromFile();
            allQuestions.Add(newQuestion);
            QuestionStorage.SaveQuestions(allQuestions);
        }

        public static List<UserResult> GetUserResultsFromFile()
        {
            var serializedUserResults = FileProvider.Get(userResultsPath);
            var userResults = JsonConvert.DeserializeObject<List<UserResult>>(serializedUserResults);
            return userResults;
        }
        public void SaveResult(List<UserResult> userResults)
        {
            var serializedUser = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Set(userResultsPath, serializedUser);
        }

        public void AddNewUserResult(UserResult newUserResult)
        {
            var allResults = GetUserResultsFromFile();
            allResults.Add(newUserResult);
            SaveResult(allResults);
        }

        public List<UserResult> GetUserResults()
        {
            var userResults = GetUserResultsFromFile();
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
