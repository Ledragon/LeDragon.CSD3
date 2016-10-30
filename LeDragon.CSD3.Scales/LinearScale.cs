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
            this.Range(range);
            this._domain = domain;
        }

        private Range<Double> _range;
        private Range<Double> _domain;

        public Range<Double> Domain()
        {
            return this._domain;
        }

        public IScale<Double, Double> Domain(Range<Double> domain)
        {
            this._domain = domain;
            return this;
        }

        public Range<Double> Range()
        {
            return this._range;
        }

        public IScale<Double, Double> Range(Range<Double> range)
        {
            this._range = range;
            return this;
        }


        /// <summary>
        ///     Given a value in range, scales the given value to the domain.
        /// </summary>
        /// <param name="value">The value to scale.</param>
        /// <returns>The scaled value.</returns>
        public Double Scale(Double value)
        {
            var result = (this._domain.Max-this._domain.Min)/(this._range.Max - this._range.Min)*(value - this._range.Min);
            return result;
        }

        /// <summary>
        ///     Given a value in domain, inverts the given value to the range.
        /// </summary>
        /// <param name="value">The value to invert.</param>
        /// <returns>The inverted value.</returns>
        public Double Invert(Double value)
        {
            var result = (this._range.Max - this._range.Min) / (this._domain.Max - this._domain.Min) * (value - this._domain.Min);
            return result;
        }
    }
}