using System;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SoGoodClass.SoGoodMethod());
            if(args.Length == 0)
            {
                CanvasImage default_image = new CanvasImage("tux.jpg");
                default_image.MaxWidth(24);
                AnsiConsole.Write(default_image);
            }
            else
            {
                CanvasImage input_image = new CanvasImage(args[0]);
                input_image.MaxWidth(int.Parse(args[1]));
                AnsiConsole.Write(input_image);
            }
        }
    }
}
