using System;
using System.Collections.Generic;

[Serializable]
public class Debug_CharaMember
{
	public class Debug_Chara_EquipData
	{
		public InventoryInfo HEAD;

		public InventoryInfo BODY;

		public InventoryInfo WEAPON;

		public InventoryInfo SHIELD;

		public InventoryInfo ACC1;

		public InventoryInfo ACC2;

		public InventoryInfo ACC3;

		public List<InventoryInfo> GetAll()
		{
			return null;
		}
	}

	public class Debug_Chara_EquipFoldingInfo
	{
		public bool HEAD;

		public bool BODY;

		public bool WEAPON;

		public bool SHIELD;

		public bool ACC1;

		public bool ACC2;

		public bool ACC3;
	}

	public BattlePlayerInfo Info;

	public string name;

	public Debug_Chara_EquipData EQU;

	public Debug_Chara_EquipData CD;

	public List<InventoryInfo> SUB;

	public Debug_Chara_EquipFoldingInfo EQU_FOLD;

	public bool IsFold;

	private int ID;

	public int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int df
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int head
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int body
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int weapon
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int shield
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int acc1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int acc2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int acc3
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Debug_CharaMember(int _id)
	{
	}
}
