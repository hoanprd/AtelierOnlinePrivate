using System;

[Serializable]
public class ResponseData<T> : ResponseDataCommon
{
	public T API;

	public new ResponseData<T> Clone()
	{
		return null;
	}
}
