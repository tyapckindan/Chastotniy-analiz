internal class Program
{
    private static void Main(string[] args)
    {
        // array filling 
        var counters = new int[17];
        // Data input
        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
            counters[int.Parse(Console.ReadLine())]++;

        // Pair counting and output
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] != 0)
                Console.WriteLine($"{i} {counters[i]}");
        }
    }
}