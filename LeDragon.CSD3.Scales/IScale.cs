using LeDragon.CSD3.Models;

namespace LeDragon.CSD3.Scales
{
    public interface IScale<TRange, TDomain>
    {
        Range<TDomain> Domain();
        IScale<TRange, TDomain> Domain(Range<TDomain> domain);

        Range<TRange> Range();
        IScale<TRange, TDomain> Range(Range<TRange> range);

        TDomain Invert(TRange value);
        TRange Scale(TDomain value);
    }
}