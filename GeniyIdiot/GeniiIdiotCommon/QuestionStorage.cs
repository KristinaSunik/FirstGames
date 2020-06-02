using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class QuestionStorage
    {
        public static List<Question> Get()
        {
            Question question1 = new Question("Сколько будет два плюс два  умноженное на два?", 6);
            Question question2 = new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9);
            Question question3 = new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25);
            Question question4 = new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60);
            Question question5 = new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 5);
            var questions = new List<Question> { question1, question2, question3, question4, question5 };
            return questions;
        }
    }
}
