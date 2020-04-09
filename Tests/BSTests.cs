using Xunit;

namespace XtermSharp.Tests {
	/// <summary>
	/// BS (Backspace) tests
	/// </summary>
	public class BSTests : BaseTerminalTest {
		[Fact]
		public void BS_StopsAtOrigin ()
		{
			//esccmd.CUP(Point(1, 1))
			//escio.Write(esc.BS)
			//AssertEQ(GetCursorPosition(), Point(1, 1))
			Commander.CursorCharAbsolute (new int [] { 1, 1 });
			Commander.Backspace ();
			var point = Commands.GetCursorPosition (Commander, (IResponseReader)Terminal.Delegate);
			Assert.Equal (1, point.col);
			Assert.Equal (1, point.row);
		}
	}
}
