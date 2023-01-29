internal class Program
{

    private static void Main(string[] args)
    {
      //  Console.ReadLine(N)
           // a[N]++
            // 1 путь остортировать массив. 
            // 2 путь ручной, нашли максимум выписали индексы. Можно вспомогательный массив. Нашли из оставшихся максимум выписали и так далее.
            int[] array = new int [1000];
        Random r = new();
        for (int i = 0; i < array.Length; i++)
            array[i] = r.Next(0, 17);


    }
}