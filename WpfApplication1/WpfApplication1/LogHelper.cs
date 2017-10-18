using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WpfApplication1
{
    public class LogHelper
    {
        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
            log.Info(msg);
            log.Fatal(msg);
            log.Debug(msg);
            
        }

        public static void dlog()
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //记录错误日志
            log.Error("error", new Exception("发生了一个异常"));
            //记录严重错误
            log.Fatal("fatal", new Exception("发生了一个致命错误"));
            //记录一般信息
            log.Info("info");
            //记录调试信息
            log.Debug("debug");
            //记录警告信息
            log.Warn("warn");
            Console.WriteLine("日志记录完毕。");
            Console.Read();
        }
    }

}
