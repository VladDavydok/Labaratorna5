using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Mp3 : File
    {
        public Mp3(string name, int size) : base(name, size) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Mp3 file: " + name + " Size: " + size + "MB");
        }
    }
}
