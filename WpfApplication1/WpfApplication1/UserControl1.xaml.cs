using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Brush Border1Brush
        {
            get { return (Brush)GetValue(Border1BrushProperty); }
            set { SetValue(Border1BrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Border1Brush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Border1BrushProperty =
            DependencyProperty.Register("Border1Brush", typeof(Brush), typeof(UserControl1), new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        public string Image1Source
        {
            get { return (string)GetValue(Image1SourceProperty); }
            set { SetValue(Image1SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image1Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image1SourceProperty =
            DependencyProperty.Register("Image1Source", typeof(string), typeof(UserControl1), new PropertyMetadata(null));





        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(UserControl1), new PropertyMetadata("mydefault"));



    }
}
