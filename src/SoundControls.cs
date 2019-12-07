using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using NAudio.Wave;

namespace FfmpegTest
{
    class SoundControls
    {
        public void PlaySound()
        {
            var path = Directory.GetCurrentDirectory();
            var file = Path.Combine(path, "AccessDenied.mp3");
            using (var audioFile = new AudioFileReader(file))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
