using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        int i = 3;
        public int getNum()
        {
            string str1 = "test";
            return 1;
        }

        public void dowork1(string str1)
        {
            new System.Threading.Thread(() =>
            {
                System.Threading.Thread.Sleep(3000);

            }).Start();
        }
    }
    
}
