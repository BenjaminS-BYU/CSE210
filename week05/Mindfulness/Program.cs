using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Welcome to the Mindfulness App!
    Choose an activity to begin:
    1. Breathing Activity
    2. Reflecting Activity
    3. Listing Activity
Enter the number of your choice:");

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
        default:
            Console.WriteLine("Invalid choice. Please restart the program and select a valid option.");
            break;
    }
    }

    
}