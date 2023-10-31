using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFile
{
     class  RARFile : ICompression
    {
        public void CompressFolder(string CompressedArchiveFolder)
        {
            Console.WriteLine("Folder is  compress using RAR approach: '" + CompressedArchiveFolder + ".rar file is created");
        }
    }
}
