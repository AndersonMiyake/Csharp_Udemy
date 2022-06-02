namespace Course_Section6
{
    class Calculator
    {
        //72. Modificador de parâmetros params
        //public static int Sum(params int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        //73. Modificadores de parâmetros ref e out

        //public static void Triple(ref int x)
        //{
        //    x = x * 3;
        //}

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
