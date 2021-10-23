namespace Question5
{
    public class Program
    {
        public static string GetString()
        {
            Console.WriteLine("Enter some thing.");
            return Console.ReadLine();
        }

        public static Func<string, int> GetNumOfWords = str =>
        {
            int counter = 0;
            if(str.Length != 0 && str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        counter++;
                    }
                }
                if(str[0] !=  ' ')
                    counter += 1;
            }
            return counter;
        };

        public static void Main()
        {
            GetNumOfWords(GetString());
        }
    }
}