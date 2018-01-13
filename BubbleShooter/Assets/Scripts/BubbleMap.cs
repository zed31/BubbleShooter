using System.Linq;
using System.Collections.Generic;
using BubbleShooter;
using UnityEngine;

public class BubbleMap : MonoBehaviour {

    [SerializeField] private GameObject m_gameObjectRef;

    private ComponentContainer m_bubbles = new ComponentContainer();
    private float m_startX = -4.5f;
    private float m_startY = 4.41f;
    private float m_scale = 0.60f;

	// Use this for initialization
	void Awake() {
        foreach (var i in Enumerable.Range(0, 14)) {
            foreach (var j in Enumerable.Range(0, 16)) {
                m_bubbles.Push(m_startX, m_startY, m_gameObjectRef);
                m_startX += m_scale;
            }
            m_startX = -4.5f;
            m_startY -= m_scale;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
