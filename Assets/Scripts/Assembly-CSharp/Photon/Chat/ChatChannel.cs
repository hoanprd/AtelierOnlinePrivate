using System.Collections.Generic;

namespace Photon.Chat
{
	public class ChatChannel
	{
		public readonly string Name;

		public readonly List<string> Senders;

		public readonly List<object> Messages;

		public int MessageLimit;

		private Dictionary<object, object> properties;

		public readonly HashSet<string> Subscribers;

		public bool IsPrivate { get; protected internal set; }

		public int MessageCount
		{
			get
			{
				return 0;
			}
		}

		public int LastMsgId { get; protected set; }

		public bool PublishSubscribers { get; protected set; }

		public int MaxSubscribers { get; protected set; }

		public ChatChannel(string name)
		{
		}

		public void Add(string sender, object message, int msgId)
		{
		}

		public void Add(string[] senders, object[] messages, int lastMsgId)
		{
		}

		public void TruncateMessages()
		{
		}

		public void ClearMessages()
		{
		}

		public string ToStringMessages()
		{
			return null;
		}

		internal void ReadProperties(Dictionary<object, object> newProperties)
		{
		}

		internal void AddSubscribers(string[] users)
		{
		}

		internal void ClearProperties()
		{
		}
	}
}
