using System;
using System.IO;

namespace ConsoleApplication1
{
    /// <summary>
    /// The Console Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main entry point.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            // Ensure adequate buffer but cannot be less than the current size.
            Console.BufferHeight = Console.BufferHeight < 103 ? 103 : Console.BufferHeight;

            for (int c = 1; c <= 100; c++)
            {
                bool div3 = false;
                bool div5 = false;
                
                if (c % 3 == 0)
                {
                    div3 = true;
                }

                if (c % 5 == 0)
                {
                    div5 = true;
                }

                if (div3 && div5)
                {
                    Console.WriteLine("ModernMedical");
                    
                } 
                else if (div3)
                {
                    Console.WriteLine("Modern");
                }
                else if (div5)
                {
                    Console.WriteLine("Medical");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
