/*
    teabag
    Copyright (C) 2013 pixeldesu

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teabag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "teabag | © 2013 pixeldesu";
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("teabag v0.3-alpha");
            Console.ResetColor();
            Console.WriteLine(" by pixeldesu");
            Console.WriteLine("This little tool will create a little 'website' for you.");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Step 1");
            Console.ResetColor();
            Console.WriteLine("] Contents");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("//Enter your title here");
            Console.ResetColor();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("//Enter a little text for visitors here!");
            Console.ResetColor();
            Console.Write("Text: ");
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("//Add some links to webpages (currently 3, while testing release)");
            Console.ResetColor();
            Console.Write("Link-Text 1: ");
            string linktext1 = Console.ReadLine();
            Console.Write("Link-URL 1: ");
            string linkurl1 = Console.ReadLine();
            Console.Write("Link-Text 2: ");
            string linktext2 = Console.ReadLine();
            Console.Write("Link-URL 2: ");
            string linkurl2 = Console.ReadLine();
            Console.Write("Link-Text 3: ");
            string linktext3 = Console.ReadLine();
            Console.Write("Link-URL 3: ");
            string linkurl3 = Console.ReadLine();
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Step 1");
            Console.ResetColor();
            Console.WriteLine("] Finished!");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Step 2");
            Console.ResetColor();
            Console.WriteLine("] Writing File");

            using (StreamWriter sw = new StreamWriter("index.html")) 
            {
                sw.WriteLine("<!DOCTYPE html>");
                Console.WriteLine("<!DOCTYPE html>");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<head>");
                Console.WriteLine("<head>");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<title>{0}</title>", title);
                Console.WriteLine("<title>{0}</title>", title);
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<style type=\"text/css\">\nbody {\nfont-family: \"Helvetica Neue\", Arial, sans-serif;\n text-align: center;\n margin-left: 15%; margin-right: 15%; }\n </style>");
                Console.WriteLine("<style type=\"text/css\">\nbody {\nfont-family: \"Helvetica Neue\", Arial, sans-serif;\n text-align: center;\n margin-left: 15%; margin-right: 15%; }\n </style>");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("</head>");
                Console.WriteLine("</head>");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<body text-align=\"center\">");
                Console.WriteLine("<body text-align=\"center\">");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<h2>{0}</h2>", title);
                Console.WriteLine("<h2>{0}</h2>", title);
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<p>{0}</p>", text);
                Console.WriteLine("<p>{0}</p>", text);
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<br />");
                Console.WriteLine("<br />");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("<hr />");
                Console.WriteLine("<hr />");
                System.Threading.Thread.Sleep(50);
                sw.Write("<a href=\"{0}\">{1}</a> ", linkurl1, linktext1);
                Console.Write("<a href=\"{0}\">{1}</a> ", linkurl1, linktext1);
                System.Threading.Thread.Sleep(50);
                sw.Write("<a href=\"{0}\">{1}</a> ", linkurl2, linktext2);
                Console.Write("<a href=\"{0}\">{1}</a> ", linkurl2, linktext2);
                System.Threading.Thread.Sleep(50);
                sw.Write("<a href=\"{0}\">{1}</a> ", linkurl3, linktext3);
                Console.Write("<a href=\"{0}\">{1}</a> ", linkurl3, linktext3);
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("</body>");
                Console.WriteLine("</body>");
                System.Threading.Thread.Sleep(50);
                sw.WriteLine("</html>");
                Console.WriteLine("</html>");
            }
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Step 2");
            Console.ResetColor();
            Console.WriteLine("] Finished!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Note: This website is only a small placeholder \n      and not purposed for any big projects\n      This is only a little test, to show what I want to create!");
            Console.ReadKey();

        }
    }
}
