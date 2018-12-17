using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfPlayground.FoundationExamples.Panels
{
    public class DiagonalPanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            var desiredSize = new Size(0, 0);

            foreach (UIElement e in this.InternalChildren)
            {
                e.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                desiredSize.Height += e.DesiredSize.Height;
                desiredSize.Width += e.DesiredSize.Width;
            }

            return desiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Point childPos = new Point(0, 0);

            foreach (UIElement e in this.InternalChildren)
            {
                e.Arrange(new Rect(childPos, e.DesiredSize));
                childPos.X += e.DesiredSize.Width;
                childPos.Y += e.DesiredSize.Height;
            }

            return finalSize;
        }
    }
}
