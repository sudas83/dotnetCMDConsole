﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Master branch");
            Console.WriteLine("firstBranch branch");
//<<<<<<< HEAD
            Console.WriteLine("Master branch");
//=======
            Console.WriteLine("first branch2");
//>>>>>>> firstBranch
            Console.ReadLine();
        }
    }
}
