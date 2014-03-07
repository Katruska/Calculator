using System;
using NUnit.Framework;
namespace Calc
{
	[TestFixture] 
	public class FirstTestClass 
	{
		[Test] 
		public void TestTwoPTwo()
		{
			Calc.Form1.TOperand TO = new Calc.Form1.TOperand(); 
			Assert.IsTrue(TO.SetTGpp(2,2,"+")=="4");
		}

		[Test] 
		public void TestPIvAlue()
		{
            Calc.Form1.TPI Tpi = new Calc.Form1.TPI(); 
			Assert.AreEqual(Tpi.GetPIVal(),3.14);
		}	

		[Test] 
		public void TestSub()
		{
            Calc.Form1.TSub TSuB = new Calc.Form1.TSub(); 
			TSuB.SetNumeric(3,3);
			Assert.IsFalse(TSuB.GetNumeric()==1);
		}	

	}
}
