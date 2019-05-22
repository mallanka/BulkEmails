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
            Directory.CreateDirectory("f://spam//");
            int count = 1;
            while (count <= 50)
            {
                var sw = new StreamWriter($"f://spam//{count}.txt");
                sw.Write("spam text");
                sw.Dispose();
                count++;
                Thread.Sleep(100);
            }
        }
    }
}
