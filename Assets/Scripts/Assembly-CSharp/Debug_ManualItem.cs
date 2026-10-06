using System;

[Serializable]
public class Debug_ManualItem : Debug_Item
{
	public ManualItemInfo Info;

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

	public Debug_ManualItem(int _id)
		: base(0)
	{
	}
}
