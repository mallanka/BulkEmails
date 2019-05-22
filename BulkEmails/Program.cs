using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BulkEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Object();
            Directory.CreateDirectory("f://spam//");
            int count = 1;
            while (count <= 50)
            {
                StreamWriter sw = File.AppendText("f://spam//log.txt");
                lock (obj)
                {
                    sw.WriteLine($"{count} spam text");
                }
                sw.Dispose();
                count++;
            }
        }
    }
}
