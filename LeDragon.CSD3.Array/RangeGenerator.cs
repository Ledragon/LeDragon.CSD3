using System;
using System.Collections.Generic;

namespace LeDragon.CSD3.Array
{
    public static class RangeGenerator
    {
        /// <summary>
        /// Generates an inclusive interval of evenly spaced numbers.
        /// </summary>
        /// <param name="start">The first value of the interval.</param>
        /// <param name="end">The last value of the interval.</param>
        /// <param name="count">The number of intervals.</param>
        /// <returns>The list of generated values.</returns>
        public static List<Int32> Create(Int32 start, Int32 end, Int32 count)
        {
            var result = new List<Int32>();
            for (var i = 0; i < count + 1; i++)
            {
                result.Add(start + (Int32) Math.Round((Double) (end - start)/count)*i);
            }
            return result;
        }

        /// <summary>
        /// Generates an inclusive interval of evenly spaced numbers.
        /// </summary>
        /// <param name="start">The first value of the interval.</param>
        /// <param name="end">The last value of the interval.</param>
        /// <param name="count">The number of intervals.</param>
        /// <returns>The list of generated values.</returns>
        public static List<Double> Create(Double start, Double end, Int32 count)
        {
            //TODO use decimal if possible, to avoid numeric noise
            var result = new List<Double>();
            for (var i = 0; i < count + 1; i++)
            {
                result.Add(start + (end - start)/count*i);
            }
            return result;
        }
    }
}