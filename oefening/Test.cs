using NUnit.Framework;
using NUnitLite;

namespace Tests
{
	[TestFixture]
	public class TestClass
	{
		// deze functie is nodig om de testen achteraf via de webinterface uit te voeren
		public static int Run(string resultPath)
		{
			string[] args = { "--work=" + resultPath };
			return new AutoRun().Execute(args);
		}

		//[Test]
		public void TestOefening1()
		{
			//Assert.That(First.Program.NaamOefening(1, 2), Is.EqualTo(3), "Dit wordt door de webinterface getoond wanneer de test faalt.");
			//Assert.That(First.Program.NaamOefening(20, -3), Is.EqualTo(17), "Dit wordt door de webinterface getoond wanneer de test faalt.");
		}
	}
}
