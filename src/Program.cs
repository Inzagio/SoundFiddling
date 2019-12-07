using System;
using System.IO;
using System.Reflection;
using System.Threading;
using NAudio.Wave;

namespace FfmpegTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new SoundControls();
            test.PlaySound();
        }

        
    }
}
