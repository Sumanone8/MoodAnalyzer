using System;

class MoodAnalyser
{
    public string AnalyseMood(string message)
    {
        // Check for null or empty message
        if (string.IsNullOrWhiteSpace(message))
        {
            return "Neutral Mood";
        }

        // Perform mood analysis based on certain criteria
        if (message.ToLower().Contains("happy") || message.ToLower().Contains("joy"))
        {
            return "Happy Mood";
        }
        else if (message.ToLower().Contains("sad") || message.ToLower().Contains("unhappy"))
        {
            return "Sad Mood";
        }
        else
        {
            return "Neutral Mood";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MoodAnalyser
        MoodAnalyser moodAnalyser = new MoodAnalyser();

        // Get input message from the user
        Console.Write("Enter a message: ");
        string message = Console.ReadLine();

        // Analyze the mood and display the result
        string mood = moodAnalyser.AnalyseMood(message ?? ""); // Handle null by providing a default empty string
        Console.WriteLine("Mood: " + mood);
    }
}
