using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    abstract class Disk
    {
        protected string name;
        protected int size;

        public Disk(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public abstract void DisplayInfo();
    }
}
