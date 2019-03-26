using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusOne
{
    public class Grade
    {
        private int GradeNum;
        private string GradeLetter;

        public Grade()
        {
            this.GradeNum = 0;
            this.GradeLetter = SetGradeLetter(GradeNum);
        }

        public Grade(int num)
        {
            this.GradeNum = num;
            this.GradeLetter = SetGradeLetter(GradeNum);
        }

        public string GetGradeLetter()
        {
            return this.GradeLetter;
        }

        private string SetGradeLetter(int grade)
        {
            int tenths = (grade % 100) / 10;
            int unit = (grade % 10);
            string gradeLetter;

            if (grade < 0)
            {
                gradeLetter = "Cannot be Negative";
            }
            else if (grade < 60)
            {
                gradeLetter = "F";
            }
            else if (grade == 100)
            {
                gradeLetter = "A+";
            }
            else if (grade > 100)
            {
                gradeLetter = "Cannot be over 100";
            }
            else
            {
                switch (tenths)
                {
                    case 6:
                        gradeLetter = "D";
                        break;
                    case 7:
                        gradeLetter = "C";
                        break;
                    case 8:
                        gradeLetter = "B";
                        break;
                    case 9:
                        gradeLetter = "A";
                        break;
                    default:
                        gradeLetter = "Something Went Wrong";
                        break;
                }

                if (unit < 4)
                {
                    gradeLetter += "-";
                }
                else if (unit < 7)
                {
                    gradeLetter += " ";

                }
                else if (unit < 10)
                {
                    gradeLetter += "+";
                }
                else
                {
                    gradeLetter += "Something went wrong";
                }
                
            }

            return gradeLetter;
        }
    }
}
