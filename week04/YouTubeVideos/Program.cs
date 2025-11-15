using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Jane Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        Console.WriteLine($"Video 1: {video1.GetNumberOfComments()} comments");

        Video video2 = new Video("Advanced C# Concepts", "John Smith", 900);
        video2.AddComment(new Comment("Charlie", "This was a bit complex, but I got it."));
        video2.AddComment(new Comment("Dave", "Can you make a video on LINQ next?"));
        video2.AddComment(new Comment("Eve", "Thanks for the clear explanations!"));
        Console.WriteLine($"Video 2: {video2.GetNumberOfComments()} comments");

        Video video3 = new Video("C# Design Patterns", "Emily Johnson", 1200);
        Console.WriteLine($"Video 3: {video3.GetNumberOfComments()} comments");

    }
}