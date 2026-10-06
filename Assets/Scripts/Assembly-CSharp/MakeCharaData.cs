public class MakeCharaData
{
	public string name;

	public int lv;

	public eRaceKind raceKind;

	public ERollKind rollKind;

	public EWeaponKind weaponKind;

	public EQuality weaponQuality;

	public bool custom;

	public Game_Chara_Base.eAnimator animKind;

	public int charaId;

	public int eyeId;

	public int headId;

	public int hairId;

	public int eyeColor;

	public int hairColor;

	public int skinColor;

	public int voice;

	public int weaponId;

	public int shieldId;

	public int bodyId;

	public int helmId;

	public int accId1;

	public int accId2;

	public int accId3;

	public int pickaxeId;

	public int fishingId;

	public int catchNetId;

	public bool dispShield;

	public long[] equipList;

	public long[] subEquipList;

	public MakeCharaData()
	{
	}

	public MakeCharaData(int _charaId, string _name, eRaceKind _raceKind, EWeaponKind _weaponKind, int _weapon, int _shield, int _body, int _helm, int _acc1, int _acc2, int _acc3, ERollKind _roll, AppearanceInfo mk)
	{
	}

	public MakeCharaData(int _charaId, string _name, eRaceKind _raceKind, EWeaponKind _weaponKind, int _weapon, int _shield, int _body, int _helm, int _acc1, int _acc2, int _acc3, ERollKind _roll = ERollKind.ePLAYABLE)
	{
	}

	public MakeCharaData(int _charaId, string _name, eRaceKind _raceKind, int _head, int _hair, int _eye, int _weapon, int _shield, int _body, int _helm, int _acc1, int _acc2, int _acc3, ERollKind _roll)
	{
	}

	public bool Compare(MakeCharaData mk)
	{
		return false;
	}

	public int[] GetEquipModelIDArray()
	{
		return null;
	}

	public void SetEquipModelIDArray(int weapon = 0, int shield = 0, int helm = 0, int body = 0, int acc1 = 0, int acc2 = 0, int acc3 = 0)
	{
	}

	public MakeCharaData Clone()
	{
		return null;
	}

	public static MakeCharaData MakeDefaultData(int charaID, string name = "")
	{
		return null;
	}
}
