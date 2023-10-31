using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFile
{
    interface ICompression
    {
        void CompressFolder(string CompressedArchiveFolder);
    }
}
