// <copyright file="Temperature.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records.Examples;

internal static class Temperature
{
    public static DailyTemperature[] Data { get; } =
    {
        new(HighTemp: 57, LowTemp: 30),
        new(60, 35),
        new(63, 33),
        new(68, 29),
        new(72, 47),
        new(75, 55),
        new(77, 55),
        new(72, 58),
        new(70, 47),
        new(77, 59),
        new(85, 65),
        new(87, 65),
        new(85, 72),
        new(83, 68),
        new(77, 65),
        new(72, 58),
        new(77, 55),
        new(76, 53),
        new(80, 60),
        new(85, 66)
    };
}
