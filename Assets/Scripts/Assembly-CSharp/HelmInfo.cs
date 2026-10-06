using System;
using System.Collections.Generic;

[Serializable]
public class HelmInfo
{
	[Serializable]
	public class Unique
	{
		public int iChara;

		public EHelmKind eKind;
	}

	public int iID;

	public EHelmKind eDefault;

	public List<Unique> vUnique;
}
