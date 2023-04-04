using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class TextFile : File
    {
        public TextFile(string name, int size) : base(name, size) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Text file: " + name + " Size: " + size + "MB");
        }
    }
}
