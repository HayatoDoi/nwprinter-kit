using System.Diagnostics;

namespace nwprinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("explorer.exe", @"\\iogate2.kanazawa-it.ac.jp");
        }
    }
}
