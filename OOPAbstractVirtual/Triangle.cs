using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractVirtual
{
    public class Triangle(Point p1, Point p2, Point p3) : Shape(nameof(Triangle), p1, p2, p3)
    {
        public Point P1 { get; } = p1 ?? new Point(0, 0);

        public Point P2 { get; } = p2 ?? new Point(0, 0);

        public Point P3 { get; } = p3 ?? new Point(0, 0);

        public override sealed double Area
        {
            get
            {
                // see: https://www.mathopenref.com/coordtrianglearea.html
                double area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;
                return Math.Round(area, 2);
            }
        }

        public override void Move(int dx, int dy)
        {
            Console.WriteLine("Before triangle Move");
            Print();

            base.Move(dx, dy);

            Console.WriteLine("After triangle Move");
            Print();
        }

        public override void Rotate(double angleDegrees)
        {
            this.P1.ApplyRotationTransform(angleDegrees);
            this.P2.ApplyRotationTransform(angleDegrees);
            this.P3.ApplyRotationTransform(angleDegrees);
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
