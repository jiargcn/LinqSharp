﻿using Microsoft.EntityFrameworkCore;
using System;

namespace LinqSharp.ProviderFunctions
{
    public static class POracle
    {
        [DbFunction("RANDOM", "DBMS_RANDOM")]
        public static double Random() => throw new NotSupportedException();

    }
}