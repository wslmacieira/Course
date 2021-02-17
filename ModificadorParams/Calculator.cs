namespace ModificadorParams
{
    class Calculator
    {
       // public static int Sum(int[] numbers)
        public static int Sum(params int[] numbers) // params
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
