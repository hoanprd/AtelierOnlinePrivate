using System;
using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
    public class ScriptBackground : ScriptBase
    {
        private enum EParamKind
        {
            ePICTURE_ID = 0,
            eNAME = 1,
            eNAME_SUB = 2
        }

        private int m_iPictureID;
        private string m_sName;
        private string m_sNameSub;

        public override void SetParam(List<string> param)
        {
            base.SetParam(param);
            m_iPictureID = GetInt(param, (int)EParamKind.ePICTURE_ID, 0);
            m_sName = GetParam(param, (int)EParamKind.eNAME);
            m_sNameSub = GetParam(param, (int)EParamKind.eNAME_SUB);
        }

        public override List<string> GetNeedAsset()
        {
            List<string> list = base.GetNeedAsset();
            if (list == null) list = new List<string>();

            // Lấy đường dẫn ảnh background thực tế từ Background class
            string imagePath = Background.GetImagePath(m_iPictureID);
            if (!string.IsNullOrEmpty(imagePath))
            {
                list.Add(imagePath);
            }

            return list;
        }

        public override bool Init(List<string> param, bool skip)
        {
            SetParam(param);

            if (m_sUI != null && m_sUI.m_sBG != null)
            {
                Background bg = m_sUI.m_sBG;

                // 1. Thiết lập tên địa danh/bối cảnh chính và phụ
                bg.SetName(m_sName, m_sNameSub);

                // 2. Lấy đường dẫn và đăng ký texture hình nền qua AssetBundle (3 tham số chuẩn)
                string imagePath = Background.GetImagePath(m_iPictureID);
                if (!string.IsNullOrEmpty(imagePath) && bg.m_txPicture != null)
                {
                    UIAssetBundleTexture.Regist(imagePath, bg.m_txPicture, true);
                }

                // 3. Kích hoạt hiệu ứng xuất hiện bối cảnh lên màn hình
                bg.Bringin();
            }

            return true; // Hoàn tất ngay lập tức sau khi kích hoạt background
        }

        public override bool Exec(bool tap, bool skip)
        {
            return true;
        }
    }
}