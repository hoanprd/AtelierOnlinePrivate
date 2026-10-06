using System;
using System.Collections.Generic;

[Serializable]
public class RpcGimmickReserveListAdd
{
	public int charaID;

	public long gimmickID;

	public Dictionary<string, object> obj;
}
