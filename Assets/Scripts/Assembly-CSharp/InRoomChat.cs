using System.Collections.Generic;
using Photon;
using UnityEngine;

public class InRoomChat : Photon.MonoBehaviour
{
	public Rect GuiRect;

	public bool IsVisible;

	public bool AlignBottom;

	public List<string> messages;

	private string inputLine;

	private Vector2 scrollPos;

	public static readonly string ChatRPC;

	public void Start()
	{
	}

	public void OnGUI()
	{
	}

	[PunRPC]
	public void Chat(string newLine, PhotonMessageInfo mi)
	{
	}

	public void AddLine(string newLine)
	{
	}
}
