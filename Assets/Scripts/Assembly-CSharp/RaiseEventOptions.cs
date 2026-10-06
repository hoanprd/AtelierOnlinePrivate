public class RaiseEventOptions
{
	public static readonly RaiseEventOptions Default;

	public EventCaching CachingOption;

	public byte InterestGroup;

	public int[] TargetActors;

	public ReceiverGroup Receivers;

	public byte SequenceChannel;

	public bool ForwardToWebhook;

	public bool Encrypt;

	public void Reset()
	{
	}
}
