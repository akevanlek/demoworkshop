using System;

namespace workshopep28
{
    public class Calculator
    {
        public string GradeCalculator(int score)
        {    
            if (score>80)
            {
                return "A";
            }
            else if (score>70)
            {
                return "B";
            }
            else if (score>60)
            {
                return "C";
            }
            else if (score>50)
            {
                return "D";
            }
            else if (score<=50)
            {
                return "F";
            }
            else
            {
                 return "some thing wrong";
            }          
        }
    }
}
