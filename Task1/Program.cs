namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("range a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("range b:");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"count {count}");



        }
}
}