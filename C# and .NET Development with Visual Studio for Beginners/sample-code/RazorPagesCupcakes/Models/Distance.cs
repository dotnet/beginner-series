namespace RazorPagesCupcakes.Models
{
    public readonly struct Distance(double dx, double dy)
    {
        public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);

        public readonly double Direction { get; } = Math.Atan2(dy, dx);
    }
}
