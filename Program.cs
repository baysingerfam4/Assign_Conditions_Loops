namespace Assign_Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem1();
        }

        public static void Problem1()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool positive = num > 0;
            bool negative = num < 0;
            bool zero = num == 0;
            if (positive)
            {
                Console.WriteLine("positive");
            }

            else if (negative)
            {
                Console.WriteLine("negative");
            }
            else if (zero)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            
        }
    } //class
} //namespace
