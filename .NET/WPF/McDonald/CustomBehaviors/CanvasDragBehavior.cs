using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace CustomBehaviors
{
    public class CanvasDragBehavior : Behavior<UIElement>
    {
        private Canvas canvas;

        private bool isDragging = false;

        private Point mouseOffset;

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseLeftButtonDown += AssociatedObjectOnMouseLeftButtonDown;
            AssociatedObject.MouseMove += AssociatedObjectOnMouseMove;
            AssociatedObject.MouseLeftButtonUp += AssociatedObjectOnMouseLeftButtonUp;
        }

        private void AssociatedObjectOnMouseLeftButtonUp(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            if (isDragging)
            {
                AssociatedObject.ReleaseMouseCapture();
                isDragging = false;
            }
        }

        private void AssociatedObjectOnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            if (isDragging)
            {
                Point point = mouseEventArgs.GetPosition(canvas);
                AssociatedObject.SetValue(Canvas.TopProperty, point.Y - mouseOffset.Y);
                AssociatedObject.SetValue(Canvas.LeftProperty, point.X - mouseOffset.X);
            }
        }

        private void AssociatedObjectOnMouseLeftButtonDown(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            if (canvas == null)
            {
                canvas = VisualTreeHelper.GetParent(AssociatedObject) as Canvas;
                if (canvas == null)
                {
                    throw new Exception();
                }
            }
            isDragging = true;
            mouseOffset = mouseButtonEventArgs.GetPosition(AssociatedObject);
            AssociatedObject.CaptureMouse();
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseLeftButtonDown += AssociatedObjectOnMouseLeftButtonDown;
            AssociatedObject.MouseMove += AssociatedObjectOnMouseMove;
            AssociatedObject.MouseLeftButtonUp += AssociatedObjectOnMouseLeftButtonUp;
        }
    }
}
