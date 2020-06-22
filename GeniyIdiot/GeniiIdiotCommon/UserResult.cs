

namespace GeniyIdiotCommon
{
    public class UserResult
    {
        public string Name;
        public string Surname;
        public int CountRightAnswers;
        public string Diagnose;

        public UserResult(string name, string surname, int countRightAnswers, string diagnose)
        {
            Name = name;
            Surname = surname;
            CountRightAnswers = countRightAnswers;
            Diagnose = diagnose;
        }

   

    }
}
