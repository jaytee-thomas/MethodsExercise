namespace MethodsExercise
{
    public class Program
    {
        static void AboutYou()
        {
            Console.WriteLine("Please Eneter Your Name: ");
            Console.ReadLine();

            Console.WriteLine("Please eneter if you're using a Mac or PC: ");
            Console.ReadLine();

            Console.WriteLine("Please Eneter your level of experience (begginer - intermediate - advanced): ");
            Console.ReadLine();
        }

        static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
            return result;
        }

        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Result: " + result);
            return result;
        }

        static double Divide(double num1, double num2)
        {   
            double result = num1 / num2;
            Console.WriteLine("Result: " + result);
            return result;
        }
        static int Mod(int num1, int num2)
        {
            int result = num1 % num2;
            Console.WriteLine("Result: " + result);
            return result;
        }


        static void Main(string[] args)
        {
            
            AboutYou();

            Console.WriteLine("Enter num1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            int sum = Addition(num1, num2);

            int product = Multiply(num1, num2);

            double quotient = Divide(num1, num2);

            int remainder = Mod(num1, num2);

            /*Console.WriteLine("Summary of your entries:");
            Console.WriteLine($"Num1: {num1}");
            Console.WriteLine($"Num2: {num2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");*/

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine( "   Summary of your entries:");
            Console.WriteLine();
            Console.WriteLine( " | Operation |    Result    ");
            Console.WriteLine( " |---------- |--------------");
            Console.WriteLine($" | Addition  | {sum}        ");
            Console.WriteLine($" | Multily   | {product}    ");
            Console.WriteLine($" | Division  | {quotient}   ");
            Console.WriteLine($" | Modulus   | {remainder}  ");
            Console.WriteLine( " |___________|______________");

            Console.ReadKey();

        }

    }
}

