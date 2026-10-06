using System;
using System.Collections.Generic;

[Serializable]
public class UserDetail : UserDetailBase
{
	public int LV;

	public int LVCAP;

	public int DF;

	public AppearanceInfo MK;

	public int GRD;

	public int EXP;

	public int FDM;

	public EquipData EQU;

	public List<SubEquip> SUB;

	public List<InventoryInfo> INV;

	public EquipData CD_EQU;

	public int[] CD_V;
}
