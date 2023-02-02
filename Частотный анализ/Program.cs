internal class Program
{
    private static void Main(string[] args)
    {
        int k = 0, max = -1000;
        // array filling 
        var counters = new int[17];
        // Data input
        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
        {
            k = int.Parse(Console.ReadLine());
            counters[k]++;
            if (max < counters[k])
                max = counters[k];
            
        }

        // Pair counting and output
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] != 0 && max == counters[i])
                Console.WriteLine($"{i} {counters[i]}");
            if (i == counters.Length)
            {
                max = counters[i]-1;
                i = 0;
                counters[i]=0;
            }
        }
    }
}