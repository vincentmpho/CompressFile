using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFile
{
     class Context
    {
        private ICompression Compression;
            public Context(ICompression Compression)
        {
           this. Compression = Compression;
        }
        public void setstrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void CreateArchive (string CompressedArchiveFolder)
        {
            Compression.CompressFolder("CompressedArchiveFolder");
        }




    }
}
