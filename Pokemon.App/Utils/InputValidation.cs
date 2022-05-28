namespace PokemonGame.App.Utils
{
    public static class InputValidation
    {
        public static int ValidateInputTypeInt(this string inputData, int maxRange)
        {
            int inputDataConverted = 0;
            try
            {
                inputDataConverted = int.Parse(inputData);
                if(inputDataConverted > maxRange)
                {
                    Console.WriteLine($"Somente números menores ou iguais a {maxRange} são aceitos");
                    inputDataConverted = Console.ReadLine()!.ValidateInputTypeInt(maxRange);
                }
                else if (inputDataConverted < 0)
                {
                    Console.WriteLine($"Números negativos não são aceitos");
                    inputDataConverted = Console.ReadLine()!.ValidateInputTypeInt(maxRange);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Somente números são aceitos.");
                inputDataConverted = Console.ReadLine()!.ValidateInputTypeInt(maxRange);
            }
            return inputDataConverted;
        }

        public static string ValidateInputTypeString(this string inputData)
        {
            if (String.IsNullOrEmpty(inputData))
            {
                Console.WriteLine($"Nomes vazios não são aceitos");
                inputData = Console.ReadLine()!.ValidateInputTypeString();
            }

            return inputData;
        }
    }
}
