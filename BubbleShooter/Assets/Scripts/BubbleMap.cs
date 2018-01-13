using System.Linq;
using System.Collections.Generic;
using BSComponent;
using UnityEngine;

public class BubbleMap : MonoBehaviour {

    [SerializeField] private GameObject m_gameObjectRef;

    private BubbleContainer m_bubbles = new BubbleContainer();

    private float m_startX = -2.95f;
    private float m_startY = 4.61f;
    private float m_scale = 0.40f;

	// Use this for initialization
	void Awake() {
        foreach (var i in Enumerable.Range(0, 14)) {
            foreach (var j in Enumerable.Range(0, 16)) {
                m_bubbles.Push(m_startX, m_startY, m_gameObjectRef);
                m_startX += m_scale;
            }
            m_startX = -2.95f;
            m_startY -= m_scale;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
