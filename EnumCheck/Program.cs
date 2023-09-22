using System.Diagnostics;
using static Program.MyProgram;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class MyProgram
    {
        public enum MyEnum
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public delegate void MyDelegate();

        public static void Test(MyDelegate my)
        {
            var list = new List<long>();
            Stopwatch watch = new Stopwatch();
            for (int k = 0; k < 100; k++)
            {
                watch.Reset();
                watch.Start();

                for (int i = 0; i < 1000000; i++)
                {
                    my();
                }
                watch.Stop();
                list.Add(watch.ElapsedTicks);
            }
            Console.WriteLine("RunTime " + list.Average());
        }

        private static void Main(string[] args)
        {
            Console.Write("Result of nameof: ");
            Test(() => { var a = nameof(MyEnum) == "Monday"; });
            Console.Write("Result of ToString ==: ");
            Test(() => { var a = MyEnum.Monday.ToString() == "Monday"; });
            Console.Write("Result of ToString Equals: ");
            Test(() => { var a = MyEnum.Monday.ToString().Equals("Monday"); });
            Console.Write("Result of ToString Equals Ignore Case: ");
            Test(() => { var a = MyEnum.Monday.ToString().Equals("Monday", StringComparison.OrdinalIgnoreCase); });
        }
    }
}
