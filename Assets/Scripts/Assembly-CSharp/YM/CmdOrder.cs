using System.Collections.Generic;

namespace YM
{
	internal struct CmdOrder
	{
		public readonly int blockNo;

		public readonly List<Cmd> cmdList;

		public readonly PhotonTargets targets;

		public readonly PhotonPlayer player;

		public CmdOrder(PhotonTargets targets)
		{
			blockNo = 0;
			cmdList = null;
			this.targets = PhotonTargets.All;
			player = null;
		}

		public CmdOrder(PhotonPlayer player)
		{
			blockNo = 0;
			cmdList = null;
			targets = PhotonTargets.All;
			this.player = null;
		}
	}
}
