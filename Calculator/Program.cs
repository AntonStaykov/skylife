// Create a calculator witd addition " + ", subtraction " - ", multiplication " * ", division " / ", square root " Math.Sqrt - 81 = 9 ", power " ^ ".

internal class Program
{
    static void writer(string input)
        {
            Console.WriteLine(input + "\n");
        }
    private static int Main(string[] args)
    {
    start:

        writer("i want to write something here so im using a function to do so");

        Console.WriteLine("\nChoose from the given functions:");
        Console.WriteLine("1.Addition +");
        Console.WriteLine("2.Subtraction  - ");
        Console.WriteLine("3.Multiplication  * ");
        Console.WriteLine("4.Division  / ");
        Console.WriteLine("\nEnter your choise:");

        int choise = int.Parse(Console.ReadLine());


        switch (choise)
        {
            case 1: // Addition

                Console.WriteLine("\nEnter first number");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nThe addition of " + (n1 + n2));
                Console.WriteLine("\n\nWould you like to continue, yes(y) or no(n)?");
                string m1 = Console.ReadLine();

                if (m1 == "y")
                {
                    goto start; //forbidden , use while loop on whole thing
                }

                else if (m1 == "n")
                {
                    break;
                }

                break;

            case 2: // Subtraction

                Console.WriteLine("Enter first number");
                int n3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int n4 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nThe addition of {n3} - {n4} = {n3 - n4}");

                Console.WriteLine("\n\nWould you like to continue, yes(y) or no(n)?");
                string m2 = Console.ReadLine();

                if (m2 == "y")

                {
                    goto start;
                }

                else if (m2 == "n")

                {
                    break;
                }

                break;

            case 3: // Multiplication

                Console.WriteLine("Enter first number");
                int n5 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int n6 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nThe Multiplication of {n5} * {n6} = {n5 * n6}");

                Console.WriteLine("\n\nWould you like to continue, yes(y) or no(n)?");
                string m3 = Console.ReadLine();

                if (m3 == "y")

                {
                    goto start;
                }

                else if (m3 == "n")

                {
                    break;
                }

                break;

            case 4: // Division

                Console.WriteLine("Enter first number");
                int n7 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int n8 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nThe Division of {n7} + {n8} = {n7 / n8}");

                Console.WriteLine("\n\nWould you like to continue, yes(y) or no(n)?");
                string m4 = Console.ReadLine();

                if (m4 == "y")

                {
                    goto start;
                }

                else if (m4 == "n")

                {
                    break;
                }

                break;

            default:

                break;
        }


        return 0;
        //double number = double.Parse(Console.ReadLine());

        //Console.WriteLine(Math.Sqrt(number));
    }
}