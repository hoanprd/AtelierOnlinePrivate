using System;
using MessagePack;

[Serializable]
public class PossessionInfo
{
	public int DF;

	[IgnoreMember]
	public int CNT;
}
