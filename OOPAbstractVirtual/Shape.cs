using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractVirtual
{
    public abstract class Shape(string name, params Point[] points)
    {
        public string Name 
        { 
            get 
            { 
                return name; 
            }
        }

        public Point[] Points 
        { 
            get 
            { 
                return points; 
            } 
        }

        public abstract double Area
        {
            get;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} area: {Area}");
            Console.WriteLine($"{Name} coordinates:");
            foreach (var p in Points)
            {
                Console.WriteLine($"X={p.X}, Y={p.Y}");
            }
        }

        public virtual void Move(int dx,int dy)
        {
            foreach (var p in Points) 
            {
                p.ApplyTranslationTransform(dx, dy);
            }
        }

        public abstract void Rotate(double angleDegrees);

        public abstract double GetArea();
    }

}
