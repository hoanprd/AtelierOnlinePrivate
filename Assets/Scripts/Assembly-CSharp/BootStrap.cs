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
        // Kích hoạt Coroutine khởi tạo ngay khi Object vừa được load
        StartCoroutine(InstantiateCoroutine());
    }

    [DebuggerHidden]
    private IEnumerator InstantiateCoroutine()
    {
        Transform parentTransform = null;

        // 1. Khởi tạo Object cha nếu có
        if (_parent != null)
        {
            GameObject parentObj = InstantiateWithSpeedMeasurement(_parent);
            if (parentObj != null)
            {
                parentTransform = parentObj.transform;
                DontDestroyOnLoad(parentObj); // Giữ object cha tồn tại qua các Scene
            }
        }

        // 2. Vòng lặp duyệt danh sách các Prefab con (_children)
        if (_children != null)
        {
            for (int i = 0; i < _children.Count; i++)
            {
                GameObject childPrefab = _children[i];
                if (childPrefab != null)
                {
                    GameObject childObj = InstantiateWithSpeedMeasurement(childPrefab, parentTransform);

                    // Nếu không có parentTransform, giữ object con không bị xóa khi đổi Scene
                    if (parentTransform == null && childObj != null)
                    {
                        DontDestroyOnLoad(childObj);
                    }
                }

                // Chờ 1 frame trước khi khởi tạo Prefab tiếp theo để tránh freeze game
                yield return null;
            }
        }

        UnityEngine.Debug.Log("[BootStrap] Đã khởi tạo hoàn tất toàn bộ các Manager con.");
    }

    private GameObject InstantiateWithSpeedMeasurement(GameObject original, Transform parent = null)
    {
        if (original == null) return null;

        // Bắt đầu đo thời gian Instantiate từng Prefab
        Stopwatch sw = new Stopwatch();
        sw.Start();

        GameObject instance = Instantiate(original, parent);

        sw.Stop();
        UnityEngine.Debug.Log($"[BootStrap] Spawned {original.name} in {sw.ElapsedMilliseconds} ms");

        return instance;
    }
}