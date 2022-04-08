using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4_ExerciciosPropostos
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double grade1;

        public double Grade1
        {
            get { return grade1; }
            set { grade1 = value; }
        }

        private double grade2;

        public double Grade2
        {
            get { return grade2; }
            set { grade2 = value; }
        }

        private double grade3;

        public double Grade3
        {
            get { return grade3; }
            set { grade3 = value; }
        }

        public double FinalGrade()
        {
            return grade1 + grade2 + grade3;
        }

        public bool Approved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PointsLeft()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGrade();
            }
        }

        public string FinalResult()
        {
            double finalGrade = FinalGrade();

            if (finalGrade >= 60.0)
            {
                return "APPROVED";
            }
            else
            {
                double pointsLeft = 60 - finalGrade;
                return string.Format("FAILED\n {0} POINTS LEFT", pointsLeft);
            }
        }
    }
}
