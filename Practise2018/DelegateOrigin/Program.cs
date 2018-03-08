﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            // 引入委托之后
            // 初始化对象
            Program p = new Program();
            p.Greeting("李志", p.ChineseGreeting);
            p.Greeting("Tommy Li", p.EnglishGreeting);
            Console.Read();
        }
        #region 引入委托之后
        // 定义委托类型
        public delegate void GreetingDelegate(string name);
        // 有了委托之后，可以像如下实现打招呼方法
        public void Greeting(string name, GreetingDelegate callback)
        {
            // 调用委托
            callback(name);
        }

        // 英国人打招呼方法
        public void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello,  " + name);
        }

        // 中国人打招呼方法
        public void ChineseGreeting(string name)
        {
            Console.WriteLine("你好, " + name);
        }
        public void JapaneseGreeting(string name)
        {
            Console.WriteLine("こんにちは, " + name);
        }
        #endregion 

        #region 没有委托的情况
        //// 不使用委托实现打招呼方法
        //public void Greeting(string name,string language)
        //{
        //    switch (language)
        //    {
        //        case "zh-cn":
        //            ChineseGreeting(name);
        //            break;
        //        case "en-us":
        //            EnglishGreeting(name);
        //            break;
        //        default:
        //            EnglishGreeting(name);
        //            break;
        //    }
        //}

        //// 英国人打招呼方法
        //public void EnglishGreeting(string name)
        //{
        //    Console.WriteLine("Hello,  "+name);
        //}

        //// 中国人打招呼方法
        //public void ChineseGreeting(string name)
        //{
        //    Console.WriteLine("你好, "+name);
        //}
        #endregion
    }
}
