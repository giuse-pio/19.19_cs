namespace _19._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();
            string input;
            do
            {
                Console.Write("inserisci un numero(o premi invio per uscire): ");
                input = Console.ReadLine();
                int numero;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out numero);
                    numeri.Add(numero);
                }
            }
            while (input != "");

            if(VerificaOrdinamento(numeri)==false)
                Console.WriteLine("la lista non è ordinata");
            else
                Console.WriteLine("la lista è ordinata");
        }

        static bool VerificaOrdinamento(List<int> numeri)
        {
            for (int i = 0; i < numeri.Count - 1; i++)
            {
                if (numeri[i] > numeri[i + 1])
                    return false;
            }
            return true;
        }
    }
}
