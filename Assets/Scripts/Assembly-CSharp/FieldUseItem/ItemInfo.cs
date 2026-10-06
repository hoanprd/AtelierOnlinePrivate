using System.Collections.Generic;

namespace FieldUseItem
{
	public class ItemInfo
	{
		public int iNum;

		public int iUseNum;

		public bool bOthers;

		public MasterItem clsMaster;

		public List<EAbnormalState> eStateList;

		public ItemInfo(int iNum, int iUseNum, bool bOthers, MasterItem clsMaster, List<EAbnormalState> eStateList)
		{
		}
	}
}
