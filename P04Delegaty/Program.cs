namespace P04Delegaty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> greet = SayHello;

            greet("Tomasz");

            Predicate<int> isEven = IsEven;

            Console.WriteLine(isEven(4));


            Func<int, int, double> add = Sum;

            Console.WriteLine(add(3, 5));

            Action<string> action = Console.WriteLine;
            action("Hello, World!");
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static double Sum(int a, int b)
        {
            return a + b;
        }
    }
}
