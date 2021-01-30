using System;

namespace typeforme
{
		class Program
    {
				static void Main(string[] args)
				{
					for (int i=0; i < args.Length; i++) 
					{
							switch(args[i]) {
									case "--reset": 		Console.Write(TextFormat.reset); continue;
									case "+bold": 			Console.Write(TextFormat.bold); continue;
									case "+italic": 		Console.Write(TextFormat.italic); continue;
									case "+underline": 	Console.Write(TextFormat.underline); continue;
									case "+highlight":		Console.Write(TextFormat.highlight); continue;
									case "+strikethrough": 	Console.Write(TextFormat.strikethrough); continue;
									case "+underline-dual":	Console.Write(TextFormat.underlineDual); continue;

									case "-bold": 			Console.Write(TextFormat.noBold); continue;
									case "-italic": 		Console.Write(TextFormat.noItalic); continue;
									case "-underline": 	Console.Write(TextFormat.noUnderline); continue;
									case "-highlight":			Console.Write(TextFormat.noHighlight); continue;
									case "-strikethrough": 	Console.Write(TextFormat.noStrikethrough); continue;

									case "-color-fg":	Console.Write(TextFormat.noColor); continue;
									case "-color-bg":	Console.Write(BackgroundFormat.noColor); continue;

									case "+color-fg-dark-gray":		Console.Write(TextFormat.darkGray); continue;
									case "+color-fg-dark-red":		Console.Write(TextFormat.darkRed); continue;
									case "+color-fg-dark-green":	Console.Write(TextFormat.darkGreen); continue;
									case "+color-fg-dark-yellow": Console.Write(TextFormat.darkYellow); continue;
									case "+color-fg-dark-blue":		Console.Write(TextFormat.darkBlue); continue;
									case "+color-fg-dark-purple": Console.Write(TextFormat.darkPurple); continue;
									case "+color-fg-dark-cyan":		Console.Write(TextFormat.darkCyan); continue;
									case "+color-fg-dark-white":	Console.Write(TextFormat.darkWhite); continue;

									case "+color-fg-bright-gray":		Console.Write(TextFormat.brightGray); continue;
									case "+color-fg-bright-red": 		Console.Write(TextFormat.brightRed); continue;
									case "+color-fg-bright-green":	Console.Write(TextFormat.brightGreen); continue;
									case "+color-fg-bright-yellow":	Console.Write(TextFormat.brightYellow); continue;
									case "+color-fg-bright-blue":		Console.Write(TextFormat.brightBlue); continue;
									case "+color-fg-bright-purple":	Console.Write(TextFormat.brightPurple); continue;
									case "+color-fg-bright-cyan":		Console.Write(TextFormat.brightCyan); continue;
									case "+color-fg-bright-white":	Console.Write(TextFormat.brightWhite); continue;

									case "+color-bg-dark-gray":		Console.Write(BackgroundFormat.darkGray); continue;
									case "+color-bg-dark-red": 		Console.Write(BackgroundFormat.darkRed); continue;
									case "+color-bg-dark-green":	Console.Write(BackgroundFormat.darkGreen); continue;
									case "+color-bg-dark-yellow":	Console.Write(BackgroundFormat.darkYellow); continue;
									case "+color-bg-dark-blue":		Console.Write(BackgroundFormat.darkBlue); continue;
									case "+color-bg-dark-purple":	Console.Write(BackgroundFormat.darkPurple); continue;
									case "+color-bg-dark-cyan":		Console.Write(BackgroundFormat.darkCyan); continue;
									case "+color-bg-dark-white":	Console.Write(BackgroundFormat.darkWhite); continue;

									case "+color-bg-bright-gray":		Console.Write(BackgroundFormat.brightGray); continue;
									case "+color-bg-bright-red": 		Console.Write(BackgroundFormat.brightRed); continue;
									case "+color-bg-bright-green":	Console.Write(BackgroundFormat.brightGreen); continue;
									case "+color-bg-bright-yellow":	Console.Write(BackgroundFormat.brightYellow); continue;
									case "+color-bg-bright-blue":		Console.Write(BackgroundFormat.brightBlue); continue;
									case "+color-bg-bright-purple":	Console.Write(BackgroundFormat.brightPurple); continue;
									case "+color-bg-bright-cyan":		Console.Write(BackgroundFormat.brightCyan); continue;
									case "+color-bg-bright-white":	Console.Write(BackgroundFormat.brightWhite); continue;

									default: Console.Write(args[i]); continue;
								}
						}
						Console.WriteLine("");
				}
		}
}
