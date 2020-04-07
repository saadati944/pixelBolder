using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace pixelBolder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter source file path : ");
                    string sfile = Console.ReadLine();
                    Bitmap source = (Bitmap)Image.FromFile(sfile);


                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
