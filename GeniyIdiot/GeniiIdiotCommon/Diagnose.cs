using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class Diagnose
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
        public static int CalculateNumberOfDiagnose(User user)
        {
            if (user.PercentageOfRightAnswers <= 17)
            {
                return 0;
            }
            if (user.PercentageOfRightAnswers <= 34)
            {
                return 1;
            }
            if (user.PercentageOfRightAnswers <= 51)
            {
                return 2;
            }
            if (user.PercentageOfRightAnswers <= 68)
            {
                return 3;
            }
            if (user.PercentageOfRightAnswers <= 85)
            {
                return 4;
            }

            return 5;


        }
    }
}
