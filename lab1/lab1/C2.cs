using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public  class C2 : I1
    {

        private const string first = "first";
        public const int two = 2;
        protected const char a = 'a';
        private int one = 1;
        public string three = "three";
        protected char b = 'b';

        public event EventHandler StartListening;

        private int Four { get; set; }
        protected int Five { get; set; }
        public int Six { get; set; }
        public int Firsted { get; set; }
        int[] cs = new int[5];

        public int this[int index] { get => cs[index]; set => cs[index]=value; }

        public void Hi()
        {
            throw new NotImplementedException();
        }

        public C2(int one, string three, char b, int four, int five, int six)
        {
            this.one = one;
            this.three = three;
            this.b = b;
            Four = four;
            Five = five;
            Six = six;
        }
        public C2(C2 c2)
        {
            Five = c2.Five;
        }
        public C2()
        {

        }

        private void First()
        {
            Console.WriteLine("Приватный метод");
        }
        public void Second()
        {
            Console.WriteLine("Публичный метод");
        }
        protected void Third()
        {
            Console.WriteLine("Защищенный метод");
        }
    }
}
