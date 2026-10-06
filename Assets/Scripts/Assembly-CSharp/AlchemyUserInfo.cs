using System;
using System.Collections.Generic;

[Serializable]
public class AlchemyUserInfo
{
	public int LV;

	public int EXP;

	public int EXN;

	public int EXB;

	public int NRC;

	public List<int> ULRCP;

	public bool IsUnlockRecipe(int df)
	{
		return false;
	}
}
