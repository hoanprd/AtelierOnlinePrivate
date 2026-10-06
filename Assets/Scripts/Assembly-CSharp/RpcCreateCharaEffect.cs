using System;
using UnityEngine;

[Serializable]
public class RpcCreateCharaEffect
{
	public int charaID;

	public int effectId;

	public Vector3 localOffset;

	public int soundId;
}
