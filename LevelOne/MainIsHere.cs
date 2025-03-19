using System;

namespace LevelOne
{
    public class Program
    {
        /// <summary>
        /// This is the Main() method
        /// </summary>
        /// <param name="args">Console arguments go here</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }
        public static string NewFeature(string feature_string)
        {
            feature_string = "Cool feature";
            return feature_string;
        }
    }
}
