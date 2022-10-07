using System;

namespace Test
{
    class test
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input num");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello World!" + num);
            Console.WriteLine((num + 13));
            int age = 19;
            string name = "张三丰";
            Console.WriteLine("你好，我叫" + name + "我今年" + age + "岁了");

        }
    }
}