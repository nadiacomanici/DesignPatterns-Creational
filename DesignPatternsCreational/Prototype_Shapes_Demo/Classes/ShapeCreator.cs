using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Prototype_Shapes_Demo.Classes
{
    public class ShapeCreator
    {
        public SimpleShape CreateShape(ShapeType shapeType, Point position)
        {
            SimpleShape shape = null;

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    shape = new SimpleRectangle()
                    {
                        FillBrush = Brushes.Blue,
                        StrokeBrush = Brushes.DarkBlue
                    };
                    break;

                case ShapeType.Ellipse:
                    shape = new SimpleEllipse()
                    {
                        FillBrush = Brushes.Red,
                        StrokeBrush = Brushes.DarkRed
                    };
                    break;

                default:
                    throw new ArgumentException("Invalid shape mode to create a shape");
            }

            shape.Width = 100;
            shape.Height = 50;
            shape.Left = position.X - shape.Width / 2;
            shape.Top = position.Y - shape.Height / 2;

            return shape;
        }
    }
}
