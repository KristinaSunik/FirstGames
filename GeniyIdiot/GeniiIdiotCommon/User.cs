using System.Net.Http.Headers;

namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name;
        public string Surname;
        public int CountRightAnswers;
        public string Diagnose;

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

        public void SetDiagnose(string diagnose)
        {
            Diagnose = diagnose;
        }
    }
}



