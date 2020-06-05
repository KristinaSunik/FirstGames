using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class Diagnose
    {

       /* public static List<string> Get()
        {
            var diagnoses = new List<string>();
            diagnoses.Add("Идиот");
            diagnoses.Add("Кретин");
            diagnoses.Add("Дурак");
            diagnoses.Add("Нормальный");
            diagnoses.Add("Талант");
            diagnoses.Add("Гений");
            return diagnoses;
        } */

        public static string Calculate(User user)
        {
            if (user.PercentageOfRightAnswers <= 17)
            {
                return "Идиот";
            }
            if (user.PercentageOfRightAnswers <= 34)
            {
                return "Кретин";
            }
            if (user.PercentageOfRightAnswers <= 51)
            {
                return "Дурак";
            }
            if (user.PercentageOfRightAnswers <= 68)
            {
                return "Нормальный";
            }
            if (user.PercentageOfRightAnswers <= 85)
            {
                return "Талант";
            }

            return "Гений";


        }
    }
}
