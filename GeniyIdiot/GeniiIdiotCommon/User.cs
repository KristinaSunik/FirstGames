using System.Net.Http.Headers;

namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name;
        public string Diagnose;
        public string Surname;
        public int CountRightAnswers;
        public int PercentageOfRightAnswers;


        public User()
        {
            Name = "Иван";
            Surname = "Иванович";
            CountRightAnswers = 0;
            PercentageOfRightAnswers = 0;
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }


        public string GetName(string value)
        {
            Name = value;
            return Name;
        }

        public string GetSurname(string value)
        {
            Surname = value;
            return Surname;
        }
    }
}

    

