using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptPrologue : ScriptBase
	{
		private static Prologue m_sInstance;

		public override bool Init(List<string> param, bool skip)
		{
			int sw = GetInt(param, 0, 0);
			if (m_sInstance != null)
			{
				m_sInstance.Kill();
				m_sInstance = null;
			}
			if (sw == 1)
			{
				GameObject parent = (ADVManager.Instance != null && ADVManager.Instance.m_trUIRoot != null) 
					? ADVManager.Instance.m_trUIRoot.gameObject 
					: null;
				m_sInstance = Prologue.Create(parent);
				if (m_sInstance != null)
				{
					m_sInstance.Play();
				}
				if (ADVManager.Instance != null)
				{
					ADVManager.Instance.SetRollbackBGM((eMusicID)1);
				}
			}
			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			if (m_sInstance == null)
			{
				return true;
			}
			return m_sInstance.IsEnd();
		}
	}
}
