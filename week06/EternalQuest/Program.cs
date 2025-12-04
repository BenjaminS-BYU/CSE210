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
            Console.Write(@$"Welcome to the Goal Tracking Game!
Your Score: {manager.GetScore()}

1. Create Goal
2. List Goals
3. Record Event
4. Save
5. Load
6. Point History
7. Quit

Which do you choose?: ");
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
                    manager.ShowPointHistory();
                    break;

                case "7":
                    running = false;
                    break;

            }
        }
    }
}