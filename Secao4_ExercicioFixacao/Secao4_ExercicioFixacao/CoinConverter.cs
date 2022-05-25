
namespace Secao4_ExercicioFixacao
{
    class CoinConverter
    {
        public static double tax = 0.06;
        //public static double tax = 6.0;

        public static double CalculateTotal(double rate, double dollars)
        {
            return rate * dollars * (1.00 + tax);
            //double total = rate * dollars;
            //return total + total * tax / 100.0;
        }
    }
}
