﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C1
    {

        private const string first = "first";
        public const int two = 2;
        protected const char a = 'a';
        private int one = 1;
        public string three = "three";
        protected char b = 'b';
        private int Four { get; set; }
        protected int Five { get; set; }
        public int Six { get; set; }
        public C1(int one, string three, char b, int four, int five, int six)
        {
            this.one = one;
            this.three = three;
            this.b = b;
            Four = four;
            Five = five;
            Six = six;
        }
        public C1(C1 c1)
        {
            Five= c1.Five;
        }
        public C1()
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
