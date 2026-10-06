using System;
using System.Collections.Generic;

namespace Tutorial
{
	[Serializable]
	public class Data
	{
		public enum eWindowData
		{
			Title = 0,
			Detail = 1,
			CatchPhrase = 2,
			Texture = 3,
			EnumMax = 4
		}

		public eExecKind eKind;

		public List<string> strParamList;

		public string GetParam(int iIndex)
		{
			return null;
		}

		public int GetParamInt(int iIndex, int iDefault)
		{
			return 0;
		}

		public float GetParamFloat(int iIndex, float fDefault)
		{
			return 0f;
		}

		public bool GetParamBool(int iIndex, bool bDefault)
		{
			return false;
		}
	}
}
