using CoordinateSystem.Messages;
using System;
using System.Text;

namespace CoordinateSystem.Models
{
    public class Point : IPoint
    {
        private string name;
        private double x;
        private double y;

        public Point(string name, double x, double y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }
                this.name = value;
            }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Distance => Math.Sqrt((Math.Pow(this.X, 2)) + (Math.Pow(this.Y, 2)));

        protected string Quadrant()
        {
            if (this.X > 0 && this.Y > 0)
            {
                return "First quandrant";
            }
            else if (this.X < 0 && this.Y > 0)
            {
                return "Second quandrant";
            }
            else if (this.X < 0 && this.Y < 0)
            {
                return "Third quandrant.";
            }
            else if (this.X > 0 && this.Y < 0)
            {
                return "Fourth quandrant";
            }
            else if (this.X == 0 && (this.Y > 0 || this.Y < 0))
            {
                return "the ordinate.";
            }
            else if ((this.X > 0 || this.X < 0) && Y == 0)
            {
                return "the abscissa.";
            }
            else
            {
                return "center.";
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Point {this.Name}({this.X}, {this.Y}) - {this.Distance:f2} away from the center.");
            sb.AppendLine($"Point {this.Name}({this.X}, {this.Y}) - {this.Quadrant()}");
            return sb.ToString().TrimEnd();
        }
    }
}
