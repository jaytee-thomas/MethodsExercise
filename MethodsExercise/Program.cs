namespace MethodsExercise
{
    public class Program
    {
        static void aboutYou()
        {
            Console.WriteLine("Please Eneter Your Name: ");
            Console.ReadLine();

            Console.WriteLine("Please eneter if you're using a Mac or PC: ");
            Console.ReadLine();

            Console.WriteLine("Please Eneter your level of experience (begginer - intermediate - advanced): ");
            Console.ReadLine();
        }

        static void addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }

        static void multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Result: " + result);
        }

        static void divide(int num1, int num2)
        {   
            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }



        static void Main(string[] args)
        {
            
            aboutYou();

            Console.WriteLine("Enter num1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            addition(num1, num2);

            multiply(num1, num2);

            divide(num1, num2);

            Console.WriteLine("This is a summary of your entries: ");

            Console.ReadKey();

        }

    }
}

