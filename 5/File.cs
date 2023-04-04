using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class File : Disk
    {
        public File(string name, int size) : base(name, size) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("File: " + name + " Size: " + size + "MB");
        }
    }
}
