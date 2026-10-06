using System;

[Serializable]
public class RpcCharaItemUse
{
	public int charaID;

	public float[] healHpRate;

	public int[] healState;

	public int useType;

	public int range;

	public bool others;
}
