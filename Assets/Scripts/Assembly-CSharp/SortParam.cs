public class SortParam
{
	public EFilterKind eFilter;

	public ESortKind eSort;

	public EOrder eOrder;

	public string sKey;

	public SortParam()
	{
	}

	public SortParam(string key, ESortKind sort, EOrder order = EOrder.eDESC, EFilterKind filter = EFilterKind.eALL)
	{
	}

	public void ChangeKey(string key, ESortKind sort, EOrder order = EOrder.eDESC, EFilterKind filter = EFilterKind.eALL)
	{
	}

	public void Load()
	{
	}

	public void Save(ESortKind sort, EFilterKind filter, EOrder order)
	{
	}

	public void Save()
	{
	}
}
