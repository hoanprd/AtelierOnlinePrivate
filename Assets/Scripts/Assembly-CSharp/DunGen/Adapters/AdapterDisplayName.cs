using System;

namespace DunGen.Adapters
{
	public sealed class AdapterDisplayName : Attribute
	{
		public string Name { get; private set; }

		public AdapterDisplayName(string name)
		{
		}
	}
}
