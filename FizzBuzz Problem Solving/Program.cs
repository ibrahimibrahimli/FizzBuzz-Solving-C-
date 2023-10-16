namespace FizzBuzz_Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void fizzBuzz(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 15 != 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0 && i % 15 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}