using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot
{
    class Diagnos
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
        public static int Calculate(User user, int questionCount)
        {
            var percentageOfRightAnswers = user.CountRightAnswers * 100 / questionCount;

            if (percentageOfRightAnswers <= 17)
            {
                return 0;
            }
            else if (percentageOfRightAnswers > 17 && percentageOfRightAnswers <= 34)
            {
                return 1;
            }
            else if (percentageOfRightAnswers > 34 && percentageOfRightAnswers <= 51)
            {
                return 2;
            }
            else if (percentageOfRightAnswers > 51 && percentageOfRightAnswers <= 68)
            {
                return 3;
            }
            else if (percentageOfRightAnswers > 68 && percentageOfRightAnswers <= 85)
            {
                return 4;
            }

            return 5;


        }
    }
}
