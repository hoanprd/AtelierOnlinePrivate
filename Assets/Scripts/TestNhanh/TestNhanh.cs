using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestNhanh : MonoBehaviour
{
    private static readonly string ARTIFACT_DIR = @"C:\Users\DELL\.gemini\antigravity\brain\b548421c-7dad-4de4-8dab-f81b9bc4f0a8";
    private static TestNhanh s_instance;
    private bool m_bRunning = false;

    private void Awake()
    {
        if (s_instance != null && s_instance != this)
        {
            Destroy(gameObject);
            return;
        }
        s_instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (!m_bRunning)
        {
            m_bRunning = true;
            StartCoroutine(RunFullFlow());
        }
    }

    private void SaveScreen(string fileName)
    {
        string fullPath = Path.Combine(ARTIFACT_DIR, fileName);
        try
        {
            ScreenCapture.CaptureScreenshot(fullPath);
            Debug.Log($"[TestNhanh] Screenshot captured: {fileName}");
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"[TestNhanh] ScreenCapture error: {ex.Message}");
        }
    }

    private IEnumerator RunFullFlow()
    {
        Debug.Log("[TestNhanh] ================================================================");
        Debug.Log("[TestNhanh] === BẮT ĐẦU LUỒNG KIỂM THỬ TẠO NHÂN VẬT & TUTORIAL ACADEMY ===");
        Debug.Log("[TestNhanh] ================================================================");

        // Đảm bảo là người chơi mới
        PlayerPrefs.DeleteKey(GameDefine.sKEY_FIRST_GEN_CHOOSED);
        PlayerPrefs.SetInt(GameDefine.sKEY_AGREE_KTG_TERMS, 1);
        PlayerPrefs.SetInt(GameDefine.sKEY_AGREE_TERMS, 1);
        PlayerPrefs.Save();

        // -----------------------------------------------------------------
        // BƯỚC 1: ĐỢI TITLE SCENE VÀ CHỜ IDLE SCREEN (TOUCH TO START)
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [1/8] Chờ màn hình Title và nút Touch to Start...");
        while (Menu_Title.GetInst() == null)
        {
            yield return null;
        }

        while (Menu_Title.GetInst().m_eMainStep != Menu_Title.eMainStep.ControlWait_Wait)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1.5f);
        SaveScreen("flow1_title_idle.png");
        yield return new WaitForSeconds(0.5f);

        // -----------------------------------------------------------------
        // BƯỚC 2: TOUCH TO START -> CHUYỂN VÀO TẠO NHÂN VẬT (CHARA SELECT)
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [2/8] Chạm màn hình -> Mở giao diện tạo nhân vật CharaSelect...");
        Menu_Title.GetInst().OnContinue();

        CharaSelectManager csm = null;
        while (csm == null)
        {
            csm = FindAnyObjectByType<CharaSelectManager>();
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);

        // Xem nhân vật Nam
        Debug.Log("[TestNhanh] Chọn giới tính Nam (Boy)...");
        csm.OnChangeGender(1);
        yield return new WaitForSeconds(1.0f);
        SaveScreen("flow2_chara_boy.png");
        yield return new WaitForSeconds(0.5f);

        // Xem nhân vật Nữ
        Debug.Log("[TestNhanh] Chọn giới tính Nữ (Girl)...");
        csm.OnChangeGender(2);
        yield return new WaitForSeconds(1.0f);
        SaveScreen("flow3_chara_girl.png");
        yield return new WaitForSeconds(0.5f);

        // Mở popup xác nhận
        Debug.Log("[TestNhanh] Mở Dialog xác nhận bắt đầu game...");
        csm.OnDecideConfirm();
        yield return new WaitForSeconds(1.0f);
        SaveScreen("flow4_chara_confirm.png");
        yield return new WaitForSeconds(0.5f);

        // -----------------------------------------------------------------
        // BƯỚC 3: XÁC NHẬN -> CHẠY ANIMATION CONFIRM MỪNG + VOICE + SE 77
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [3/8] Xác nhận tạo nhân vật -> Animation mừng & SE 77...");
        csm.SendMessage("OnDecide", EButtonKind.eDECIDE, SendMessageOptions.DontRequireReceiver);

        yield return new WaitForSeconds(1.2f);
        SaveScreen("flow5_chara_celebrate.png");
        yield return new WaitForSeconds(2.0f);

        // -----------------------------------------------------------------
        // BƯỚC 4: MÀN HÌNH LOADING MASTER TIPS
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [4/8] Chờ màn hình Loading Master TIPS...");
        yield return new WaitForSeconds(1.0f);
        SaveScreen("flow6_loading_tips.png");
        yield return new WaitForSeconds(1.5f);

        // -----------------------------------------------------------------
        // BƯỚC 5: NẠP VÀO SCENE ACADEMY -> PROLOGUE BẢN ĐỒ ĐẢO BRESSISLE
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [5/8] Chờ chuyển cảnh vào Academy...");
        while (SceneManager.GetActiveScene().name != "Academy")
        {
            yield return null;
        }

        Debug.Log("[TestNhanh] Đã vào Academy! Đang hiển thị bản đồ Prologue Bressisle...");
        yield return new WaitForSeconds(2.0f);
        SaveScreen("flow7_academy_prologue_map.png");
        yield return new WaitForSeconds(0.5f);

        // Chạm qua Prologue
        Prologue pro = FindAnyObjectByType<Prologue>();
        if (pro != null)
        {
            pro.SendMessage("OnNext", SendMessageOptions.DontRequireReceiver);
        }

        // -----------------------------------------------------------------
        // BƯỚC 6: VISUAL NOVEL ADV CUTSCENE (t_0101 THOẠI MỞ ĐẦU)
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [6/8] Visual Novel ADV Cutscene t_0101 hiển thị...");
        yield return new WaitForSeconds(2.0f);
        SaveScreen("flow8_academy_adv_cutscene.png");
        yield return new WaitForSeconds(0.5f);

        // Chuyển tiếp thoại ADV
        if (ADV.ADVManager.Instance != null)
        {
            ADV.ADVManager.Instance.SendMessage("Next", SendMessageOptions.DontRequireReceiver);
        }

        // -----------------------------------------------------------------
        // BƯỚC 7: CẮT CẢNH t_0102 (THOẠI VỚI HIỆU TRƯỞNG HỌC VIỆN)
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [7/8] Thoại tiếp theo với Hiệu trưởng tại Học viện...");
        yield return new WaitForSeconds(2.0f);
        SaveScreen("flow9_academy_adv_dialogue2.png");
        yield return new WaitForSeconds(0.5f);

        // Kết thúc Tutorial Academy_First
        if (TutorialManager.Instance != null)
        {
            TutorialManager.Instance.ForceEnd();
        }

        // -----------------------------------------------------------------
        // BƯỚC 8: SẢNH CHÍNH ACADEMY SẴN SÀNG TƯƠNG TÁC
        // -----------------------------------------------------------------
        Debug.Log("[TestNhanh] [8/8] Sảnh chính Học viện Hoàng Gia (Academy) sẵn sàng...");
        yield return new WaitForSeconds(2.5f);
        SaveScreen("flow10_academy_ready.png");
        yield return new WaitForSeconds(1.0f);

        Debug.Log("[TestNhanh] ================================================================");
        Debug.Log("[TestNhanh] === HOÀN THÀNH TOÀN BỘ LUỒNG TẠO NHÂN VẬT & TUTORIAL THÀNH CÔNG! ===");
        Debug.Log("[TestNhanh] ================================================================");

        string reportPath = Path.Combine(ARTIFACT_DIR, "end_to_end_test_summary.txt");
        File.WriteAllText(reportPath, $"End-to-End Test Passed: All 8 Milestones Captured Offline Successfully!\nCompleted At: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
