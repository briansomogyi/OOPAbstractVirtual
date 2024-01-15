using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractVirtual
{
    public class Square(int width, Point topLeft) : Shape(nameof(Square), topLeft, new Point(topLeft.X + width, topLeft.Y), new Point(topLeft.X + width, topLeft.Y + width), new Point(topLeft.X, topLeft.Y + width))
    {
        public int Width { get; } = width;

        public override sealed double Area
        {
            get
            {
                return Width * Width;
            }
        }

        public override void Rotate(double angleDegrees)
        {
            foreach (var p in Points)
            {
                p.ApplyRotationTransform(angleDegrees);
            }
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
