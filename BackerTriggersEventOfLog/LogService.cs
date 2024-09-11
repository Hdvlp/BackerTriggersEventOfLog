using System;

public class LogService
{
    public LogService()
    {
        Console.WriteLine("Constructed LogService");
    }

    public void OnBackedUp(object? sender, EventArgs e)
    {
        DateTime dateTime = DateTime.Now;

        Console.WriteLine("Logging: Files were backed up at {0}",
            dateTime.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss'_'zzz"));
    }
}
