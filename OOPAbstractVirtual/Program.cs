using System;
using MyFancyConsumerProject;

namespace OOPAbstractVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shape shape = new("weird shape");
            // Console.WriteLine(shape.Area);

            Square square = new(10, new Point(100,100));
            PrintShape(square);

            Console.WriteLine($"Area of the {nameof(Square)} before rotation: {square.Area}");
            MoveShape(square);
            PrintShape(square);
            RotateShape(square);
            PrintShape(square);
            Console.WriteLine($"Area of the {nameof(Square)} after rotation: {square.Area}");

            // Triangle triangle = new(new Point(50, 50), new Point(100, 50), new Point(75, 100));
            // Console.WriteLine($"Area of the {nameof(Triangle)} before rotation: {triangle.Area}");
            // triangle.Move(50, 50);
            // triangle.Rotate(45);
            // Console.WriteLine($"Area of the {nameof(Triangle)} after rotation: {triangle.Area}");

            Shape triangleShape = new Triangle(
                new Point(50, 50), 
                new Point(100, 50), 
                new Point(75, 100));

            PrintShape(triangleShape);

            Console.WriteLine($"Area of the {nameof(Triangle)} before rotation: {triangleShape.Area}");
            MoveShape(triangleShape);
            RotateShape(triangleShape);
            Console.WriteLine($"Area of the {nameof(Triangle)} after rotation: {triangleShape.Area}");

            DoSomethingWithBaseClass(new ChildClass());
            DoSomethingElseWithBaseClass(new ChildClass());
            NonPolymorphicDoSomethingWithBaseClass(new ChildClass());

            AutoCountingCollectionOfIntegers collection = new();
            collection.AddElement(1);
            collection.AddCollection([2, 3]);
            Console.WriteLine($"Count: {collection.Count}");

            // Shape.Print();
            // Console.WriteLine("Hello, World!");
        }

        public static void PrintShape(Shape shape) 
        {
            shape.Print();
        }

        public static void PrintArea(Shape shape) 
        {
            // Dynamic dispatch
            // 1. Who is shape?
            //  shape may be: a triangle
            //  shape may be: a square
            // 2. What kind of method is GetArea?
            //  GetArea: abstract or virtual ==> polymorphic method
            //  GetArea: not abstract and not virtual ==> non-polymorphic method
            // 3. Actual call:
            //  for polymorphic methods ==> call the method based on actual object identity
            //      (the type used when object is instantiated)
            //  for non-polymorphic methods ==> call the method based on declared object type
            //      (the type used to declare the object)

            double area = shape.Area;

            Console.WriteLine($"Area: {area}");
        }

        public static void MoveShape(Shape shape) 
        {
            shape.Move(50, 50);
        }

        public static void RotateShape(Shape shape)
        {
            shape.Rotate(45);
        }

        public static void DoSomethingWithBaseClass(BaseClass baseClass) 
        {
            baseClass.DoSomething();
        }

        public static void DoSomethingElseWithBaseClass(BaseClass baseClass)
        {
            baseClass.DoSomethingElse();
        }

        public static void NonPolymorphicDoSomethingWithBaseClass(BaseClass baseClass)
        {
            BaseClass.NonPolymorphicDoSomething();
        }
    }

    public abstract class BaseClass
    {
        public abstract void DoSomething();

        public virtual void DoSomethingElse()
        {
            Console.WriteLine("BaseClass - DoSomethingElse");
        }

        public static void NonPolymorphicDoSomething()
        {
            Console.WriteLine("BaseClass - NonPolymorphicDoSomething");
        }
    }

    public class ChildClass : BaseClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("ChildClass - DoSomething");
        }

        public override void DoSomethingElse()
        {
            Console.WriteLine("ChildClass - DoSomethingElse");
        }

        public new static void NonPolymorphicDoSomething()
        {
            Console.WriteLine("ChildClass - NonPolymorphicDoSomething");
        }
    }

    public class GrandsonClass : ChildClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("GrandsonClass - DoSomething");
        }

        public override void DoSomethingElse()
        {
            Console.WriteLine("GrandsonClass - DoSomethingElse");
        }

        public new static void NonPolymorphicDoSomething()
        {
            Console.WriteLine("GrandsonClass - NonPolymorphicDoSomething");
        }
    }
}
