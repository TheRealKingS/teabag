using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teabag
{
    public class tealeaf
    {
        /// <summary>
        /// Writes out a string to both a stream writer and a console.
        /// </summary>
        /// <returns>
        /// It's a fucking void.
        /// </returns>
        /// <param name='sw'>
        /// A StreamWriter object.
        /// </param>
        /// <param name='s'>
        /// The string to be written
        /// </param>
        public static void ConsoleStreamWrite(StreamWriter sw, string s)
        {
            sw.Write(s);
            Console.WriteLine(s);
        }

        /// <summary>
        /// Writes out a string to both a stream writer and a console and terminates it with a newline.
        /// </summary>
        /// <returns>
        /// It's a fucking void.
        /// </returns>
        /// <param name='sw'>
        /// A StreamWriter object.
        /// </param>
        /// <param name='s'>
        /// The string to be written
        /// </param>
        public static void ConsoleStreamWriteLine(StreamWriter sw, string s)
        {
            ConsoleStreamWrite(sw, s + "\n");
        }
    }
}
