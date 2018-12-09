using System;
using System.IO;

namespace files0
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            //above takes more data

            //File.ReadAllByte(); reads binary

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            //above methods take less data
        }
    }
}
