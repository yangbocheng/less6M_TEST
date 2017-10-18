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
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void prochanged(string yy)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(yy));//对Name进行监听
            }
        }
        private string _result = mypath2;
        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                prochanged("Result");
            }
        }


        int i = 1;
        const string mypath1 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\1.png";
        const string mypath = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\test.png";
        const string mypath2 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\2.png";
        const string mypath3 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\copy.png";
        const string pathbase = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\";

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //FastDFSClient.autoDown("group1", "M00/00/08/wKgA8FndzNKASNrwAAJnYXhsJ447002156", pathbase+"copyy.jpg");
            //LogHelper.WriteLog(typeof(MainWindow),tbfile.Text.ToString());

        }
        public void ddd([CallerMemberName]string str="nostr")
        {
            
        }
        private BitmapImage getimage(string path)
        {
            BitmapImage bt = new BitmapImage();
            bt.BeginInit();
            bt.CacheOption = BitmapCacheOption.OnLoad;
            using (var stream = new MemoryStream(File.ReadAllBytes(mypath1)))
            {
                bt.StreamSource = stream;
                bt.EndInit();
                bt.Freeze();
            }
            return bt;
        }

        private string getpath()
        {
            if (i > 2) i = 1;
            string st = string.Format("pack://SiteOfOrigin:,,,/ex/{0}.png", i++);
            Console.WriteLine(st);
            return st;
        }
        public void test(ref string str)
        {
            str = "change";
        }
        
        public string str { get; set; }

        private void UserControl1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var reso = App.Current.Resources["brush111"] as SolidColorBrush;
            App.Current.Resources["brush111"] = new SolidColorBrush(Colors.Red);
        }
    }

}
