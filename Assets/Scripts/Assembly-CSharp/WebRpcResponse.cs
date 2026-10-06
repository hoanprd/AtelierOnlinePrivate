using System.Collections.Generic;
using ExitGames.Client.Photon;

public class WebRpcResponse
{
	public string Name { get; private set; }

	public int ReturnCode { get; private set; }

	public string DebugMessage { get; private set; }

	public Dictionary<string, object> Parameters { get; private set; }

	public WebRpcResponse(OperationResponse response)
	{
	}

	public string ToStringFull()
	{
		return null;
	}
}
