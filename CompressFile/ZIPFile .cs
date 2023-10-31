using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFile
{
    class ZIPFile : ICompression
    {
        public void CompressFolder( string CompressArchiveFolder)
        {
            Console.WriteLine("folder is compress using ZIP approach: '" + CompressArchiveFolder + "zip '   is created");
        }
    }
}
