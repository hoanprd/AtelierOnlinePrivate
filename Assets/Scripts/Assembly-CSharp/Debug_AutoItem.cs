using System;

[Serializable]
public class Debug_AutoItem : Debug_Item
{
	public AIItemInfo Info;

	public override int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Debug_AutoItem(int _id)
		: base(0)
	{
	}
}
