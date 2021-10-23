namespace Question1
{
    public class Program
    {
        public static int GetNumber()
        {
            Console.WriteLine("Enter number.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static Func<int> GetSmalest = () =>
        {
            int num1 = GetNumber();
            int num2;
            for(int i = 0; i < 2; i++)
            {
                num2 = GetNumber();
                if(num2 < num1)
                {
                    num1 = num2;
                }
            }
            return num1;
        };

        public static void Main()
        {
            int x = GetSmalest();
        }
    }
}