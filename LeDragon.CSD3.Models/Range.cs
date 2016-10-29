namespace LeDragon.CSD3.Models
{
    public class Range<T>
    {
        public Range(T min, T max)
        {
            this.Max = max;
            this.Min = min;
        }

        public T Min { get; }
        public T Max { get; }
    }
}