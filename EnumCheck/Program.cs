using EnumCheck;
using System.Diagnostics;
using System.Dynamic;
using System.Text;
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
        //добавили object obg
        public delegate void MyDelegate<T>(T obg);
        //добавили object obj
        public static void Test<T>(MyDelegate<T> my, T obj)
        {
            var list = new List<long>();
            Stopwatch watch = new Stopwatch();
            for (int k = 0; k < 100; k++)
            {
                watch.Reset();
                watch.Start();

                for (int i = 0; i < 1000000; i++)
                {
                    //добавили (obj)
                    my(obj);
                }
                watch.Stop();
                list.Add(watch.ElapsedTicks);
            }
            Console.WriteLine("RunTime " + list.Average());
        }

        private static void Main(string[] args)
        {

            //Console.Write("Result of nameof: ");
            //Test(() => { var a = nameof(MyEnum) == "Monday"; });
            //Console.Write("Result of nameof + equals: ");
            //Test(() => { var a = nameof(MyEnum).Equals("Monday"); });
            //Console.Write("Result of ToString ==: ");
            //Test(() => { var a = MyEnum.Monday.ToString() == "Monday"; });
            //Console.Write("Result of ToString Equals: ");
            //Test(() => { var a = MyEnum.Monday.ToString().Equals("Monday"); });
            //Console.Write("Result of ToString Equals Ignore Case: ");
            //Test(() => { var a = MyEnum.Monday.ToString().Equals("Monday", StringComparison.OrdinalIgnoreCase); });


            //Console.Write("Result of new: ");
            //Test(() => { var a = new TestClass(); });
            //Console.Write("Result of Create Instance: ");
            //Test(() => { var a = Activator.CreateInstance(typeof(TestClass), true) as TestClass; });
            //Console.Write("Result of Create Instance: ");
            //Test(() => { var a = (TestClass)Activator.CreateInstance(typeof(TestClass), true); });



            //Test(() => { var d9 = typeof(IBase).IsAssignableFrom(typeof(TestClass)); });
            //Test(() => { var d3 = typeof(TestClass).IsAssignableFrom(typeof(TestClass)); });
            //Test(() => { var d4 = typeof(Base).IsAssignableFrom(typeof(TestClass)); });

            //Test(() => { var d9 = new TestClass() is IBase; });
            //Test(() => { var d9 = new TestClass() is Base; });
            //Test(() => { var d9 = new TestClass() is TestClass; });



            //виклик delegate з obj
            //object obj = new TestClass();


            //Test((object obj) => { var d9 = obj is Base; }, obj);
            //Test((object obj) => { var d9 = obj is IBase; }, obj);
            //Test((object obj) => { var d9 = obj is TestClass; }, obj);

            //var type = obj.GetType();
            //Test((object obj) => { var d9 = obj.GetType() == typeof(TestClass); }, obj);
            //Test((object obj) => { var d9 = type == typeof(TestClass); }, type);
            var name = new StringBuilder("Veronika", 500);
            var strname = "Veronika";
            //Test((object name) => { var a = string.Format("My name is {0}", name); }, name);
            //Test((object name) => { var a = $"My name is {name}"; }, name);
            Test((StringBuilder name) => { var a = name.Append("veronika").Append("veronika").Append("veronika").Append("veronika").Append("veronika").Append("veronika").Append("veronika").Append("veronika").Clear(); }, name);
            Test((string name) => { var a = "My name is " + name + name + name + name + name + name + name + name; }, strname);


        }
    }
}
