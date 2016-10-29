using System;
using LeDragon.CSD3.Models;

namespace LeDragon.CSD3.Scales
{
    public class LinearScale
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
    }
}