﻿using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        IList<IRepair> Repairs { get; }
    }
}