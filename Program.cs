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
using teabag;

namespace teabag
{
    class Program
    {
        static void Main (string[] args)
		{
			Console.Title = "teabag | © 2013 pixeldesu";
			Console.Write ("Welcome to ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("teabag build-04262013");
			Console.ResetColor ();
			Console.WriteLine (" by pixeldesu");
			Console.WriteLine ("This little tool will create a little 'website' for you.");
			Console.WriteLine ("");

			Console.Write ("[");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("Step 1");
			Console.ResetColor ();
			Console.WriteLine ("] Contents");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine ("//Enter your title here");
			Console.ResetColor ();
			Console.Write ("Title: ");
			string title = Console.ReadLine ();
			Console.WriteLine ("");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine ("//Enter a little text for visitors here!");
			Console.ResetColor ();
			Console.Write ("Text: ");
			string text = Console.ReadLine ();
			Console.WriteLine ("");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine ("//Add some links to webpages (currently 3, while testing release)");
			Console.ResetColor ();
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("Text");
			Console.ResetColor ();
			Console.Write (" 1: ");
			Console.ResetColor ();
			string linktext1 = Console.ReadLine ();
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write ("URL");
			Console.ResetColor ();
			Console.Write (" 1: ");
			Console.ResetColor ();
			string linkurl1 = Console.ReadLine ();
			Console.WriteLine ("");
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("Text");
			Console.ResetColor ();
			Console.Write (" 2: ");
			Console.ResetColor ();
			string linktext2 = Console.ReadLine ();
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write ("URL");
			Console.ResetColor ();
			Console.Write (" 2: ");
			Console.ResetColor ();
			string linkurl2 = Console.ReadLine ();
			Console.WriteLine ("");
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("Text");
			Console.ResetColor ();
			Console.Write (" 3: ");
			Console.ResetColor ();
			string linktext3 = Console.ReadLine ();
			Console.Write ("Link-");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write ("URL");
			Console.ResetColor ();
			Console.Write (" 3: ");
			Console.ResetColor ();
			string linkurl3 = Console.ReadLine ();
			Console.Write ("[");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write ("Step 1");
			Console.ResetColor ();
			Console.WriteLine ("] Finished!");
			Console.WriteLine ("");

			Console.Write ("[");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("Step 2");
			Console.ResetColor ();
			Console.WriteLine ("] Writing File");

			using (StreamWriter sw = new StreamWriter("index.html")) {
				tealeaf.ConsoleStreamWrite(sw, "<!DOCTYPE html>");
				tealeaf.ConsoleStreamWrite(sw, "<head>");
                tealeaf.ConsoleStreamWrite(sw, string.Format("<title>{0}</title>", title));
                tealeaf.ConsoleStreamWrite(sw, teabag.Properties.Resources.style.ToString());
                tealeaf.ConsoleStreamWrite(sw, "</head>");
                tealeaf.ConsoleStreamWrite(sw, "<body text-align=\"center\">");
                tealeaf.ConsoleStreamWrite(sw, string.Format("<h2>{0}</h2>", title));
                tealeaf.ConsoleStreamWrite(sw, string.Format("<p>{0}</p>", text));
                tealeaf.ConsoleStreamWrite(sw, "<hr />");
                tealeaf.ConsoleStreamWrite(sw, string.Format("<a href=\"{0}\">{1}</a> ", linkurl1, linktext1));
                tealeaf.ConsoleStreamWrite(sw, string.Format("<a href=\"{0}\">{1}</a> ", linkurl2, linktext2));
                tealeaf.ConsoleStreamWrite(sw, string.Format("<a href=\"{0}\">{1}</a>", linkurl3, linktext3));
                tealeaf.ConsoleStreamWrite(sw, "</body>");
                tealeaf.ConsoleStreamWrite(sw, "</html>");
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
