using System;
using System.Collections.Generic;

[Serializable]
public class JoinCondition
{
	public int CNDID;

	public int ESS;

	public int RATEBNS;

	public eConditionType TYPE;

	public List<int> VALS;

	public int ACVBNS;
}
