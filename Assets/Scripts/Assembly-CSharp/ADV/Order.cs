using System;
using System.Collections.Generic;

namespace ADV
{
	[Serializable]
	public class Order
	{
		public EOrderType eOrder;

		public List<string> vsParam;
	}
}
