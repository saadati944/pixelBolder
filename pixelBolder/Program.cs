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
                    Console.WriteLine("source file size : " + source.Width.ToString() + " X " + source.Height.ToString());
                    Console.WriteLine();

                    Console.Write("enter destination file path : ");
                    string dfile = Console.ReadLine();
                    Console.Write("enter destination file width : ");
                    int dwidth = int.Parse(Console.ReadLine());
                    Console.Write("enter destination file height : ");
                    int dheight = int.Parse(Console.ReadLine());
                    Bitmap dest = new Bitmap(dwidth, dheight);
                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
