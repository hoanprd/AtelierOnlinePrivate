using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FairyRoute
{
	[Serializable]
	public class Move
	{
		public int iCollId;

		public Vector3 v3Move;

		public Move(int iCollId, Vector3 v3Move)
		{
		}
	}

	public int iId;

	public List<int> iQuestDFList;

	public List<Move> clsMoveList;
}
