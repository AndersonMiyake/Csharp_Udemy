using System;
using DelegateExample.Services;

namespace DelegateExample
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation2(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            //double a = 10;
            //double b = 12;

            ////BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //BinaryNumericOperation op = CalculationService.Sum;

            ////double result = op.Invoke(a, b);
            //double result = op(a, b);
            //Console.WriteLine(result);

            double a = 10;
            double b = 12;

            BinaryNumericOperation2 op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);
        }
    }
}
