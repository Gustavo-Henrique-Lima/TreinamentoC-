﻿namespace Dependencias;
using Humanizer;
class Program
{
    static void HumanizeQuantities()
    {
        Console.WriteLine("case".ToQuantity(0));
        Console.WriteLine("case".ToQuantity(1));
        Console.WriteLine("case".ToQuantity(5));
    }

    static void HumanizeDates()
    {
        Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        Console.WriteLine(TimeSpan.FromDays(5).Humanize());
        Console.WriteLine(TimeSpan.FromDays(16).Humanize());
    }

    public static void Main()
    {
        Console.WriteLine("Quantities:");
        HumanizeQuantities();

        Console.WriteLine("\nDate/Time Manipulation:");
        HumanizeDates();   
    }
}
