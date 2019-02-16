using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{

    class Program
    {
        public class SimpleFileCopyandDelete
        {
            static void Main()
            {
                string fileName = "file.txt";
                string sourcePath = @"D:\KBTU\PP2\Task 4\path";
                string targetPath = @"D:\KBTU\PP2\ez\path1";

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                System.IO.File.Copy(sourceFile, destFile, true);

                if (System.IO.File.Exists(@"D:\KBTU\PP2\Task 4\path\file.txt"))
                {

                    Directory.Delete(@"D:\KBTU\PP2\Task 4\path", true);
                }
            }
        }
    }
}

