using System;
//
namespace ConsoleApplication1
{
    delegate void Mydel();
    class print
        {
         public void Print1()
    {
        Console.WriteLine("Print1");
    }
        public void Prin2()
    {
        Console.WriteLine("Print2");
    }
        public void Print3()
    {
        Console.WriteLine("Print3");
    }
}

    class Program
    {
       
        static void Main()
        {
            print program = new print();
            Mydel del;
            //del = program.Prin2;
            del = program.Print1;
            del();

            Console.ReadLine();
            
        }
    }

//    #region 委托示例
//    delegate void Mydel(int value);
//    class Program
//    {
//        void Printlow(int value)
//        {
//            Console.WriteLine("{0}--low",value);
//        }
//        void Printhigh(int value)
//        {
//            Console.WriteLine("{0}--high", value);
//        }
//        static void Main()
//        {
//            Program program = new Program();
//            Mydel del;
//            Random rand = new Random();
//            int randValue = rand.Next(99);
//            del = randValue < 50 ? new Mydel(program.Printlow) : new Mydel(program.Printhigh);
//            del(randValue);
//        }
//     }
//#endregion



    #region eventhandler
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter c = new Counter(new Random().Next(10));
    //        c.ThresholdReached += c_ThresholdReached;

    //        Console.WriteLine("press 'a' key to increase total");
    //        while (Console.ReadKey(true).KeyChar == 'a')
    //        {
    //            Console.WriteLine("adding one");
    //            c.Add(1);
    //        }
    //    }

    //    static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
    //    {
    //        Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
    //        Environment.Exit(0);
    //    }
    //}

    //class Counter
    //{
    //    private int threshold;
    //    private int total;

    //    public Counter(int passedThreshold)
    //    {
    //        threshold = passedThreshold;
    //    }

    //    public void Add(int x)
    //    {
    //        total += x;
    //        if (total >= threshold)
    //        {
    //            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
    //            args.Threshold = threshold;
    //            args.TimeReached = DateTime.Now;
    //            OnThresholdReached(args);
    //        }
    //    }

    //    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    //    {
    //        EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
    //        if (handler != null)
    //        {
    //            handler(this, e);
    //        }
    //    }

    //    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    //}

    //public class ThresholdReachedEventArgs : EventArgs
    //{
    //    public int Threshold { get; set; }
    //    public DateTime TimeReached { get; set; }
    //}
    #endregion
}