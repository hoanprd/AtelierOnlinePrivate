using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
    [DoNotObfuscateNGUI]
    public enum Scaling
    {
        Flexible = 0,
        Constrained = 1,
        ConstrainedOnMobiles = 2
    }

    [DoNotObfuscateNGUI]
    public enum Constraint
    {
        Fit = 0,
        Fill = 1,
        FitWidth = 2,
        FitHeight = 3
    }

    public static List<UIRoot> list = new List<UIRoot>();

    public Scaling scalingStyle = Scaling.Constrained;

    public int manualWidth = 1280;

    public int manualHeight = 720;

    public int minimumHeight = 320;

    public int maximumHeight = 1536;

    public bool fitWidth = false;

    public bool fitHeight = true;

    public bool adjustByDPI = false;

    public bool shrinkPortraitUI = false;

    public bool adjustAspect = true;

    private Transform mTrans;

    public Constraint constraint
    {
        get
        {
            if (fitWidth)
            {
                if (fitHeight) return Constraint.Fit;
                return Constraint.FitWidth;
            }
            if (fitHeight) return Constraint.FitHeight;
            return Constraint.Fill;
        }
    }

    public Scaling activeScaling
    {
        get
        {
            Scaling s = scalingStyle;
            if (s == Scaling.ConstrainedOnMobiles)
            {
#if UNITY_EDITOR
                return Scaling.Constrained;
#else
				if (Application.platform == RuntimePlatform.IPhonePlayer ||
					Application.platform == RuntimePlatform.Android)
				{
					return Scaling.Constrained;
				}
				return Scaling.Flexible;
#endif
            }
            return s;
        }
    }

    public int activeHeight
    {
        get
        {
            Scaling s = activeScaling;
            if (s == Scaling.Flexible)
            {
                int height = Mathf.Max(2, Screen.height);
                if (shrinkPortraitUI && Screen.height > Screen.width)
                {
                    height = Mathf.RoundToInt(height * Screen.width / (float)Screen.height);
                }
                return Mathf.Clamp(height, minimumHeight, maximumHeight);
            }

            int w = Screen.width;
            int h = Screen.height;

            if (w == 0 || h == 0) return manualHeight;

            if (shrinkPortraitUI && h > w)
            {
                float targetAspect = (float)manualWidth / manualHeight;
                float currentAspect = (float)w / h;

                if (currentAspect < targetAspect)
                {
                    if (constraint == Constraint.FitWidth || constraint == Constraint.Fit)
                    {
                        return Mathf.RoundToInt(manualWidth / currentAspect);
                    }
                }
            }

            float aspect = (float)w / h;
            float manualAspect = (float)manualWidth / manualHeight;

            switch (constraint)
            {
                case Constraint.Fit:
                    {
                        if (aspect > manualAspect)
                        {
                            return manualHeight;
                        }
                        else
                        {
                            return Mathf.RoundToInt(manualWidth / aspect);
                        }
                    }
                case Constraint.Fill:
                    {
                        if (aspect > manualAspect)
                        {
                            return Mathf.RoundToInt(manualWidth / aspect);
                        }
                        else
                        {
                            return manualHeight;
                        }
                    }
                case Constraint.FitWidth:
                    {
                        return Mathf.RoundToInt(manualWidth / aspect);
                    }
                case Constraint.FitHeight:
                    {
                        return manualHeight;
                    }
            }

            return manualHeight;
        }
    }

    public float pixelSizeAdjustment
    {
        get
        {
            int height = Mathf.Max(2, Screen.height);
            return GetPixelSizeAdjustment(height);
        }
    }

    public static float GetPixelSizeAdjustment(GameObject go)
    {
        UIRoot root = Find(go.transform);
        return (root != null) ? root.pixelSizeAdjustment : 1f;
    }

    public float GetPixelSizeAdjustment(int height)
    {
        Scaling s = activeScaling;
        if (s == Scaling.Flexible)
        {
            return Mathf.Clamp01((float)minimumHeight / Mathf.Max(2, height));
        }
        return (float)manualHeight / Mathf.Max(2, height);
    }

    protected virtual void Awake()
    {
        mTrans = transform;
    }

    protected virtual void OnEnable()
    {
        list.Add(this);
    }

    protected virtual void OnDisable()
    {
        list.Remove(this);
    }

    protected virtual void Start()
    {
        UpdateScale(true);
    }

    private void Update()
    {
        UpdateScale(false);
    }

    public void UpdateScale(bool updateAnchors = true)
    {
        if (mTrans == null) mTrans = transform;

        Scaling s = activeScaling;
        if (s == Scaling.Flexible)
        {
            mTrans.localScale = Vector3.one;
        }
        else
        {
            int height = Mathf.Max(2, activeHeight);
            float target = 2f / height;

            Vector3 scale = new Vector3(target, target, target);

            if (mTrans.localScale != scale)
            {
                mTrans.localScale = scale;
                if (updateAnchors)
                {
                    Broadcast("UpdateAnchors");
                }
            }
        }
    }

    public static void Broadcast(string funcName)
    {
        for (int i = 0; i < list.Count; i++)
        {
            UIRoot root = list[i];
            if (root != null)
            {
                root.BroadcastMessage(funcName, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    public static void Broadcast(string funcName, object param)
    {
        if (param == null)
        {
            Broadcast(funcName);
            return;
        }

        for (int i = 0; i < list.Count; i++)
        {
            UIRoot root = list[i];
            if (root != null)
            {
                root.BroadcastMessage(funcName, param, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    public static UIRoot Find(Transform trans)
    {
        while (trans != null)
        {
            UIRoot root = trans.GetComponent<UIRoot>();
            if (root != null) return root;
            trans = trans.parent;
        }
        return (list.Count > 0) ? list[0] : null;
    }
}