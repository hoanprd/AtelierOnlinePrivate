using System;

[Serializable]
public class RpcCharaAnimation
{
	public int playerID;

	public bool isSP_PickUp;

	public bool isSP_Boring;

	public bool isSP_Bomb;

	public bool isSP_Surprise;

	public bool isAlchemy;

	public int motionStep;

	public int pickUpKind;

	public int pickUpLook;

	public int bombKind;

	public float targetX;

	public float targetY;

	public float targetZ;

	public float bombScale;

	public bool isClimb;

	public bool isCarriage;

	public bool isWind;
}
