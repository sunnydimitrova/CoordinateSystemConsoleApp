using CoordinateSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordinateSystem.Core
{
    public class Controller : IController
    {
        private readonly ICollection<IPoint> points;

        public Controller()
        {
            this.points = new List<IPoint>();
        }

        public void AddPoint(string name, double x, double y)
        {
            points.Add(new Point(name, x, y));
        }

        public string ReturnsTheFurthestPointInformation()
        {
            var sb = new StringBuilder();
            var furthestPoint = this.ReturnsTheFurthestPoints();
            foreach (var point in furthestPoint)
            {
                sb.AppendLine(point.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        protected ICollection<IPoint> ReturnsTheFurthestPoints()
        {
            var orderDescendingPoints = this.points.OrderByDescending(x => x.Distance).ToList();
            var furthestPoint = orderDescendingPoints.FirstOrDefault().Distance;
            var furthestPoints = new List<IPoint>();

            foreach (var item in orderDescendingPoints)
            {
                if (item.Distance == furthestPoint)
                {
                    furthestPoints.Add(item);
                }
            }

            return furthestPoints;
        }

    }
}
