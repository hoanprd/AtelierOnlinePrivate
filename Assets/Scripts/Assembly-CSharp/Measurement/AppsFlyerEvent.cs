using System.Collections.Generic;

namespace Measurement
{
	public class AppsFlyerEvent
	{
		public const string Tag = "[AppsFlyerEvent] ";

		public string Name { get; private set; }

		public Dictionary<string, string> Values { get; set; }

		public AppsFlyerEvent(string name, Dictionary<string, string> values)
		{
		}

		public string Dump()
		{
			return null;
		}
	}
}
