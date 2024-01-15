using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractVirtual
{
    public class Point(double x, double y)
    {
        public double X { get; private set; } = x;

        public double Y { get; private set; } = y;

        public void ApplyTranslationTransform(double translationX, double translationY)
        {
            X += translationX;
            Y += translationY;
        }

        public void ApplyRotationTransform(double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix

            double originalX = this.X;
            double originalY = this.Y;

            this.X = (originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians));
            this.Y = (originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians));
        }
    }

}
