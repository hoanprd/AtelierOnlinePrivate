using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    [SerializeField]
    private GameObject _parent;

    [SerializeField]
    private List<GameObject> _children;

    private void Awake()
    {
        if (System_MenuManager.GetInst() != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        StartCoroutine(InstantiateCoroutine());
    }

    [DebuggerHidden]
    private IEnumerator InstantiateCoroutine()
    {
        Transform parentTransform = null;

        if (_parent != null)
        {
            GameObject parentObj = InstantiateWithSpeedMeasurement(_parent);
            if (parentObj != null)
            {
                parentTransform = parentObj.transform;
                DontDestroyOnLoad(parentObj);
            }
        }

        if (_children != null)
        {
            for (int i = 0; i < _children.Count; i++)
            {
                GameObject childPrefab = _children[i];
                if (childPrefab != null)
                {
                    GameObject childObj = InstantiateWithSpeedMeasurement(childPrefab, parentTransform);
                    if (parentTransform == null && childObj != null)
                    {
                        DontDestroyOnLoad(childObj);
                    }
                }
                yield return null;
            }
        }

        if (System_MenuManager.GetInst() != null)
        {
            System_MenuManager.GetInst().IsDone = true;
        }

        UnityEngine.Debug.Log("[BootStrap] Đã khởi tạo hoàn tất toàn bộ các Manager con.");
        Destroy(gameObject);
    }

    private GameObject InstantiateWithSpeedMeasurement(GameObject original, Transform parent = null)
    {
        if (original == null) return null;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        GameObject instance = Instantiate(original, parent);
        instance.name = original.name;

        sw.Stop();
        UnityEngine.Debug.Log($"[BootStrap] Spawned {original.name} in {sw.ElapsedMilliseconds} ms");

        return instance;
    }
}
