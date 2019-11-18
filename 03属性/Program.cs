using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03属性
{
    class Program
    {
        static void Main(string[] args)
        {
            属性类 s1 = new 属性类();
            //s1.MyInt = 100;
            //s1.X = 50;
            //s1.Age = -1;
            s1.Name = "gfsehgerh";
            Console.WriteLine("get属性块的name是：" + s1.Name);
            Console.ReadKey();

        }
    }
}
