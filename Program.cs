namespace NewC_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userInputSimvol;
            string stringWithName;
            string stringWithCharacters=null;

            Console.Write($"Введите имя: ");
            userInput = Console.ReadLine();

            Console.Write($"Введите символ: ");
            userInputSimvol = Console.ReadLine();

            stringWithName = userInputSimvol + userInput + userInputSimvol;

            for (int i = 0; i < stringWithName.Length; i++)
            {
                stringWithCharacters += userInputSimvol;
            }

            Console.Write($"{stringWithCharacters}\n" +
                $"{stringWithName}\n" +
                $"{stringWithCharacters}\n");

            Console.ReadKey();
        }
    }
}