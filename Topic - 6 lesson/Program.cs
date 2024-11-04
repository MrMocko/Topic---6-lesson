using System.Net.Sockets;

namespace Topic___6_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int guess, randNum, minimum, maximum, dice1, dice2;
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
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            randNum = generator.Next(1, 11);
            Console.WriteLine("Hey man lets play a guessing game.");
            Console.WriteLine("The number i have picked is between 1 - 10.");
            Console.WriteLine("Good luck");
            Console.Write("Enter your answer here: ");
            Int32.TryParse(Console.ReadLine(), out guess);
            if (guess == randNum)
            {
                Console.WriteLine("Yea man good job you got it, it was: " + randNum);

            }
            else
            {
                Console.WriteLine("No you're wrong the answer was: " + randNum);
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            dice1 = generator.Next(1,7);
            dice2 = generator.Next(1, 7);
            Console.WriteLine("Ok i am going to roll 2 die and tell you what they were and add them together.");
            Console.WriteLine("Time to roll the die");
            Thread.Sleep(1000);
            Console.Write("Here is what you rolled: ");
            Console.Write(dice1 + " " + dice2 + " ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("Now i'm going to add them together: ");
            Thread.Sleep(1000);
            Console.WriteLine(dice1 + dice2);
            Console.ReadLine();
        }
    }
}
