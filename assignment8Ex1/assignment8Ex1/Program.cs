﻿using System;
using System.Runtime.CompilerServices;
using static assignment8Ex1.Program.HereComesTheSun;

namespace assignment8Ex1
{
    class Program
    {
        //declaring the delegate 

        public class HereComesTheSun
        {
            public delegate void HereComesTheSunDelegate();

            public static void chorus()
            {
                Console.Write("Here comes the sun, doo-doo-doo-doo\r\n");
                Console.WriteLine("Here comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
            }
            public static void chorus2()
            {
                Console.WriteLine("Here comes the sun\r\nHere comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.WriteLine("Sun, sun, sun, here it comes");
                Console.WriteLine();
            }
            public static void verse1()
            {
                Console.Write("Little darlin', it's been a long, cold, lonely winter\r\n");
                Console.WriteLine("Little darlin', it feels like years since it's been here");
                Console.WriteLine();
            }
            public static void verse2()
            {
                Console.Write("Little darlin', the smile's returning to their faces\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been here");
                Console.WriteLine();
            }
            public static void verse3()
            {
                Console.Write("Little darlin', I feel that ice is slowly melting\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been clear");
                Console.WriteLine();
            }
            public static void end()
            {
                Console.WriteLine("It's alright");
            }
        }

        static void Main(string[] args)
        {
            //HereComesTheSun.chorus();
            //HereComesTheSun.verse1();
            //HereComesTheSun.chorus();
            //HereComesTheSun.verse2();
            //HereComesTheSun.chorus2();
            //HereComesTheSun.verse3();
            //HereComesTheSun.chorus();
            //HereComesTheSun.chorus();
            //HereComesTheSun.end();

            HereComesTheSunDelegate songDelegate = new HereComesTheSunDelegate(HereComesTheSun.chorus);

            songDelegate += HereComesTheSun.chorus2;
            songDelegate += HereComesTheSun.verse1;
            songDelegate += HereComesTheSun.verse2;
            songDelegate += HereComesTheSun.verse3;
            songDelegate += HereComesTheSun.end;

            songDelegate();
        }
    }
}