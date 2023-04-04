using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Directory : Disk
    {
        private List<Disk> items;

        public Directory(string name, int size) : base(name, size)
        {
            items = new List<Disk>();
        }

        public void Add(Disk item)
        {
            items.Add(item);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Директорiя: " + name + " Розмiр: " + size + "MB");
            Console.WriteLine("Предмети в директорiї:");
            foreach (Disk item in items)
            {
                Console.WriteLine("- " + item.Name);
            }
        }

        public int CountAudioFiles()
        {
            int count = 0;
            foreach (Disk item in items)
            {
                if (item is Mp3)
                {
                    count++;
                }
            }
            return count;
        }

        public void LaunchFile(string name)
        {
            foreach (Disk item in items)
            {
                if (item.Name == name && item is File)
                {
                    Console.WriteLine("Запущений файл: " + name);
                    return;
                }
            }
            Console.WriteLine("Файл не знайдено");
        }
    }
}
