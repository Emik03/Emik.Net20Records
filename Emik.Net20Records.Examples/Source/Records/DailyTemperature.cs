// <copyright file="DailyTemperature.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records.Examples;

internal readonly record struct DailyTemperature(double HighTemp, double LowTemp)
{
    public double Mean => (HighTemp + LowTemp) / 2.0;
}
