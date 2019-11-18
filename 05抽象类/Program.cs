using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Engle();

            bird.Fly();
            Console.ReadKey();

        }
    }
}
