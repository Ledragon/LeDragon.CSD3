using System;
using LeDragon.CSD3.Models;

namespace LeDragon.CSD3.Scales
{
    public class LinearScale : IScale<Double, Double>
    {
        public LinearScale() : this(new Range<Double>(0, 1), new Range<Double>(0, 1))
        {
        }

        public LinearScale(Range<Double> range, Range<Double> domain)
        {
            this.Range = range;
            this.Domain = domain;
        }

        public Range<Double> Range { get; }

        public Range<Double> Domain { get; }

        /// <summary>
        ///     Given a value in range, scales the given value to the domain.
        /// </summary>
        /// <param name="value">The value to scale.</param>
        /// <returns>The scaled value.</returns>
        public Double Scale(Double value)
        {
            var result = (this.Domain.Max-this.Domain.Min)/(this.Range.Max - this.Range.Min)*(value - this.Range.Min);
            return result;
        }

        /// <summary>
        ///     Given a value in domain, inverts the given value to the range.
        /// </summary>
        /// <param name="value">The value to invert.</param>
        /// <returns>The inverted value.</returns>
        public Double Invert(Double value)
        {
            var result = (this.Range.Max - this.Range.Min) / (this.Domain.Max - this.Domain.Min) * (value - this.Domain.Min);
            return result;
        }
    }
}