namespace PokemonGame.App.Utils
{
    public static class InputValidation
    {
        public static int ValidateInputTypeInt(int maxRange)
        {
            string inputData = Console.ReadLine();
            int inputDataConverted = 0;
            try
            {
                inputDataConverted = int.Parse(inputData);
                if(inputDataConverted > maxRange)
                {
                    Console.WriteLine($"Somente números menores ou iguais a {maxRange} são aceitos");
                    inputDataConverted = ValidateInputTypeInt(maxRange);
                }
                else if (inputDataConverted < 0)
                {
                    Console.WriteLine($"Números negativos não são aceitos");
                    inputDataConverted = ValidateInputTypeInt(maxRange);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Somente números são aceitos.");
                inputDataConverted = ValidateInputTypeInt(maxRange);
            }
            return inputDataConverted;
        }

        public static string ValidateInputTypeString()
        {
            string inputData = Console.ReadLine();

            if (String.IsNullOrEmpty(inputData))
            {
                Console.WriteLine($"Nomes vazios não são aceitos");
                inputData = ValidateInputTypeString();
            }

            return inputData;
        }
    }
}
