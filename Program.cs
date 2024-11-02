namespace NewC_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userInputSimvol;
            int lendtUserInput;
            bool isReplay = true;
            int errorRare = 1;

            Console.Write($"Введите имя: ");
            userInput = Console.ReadLine();
            lendtUserInput = userInput.Length + errorRare;

            Console.Write($"Введите символ: ");
            userInputSimvol = Console.ReadLine();

            for (int i = 0; i <= lendtUserInput; i++)
            {
                Console.Write(userInputSimvol);

                if (i == lendtUserInput && isReplay)
                {
                    Console.Write($"\n{userInputSimvol}{userInput}{userInputSimvol}\n");
                    i = 0 - errorRare;
                    isReplay = false;
                }
            }

            Console.ReadKey();
        }
    }
}