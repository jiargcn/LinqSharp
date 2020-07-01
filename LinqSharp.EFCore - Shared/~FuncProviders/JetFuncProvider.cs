﻿using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0060 // Remove unused parameter

namespace LinqSharp.EFCore
{
    internal static class JetFuncProvider
    {
        public static void Register(ModelBuilder modelBuilder)
        {
            Random(modelBuilder);
        }

        private static void Random(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasDbFunction(typeof(DbFunc).GetMethod(nameof(DbFunc.Random)))
                .HasTranslation(args => Translator.Function("RND", args, typeof(double)));
        }

    }
}

#pragma warning restore IDE0060 // Remove unused parameter
