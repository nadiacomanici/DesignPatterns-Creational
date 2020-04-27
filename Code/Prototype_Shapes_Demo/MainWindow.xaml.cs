using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Prototype_Shapes_Begin.Classes;

namespace Prototype_Shapes_Begin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShapeType? _currentAddShapeType = null;
        private ShapeCreator _shapeCreator = new ShapeCreator();
        private ObservableCollection<SimpleShape> _shapes = new ObservableCollection<SimpleShape>();
        private Canvas canvas;

        public MainWindow()
        {
            InitializeComponent();

            // bind logical collection of shapes to the visual listbox
            listBox.ItemsSource = _shapes;
        }

        #region Add shapes on canvas
        private void UpdateToggleButtons()
        {
            btnAddEllipse.IsChecked = _currentAddShapeType == ShapeType.Ellipse;
            btnAddRectangle.IsChecked = _currentAddShapeType == ShapeType.Rectangle;
        }

        private void BtnAddRectangle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentAddShapeType = ShapeType.Rectangle;
                UpdateToggleButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddEllipse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentAddShapeType = ShapeType.Ellipse;
                UpdateToggleButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                canvas = sender as Canvas;
                if (_currentAddShapeType != null && canvas != null)
                {
                    // get the point where you clicked on the canvas
                    var position = e.GetPosition(canvas);

                    // create and add shape
                    var shape = _shapeCreator.CreateShape(_currentAddShapeType.Value, position);
                    _shapes.Add(shape);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region Shape movement
        private Point? oldPosition;

        private void Shape_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var visualShape = sender as Shape;
            if (visualShape != null)
            {
                oldPosition = null;
                visualShape.ReleaseMouseCapture();
            }
        }

        private void Shape_MouseMove(object sender, MouseEventArgs e)
        {
            var visualShape = sender as Shape;
            if (oldPosition.HasValue && visualShape != null)
            {
                var simpleShape = visualShape.DataContext as SimpleShape;
                if (simpleShape != null)
                {
                    // get the point where you clicked on the canvas
                    var newPosition = e.GetPosition(canvas);

                    // compute movement
                    var xDiff = newPosition.X - oldPosition.Value.X;
                    var yDiff = newPosition.Y - oldPosition.Value.Y;

                    // update data object
                    simpleShape.Left += xDiff;
                    simpleShape.Top += yDiff;

                    // this is the old position
                    oldPosition = newPosition;
                }
            }
        }

        private void Shape_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var visualShape = sender as Shape;
            if (visualShape != null)
            {
                var simpleShape = visualShape.DataContext as SimpleShape;
                if (simpleShape != null)
                {
                    // get the point where you clicked on the canvas
                    oldPosition = e.GetPosition(canvas);

                    // capture all mouse movement for this control
                    visualShape.CaptureMouse();

                    // prefent the click event from propagating to the parent controls
                    e.Handled = true;

                    // attach the current shape to the properties panel, to update the values
                    gridProperties.DataContext = simpleShape;
                }
            }
        }
        #endregion

        private void MenuItemClone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var menuItem = sender as MenuItem;
                if (menuItem != null)
                {
                    var simpleShape = menuItem.DataContext as SimpleShape;
                    if (simpleShape != null)
                    {
                        var clone = simpleShape.Clone() as SimpleShape;
                        clone.Top += 10;
                        clone.Left += 10;
                        _shapes.Add(clone);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
