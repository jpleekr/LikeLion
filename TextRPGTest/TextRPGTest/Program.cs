﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManger gm = new GameManger();

            gm.Init();
            gm.Procease();
        }
    }
}
