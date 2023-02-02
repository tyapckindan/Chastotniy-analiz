internal class Program
{
    private static void Main(string[] args)
    {
        int countVoice = 0, max = -1000, count = 0;
        // array filling 

        var counters = new int[17];
        // Data input
        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
        {
            countVoice = int.Parse(Console.ReadLine());
            counters[countVoice]++;
            if (max == counters[countVoice])
                count++;
            if (max < counters[countVoice])
                max = counters[countVoice];
        }

        // Pair counting and output
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] != 0 && max == counters[i])
            {
                {
                    Console.WriteLine($"{i} {counters[i]}");
                    count--;
                }
                if (count < 0)
                {
                    max--;
                    i = 0;
                }
            }
        }
    }
}