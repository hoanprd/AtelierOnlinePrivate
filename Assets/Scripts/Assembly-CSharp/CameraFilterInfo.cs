using System;

[Serializable]
public class CameraFilterInfo
{
	public int iAreaId;

	public float fRedR;

	public float fRedG;

	public float fRedB;

	public float fRedConstant;

	public float fGreenR;

	public float fGreenG;

	public float fGreenB;

	public float fGreenConstant;

	public float fBlueR;

	public float fBlueG;

	public float fBlueB;

	public float fBlueConstant;

	public bool IsAreaId(int iAreaId)
	{
		return false;
	}
}
