// <copyright file="Program.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records.Examples;

internal class Program
{
    private static void Main(string[] _)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This program demonstrates use of record types in .NET Framework 2.0 by using examples found in:");
        Console.WriteLine("https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        ShowEquality(
            ShowDestructuring(
                ShowInheritance(
                    ShowPrint(Temperature.Data))));

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("All examples finished computing. Press any key to exit the program.");
        Console.ReadKey();
    }

    private static DailyTemperature[] ShowPrint(DailyTemperature[] data)
    {
        DailyTemperature[] temps = { data[0], data[1], data[^2], data[^1] };
        string[] strings = Array.ConvertAll(temps, temps => temps.ToString());

        Console.WriteLine("Demonstrating ToString():");
        Console.WriteLine(string.Join("\n", strings));
        Console.WriteLine();

        return data;
    }

    private static CoolingDegreeDays ShowInheritance(DailyTemperature[] data)
    {
        HeatingDegreeDays heatingDegreeDays = new(65, data);
        Console.WriteLine($"Demonstrating {nameof(HeatingDegreeDays)}:");
        Console.WriteLine(heatingDegreeDays);
        Console.WriteLine();

        CoolingDegreeDays coolingDegreeDays = new(65, data);
        Console.WriteLine($"Demonstrating {nameof(CoolingDegreeDays)}:");
        Console.WriteLine(coolingDegreeDays);
        Console.WriteLine();

        return coolingDegreeDays;
    }

    private static CoolingDegreeDays ShowDestructuring(CoolingDegreeDays coolingDegreeDays)
    {
        CoolingDegreeDays growingDegreeDays = coolingDegreeDays with { BaseTemperature = 41 };
        Console.WriteLine("Demonstrating Deconstruct():");
        Console.WriteLine(growingDegreeDays);
        Console.WriteLine();

        return growingDegreeDays;
    }

    private static void ShowEquality(CoolingDegreeDays growingDegreeDays)
    {
        CoolingDegreeDays growingDegreeDaysCopy = growingDegreeDays with { };
        Console.WriteLine($"Demonstrating equality with op_Equality (==): {growingDegreeDays == growingDegreeDaysCopy}");
        Console.WriteLine($"Demonstrating equality with {nameof(ReferenceEquals)}: {ReferenceEquals(growingDegreeDays, growingDegreeDaysCopy)}");
        Console.WriteLine();
    }
}
