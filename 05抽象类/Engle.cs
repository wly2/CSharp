using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05抽象类
{
    class Engle : Bird
    {//在继承一个类的时候，必须实现这个类中的抽象方法
        public override void Fly()
        {   
            Console.WriteLine("鹰在飞行");
        }
    }
}
