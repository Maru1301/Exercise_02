using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_UnitTest
{
	public class TaiwanStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			int weekDay = (int)dt.DayOfWeek;

			if (weekDay < 1 || weekDay > 5)
			{
				return false;
			}

			int hour = dt.Hour;
			int minute = dt.Minute;
			int second = dt.Second;

			if (hour < 9 || hour > 13 || (hour == 13 && minute > 30) || (hour == 13 && minute == 30 && second > 0))
			{
				return false;
			}

			return true;
		}
	}
}
