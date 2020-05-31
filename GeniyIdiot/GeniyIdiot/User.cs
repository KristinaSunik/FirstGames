

namespace GeniyIdiot
{
    public class User
    {
        public string Name;
        public string Diagnose;
        public string Surname;
        public int CountRightAnswers;

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            CountRightAnswers = 0;
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }

      
    }
}
