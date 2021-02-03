using System;
using System.Threading;

namespace typeforme
{
	class Typer
	{
		private int typeSpeed = 60;
		private bool isSwitchSetup = false;

		public void ProcessArguments(string[] arguments) {

			for (
				int i = 0; 
					i < arguments.Length; 
					i = isSwitchSetup ? i+2 : i+1, isSwitchSetup = false
				) {
				switch (arguments[i]) {

					case "--help":	ShowHelp();
									break;

					case "--speed":	try {
										typeSpeed = Convert.ToInt32(arguments[i+1]);
									}
									catch(System.IndexOutOfRangeException) {
										break;
									} 
									catch(System.FormatException) {
										StartTyping(arguments[i]);
									}
									isSwitchSetup = true;
									continue;

					case "--delay":	try {
										Thread.Sleep(Convert.ToInt32(arguments[i+1])); 
									}
									catch(System.IndexOutOfRangeException) {
										break;
									}
									catch(System.FormatException) {
										StartTyping(arguments[i]);
									}
									isSwitchSetup = true;
									continue;

					case "--reset": 	Console.Write(Format.reset); continue;
					case "--break": 	Console.Write(Format.lineBreak); continue;
					case "--newline": 	Console.Write(Format.lineBreakAndReset); continue;

					case "+bold": 			Console.Write(TextFormat.bold); continue;
					case "+italic": 		Console.Write(TextFormat.italic); continue;
					case "+underline": 		Console.Write(TextFormat.underline); continue;
					case "+blink": 			Console.Write(TextFormat.blink); continue;
					case "+highlight":		Console.Write(TextFormat.highlight); continue;
					case "+strikethrough": 	Console.Write(TextFormat.strikethrough); continue;
					case "+underline-dual":	Console.Write(TextFormat.underlineDual); continue;

					case "-bold": 			Console.Write(TextFormat.noBold); continue;
					case "-italic": 		Console.Write(TextFormat.noItalic); continue;
					case "-underline": 		Console.Write(TextFormat.noUnderline); continue;
					case "-blink": 			Console.Write(TextFormat.noBlink); continue;
					case "-highlight":		Console.Write(TextFormat.noHighlight); continue;
					case "-strikethrough": 	Console.Write(TextFormat.noStrikethrough); continue;

					case "-cursor":		Console.CursorVisible = false; continue;
					case "+cursor":		Console.CursorVisible = true; continue;

					case "--color-fg-reset":		Console.Write(TextFormat.noColor); continue;
					case "--color-bg-reset":		Console.Write(BackgroundFormat.noColor); continue;

					case "--color-fg-dark-gray":		Console.Write(TextFormat.darkGray); continue;
					case "--color-fg-dark-red":			Console.Write(TextFormat.darkRed); continue;
					case "--color-fg-dark-green":		Console.Write(TextFormat.darkGreen); continue;
					case "--color-fg-dark-yellow": 		Console.Write(TextFormat.darkYellow); continue;
					case "--color-fg-dark-blue":		Console.Write(TextFormat.darkBlue); continue;
					case "--color-fg-dark-purple": 		Console.Write(TextFormat.darkPurple); continue;
					case "--color-fg-dark-cyan":		Console.Write(TextFormat.darkCyan); continue;
					case "--color-fg-dark-white":		Console.Write(TextFormat.darkWhite); continue;

					case "--color-fg-bright-gray":		Console.Write(TextFormat.brightGray); continue;
					case "--color-fg-bright-red": 		Console.Write(TextFormat.brightRed); continue;
					case "--color-fg-bright-green":		Console.Write(TextFormat.brightGreen); continue;
					case "--color-fg-bright-yellow":	Console.Write(TextFormat.brightYellow); continue;
					case "--color-fg-bright-blue":		Console.Write(TextFormat.brightBlue); continue;
					case "--color-fg-bright-purple":	Console.Write(TextFormat.brightPurple); continue;
					case "--color-fg-bright-cyan":		Console.Write(TextFormat.brightCyan); continue;
					case "--color-fg-bright-white":		Console.Write(TextFormat.brightWhite); continue;

					case "--color-bg-dark-gray":		Console.Write(BackgroundFormat.darkGray); continue;
					case "--color-bg-dark-red": 		Console.Write(BackgroundFormat.darkRed); continue;
					case "--color-bg-dark-green":		Console.Write(BackgroundFormat.darkGreen); continue;
					case "--color-bg-dark-yellow":		Console.Write(BackgroundFormat.darkYellow); continue;
					case "--color-bg-dark-blue":		Console.Write(BackgroundFormat.darkBlue); continue;
					case "--color-bg-dark-purple":		Console.Write(BackgroundFormat.darkPurple); continue;
					case "--color-bg-dark-cyan":		Console.Write(BackgroundFormat.darkCyan); continue;
					case "--color-bg-dark-white":		Console.Write(BackgroundFormat.darkWhite); continue;

					case "--color-bg-bright-gray":		Console.Write(BackgroundFormat.brightGray); continue;
					case "--color-bg-bright-red": 		Console.Write(BackgroundFormat.brightRed); continue;
					case "--color-bg-bright-green":		Console.Write(BackgroundFormat.brightGreen); continue;
					case "--color-bg-bright-yellow":	Console.Write(BackgroundFormat.brightYellow); continue;
					case "--color-bg-bright-blue":		Console.Write(BackgroundFormat.brightBlue); continue;
					case "--color-bg-bright-purple":	Console.Write(BackgroundFormat.brightPurple); continue;
					case "--color-bg-bright-cyan":		Console.Write(BackgroundFormat.brightCyan); continue;
					case "--color-bg-bright-white":		Console.Write(BackgroundFormat.brightWhite); continue;

					default: StartTyping(arguments[i]);
							 continue;
				}
			}
			Console.WriteLine(Format.reset);
			
		}

		public void StartTyping(string text) {
			for (int i=0; i < text.Length; i++){
				Console.Write(text[i]);
				Thread.Sleep(typeSpeed);
			}
		}

		public void ShowUsage() {
			Console.WriteLine("");
			Console.WriteLine("Usage:");
			Console.WriteLine("\ttypeforme ['text']...");
			Console.WriteLine("\ttypeforme [options] ['text']...");
			Console.WriteLine("");
		}

		public void ShowHelp() {
			Console.WriteLine("");
			Console.WriteLine("typeforme - Show a formatteable message, character by character.");	

			ShowUsage();
			
			Console.WriteLine("Options:");
			Console.WriteLine("\t--help\t\t\tDisplay this usage information.");
			Console.WriteLine("\t--speed <integer>\tChanges the typing speed by milliseconds.");
			Console.WriteLine($"\t\t\t\t(default value: {typeSpeed})");
			Console.WriteLine("\t--delay <integer>\tPuts this program to sleep for milliseconds");
			Console.WriteLine("\t\t\t\tbefore resuming.");
			Console.WriteLine("Formatting options:");
			Console.WriteLine("\t--reset\t\tDisables all formatting options onwards.");
			Console.WriteLine("\t--break\t\tBreaks line.");
			Console.WriteLine("\t--newline\tSame as --break, but also applies --reset beforehand.");
			Console.WriteLine("");
			Console.WriteLine("\tEnabling\t\tDisabling");
			Console.WriteLine("\t--------\t\t---------");
			Console.WriteLine("\t+bold · · · · · · · ·  \t-bold");
			Console.WriteLine("\t+italic · · · · · · ·  \t-italic");
			Console.WriteLine("\t+underline  · · · · ·  \t-underline");
			Console.WriteLine("\t+blink  · · · · · · ·  \t-blink");
			Console.WriteLine("\t+highlight  · · · · ·  \t-highlight");
			Console.WriteLine("\t+strikethrough  · · ·  \t-strikethrough");
			Console.WriteLine("\t+underline-dual · · ·  \t-underline");
			Console.WriteLine("");
			Console.WriteLine("Miscellaneous:");
			Console.WriteLine("\t-cursor · · · · · · ·  \t-cursor");
			Console.WriteLine("");
			Console.WriteLine("Coloring Options:");
	  		Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-gray\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-red\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-green\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-yellow\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-blue\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-purple\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-cyan\t");
			Console.WriteLine("\t--color-[fg|bg]-[dark|bright]-white\t");
			Console.WriteLine("");
			Console.WriteLine("\tfg and bg are foreground (text) and inline background, respectively.");
			Console.WriteLine("");
			Console.WriteLine("\t--color-fg-reset\tRestores foreground color to default.");
			Console.WriteLine("\t--color-bg-reset\tRestores background color to default.");
			Console.WriteLine("");

			ShowExamples();
		}

		public void ShowExamples() {
			Console.WriteLine("Examples:");
			Console.WriteLine("\ttypeforme 'I am the alpha and the omega'");
			Console.WriteLine("\ttypeforme +bold --color-fg-dark-green 'I am the alpha and the omega'");
			Console.WriteLine("\ttypeforme +bold --color-fg-dark-green 'I am the ' \\");
			Console.WriteLine("\t\t  --color-fg-bright-green 'alpha ' \\");
			Console.WriteLine("\t\t  --color-fg-dark-green 'and the ' \\");
			Console.WriteLine("\t\t  --color-fg-bright-green 'omega'");
			Console.WriteLine("");
		}
 
	}
}
