using LeDragon.CSD3.Models;

namespace LeDragon.CSD3.Scales
{
    public interface IScale<TRange, TDomain>
    {
        Range<TDomain> Domain { get; }
        Range<TRange> Range { get; }

        TDomain Invert(TRange value);
        TRange Scale(TDomain value);
    }
}