using System;
using System.Collections.Generic;

[Serializable]
public class CharaModelInfo
{
	[Serializable]
	public class HelmOffset
	{
		public int id;

		public float offsetY;
	}

	public float fScale;

	public Game_Chara_Base.eAnimator eAnimKind;

	public List<HelmOffset> avHelmOffset;

	public bool bMacho;

	public int hairId;

	public int eyeId;

	public int headId;

	public int voice;

	public int weaponId;

	public int bodyId;

	public int shieldId;

	public int helmId;

	public int accId1;

	public int accId2;

	public int accId3;
}
