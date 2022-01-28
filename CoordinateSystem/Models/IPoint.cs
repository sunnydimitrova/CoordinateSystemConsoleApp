
namespace CoordinateSystem.Models
{
    public interface IPoint
    {
        string Name { get; }

        double X { get; }

        double Y { get; }

        double Distance { get; }
    }
}
