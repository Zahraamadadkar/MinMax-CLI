namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("che tedad add vared mikonid?: ");
            int count = int.Parse(Console.ReadLine()!);

            int[] numbers = new int[count];
            int max = int.MinValue;
            int min = int.MaxValue;

            Console.WriteLine("enter numbers:");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"max: {max}");
            Console.WriteLine($" min: {min}");
            Console.WriteLine($"max*min: {max * min}");
        }
    }
}
 