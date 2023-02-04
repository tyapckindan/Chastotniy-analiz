internal class Program
{
    private static void Main(string[] args)
    {
        int countVoice = 0, max1 = 0, max2 = 0, max3 = 0, flag = 0;
        // array filling 

        var counters = new int[17];
        // Data input
        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
        {
            countVoice = int.Parse(Console.ReadLine());
            counters[countVoice]++;
        }

        //Search max
        for (int i = 1; i < counters.Length; i++)
            if (counters[i] > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = counters[i];
            }

        // Pair output
        for (int i = 0; i < counters.Length; i++)
            if (counters[i] != 0 && max1 == counters[i])
                Console.WriteLine($"{i} {counters[i]}");

        for (int i = 0; i < counters.Length; i++)
            if (counters[i] != 0 && max2 == counters[i])
                Console.WriteLine($"{i} {counters[i]}");

        for (int i = 0; i < counters.Length; i++)
            if (counters[i] != 0 && max3 == counters[i])
                Console.WriteLine($"{i} {counters[i]}");    
    }
}