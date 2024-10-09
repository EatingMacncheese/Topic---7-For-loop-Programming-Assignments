namespace Topic___7_For_loop_Programming_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assingment 1
            Console.WriteLine("Press enter to start count down");
            Console.ReadLine();
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Blast off");
            Console.ReadLine();

            //Assignment 2
            Console.WriteLine("Press enter for some numbers");
            Console.ReadLine();
            Console.WriteLine("x      y");
            Console.WriteLine("_________");
            for (int i = -10; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + "   " + (i * i));
            }
            Console.WriteLine("hooray");
            Console.ReadLine();

            //Assignment 3
            Console.WriteLine("Enter your name");
            Console.WriteLine("Name: ");
            String name = Console.ReadLine();
            if (name != "Aldworth")
                for (int i = 1; i <= 9; i = i + 1)
            {
                Console.WriteLine(name);
            }
            else
            {
                for (int i = 1; i <= 4; i = i + 1)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
