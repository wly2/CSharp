using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05抽象类
{
    abstract class Bird
    {//一个类中存在抽象方法，那么这个类就一定是一个抽象类
        private float spennd;

        public void Eat() { }
        public abstract void Fly();//抽象类可以申明对象，但不可以构造
    }
}
