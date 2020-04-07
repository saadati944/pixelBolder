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

                    for (int i = 0; i < dwidth; i++)
                        for (int j = 0; j < dheight; j++)
                        {
                            dest.SetPixel(i, j, source.GetPixel((int)((float)i / (float)dwidth * (float)source.Width), (int)((float)j / (float)dheight * (float)source.Height)));
                        }
                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
