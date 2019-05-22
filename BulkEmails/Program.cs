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
            int[] arr = new int[50];
            for (int i = 0; i < 50; i++)
            {
                arr[i] = i + 1;
            }

            foreach (var x in arr)
            {
                ThreadPool.QueueUserWorkItem(obj =>
                {
                    var sw = new StreamWriter($"f://spam//{x}.txt");
                    sw.Write("spam text");
                    sw.Dispose();
                    Thread.Sleep(1000);
                });
            }
            Console.ReadLine();
        }
    }
}
