﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Server.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
