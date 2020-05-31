
using System.Collections.Generic;


namespace GeniyIdiot
{
    class Diagnose
    {

        public static List<string> Get()
        {
            var diagnoses = new List<string>();
            diagnoses.Add("Идиот");
            diagnoses.Add("Кретин");
            diagnoses.Add("Дурак");
            diagnoses.Add("Нормальный");
            diagnoses.Add("Талант");
            diagnoses.Add("Гений");
            return diagnoses;
        }
        public static int CalculateNumberOfDiagnose(User user, int questionCount)
        {
            var percentageOfRightAnswers = user.CountRightAnswers * 100 / questionCount;

            if (percentageOfRightAnswers <= 17)
            {
                return 0;
            }
            if (percentageOfRightAnswers <= 34)
            {
                return 1;
            }
           if (percentageOfRightAnswers <= 51)
            {
                return 2;
            }
            if (percentageOfRightAnswers <= 68)
            {
                return 3;
            }
            if (percentageOfRightAnswers <= 85)
            {
                return 4;
            }

            return 5;


        }
    }
}
