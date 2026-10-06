using System.Collections.Generic;
using Tutorial;

public class TutorialCommandArrow : TutorialCommandBase
{
	public static List<TutorialArrow> s_scrArrowList;

	private bool m_bEnd;

	private string m_strRootName;

	private float m_fWaitTime;

	public override void Update()
	{
	}

	private bool MakeArrow(string strRootName)
	{
		return false;
	}

	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}

	public static void AllArrowDestroy()
	{
	}
}
