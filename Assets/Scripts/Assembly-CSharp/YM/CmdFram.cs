using System.Collections.Generic;

namespace YM
{
	internal class CmdFram : Dictionary<int, List<Cmd>>
	{
		public readonly PhotonTargets targets;

		public readonly PhotonPlayer player;

		public CmdFram(CmdOrder oreder)
		{
		}
	}
}
