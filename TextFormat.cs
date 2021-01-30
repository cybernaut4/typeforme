using System;

namespace typeforme
{
		class TextFormat : Format
    {
				public const string bold				= "\x1b[1m";
				public const string italic			= "\x1b[3m";
				public const string underline		= "\x1b[4m";
				public const string blink				= "\x1b[5m";
				public const string highlight		= "\x1b[7m";
				public const string strikethrough	= "\x1b[9m";
				public const string underlineDual	= "\x1b[21m";

				public const string noBold				= "\x1b[22m";
				public const string noItalic			= "\x1b[23m";
				public const string noUnderline		= "\x1b[24m"; // For underline_dual too
				public const string noBlink					= "\x1b[25m";
				public const string noHighlight			= "\x1b[27m";
				public const string noStrikethrough	= "\x1b[29m";

				public const string noColor				= "\x1b[39m";

				public const string darkGray   	= "\x1b[30m";
				public const string darkRed    	= "\x1b[31m";
				public const string darkGreen  	= "\x1b[32m";
				public const string darkYellow 	= "\x1b[33m";
				public const string darkBlue   	= "\x1b[34m";
				public const string darkPurple 	= "\x1b[35m";
				public const string darkCyan   	= "\x1b[36m";
				public const string darkWhite  	= "\x1b[37m";

				public const string brightGray   = "\x1b[90m";
				public const string brightRed    = "\x1b[91m";
				public const string brightGreen  = "\x1b[92m";
				public const string brightYellow = "\x1b[93m";
				public const string brightBlue   = "\x1b[94m";
				public const string brightPurple = "\x1b[95m";
				public const string brightCyan   = "\x1b[96m";
				public const string brightWhite  = "\x1b[97m";
		}
}
