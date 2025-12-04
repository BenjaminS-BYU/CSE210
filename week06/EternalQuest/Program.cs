using System;
using System.Collections.Generic;
using System.IO;

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
                case "1":
                    manager.CreateGoal();
                    break;

                case "2":
                    manager.ListGoalDetails();
                    Console.ReadKey();
                    break;

                case "3":
                    manager.RecordEvent();
                    break;

                case "4":
                    manager.SaveGoals();
                    break;

                case "5":
                    manager.LoadGoals();
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }
}