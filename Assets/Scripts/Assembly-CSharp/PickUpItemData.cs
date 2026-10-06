using UnityEngine;

public class PickUpItemData
{
	public ePickUpToolKind toolKind;

	public int lightId;

	public eSoundID seId;

	public float seWait;

	public eEffectKind effectKind_Get;

	public Vector3 effectOffset;

	public float effectWait;

	public bool rareFlag;

	public bool kirakiraFlag;

	public string effectPath { get; private set; }

	public PickUpItemData(ePickUpToolKind tool, int light, eSoundID seId, float seWait, eEffectKind effect, float effWait, Vector3 offset, bool kirakira)
	{
	}
}
