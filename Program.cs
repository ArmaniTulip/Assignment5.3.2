namespace Assignment5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of steps");
            int userInput = int.Parse(Console.ReadLine());

            //base cases
            int step1 = 1;
            int step2 = 2;
            int result = 0;

            //return user input if is it is 1 or 2
            if (userInput == 1)
            {
                Console.WriteLine($"The numbers of ways to climb the stairs is {step1}");
                return;
            }
            if (userInput == 2)
            {
                Console.WriteLine($"The numbers of ways to climb the stairs is {step2}");
                return;
            }

            //starting at step 3, calculate
            for (int i = 3; i <= userInput; i++)
            {
                result = step1 + step2;
                step1 = step2;
                step2 = result;
            }

            Console.WriteLine($"The numbers of ways to climb the stairs is {result}");



        }
    }
}
