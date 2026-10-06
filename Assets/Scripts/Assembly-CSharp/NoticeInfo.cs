using System;

[Serializable]
public class NoticeInfo
{
	public int ID;

	public string MSG;

	public string ICO;

	public string STRT;

	public string END;

	public int PRIO;

	public int CNT;

	public static int CompPRIO(NoticeInfo lhs, NoticeInfo rhs)
	{
		return 0;
	}
}
