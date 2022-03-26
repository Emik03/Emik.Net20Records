// <copyright file="DegreeDays.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records.Examples;

internal abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords);
