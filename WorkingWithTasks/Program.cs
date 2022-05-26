﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace WorkingWithTasks
{
    class Program
    {
        static void MethodA()
        {
            WriteLine("Starting method A...");
            Thread.Sleep(3000); // simulate 3 seconds of work
            WriteLine("Finished method A.");
        }

        static void MethodB()
        {
            WriteLine("Starting method B...");
            Thread.Sleep(2000); // 2 seconds of work
            WriteLine("Finished method B.");
        }

        static void MethodC()
        {
            WriteLine("Starting method C...");
            Thread.Sleep(1000); // 1 second of work
            WriteLine("Finished method C.");
        }

        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            WriteLine("Running methods synchronously on one thread.");
            MethodA();
            MethodB();
            MethodC();
            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
        }
    }
}