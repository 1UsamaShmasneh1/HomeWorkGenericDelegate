namespace Question2
{
    public class Program
    {
        public static int GetNumber()
        {
            Console.WriteLine("Enter number.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static Func<int> GetAverage = () =>
        {
            int num1 = GetNumber();
            int num2 = GetNumber();
            int num3 = GetNumber();
            return (num1 + num2 + num3) / 3;
        };

        public static void Main()
        {
            GetAverage();
        }
    }
}