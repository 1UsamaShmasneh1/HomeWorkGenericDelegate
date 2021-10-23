namespace Question6
{
    public class Program
    {
        public static int GetNumber()
        {
            Console.WriteLine("Enter number.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static Func<int, int> GetSumOfDigits = num =>
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }
            return result;
        };

        public static void Main()
        {
            GetSumOfDigits(GetNumber());
        }
    }
}