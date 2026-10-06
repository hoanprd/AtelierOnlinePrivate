using System.Collections.Generic;

public abstract class Debug_Item
{
	public string name;

	public int num;

	public int qty;

	public int trt;

	public string text;

	public List<InventoryInfo> InventoryInfoList;

	public bool isFold;

	public bool isDetailFold;

	public virtual int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Debug_Item(int _id)
	{
	}
}
