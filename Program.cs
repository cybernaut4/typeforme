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

									case "-color-fg":	Console.Write(TextFormat.textNoColor); continue;
									case "-color-bg":	Console.Write(TextFormat.backgroundNoColor); continue;

									case "+color-fg-dark-gray":		Console.Write(TextFormat.textDarkGray); continue;
									case "+color-fg-dark-red":		Console.Write(TextFormat.textDarkRed); continue;
									case "+color-fg-dark-green":	Console.Write(TextFormat.textDarkGreen); continue;
									case "+color-fg-dark-yellow": Console.Write(TextFormat.textDarkYellow); continue;
									case "+color-fg-dark-blue":		Console.Write(TextFormat.textDarkBlue); continue;
									case "+color-fg-dark-purple": Console.Write(TextFormat.textDarkPurple); continue;
									case "+color-fg-dark-cyan":		Console.Write(TextFormat.textDarkCyan); continue;
									case "+color-fg-dark-white":	Console.Write(TextFormat.textDarkWhite); continue;

									case "+color-bg-dark-gray":		Console.Write(TextFormat.backgroundDarkGray); continue;
									case "+color-bg-dark-red": 		Console.Write(TextFormat.backgroundDarkRed); continue;
									case "+color-bg-dark-green":	Console.Write(TextFormat.backgroundDarkGreen); continue;
									case "+color-bg-dark-yellow":	Console.Write(TextFormat.backgroundDarkYellow); continue;
									case "+color-bg-dark-blue":		Console.Write(TextFormat.backgroundDarkBlue); continue;
									case "+color-bg-dark-purple":	Console.Write(TextFormat.backgroundDarkPurple); continue;
									case "+color-bg-dark-cyan":		Console.Write(TextFormat.backgroundDarkCyan); continue;
									case "+color-bg-dark-white":	Console.Write(TextFormat.backgroundDarkWhite); continue;

									case "+color-fg-bright-gray":		Console.Write(TextFormat.textBrightGray); continue;
									case "+color-fg-bright-red": 		Console.Write(TextFormat.textBrightRed); continue;
									case "+color-fg-bright-green":	Console.Write(TextFormat.textBrightGreen); continue;
									case "+color-fg-bright-yellow":	Console.Write(TextFormat.textBrightYellow); continue;
									case "+color-fg-bright-blue":		Console.Write(TextFormat.textBrightBlue); continue;
									case "+color-fg-bright-purple":	Console.Write(TextFormat.textBrightPurple); continue;
									case "+color-fg-bright-cyan":		Console.Write(TextFormat.textBrightCyan); continue;
									case "+color-fg-bright-white":	Console.Write(TextFormat.textBrightWhite); continue;

									case "+color-bg-bright-gray":		Console.Write(TextFormat.backgroundBrightGray); continue;
									case "+color-bg-bright-red": 		Console.Write(TextFormat.backgroundBrightRed); continue;
									case "+color-bg-bright-green":	Console.Write(TextFormat.backgroundBrightGreen); continue;
									case "+color-bg-bright-yellow":	Console.Write(TextFormat.backgroundBrightYellow); continue;
									case "+color-bg-bright-blue":		Console.Write(TextFormat.backgroundBrightBlue); continue;
									case "+color-bg-bright-purple":	Console.Write(TextFormat.backgroundBrightPurple); continue;
									case "+color-bg-bright-cyan":		Console.Write(TextFormat.backgroundBrightCyan); continue;
									case "+color-bg-bright-white":	Console.Write(TextFormat.backgroundBrightWhite); continue;

									default: Console.Write(args[i]); continue;
								}
						}
						Console.WriteLine("");
				}
		}
}
