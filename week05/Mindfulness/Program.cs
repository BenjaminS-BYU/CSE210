//   Things I've added:
// - In Activity.cs, changed DisplayStartingMessage to return _duration and adjusted the method to use Console.Write instead of Console.WriteLine for prompts.
// - In ListingActivity.cs, added countdown display before each user input prompt in the Run method
// - In BreathingActivity.cs, added a beep sound after each inhale and exhale to enhance user experience. Although the different beep frequencies only work on Windows.
// - Added a menu option in Program.cs to display activity descriptions.
// - Added a statistics Class to track and display total time spent on each activity. I used a dictionary in a static Statistics class to record and report activity durations.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
{
    Console.Clear();
        Console.Write(@"Welcome to the Mindfulness App!
    Choose an activity to begin:
    1. Breathing Activity
    2. Reflecting Activity
    3. Listing Activity
    4. Activity Descriptions
    5. Activity Statistics
    6. Quit
Enter the number of your choice: ");

    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();
            break;
        case "2":
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
            break;
        case "3":
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
            break;
        case "4":
            Console.WriteLine("Activity Descriptions:");
            Console.WriteLine("1. Breathing Activity: Focuses on deep breathing to help you relax.");
            Console.WriteLine("2. Reflecting Activity: Encourages you to reflect on personal experiences.");
            Console.WriteLine("3. Listing Activity: Helps you list positive aspects of your life.");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Activity Statistics:");
            Console.WriteLine(Statistics.GetReport());
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
            run = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please restart the program and select a valid option.");
            break;
    }
    }
}
}