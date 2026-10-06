namespace ExitGames.Client.DemoParticle
{
	public class TimeKeeper
	{
		private int lastExecutionTime;

		private bool shouldExecute;

		public int Interval { get; set; }

		public bool IsEnabled { get; set; }

		public bool ShouldExecute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TimeKeeper(int interval)
		{
		}

		public void Reset()
		{
		}
	}
}
