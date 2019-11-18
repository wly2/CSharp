using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            var aa = new Class1<string>("你好啊", "再见");//利用泛型类构造的时候，需要指定泛型的类型
            var bb = new Class1<int>(1111, 2222);

            //Console.WriteLine(aa.GetSum());
            //Console.WriteLine(bb.GetSum());
            Console.WriteLine(GetSum(1,2));

            Console.ReadKey();
        }

        public static string GetSum<T>(T a, T b)
        {
            return a + "" + b;
        }
    }
}
