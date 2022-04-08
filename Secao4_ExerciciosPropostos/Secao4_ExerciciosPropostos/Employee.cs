using System.Globalization;

namespace Secao4_ExerciciosPropostos
{
    class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double grossSalary;
        public double GrossSalary
        {
            get { return grossSalary; }
            set { grossSalary = value; }
        }

        private double tax;
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public double LiquidSalary()
        {
            return grossSalary - tax;
        }

        public void RaiseSalary(double percentage)
        {
            grossSalary *= (100 + percentage) * 0.01;
        }

        public override string ToString()
        {
            return string.Format("{0}, $ {1}", name, LiquidSalary().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
