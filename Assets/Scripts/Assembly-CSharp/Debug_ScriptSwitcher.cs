using UnityEngine;

public class Debug_ScriptSwitcher : Debug_Base
{
	private bool m_targetScriptFlag;

	public GameObject[] m_targetObject_On;

	public GameObject[] m_targetObject_Off;

	public MonoBehaviour[] m_targetScript_On;

	public MonoBehaviour[] m_targetScript_Off;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SetScript(bool flag)
	{
	}
}
