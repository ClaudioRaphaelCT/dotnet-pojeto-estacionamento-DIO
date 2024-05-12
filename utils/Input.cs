namespace Utils
{
    internal class Input
    {
        public static int InputInt(string entrada)
        {
            Console.WriteLine($"{entrada}");
            int.TryParse(Console.ReadLine(), out int resultado);
            return resultado;
        }

        public static decimal InputDecimal(string entrada)
        {
            Console.WriteLine($"{entrada}");
            decimal resultado = Convert.ToDecimal(Console.ReadLine());
            return resultado;
        }

        public static string InputString(string entrada)
        {
            Console.WriteLine($"{entrada}");
            string valorString = Console.ReadLine() ?? "";
            return valorString;
        }

    }
}