using System;

public class APIQuestDeliver : MsgPackAPICommon<QuestDeliverResponse>
{
	[Serializable]
	public class Request
	{
		[Serializable]
		public class DeliveryList
		{
			public long ID;
		}

		public int DF;

		public DeliveryList[] DLV;
	}

	private Request m_sRequest;

	public int QuestID
	{
		set
		{
		}
	}

	public long[] DeliveryList
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
