using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._2
{
    internal class FileWorker
    {
        public static void ReadPartFromFile(StreamReader streamReader, int[] arr)
        {
            for (int i = 0; i < 50; i++)
            {
                arr[i] = int.Parse(streamReader.ReadLine());
            }
        }
        public static void WritePartInFile(string path, int[] arr)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            for (int i = 0; i < arr.Length; i++)
            {
                streamWriter.WriteLine(arr[i]);
            }

            streamWriter.Dispose();
        }
        public static void DeleteFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
        }
    }
}
