using System;
using System.Collections.Generic;
using System.Text;

namespace GeniyIdiotCommon
{
   public class Game
    {
        private List<Question> questions;

        public Game()
        {
            questions = QuestionStorage.Get();
        }
        public int GetQuestionsCount()
        {
            return questions.Count;
        }
        public Question GetRandomeQuestion()
        {
            System.Random random = new System.Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            return questions[randomQuestionIndex];

        }
    }
}
