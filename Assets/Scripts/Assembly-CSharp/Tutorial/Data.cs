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
			if (strParamList != null && iIndex >= 0 && iIndex < strParamList.Count)
			{
				return strParamList[iIndex];
			}
			return string.Empty;
		}

		public int GetParamInt(int iIndex, int iDefault)
		{
			string val = GetParam(iIndex);
			if (int.TryParse(val, out int result))
			{
				return result;
			}
			return iDefault;
		}

		public float GetParamFloat(int iIndex, float fDefault)
		{
			string val = GetParam(iIndex);
			if (float.TryParse(val, out float result))
			{
				return result;
			}
			return fDefault;
		}

		public bool GetParamBool(int iIndex, bool bDefault)
		{
			string val = GetParam(iIndex);
			if (bool.TryParse(val, out bool result))
			{
				return result;
			}
			if (int.TryParse(val, out int iVal))
			{
				return iVal != 0;
			}
			return bDefault;
		}
	}
}
