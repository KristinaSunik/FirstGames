using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class Diagnose
    {

        public static string Calculate(int percentageOfRightAnswers)
        {
            if (percentageOfRightAnswers <= 17)
            {
                return "Идиот";
            }
            if (percentageOfRightAnswers <= 34)
            {
                return "Кретин";
            }
            if (percentageOfRightAnswers <= 51)
            {
                return "Дурак";
            }
            if (percentageOfRightAnswers <= 68)
            {
                return "Нормальный";
            }
            if (percentageOfRightAnswers <= 85)
            {
                return "Талант";
            }

            return "Гений";


        }
    }
}
