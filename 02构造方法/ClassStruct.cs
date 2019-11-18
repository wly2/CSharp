using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02构造方法
{
    class ClassStruct
    {
        private int x, y, z;
        //没有构造函数，系统会自动提供一个无参构造函数
        public ClassStruct()
        {
            Console.WriteLine("=========ClassStruct函数被调用==============");
            Console.ReadKey();
        }

        public ClassStruct(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            Console.WriteLine("x的值是：" + x  + "\ny的值是："+ y + "\nz的值是："+ z);
            Console.ReadKey();
        }
    }
}
