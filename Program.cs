using System;

namespace typeforme
{
		class Program
    {
				// According to the console emulator "Terminator"
				// (which I use daily)
				
				const string reset			= "\x1b[0m";

				const string bold				= "\x1b[1m";
				const string italic			= "\x1b[3m";
				const string underline	= "\x1b[4m";
				const string blink			= "\x1b[5m";
				const string highlight	= "\x1b[7m";
				const string strikethrough	= "\x1b[9m";
				const string underlineDual	= "\x1b[21m";

				const string noBold				= "\x1b[22m";
				const string noItalic			= "\x1b[23m";
				const string noUnderline	= "\x1b[24m"; // For underline_dual too
				const string noBlink					= "\x1b[25m";
				const string noHighlight			= "\x1b[27m";
				const string noStrikethrough	= "\x1b[29m";

				const string textNoColor				= "\x1b[39m";
				const string backgroundNoColor	= "\x1b[49m";

				const string textDarkGray   	= "\x1b[30m";
				const string textDarkRed    	= "\x1b[31m";
				const string textDarkGreen  	= "\x1b[32m";
				const string textDarkYellow 	= "\x1b[33m";
				const string textDarkBlue   	= "\x1b[34m";
				const string textDarkPurple 	= "\x1b[35m";
				const string textDarkCyan   	= "\x1b[36m";
				const string textDarkWhite  	= "\x1b[37m";

				const string backgroundDarkGray   	= "\x1b[40m";
				const string backgroundDarkRed    	= "\x1b[41m";
				const string backgroundDarkGreen  	= "\x1b[42m";
				const string backgroundDarkYellow 	= "\x1b[43m";
				const string backgroundDarkBlue   	= "\x1b[44m";
				const string backgroundDarkPurple 	= "\x1b[45m";
				const string backgroundDarkCyan   	= "\x1b[46m";
				const string backgroundDarkWhite  	= "\x1b[47m";

				const string textBrightGray   = "\x1b[90m";
				const string textBrightRed    = "\x1b[91m";
				const string textBrightGreen  = "\x1b[92m";
				const string textBrightYellow = "\x1b[93m";
				const string textBrightBlue   = "\x1b[94m";
				const string textBrightPurple = "\x1b[95m";
				const string textBrightCyan   = "\x1b[96m";
				const string textBrightWhite  = "\x1b[97m";

				const string backgroundBrightGray   = "\x1b[100m";
				const string backgroundBrightRed    = "\x1b[101m";
				const string backgroundBrightGreen  = "\x1b[102m";
				const string backgroundBrightYellow = "\x1b[103m";
				const string backgroundBrightBlue   = "\x1b[104m";
				const string backgroundBrightPurple = "\x1b[105m";
				const string backgroundBrightCyan   = "\x1b[106m";
				const string backgroundBrightWhite  = "\x1b[107m";

						static void Main(string[] args)
						{
							for (int i=0; i < args.Length; i++) 
							{
								switch(args[i]) {
									case "--reset": 		Console.Write(reset); continue;
									case "+bold": 			Console.Write(bold); continue;
									case "+italic": 		Console.Write(italic); continue;
									case "+underline": 	Console.Write(underline); continue;
									case "+highlight":		Console.Write(highlight); continue;
									case "+strikethrough": 	Console.Write(strikethrough); continue;
									case "+underline-dual":	Console.Write(underlineDual); continue;

									case "-bold": 			Console.Write(noBold); continue;
									case "-italic": 		Console.Write(noItalic); continue;
									case "-underline": 	Console.Write(noUnderline); continue;
									case "-highlight":			Console.Write(noHighlight); continue;
									case "-strikethrough": 	Console.Write(noStrikethrough); continue;

									case "-color-fg":	Console.Write(textNoColor); continue;
									case "-color-bg":	Console.Write(backgroundNoColor); continue;

									case "+color-fg-dark-gray":		Console.Write(textDarkGray); continue;
									case "+color-fg-dark-red":		Console.Write(textDarkRed); continue;
									case "+color-fg-dark-green":	Console.Write(textDarkGreen); continue;
									case "+color-fg-dark-yellow": Console.Write(textDarkYellow); continue;
									case "+color-fg-dark-blue":		Console.Write(textDarkBlue); continue;
									case "+color-fg-dark-purple": Console.Write(textDarkPurple); continue;
									case "+color-fg-dark-cyan":		Console.Write(textDarkCyan); continue;
									case "+color-fg-dark-white":	Console.Write(textDarkWhite); continue;

									case "+color-bg-dark-gray":		Console.Write(backgroundDarkGray); continue;
									case "+color-bg-dark-red": 		Console.Write(backgroundDarkRed); continue;
									case "+color-bg-dark-green":	Console.Write(backgroundDarkGreen); continue;
									case "+color-bg-dark-yellow":	Console.Write(backgroundDarkYellow); continue;
									case "+color-bg-dark-blue":		Console.Write(backgroundDarkBlue); continue;
									case "+color-bg-dark-purple":	Console.Write(backgroundDarkPurple); continue;
									case "+color-bg-dark-cyan":		Console.Write(backgroundDarkCyan); continue;
									case "+color-bg-dark-white":	Console.Write(backgroundDarkWhite); continue;

									case "+color-fg-bright-gray":		Console.Write(textBrightGray); continue;
									case "+color-fg-bright-red": 		Console.Write(textBrightRed); continue;
									case "+color-fg-bright-green":	Console.Write(textBrightGreen); continue;
									case "+color-fg-bright-yellow":	Console.Write(textBrightYellow); continue;
									case "+color-fg-bright-blue":		Console.Write(textBrightBlue); continue;
									case "+color-fg-bright-purple":	Console.Write(textBrightPurple); continue;
									case "+color-fg-bright-cyan":		Console.Write(textBrightCyan); continue;
									case "+color-fg-bright-white":	Console.Write(textBrightWhite); continue;

									case "+color-bg-bright-gray":		Console.Write(backgroundBrightGray); continue;
									case "+color-bg-bright-red": 		Console.Write(backgroundBrightRed); continue;
									case "+color-bg-bright-green":	Console.Write(backgroundBrightGreen); continue;
									case "+color-bg-bright-yellow":	Console.Write(backgroundBrightYellow); continue;
									case "+color-bg-bright-blue":		Console.Write(backgroundBrightBlue); continue;
									case "+color-bg-bright-purple":	Console.Write(backgroundBrightPurple); continue;
									case "+color-bg-bright-cyan":		Console.Write(backgroundBrightCyan); continue;
									case "+color-bg-bright-white":	Console.Write(backgroundBrightWhite); continue;

									default: Console.Write(args[i]); continue;
								}
						}
						Console.WriteLine("");
				}
		}
}
