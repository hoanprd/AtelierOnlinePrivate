using System;
using System.Collections.Generic;

[Serializable]
public class ActiveSkillDirection : MasterRecordIdBase
{
	[Serializable]
	public class StrBean
	{
		public string str;
	}

	public string icon;

	public string path;

	public List<string> effect;

	public List<StrBean> effectJ;

	public List<string> se;

	public List<StrBean> seJ;
}
