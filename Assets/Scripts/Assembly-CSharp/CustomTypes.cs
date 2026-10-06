using ExitGames.Client.Photon;

internal static class CustomTypes
{
	public static readonly byte[] memVector3;

	public static readonly byte[] memVector2;

	public static readonly byte[] memQuarternion;

	public static readonly byte[] memPlayer;

	internal static void Register()
	{
	}

	private static short SerializeVector3(StreamBuffer outStream, object customobject)
	{
		return 0;
	}

	private static object DeserializeVector3(StreamBuffer inStream, short length)
	{
		return null;
	}

	private static short SerializeVector2(StreamBuffer outStream, object customobject)
	{
		return 0;
	}

	private static object DeserializeVector2(StreamBuffer inStream, short length)
	{
		return null;
	}

	private static short SerializeQuaternion(StreamBuffer outStream, object customobject)
	{
		return 0;
	}

	private static object DeserializeQuaternion(StreamBuffer inStream, short length)
	{
		return null;
	}

	private static short SerializePhotonPlayer(StreamBuffer outStream, object customobject)
	{
		return 0;
	}

	private static object DeserializePhotonPlayer(StreamBuffer inStream, short length)
	{
		return null;
	}
}
