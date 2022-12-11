using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Custom : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Mehsulun qiymetine 20% endirim edildi");
        }
    }
}
