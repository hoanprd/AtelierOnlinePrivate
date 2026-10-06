using System;
using System.Collections.Generic;

[Serializable]
public class Debug_EnemyMember
{
	public BattleEnemyInfo Info;

	public string name;

	public string anothername;

	public List<int> skillList;

	public bool isFold;

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

	public Debug_EnemyMember(int _id)
	{
	}
}
