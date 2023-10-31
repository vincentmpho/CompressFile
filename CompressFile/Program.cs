using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context m = new Context(new ZIPFile());
            m.CreateArchive("dot mpho");


            m.setstrategy(new RARFile());
            m.CreateArchive("dot mpho");

            Console.ReadLine();
        }
    }
}
