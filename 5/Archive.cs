using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Archive : File
    {
        public Archive(string name, int size) : base(name, size) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Archive: " + name + " Size: " + size + "MB");
        }
    }
}
