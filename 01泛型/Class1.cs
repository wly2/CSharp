using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01泛型
{
    class Class1<T>//T代表一个数据类型，当使用Class1进行构造的时候，需要指定T的类型
    {
        private T a;
        private T b;

        public Class1(T a, T b)
        {
            this.a = a;
            this.b = b;

        }

        public string GetSum()
        {
            return "" + a + b;
        }
    }
}
