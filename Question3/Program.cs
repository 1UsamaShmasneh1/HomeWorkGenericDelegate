namespace Question3
{
    public class Program
    {
        public static string GetString()
        {
            Console.WriteLine("Enter some thing.");
            return Console.ReadLine();
        }

        public static Func<string, string> GetMiddleChar = str =>
        {
            int position = str.Length;
            int length;
            if (position % 2 == 0)
            {
                position = position / 2 - 1;
                length = 2;
            }
            else
            {
                position = position / 2;
                length = 1;
            }
            return str.Substring(position, position + length);
        };

        public static void Main()
        {
            GetMiddleChar(GetString());
        }
    }
}