using System;
namespace XtermSharp.CsiCommandExtensions {
	/// <summary>
	/// Simple extensions to map CSI commands to terminal commands. Useful in porting esc tests
	/// </summary>
	public static class CsiCommands {
		public static void csiDECSET (this Terminal terminal, int mode)
		{
			terminal.csiDECSET (mode, "?");
		}

		public static void csiDECSTR(this Terminal terminal)
		{

		}
	}
}