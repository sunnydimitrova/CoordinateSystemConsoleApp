

namespace CoordinateSystem.Core
{
    public interface IController
    {
        void AddPoint(string name, double x, double y);

        string ReturnsTheFurthestPointInformation();
    }
}
