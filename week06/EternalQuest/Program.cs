using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();

        bool running = true;
        while(running)
        {
            Console.Clear();
            Console.Write(@$"Score: {manager.GetScore()}

1. Create Goal
2. List Goals
3. Record Event
4. Save
5. Load
6. Quit

Choose: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "6":
                Console.WriteLine("Thank you for using the goal tracker program. Goodbye.");
                running = false;
                break;

                case "1":
                    
                    break;

                case "2":
                    manager.DisplayGoals();
                    Console.ReadKey();
                    break;

                case "3":
                    
                    break;

                case "4":
                    
                    break;

                case "5":
                    
                    break;
            }


        }
    }
}