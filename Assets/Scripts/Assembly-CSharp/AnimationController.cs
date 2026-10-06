using UnityEngine;

public class AnimationController : MonoBehaviour
{
	private enum EAnimState
	{
		eWAIT = 0,
		eIN = 1,
		eOUT = 2
	}

	public bool debugPlay_In;

	public bool debugPlay_Out;

	public AnimationClip inAnimationClip;

	public AnimationClip outAnimationClip;

	public AudioClip inSE;

	public AudioClip outSE;

	public AnimationClip[] exAnimationClip;

	public float playSpeed;

	public bool checkWidgets;

	public bool inAnimationStart;

	private string playingAnimName;

	private bool isReverse;

	private float playTime;

	[SerializeField]
	private Animation animData;

	private bool outAnimationed;

	public GameObject sendObj;

	public string OnAnimEndMethod;

	private bool inAnimationed;

	public GameObject insendObj;

	public string OninAnimEndMethod;

	private EAnimState animState;

	private Animation anim
	{
		get
		{
			return null;
		}
	}

	public string PlayAnimationName
	{
		get
		{
			return null;
		}
	}

	public bool IsReverse
	{
		get
		{
			return false;
		}
	}

	private void Init()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateWidget()
	{
	}

	public virtual void PlayForceInAnimation()
	{
	}

	public virtual void PlayInAnimation()
	{
	}

	public virtual void PlayInAnimation(bool force)
	{
	}

	public virtual void PlayForceOutAnimation()
	{
	}

	public virtual void StopInAnimation()
	{
	}

	public virtual void PlayOutAnimation()
	{
	}

	public virtual void PlayOutAnimation(bool force)
	{
	}

	public virtual void StopOutAnimation()
	{
	}

	public virtual void StopAnimation()
	{
	}

	public void ReversePlayInAnimation()
	{
	}

	public void ReversePlayOutAnimation()
	{
	}

	public void PlayExAnimation(int num, bool force = true)
	{
	}

	public void ReversePlayExAnimation(int num, bool force = true)
	{
	}

	public bool IsAnimationEnd()
	{
		return false;
	}

	public bool IsOutAnimationEnd()
	{
		return false;
	}

	public bool IsOutAnimationPlay()
	{
		return false;
	}

	public bool IsInAnimationEnd()
	{
		return false;
	}

	public bool IsInAnimationPlay()
	{
		return false;
	}

	public void PauseAnimation()
	{
	}

	public void ResumeAnimation()
	{
	}

	public void SetAnimationSpeed(float speed)
	{
	}

	public void SetOnEndMethod(GameObject obj, string method)
	{
	}

	public void SetInEndMethod(GameObject obj, string method)
	{
	}

	public void ClearInEndMethod()
	{
	}

	public void ClearOutEndMethod()
	{
	}

	public void SetInAnimEnd()
	{
	}

	public void SetOutAnimEnd()
	{
	}

	public void AnimationEnd()
	{
	}

	public float GetPlayPer()
	{
		return 0f;
	}
}
