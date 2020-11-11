using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterSheetApp.Sections.Components
{
    /// <summary>
    /// Interaction logic for InvertedCornersHeader.xaml
    /// </summary>
    public partial class InvertedCornersHeader : UserControl
    {
        public static readonly DependencyProperty RadiusProperty = DependencyProperty.Register(nameof(Radius), typeof(double), typeof(InvertedCornersHeader), new PropertyMetadata(15d));
        public double? Radius
        {
            get => GetValue(RadiusProperty) as double?;
            set => SetValue(RadiusProperty, value);
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(nameof(HeaderText), typeof(string), typeof(InvertedCornersHeader));
        public string HeaderText
        {
            get => GetValue(HeaderProperty) as string;
            set => SetValue(HeaderProperty, value);
        }

        public Rect RectUpperLeft => new Rect { X = 0, Y = 0, Height = ActualHeight / 2, Width = ActualWidth / 2 };
        public Rect RectUpperRight => new Rect { X = ActualWidth / 2, Y = 0, Height = ActualHeight / 2, Width = ActualWidth / 2 };
        public Rect RectLowerLeft => new Rect { X = 0, Y = ActualHeight / 2, Height = ActualHeight / 2, Width = ActualWidth / 2 };
        public Rect RectLowerRight => new Rect { X = ActualWidth / 2, Y = ActualHeight / 2, Height = ActualHeight / 2, Width = ActualWidth / 2 };


        public InvertedCornersHeader()
        {
            InitializeComponent();
        }

        private void InvertedCornerHeader_Loaded(object sender, RoutedEventArgs e)
        {
            var upperLeft = new CombinedGeometry
            {
                GeometryCombineMode = GeometryCombineMode.Exclude,
                Geometry1 = new RectangleGeometry(new Rect { X = 0, Y = 0, Height = ActualHeight / 2, Width = ActualWidth / 2 }),
                Geometry2 = new EllipseGeometry(new Point(0, 0), ActualHeight / 2, ActualHeight / 2)
            };
            var upperRight = new CombinedGeometry
            {
                GeometryCombineMode = GeometryCombineMode.Exclude,
                Geometry1 = new RectangleGeometry(new Rect { X = ActualWidth / 2, Y = 0, Height = ActualHeight / 2, Width = ActualWidth / 2 }),
                Geometry2 = new EllipseGeometry(new Point(ActualWidth, 0), ActualHeight / 2, ActualHeight / 2)
            };
            var lowerLeft = new CombinedGeometry
            {
                GeometryCombineMode = GeometryCombineMode.Exclude,
                Geometry1 = new RectangleGeometry(new Rect { X = 0, Y = ActualHeight / 2, Height = ActualHeight / 2, Width = ActualWidth / 2 }),
                Geometry2 = new EllipseGeometry(new Point(0, ActualHeight), ActualHeight / 2, ActualHeight / 2)
            };
            var lowerRight = new CombinedGeometry
            {
                GeometryCombineMode = GeometryCombineMode.Exclude,
                Geometry1 = new RectangleGeometry(new Rect { X = ActualWidth / 2, Y = ActualHeight / 2, Height = ActualHeight / 2, Width = ActualWidth / 2 }),
                Geometry2 = new EllipseGeometry(new Point(ActualWidth, ActualHeight), ActualHeight / 2, ActualHeight / 2)
            };

            var group = new GeometryGroup();
            group.Children.Add(upperLeft);
            group.Children.Add(upperRight);
            group.Children.Add(lowerLeft);
            group.Children.Add(lowerRight);

            Background.Data = group;
        }
    }
}
