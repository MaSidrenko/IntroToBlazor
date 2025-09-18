namespace Model.Factorial
{
    public partial class Factorial
    {
        public static long factorial = 1;
        public static int n = 0;
        public static void Calculate()
        {
            factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        }
    }
}