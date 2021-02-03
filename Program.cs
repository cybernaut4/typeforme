using System;
using System.Threading;

namespace typeforme
{
	class Program
	{
		static void Main(string[] args)
		{
			Typer myTyper = new Typer();
			
			if (args.Length == 0){
				myTyper.ShowUsage();
				myTyper.ShowExamples();
				Console.WriteLine("For more info, try the --help option.");
			}
			else
				myTyper.ProcessArguments(args);
			Console.CursorVisible = true;
		}
	}
}
