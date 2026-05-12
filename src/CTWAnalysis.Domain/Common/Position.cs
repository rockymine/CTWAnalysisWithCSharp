namespace CTWAnalysis.Domain.Common;

public readonly record struct Position(double X, double Y, double Z)
{
    public double DistanceTo(Position other)
    {
        var dx = X - other.X;
        var dy = Y - other.Y;
        var dz = Z - other.Z;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}