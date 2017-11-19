using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CircularSlider
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //this.Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            //        foreach (var square in SquareOfSquares.Squares)
            {
                //var gauge = new CircularSlider();// { Height = square.ActualHeight, Width = square.ActualWidth };
                //gauge.Style = Resources["Percentage"] as Style;
                //gauge.TrailBrush = new SolidColorBrush(square.RandomColor());
                //gauge.ScaleWidth = random.Next(5, 77);
                //gauge.Unit = "%";
                //gauge.UnitBrush = App.Current.Resources["PageForegroundBrush"] as SolidColorBrush;
                //gauge.ValueBrush = gauge.UnitBrush;

                //var side = square.Side();
                //gauge.Value = side * 2;
                //square.Content = gauge;
            }
        }
    }
}
