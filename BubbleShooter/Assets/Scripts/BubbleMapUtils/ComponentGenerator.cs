using System.Collections.Generic;
using UnityEngine;

namespace BubbleShooter {
    public class ComponentGenerator {
        private List<Color32> m_allColors = new List<Color32>();
        private List<Color32> m_colors = new List<Color32>();
        
        private Color32 HexToColor(int hexValue) {
            byte R = (byte)((hexValue >> 16) & 0xFF);
            byte G = (byte)((hexValue >> 8) & 0xFF);
            byte B = (byte)((hexValue) & 0xFF);
            return new Color32(R, G, B, 255);
        }

        public ComponentGenerator() {
            m_allColors.Add(HexToColor(0x000000));
            m_allColors.Add(HexToColor(0xC0C0C0));
            m_allColors.Add(HexToColor(0x808080));
            m_allColors.Add(HexToColor(0xFFFFFF));
            m_allColors.Add(HexToColor(0x800000));
            m_allColors.Add(HexToColor(0xFF0000));
            m_allColors.Add(HexToColor(0x800080));
            m_allColors.Add(HexToColor(0xFF00FF));
            m_allColors.Add(HexToColor(0x008000));
            m_allColors.Add(HexToColor(0x00FF00));
            m_allColors.Add(HexToColor(0xFFFF00));
            m_allColors.Add(HexToColor(0x0000F0));
            m_allColors.Add(HexToColor(0x00FFFF));
            m_colors.Add(HexToColor(0x0000F0));
            m_colors.Add(HexToColor(0xFF0000));
            m_colors.Add(HexToColor(0x00FFFF));
            m_colors.Add(HexToColor(0xFFFF00));
            m_colors.Add(HexToColor(0xFF00FF));
            m_colors.Add(HexToColor(0x00FF00));
        }

        public void PushNewColor(int hex) {
            m_allColors.Add(HexToColor(hex));
        }

        public GameObject Generate(float x, float y, GameObject refObject){
            var value = Random.Range(0, m_colors.Count);
            GameObject gameObj = MonoBehaviour.Instantiate(refObject, new Vector2(x, y), Quaternion.identity);
            gameObj.GetComponent<SpriteRenderer>().material.color = m_colors[value];
            return gameObj;
        }
    }
}
