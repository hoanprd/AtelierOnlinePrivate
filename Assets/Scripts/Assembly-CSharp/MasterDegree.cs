using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MasterDegree : ScriptableObject
{
	public List<MasterDegreeInfo> List;

	public MasterDegreeInfo Find(int df, int step)
	{
		return null;
	}

	public MasterDegreeInfo Find(DegreeInfo info)
	{
		return null;
	}

	public int GetMaxStep(int df)
	{
		return 0;
	}
}
