using System.Collections.Generic;

public class ExqClearTarget_MP_CharaMemberData
{
	public int Index;

	public int DF;

	public int HP;

	public int HPBefore;

	public int HPMax;

	public int Level;

	public float SP0;

	public float SP1;

	public int CharaID;

	public int HairID;

	public int EyeID;

	public int HeadID;

	public int BodyID;

	public int SkinColorID;

	public int HairColorID;

	public int EyeColorID;

	public string Name;

	public int RaceKind;

	public int ActionSpeed;

	public int Atk;

	public int AtkOrigin;

	public int MagicAtk;

	public int MagicAtkOrigin;

	public int Def;

	public int MagicDef;

	public int Dex;

	public int Eva;

	public int Critical;

	public int SkillAddition;

	public int WeaponKind;

	public int WeaponID;

	public int ShieldID;

	public int ShieldV;

	public int HelmID;

	public int ArmorID;

	public int AccID1;

	public int AccID2;

	public int AccID3;

	public int ItemAuto;

	public EquipData EquipData;

	public bool UpdateAbnormalState;

	private List<ActiveSkill> m_ActiveSkillList;

	private List<ActiveSkill> m_PassiveSkillList;

	public bool IsUpdateEquipment;

	public bool IsHero;

	public PartyCharaData PartyCharaData;

	public BattleCharaData BattleCharaData;

	public MakeCharaData MakeCharaData;

	public float HPRate;

	public ExqClearTarget_MP_CharaMemberData(MultiPlay_CharaMemberData memberData)
	{
	}
}
