using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory("МояДиректорiя", 100);

            File file1 = new TextFile("Document.txt", 10);
            File file2 = new Mp3("Song.mp3", 5);
            File file3 = new Archive("Archive.zip", 20);

            directory.Add(file1);
            directory.Add(file2);
            directory.Add(file3);

            directory.DisplayInfo();
            Console.WriteLine("Кiлькiсть аудiо файлiв в директорiї: " + directory.CountAudioFiles());
            directory.LaunchFile("Song.mp3");
            Console.WriteLine("Розмiр директорiї: " + directory.Size + "MB");

            Console.ReadLine();
        }
    }
}
