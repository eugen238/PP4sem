using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C3
    {
        protected int a;
        private int b;
        public int c;

        public int d { get; set; }
        public C3(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void c3Method()
        {
            Console.WriteLine("c3 method");
        }
    }
}
