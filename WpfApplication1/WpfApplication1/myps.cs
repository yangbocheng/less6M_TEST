using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastDFS;
using FastDFS.Client;
using FastDFS.Client.Common;
using FastDFS.Client.Config;
using FastDFS.Client.Storage;
using FastDFS.Client.Tracker;
using System.IO;

namespace WpfApplication1
{
    public class myps
    {

        public static void getByte()
        {
            string url = "http://aa.com/da/g5/M02/0D/16/rBEDik_nOJ0IAAAAAAA_cbJCY-UAACrRgMhVLEAAD-J352.jpg";
            string url2 = "http://192.168.0.240";
            System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)req.GetResponse();
            Stream stream = res.GetResponseStream();

            byte[] data = StreamToBytes(stream);

        }

        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }

        /// 将 byte[] 转成 Stream

        public static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }




    }



    
}
