namespace Question4
{
    public class Program
    {
        public static string GetString()
        {
            Console.WriteLine("Enter some thing.");
            return Console.ReadLine();
        }

        public static Func<string, int> GetNumOfVowels = str =>
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        };

        public static void Main()
        {
            GetNumOfVowels(GetString());
        }
    }
}