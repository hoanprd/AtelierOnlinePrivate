using System.Collections.Generic;

namespace YM
{
	internal class CmdPack : Dictionary<int, CmdBlock>
	{
		private int frameIdx;

		public void Reset()
		{
		}

		public void NextFrame()
		{
		}

		public void AddCmd(CmdType cmdType, CmdOrder order, Cmd cmd)
		{
		}
	}
}
