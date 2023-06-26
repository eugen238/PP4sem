using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C4 : C3
    {
        protected int e;
        private int f;
        public int g;

        public int j { get; set; }
        public C4(int a, int b) : base(a, b)
        {
        }

        public void c4Method()
        {
            Console.WriteLine("c4 method");
        }


    }
}
