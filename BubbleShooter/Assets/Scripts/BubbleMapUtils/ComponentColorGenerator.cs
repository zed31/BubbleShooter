using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BSComponent
{
    public sealed class ComponentColorGenerator
    {
        private List<Color32> m_allColors = new List<Color32>();
        private List<Color32> m_mainColors = new List<Color32>();

        private static readonly ComponentColorGenerator m_instance = new ComponentColorGenerator();

        private void InitList()
        {
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
            m_mainColors.Add(HexToColor(0x0000F0));
            m_mainColors.Add(HexToColor(0xFF0000));
            m_mainColors.Add(HexToColor(0x00FFFF));
            m_mainColors.Add(HexToColor(0xFFFF00));
            m_mainColors.Add(HexToColor(0xFF00FF));
            m_mainColors.Add(HexToColor(0x00FF00));
        }

        static ComponentColorGenerator()
        {
        }

        private ComponentColorGenerator()
        {
            InitList();
        }

        public Color32 HexToColor(int hexValue)
        {
            byte R = (byte)((hexValue >> 16) & 0xFF);
            byte G = (byte)((hexValue >> 8) & 0xFF);
            byte B = (byte)((hexValue) & 0xFF);
            return new Color32(R, G, B, 255);
        }

        public Color32 GetColor()
        {
            var value = Random.Range(0, m_mainColors.Count);
            return m_mainColors[value];
        }

        public static ComponentColorGenerator Instance
        {
            get
            {
                return m_instance;
            }
        }
    }

}