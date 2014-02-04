﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Infrastructure.StringBuilders;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace Infrastructure.Extensions
{
    public static class UpdateExtensions
    {
        public static UpdateBuilder Set<T, TItem>(this UpdateBuilder builder, Expression<Func<T, IEnumerable<TItem>>> list, Expression<Func<TItem, object>> item, BsonValue value)
        {
            return builder.Set(NameForQueryBuilder.GetName(list, item), value);
        }
        public static UpdateBuilder Inc<T, TItem>(this UpdateBuilder builder, Expression<Func<T, IEnumerable<TItem>>> list, Expression<Func<TItem, object>> item, double value)
        {
            return builder.Inc(NameForQueryBuilder.GetName(list, item), value);
        }

        public static UpdateBuilder Unset<T, TItem>(this UpdateBuilder builder, Expression<Func<T, IEnumerable<TItem>>> list, Expression<Func<TItem, object>> item)
        {
            return builder.Unset(NameForQueryBuilder.GetName(list, item));
        }
    }
}