﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study40
{
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자 " + message);
        }
    }

    class Child : Parent
    {
        public Child() : base("하하하하성공")
        {
            Console.WriteLine("자식 생성자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();

        }
    }
}
