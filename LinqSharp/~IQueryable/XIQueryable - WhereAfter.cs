﻿using LinqSharp.Strategies;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinqSharp
{
    public static partial class XIQueryable
    {
        public static IQueryable<TEntity> WhereAfter<TEntity>(this IQueryable<TEntity> @this,
            Expression<Func<TEntity, DateTime>> memberExp,
            Expression<Func<TEntity, DateTime>> afterExp,
            bool includePoint = true)
        {
            return @this.Where(new WhereAfterStrategy<TEntity>(memberExp, afterExp, includePoint).StrategyExpression);
        }

        public static IQueryable<TEntity> WhereAfter<TEntity>(this IQueryable<TEntity> @this,
            Expression<Func<TEntity, DateTime>> memberExp,
            DateTime after,
            bool includePoint = true)
        {
            return @this.Where(new WhereAfterStrategy<TEntity>(memberExp, after, includePoint).StrategyExpression);
        }

        public static IQueryable<TEntity> WhereAfter<TEntity>(this IQueryable<TEntity> @this,
            Expression<Func<TEntity, DateTime?>> memberExp,
            Expression<Func<TEntity, DateTime>> afterExp,
            bool liftNullToTrue, bool includePoint = true)
        {
            return @this.Where(new WhereAfterStrategy<TEntity>(memberExp, afterExp, liftNullToTrue, includePoint).StrategyExpression);
        }

        public static IQueryable<TEntity> WhereAfter<TEntity>(this IQueryable<TEntity> @this,
            Expression<Func<TEntity, DateTime?>> memberExp,
            DateTime after,
            bool liftNullToTrue, bool includePoint = true)
        {
            return @this.Where(new WhereAfterStrategy<TEntity>(memberExp, after, liftNullToTrue, includePoint).StrategyExpression);
        }

        public static IQueryable<TEntity> WhereAfter<TEntity>(this IQueryable<TEntity> @this,
            Expression<Func<TEntity, object>> yearExp,
            Expression<Func<TEntity, object>> monthExp,
            Expression<Func<TEntity, object>> dayExp,
            DateTime after,
            bool includePoint = true)
        {
            return @this.Where(new WhereAfterStrategy<TEntity>(yearExp, monthExp, dayExp, after, includePoint).StrategyExpression);
        }
    }
}
