// <copyright file="HeatingDegreeDays.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records.Examples;

internal sealed record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
    : DegreeDays(BaseTemperature, TempRecords)
{
    public double DegreeDays => TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
}
