using System.Collections;
using UnityEngine;

public class Prologue : MonoBehaviour
{
	private bool m_bOutAnim;
	private bool m_bEnd;

	[SerializeField]
	private AnimationController m_scrInOutAnim;

	[SerializeField]
	private AnimationController m_scrTextAnim;

	[SerializeField]
	private UILongTapButton m_scrLongTap;

	[SerializeField]
	private GameObject m_goBlack;

	[SerializeField]
	private UIButton m_scrNextBtn;

	[SerializeField]
	private float m_fSkipSpeed = 3f;

	private void Awake()
	{
		if (m_scrInOutAnim != null)
		{
			m_scrInOutAnim.SetInEndMethod(gameObject, "OnInAnimEnd");
			m_scrInOutAnim.SetOnEndMethod(gameObject, "OnOutAnimEnd");
		}
		if (m_scrTextAnim != null)
		{
			m_scrTextAnim.SetInEndMethod(gameObject, "OnTextAnimEnd");
			m_scrTextAnim.SetOnEndMethod(gameObject, "OnTextAnimEnd");
		}
		if (m_scrLongTap != null)
		{
			EventDelegate.Set(m_scrLongTap.onLongTap, OnLongTap);
			EventDelegate.Set(m_scrLongTap.onRelease, OnRelease);
		}
		if (m_scrNextBtn != null)
		{
			EventDelegate.Set(m_scrNextBtn.onClick, OnNext);
		}
		if (m_goBlack != null)
		{
			m_goBlack.SetActive(true);
		}
	}

	private void OnInAnimEnd()
	{
		if (m_scrTextAnim != null)
		{
			m_scrTextAnim.PlayIn();
		}
	}

	private void OnOutAnimEnd()
	{
		StartCoroutine(LastFadeIn());
	}

	private void OnTextAnimEnd()
	{
		if (m_scrNextBtn != null)
		{
			m_scrNextBtn.gameObject.SetActive(true);
		}
	}

	private void OnLongTap()
	{
		Skip(true);
	}

	private void OnRelease()
	{
		Skip(false);
	}

	private void OnNext()
	{
		Dismiss();
	}

	private void Skip(bool bSkip)
	{
		float speed = bSkip ? m_fSkipSpeed : 1f;
		if (m_scrTextAnim != null && m_scrTextAnim.anim != null)
		{
			foreach (AnimationState state in m_scrTextAnim.anim)
			{
				state.speed = speed;
			}
		}
	}

	private void Dismiss()
	{
		if (m_bOutAnim) return;
		m_bOutAnim = true;
		if (m_scrInOutAnim != null)
		{
			m_scrInOutAnim.PlayOut();
		}
		else
		{
			StartCoroutine(LastFadeIn());
		}
	}

	private IEnumerator LastFadeIn()
	{
		LoadingManager.Enable(0.5f);
		while (!LoadingManager.IsBlackOut)
		{
			yield return null;
		}
		if (m_goBlack != null)
		{
			m_goBlack.SetActive(false);
		}
		LoadingManager.Disable(0.5f);
		while (!LoadingManager.IsEnd)
		{
			yield return null;
		}
		m_bEnd = true;
	}

	public void Play()
	{
		if (m_scrInOutAnim != null)
		{
			m_scrInOutAnim.PlayIn();
		}
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlayMusic((eMusicID)0, true, 0f, false);
		}
		LoadingManager.Disable(0.5f);
	}

	public bool IsEnd()
	{
		return m_bEnd;
	}

	public void Kill()
	{
		Destroy(gameObject);
	}

	public static Prologue Create(GameObject goParent)
	{
		GameObject prefab = Resources.Load<GameObject>("ui/UI_Prologue");
		if (prefab == null)
		{
			Debug.LogError("[Prologue] Failed to load Resources ui/UI_Prologue");
			return null;
		}
		GameObject go = (goParent != null) ? NGUITools.AddChild(goParent, prefab) : Instantiate(prefab);
		if (goParent != null)
		{
			ChangeLayer(go.transform, goParent.layer);
		}
		return go.GetComponent<Prologue>();
	}

	private static void ChangeLayer(Transform t, int layer)
	{
		if (t == null) return;
		t.gameObject.layer = layer;
		for (int i = 0; i < t.childCount; i++)
		{
			ChangeLayer(t.GetChild(i), layer);
		}
	}
}
