using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
MIT License (MIT)

Copyright (c) 2021 Zumbie Corp.

All I ask is to not sell it, because wtf why. also dont be a nigger </3

Credits:
github.com/notZumbie
youtube.com/c/ZumbieExploits
 */

namespace HyperSpoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Title = "Hyper Spoofer | pasting since 2019";
            PastedShit.CringyAscii();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[ 1 ] Spoof");
            Console.WriteLine("[ 2 ] Check HWID");
            Console.WriteLine();
            Console.Write("Selection : ");
            var Skiddedspooferoptions = Console.ReadLine();
            if (Skiddedspooferoptions == "1")
            {
                PastedShit.SpoofHWID();
            }
            if (Skiddedspooferoptions == "2")
            {
                PastedShit.CheckHWID();
            }
            else
            {
                Console.WriteLine("Maybe actually select one thats valid.");
            }
        }


    }
}

/*
MIT License (MIT)

Copyright (c) 2021 Zumbie Corp.

All I ask is to not sell it, because wtf why. also dont be a nigger </3

Credits:
github.com/notZumbie
youtube.com/c/ZumbieExploits
 */