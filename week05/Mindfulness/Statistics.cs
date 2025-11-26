using System;
using System.Collections.Generic;

public static class Statistics
{
    private static Dictionary<string, List<int>> _activityCounts = new Dictionary<string, List<int>>()
    {
        { "Breathing Activity", new List<int>() },
        { "Reflecting Activity", new List<int>() },
        { "Listing Activity", new List<int>() }
    };

    public static void RecordActivity(string activityName, int duration)
    {
        if (_activityCounts.ContainsKey(activityName))
        {
            _activityCounts[activityName].Add(duration);
        }
    }

    public static string GetReport()
    {
        string report = "";
        foreach (var activity in _activityCounts)
        {
            int totalDuration = 0;
            foreach (int duration in activity.Value)
            {
                totalDuration += duration;
            }
            report += $"{activity.Key}: {totalDuration} seconds spent over {activity.Value.Count} sessions.\n";
        }
        return report;
    }
}