namespace Topic___6_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum, minimum, maximum;
            randNum = generator.Next(10);
            Console.WriteLine("My random number is " + randNum);
            Console.WriteLine("Here are some numbers from 1 to 5!");
            Console.Write(generator.Next(3, 6) + " ");
            Console.Write(generator.Next(3, 6) + " ");
            Console.Write(generator.Next(3, 6) + " ");
            Console.Write(generator.Next(3, 6) + " ");
            Console.Write(generator.Next(3, 6) + " ");
            Console.WriteLine(generator.Next(3, 6) + " ");
            Console.WriteLine();
            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();
            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter a minimum and a maximum number below.");
            Console.Write("Enter your Minimum here: ");
            Int32.TryParse(Console.ReadLine(), out minimum);
            Console.WriteLine("");
            Console.Write("Enter your Maximum here: ");
            Int32.TryParse(Console.ReadLine(), out maximum);
            Console.WriteLine("Here are some numbers from " + minimum + (" and ") + maximum);
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " "); 
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.Write(generator.Next(minimum, maximum) + " ");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
