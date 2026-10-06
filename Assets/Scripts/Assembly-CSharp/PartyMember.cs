using System;
using System.Collections.Generic;

[Serializable]
public class PartyMember
{
	public int DF;

	public int GEN;

	public string NA;

	public string ICON;

	public string DESC;

	public int CTG;

	public int LV;

	public int EXP;

	public EquipData EQU;

	public EquipFavorite[] FAV;

	public AppearanceInfo MK;

	public int GRD;

	public int FDM;

	public int LVCAP;

	public EquipData CD_EQU;

	public int[] CD_V;

	public List<EXPTable> EXP_LV;

	public MemberRole ROLE;

	public List<BlazeArtsStatus> BAL;

	public bool IsEnableTreasure(int ignoreFormID)
	{
		return false;
	}
}
