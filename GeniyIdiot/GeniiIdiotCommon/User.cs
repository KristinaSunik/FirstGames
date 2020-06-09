using System.Net.Http.Headers;

namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name;
        public string Surname;
        public int CountRightAnswers;
        public int PercentageOfRightAnswers;
        public string Diagnose;

        public User()
        {
            Name = "Иван";
            Surname = "Иванович";
            CountRightAnswers = 0;
            PercentageOfRightAnswers = 0;
        }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            CountRightAnswers = 0;
            PercentageOfRightAnswers = 0;
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



