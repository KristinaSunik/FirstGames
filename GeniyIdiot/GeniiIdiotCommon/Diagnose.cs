using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class Diagnose
    {

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
