using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaveFileForControl
{
    class Program
    {
        //Application Init    程序入口
        static void Main(string[] args)
        {
            //introduce  介绍
            Console.WriteLine("Welcome to my first github program"+"\t\n"+"欢迎使用我的第一个github程序");
            //Threads sleep for one second    线程睡眠一秒
            Thread.Sleep(1000);
            //Output content to the screen  向屏幕输出内容
            Console.WriteLine("Please enter the content and the content will be saved to the content. TXT file in this proground" + "\t\n" + "请输入内容，内容会保存到的content.txt文件中");
            //Converts input to string with whitespace and receives it with a string variable
            //将输入的内容去空格转换为字符串类型将输入的内容去空格转换为字符串类型，并用一个字符串变量接收
            string str = Console.ReadLine().Trim().ToString();
            /*IO namespace is required to create a file stream 创建文件流，需要SYSTEM.IO命名空间
              IO namespace parameters 1: the location where files are stored after being converted to files,
              and 2: the file flow mode are required to create file flows 
              参数1：文件流转化成文件后最终存放的位置，参数2：文件流的模式*/
            FileStream fs = new FileStream(@"Content.txt",FileMode.Append);
            //字符换行
            str += "\n";
            //获取转换后的二进制数据  字符串装 二进制
            byte[] strData = Encoding.UTF8.GetBytes(str);
            //把数据写进文件流
            fs.Write(strData, 0, strData.Length);
            //把缓存的数据全部冲洗出来
            fs.Flush();
            //写入完成，关闭文件流
            fs.Close();
        }
    }
}
