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

	public float playSpeed = 1f;

	public bool checkWidgets;

	public bool inAnimationStart;

	private string playingAnimName = string.Empty;

	private bool isReverse;

	private float playTime;

	[SerializeField]
	private Animation animData;

	private bool outAnimationed;

	public GameObject sendObj;

	public string OnAnimEndMethod = string.Empty;

	private bool inAnimationed;

	public GameObject insendObj;

	public string OninAnimEndMethod = string.Empty;

	private EAnimState animState;

	public Animation anim
	{
		get
		{
			if (animData == null)
			{
				Init();
			}
			return animData;
		}
	}

	public void PlayIn()
	{
		PlayInAnimation();
	}

	public void PlayOut()
	{
		PlayOutAnimation();
	}

	public string PlayAnimationName
	{
		get
		{
			return playingAnimName;
		}
	}

	public bool IsReverse
	{
		get
		{
			return isReverse;
		}
	}

	private void Init()
	{
		animData = GetComponent<Animation>();
		if (animData == null)
		{
			animData = gameObject.AddComponent<Animation>();
		}
		animData.playAutomatically = false;
		if (inAnimationClip != null)
		{
			inAnimationClip.legacy = true;
			if (animData.GetClip(inAnimationClip.name) == null)
			{
				animData.AddClip(inAnimationClip, inAnimationClip.name);
			}
		}
		if (outAnimationClip != null)
		{
			outAnimationClip.legacy = true;
			if (animData.GetClip(outAnimationClip.name) == null)
			{
				animData.AddClip(outAnimationClip, outAnimationClip.name);
			}
		}
		if (exAnimationClip != null)
		{
			for (int i = 0; i < exAnimationClip.Length; i++)
			{
				if (exAnimationClip[i] != null)
				{
					exAnimationClip[i].legacy = true;
					if (animData.GetClip(exAnimationClip[i].name) == null)
					{
						animData.AddClip(exAnimationClip[i], exAnimationClip[i].name);
					}
				}
			}
		}
	}

	private void Start()
	{
		Init();
		if (inAnimationStart)
		{
			PlayInAnimation();
		}
	}

	private void Update()
	{
		if (debugPlay_In)
		{
			debugPlay_In = false;
			PlayForceInAnimation();
		}
		if (debugPlay_Out)
		{
			debugPlay_Out = false;
			PlayForceOutAnimation();
		}
		if (!string.IsNullOrEmpty(playingAnimName) && anim != null && anim.IsPlaying(playingAnimName))
		{
			playTime += Time.deltaTime;
		}
		if (outAnimationed && IsOutAnimationEnd())
		{
			if (sendObj != null && !string.IsNullOrEmpty(OnAnimEndMethod))
			{
				sendObj.SendMessage(OnAnimEndMethod, SendMessageOptions.DontRequireReceiver);
			}
			UpdateWidget();
			outAnimationed = false;
		}
		if (inAnimationed && IsInAnimationEnd())
		{
			if (insendObj != null && !string.IsNullOrEmpty(OninAnimEndMethod))
			{
				insendObj.SendMessage(OninAnimEndMethod, SendMessageOptions.DontRequireReceiver);
			}
			UpdateWidget();
			inAnimationed = false;
		}
		if (!IsAnimationEnd())
		{
			UpdateWidget();
		}
	}

	private void UpdateWidget()
	{
		if (!checkWidgets)
		{
			return;
		}
		UIWidget[] widgets = gameObject.GetComponentsInChildren<UIWidget>(true);
		for (int i = 0; i < widgets.Length; i++)
		{
			if (widgets[i] != null)
			{
				widgets[i].MarkAsChanged();
			}
		}
	}

	public virtual void PlayForceInAnimation()
	{
		PlayInAnimation(true);
	}

	public virtual void PlayInAnimation()
	{
		PlayInAnimation(false);
	}

	public virtual void PlayInAnimation(bool force)
	{
		if (!force && animState == EAnimState.eIN)
		{
			return;
		}
		gameObject.SetActive(true);
		isReverse = false;
		playTime = 0f;
		animState = EAnimState.eIN;
		inAnimationed = true;
		outAnimationed = false;
		if (inAnimationClip == null)
		{
			playingAnimName = string.Empty;
			return;
		}
		inAnimationClip.legacy = true;
		playingAnimName = inAnimationClip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(inAnimationClip, playingAnimName);
		}
		if (force)
		{
			anim.enabled = false;
			anim.enabled = true;
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			state.speed = (playSpeed != 0f) ? playSpeed : 1f;
			state.time = 0f;
		}
		anim.Play(playingAnimName);
		if (inSE != null && Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound_AudioClip(inSE);
		}
	}

	public virtual void PlayForceOutAnimation()
	{
		PlayOutAnimation(true);
	}

	public virtual void StopInAnimation()
	{
		if (inAnimationClip != null && anim != null)
		{
			anim.Stop(inAnimationClip.name);
		}
		inAnimationed = false;
	}

	public virtual void PlayOutAnimation()
	{
		PlayOutAnimation(false);
	}

	public virtual void PlayOutAnimation(bool force)
	{
		if (!force && animState == EAnimState.eOUT)
		{
			return;
		}
		isReverse = false;
		playTime = 0f;
		animState = EAnimState.eOUT;
		outAnimationed = true;
		inAnimationed = false;
		if (outAnimationClip == null)
		{
			playingAnimName = string.Empty;
			return;
		}
		outAnimationClip.legacy = true;
		playingAnimName = outAnimationClip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(outAnimationClip, playingAnimName);
		}
		if (force)
		{
			anim.enabled = false;
			anim.enabled = true;
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			state.speed = (playSpeed != 0f) ? playSpeed : 1f;
			state.time = 0f;
		}
		anim.Play(playingAnimName);
		if (outSE != null && Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound_AudioClip(outSE);
		}
	}

	public virtual void StopOutAnimation()
	{
		if (outAnimationClip != null && anim != null)
		{
			anim.Stop(outAnimationClip.name);
		}
		outAnimationed = false;
	}

	public virtual void StopAnimation()
	{
		if (anim != null)
		{
			anim.Stop();
		}
		inAnimationed = false;
		outAnimationed = false;
		animState = EAnimState.eWAIT;
	}

	public void ReversePlayInAnimation()
	{
		if (inAnimationClip == null)
		{
			return;
		}
		gameObject.SetActive(true);
		isReverse = true;
		playTime = 0f;
		inAnimationClip.legacy = true;
		playingAnimName = inAnimationClip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(inAnimationClip, playingAnimName);
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			float spd = (playSpeed != 0f) ? playSpeed : 1f;
			state.speed = -Mathf.Abs(spd);
			state.time = state.length;
		}
		anim.Play(playingAnimName);
	}

	public void ReversePlayOutAnimation()
	{
		if (outAnimationClip == null)
		{
			return;
		}
		gameObject.SetActive(true);
		isReverse = true;
		playTime = 0f;
		outAnimationClip.legacy = true;
		playingAnimName = outAnimationClip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(outAnimationClip, playingAnimName);
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			float spd = (playSpeed != 0f) ? playSpeed : 1f;
			state.speed = -Mathf.Abs(spd);
			state.time = state.length;
		}
		anim.Play(playingAnimName);
	}

	public void PlayExAnimation(int num, bool force = true)
	{
		if (exAnimationClip == null || num < 0 || num >= exAnimationClip.Length || exAnimationClip[num] == null)
		{
			return;
		}
		gameObject.SetActive(true);
		isReverse = false;
		playTime = 0f;
		AnimationClip clip = exAnimationClip[num];
		clip.legacy = true;
		playingAnimName = clip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(clip, playingAnimName);
		}
		if (force)
		{
			anim.enabled = false;
			anim.enabled = true;
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			state.speed = (playSpeed != 0f) ? playSpeed : 1f;
			state.time = 0f;
		}
		anim.Play(playingAnimName);
	}

	public void ReversePlayExAnimation(int num, bool force = true)
	{
		if (exAnimationClip == null || num < 0 || num >= exAnimationClip.Length || exAnimationClip[num] == null)
		{
			return;
		}
		gameObject.SetActive(true);
		isReverse = true;
		playTime = 0f;
		AnimationClip clip = exAnimationClip[num];
		clip.legacy = true;
		playingAnimName = clip.name;
		if (anim.GetClip(playingAnimName) == null)
		{
			anim.AddClip(clip, playingAnimName);
		}
		if (force)
		{
			anim.enabled = false;
			anim.enabled = true;
		}
		AnimationState state = anim[playingAnimName];
		if (state != null)
		{
			float spd = (playSpeed != 0f) ? playSpeed : 1f;
			state.speed = -Mathf.Abs(spd);
			state.time = state.length;
		}
		anim.Play(playingAnimName);
	}

	public bool IsAnimationEnd()
	{
		if (string.IsNullOrEmpty(playingAnimName) || anim == null)
		{
			return true;
		}
		return !anim.IsPlaying(playingAnimName);
	}

	public bool IsOutAnimationEnd()
	{
		if (outAnimationClip == null || anim == null)
		{
			return true;
		}
		return !anim.IsPlaying(outAnimationClip.name);
	}

	public bool IsOutAnimationPlay()
	{
		if (outAnimationClip == null || anim == null)
		{
			return false;
		}
		return anim.IsPlaying(outAnimationClip.name);
	}

	public bool IsInAnimationEnd()
	{
		if (inAnimationClip == null || anim == null)
		{
			return true;
		}
		return !anim.IsPlaying(inAnimationClip.name);
	}

	public bool IsInAnimationPlay()
	{
		if (inAnimationClip == null || anim == null)
		{
			return false;
		}
		return anim.IsPlaying(inAnimationClip.name);
	}

	public void PauseAnimation()
	{
		SetAnimationSpeed(0f);
	}

	public void ResumeAnimation()
	{
		SetAnimationSpeed((playSpeed != 0f) ? playSpeed : 1f);
	}

	public void SetAnimationSpeed(float speed)
	{
		if (!string.IsNullOrEmpty(playingAnimName) && anim != null)
		{
			AnimationState state = anim[playingAnimName];
			if (state != null)
			{
				state.speed = speed;
			}
		}
	}

	public void SetOnEndMethod(GameObject obj, string method)
	{
		sendObj = obj;
		OnAnimEndMethod = method;
	}

	public void SetInEndMethod(GameObject obj, string method)
	{
		insendObj = obj;
		OninAnimEndMethod = method;
	}

	public void ClearInEndMethod()
	{
		insendObj = null;
		OninAnimEndMethod = string.Empty;
	}

	public void ClearOutEndMethod()
	{
		sendObj = null;
		OnAnimEndMethod = string.Empty;
	}

	public void SetInAnimEnd()
	{
		if (inAnimationClip != null && anim != null)
		{
			inAnimationClip.legacy = true;
			if (anim.GetClip(inAnimationClip.name) == null)
			{
				anim.AddClip(inAnimationClip, inAnimationClip.name);
			}
			AnimationState state = anim[inAnimationClip.name];
			if (state != null)
			{
				anim.Play(inAnimationClip.name);
				state.time = state.length;
				anim.Sample();
				anim.Stop(inAnimationClip.name);
			}
		}
		inAnimationed = false;
		animState = EAnimState.eIN;
		UpdateWidget();
	}

	public void SetOutAnimEnd()
	{
		if (outAnimationClip != null && anim != null)
		{
			outAnimationClip.legacy = true;
			if (anim.GetClip(outAnimationClip.name) == null)
			{
				anim.AddClip(outAnimationClip, outAnimationClip.name);
			}
			AnimationState state = anim[outAnimationClip.name];
			if (state != null)
			{
				anim.Play(outAnimationClip.name);
				state.time = state.length;
				anim.Sample();
				anim.Stop(outAnimationClip.name);
			}
		}
		outAnimationed = false;
		animState = EAnimState.eOUT;
		UpdateWidget();
	}

	public void AnimationEnd()
	{
		if (!string.IsNullOrEmpty(playingAnimName) && anim != null)
		{
			AnimationState state = anim[playingAnimName];
			if (state != null)
			{
				state.time = state.length;
				anim.Sample();
				anim.Stop(playingAnimName);
			}
		}
		UpdateWidget();
	}

	public float GetPlayPer()
	{
		if (string.IsNullOrEmpty(playingAnimName) || anim == null)
		{
			return 1f;
		}
		AnimationState state = anim[playingAnimName];
		if (state == null || state.length <= 0f)
		{
			return 1f;
		}
		return Mathf.Clamp01(state.time / state.length);
	}
}
