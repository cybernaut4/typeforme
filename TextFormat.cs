using System;

namespace typeforme
{
		class TextFormat
    {
				// According to the console emulator "Terminator"
				// (which I use daily)

				public const string reset			= "\x1b[0m";

				public const string bold				= "\x1b[1m";
				public const string italic			= "\x1b[3m";
				public const string underline	= "\x1b[4m";
				public const string blink			= "\x1b[5m";
				public const string highlight	= "\x1b[7m";
				public const string strikethrough	= "\x1b[9m";
				public const string underlineDual	= "\x1b[21m";

				public const string noBold				= "\x1b[22m";
				public const string noItalic			= "\x1b[23m";
				public const string noUnderline	= "\x1b[24m"; // For underline_dual too
				public const string noBlink					= "\x1b[25m";
				public const string noHighlight			= "\x1b[27m";
				public const string noStrikethrough	= "\x1b[29m";

				public const string textNoColor				= "\x1b[39m";
				public const string backgroundNoColor	= "\x1b[49m";

				public const string textDarkGray   	= "\x1b[30m";
				public const string textDarkRed    	= "\x1b[31m";
				public const string textDarkGreen  	= "\x1b[32m";
				public const string textDarkYellow 	= "\x1b[33m";
				public const string textDarkBlue   	= "\x1b[34m";
				public const string textDarkPurple 	= "\x1b[35m";
				public const string textDarkCyan   	= "\x1b[36m";
				public const string textDarkWhite  	= "\x1b[37m";

				public const string backgroundDarkGray   	= "\x1b[40m";
				public const string backgroundDarkRed    	= "\x1b[41m";
				public const string backgroundDarkGreen  	= "\x1b[42m";
				public const string backgroundDarkYellow 	= "\x1b[43m";
				public const string backgroundDarkBlue   	= "\x1b[44m";
				public const string backgroundDarkPurple 	= "\x1b[45m";
				public const string backgroundDarkCyan   	= "\x1b[46m";
				public const string backgroundDarkWhite  	= "\x1b[47m";

				public const string textBrightGray   = "\x1b[90m";
				public const string textBrightRed    = "\x1b[91m";
				public const string textBrightGreen  = "\x1b[92m";
				public const string textBrightYellow = "\x1b[93m";
				public const string textBrightBlue   = "\x1b[94m";
				public const string textBrightPurple = "\x1b[95m";
				public const string textBrightCyan   = "\x1b[96m";
				public const string textBrightWhite  = "\x1b[97m";

				public const string backgroundBrightGray   = "\x1b[100m";
				public const string backgroundBrightRed    = "\x1b[101m";
				public const string backgroundBrightGreen  = "\x1b[102m";
				public const string backgroundBrightYellow = "\x1b[103m";
				public const string backgroundBrightBlue   = "\x1b[104m";
				public const string backgroundBrightPurple = "\x1b[105m";
				public const string backgroundBrightCyan   = "\x1b[106m";
				public const string backgroundBrightWhite  = "\x1b[107m";
		}
}
