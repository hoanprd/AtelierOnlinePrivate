using System;
using System.Collections.Generic;

[Serializable]
public class GrowBlazeArtsMateria
{
	[Serializable]
	public class Status
	{
		public int LV;

		public int EXP;

		public int LVCAP;
	}

	[Serializable]
	public class Info
	{
		public Status LV;

		public List<BlazeArtsStatus> BA;
	}

	public Info CH;
}
