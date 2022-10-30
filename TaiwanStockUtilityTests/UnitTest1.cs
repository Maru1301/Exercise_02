using Exec2_UnitTest;

namespace TaiwanStockUtilityTests
{
	public class Tests
	{
		[TestCase ("2022/10/31 9:10:00", true)]
		[TestCase ("2022/10/31 13:29:00", true)]
		public void IsTradingTime_In_Trading_Time(DateTime dt, bool expected)
		{
			TaiwanStockUtility test = new TaiwanStockUtility();

			bool actual = test.IsTradingTime(dt);

			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase("2022/10/29 9:10:00", false)]
		[TestCase("2022/10/30 13:29:00", false)]
		public void IsTradingTime_On_Weekend(DateTime dt, bool expected)
		{
			TaiwanStockUtility test = new TaiwanStockUtility();

			bool actual = test.IsTradingTime(dt);

			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase("2022/11/01 8:59:59", false)]
		[TestCase("2022/11/02 13:30:01", false)]
		public void IsTradingTime_Before_9AM_After_1330PM(DateTime dt, bool expected)
		{
			TaiwanStockUtility test = new TaiwanStockUtility();

			bool actual = test.IsTradingTime(dt);

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}