using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03属性
{
    class 属性类
    {
        public int MyInt
        {
            //没有get块，不能取值
            get
            {
                return 1;
                Console.WriteLine("==========属性中的get块被调用=========");
            }

            set
            {
                // MyInt = value;
                Console.WriteLine("==========属性中的set块被调用=========");
                Console.WriteLine("==========在set块中的Value值是=========" + value);
            }
        }

        //通过属性可以拿取私有字段
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                Console.WriteLine("get块中 x的值是：" + x);
            }
        }


        //通过set方法，在设置值之前可以做一些校验的工作
        private int age;
        public int Age
        {
            get
            {
                return 1;
            }
            set
            {
                if (age > 0)
                {
                    age = value;
                    Console.WriteLine("============get块中 x的值是：============" + x);
                }
                else Console.WriteLine("=========年龄值不能为负数=============");
            }
        }


        //自动属性
        public String Name { get; set;}//编译器会自动存储一个小写的属性名称字段name
    }
}
