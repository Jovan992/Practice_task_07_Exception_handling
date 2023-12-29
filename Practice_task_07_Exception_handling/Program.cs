namespace Practice_task_07_Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideTwoNumbers();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        public static double DivideTwoNumbers()
        {
            int a, b;
            double result = 0;
            Console.WriteLine("Please enter two numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                throw new DivideByZeroException("Second number cannot be zero!");
            }
            result = (double) a / b;
            Console.WriteLine($"{a} divided by {b} is {result}");
            return result;
        }
    }
}