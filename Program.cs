namespace Exeption_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            
            try
            {
                result = num1 % num2;
                Console.WriteLine(result);
                if (num2 ==0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
