﻿using Blacksmith.Validations;
using System;

namespace Blacksmith.Extensions.Castings
{
    public static class CastingExtensions
    {
        public static T defaultIfNull<T>(this T item, Func<T> buildNewItem) where T: class
        {
            T newItem;

            if (item == null)
            {
                newItem = buildNewItem();
                Asserts.Assert.isNotNull(newItem);

                return newItem;
            }
            else
            {
                return item;
            }
        }

        public static T defaultIfNull<T>(this T item) where T : class, new()
        {
            if (item == null)
            {
                return new T();
            }
            else
            {
                return item;
            }
        }
    }
}