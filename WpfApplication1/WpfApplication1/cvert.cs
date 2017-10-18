using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfApplication1
{
    public class cvert : IValueConverter
    {
        BitmapImage btsource1 = null;
        public static bool changeNew = false;

        const string mypath1 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\1.png";
        const string mypath2 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\2.png";
        const string mypath3 = @"D:\2017YBC\git测试\WpfApplication1\WpfApplication1\bin\Debug\ex\copy.png";
        bool signal = false;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(changeNew)
            {
                changeNew = false;
                signal = !signal;
                btsource1 = getimage(signal ? mypath1 : mypath2);
                return btsource1;
            }
            return btsource1 == null ? getimage(mypath1) : btsource1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        private BitmapImage getimage(string path)
        {
            BitmapImage bt = new BitmapImage();
            bt.BeginInit();
            bt.CacheOption = BitmapCacheOption.OnLoad;
            using (var stream = new MemoryStream(File.ReadAllBytes(path)))
            {
                bt.StreamSource = stream;
                bt.EndInit();
                bt.Freeze();
            }
            return bt;
        }
    }
}
