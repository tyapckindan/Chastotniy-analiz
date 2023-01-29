internal class Program
{
    private static void Main(string[] args)
    {
                var counters = new int[1000];

                for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
                    counters[int.Parse(Console.ReadLine())]++;

        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] != 0)
                Console.WriteLine($"{i} {counters[i]}");
        }
    }
}